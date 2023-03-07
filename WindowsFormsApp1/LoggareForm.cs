using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string exportFileName = "export-loggar.txt";

        public Form1()
        {
            InitializeComponent();
            var db = new SQLiteConnection("diary");
            db.CreateTable<LogEntry>();
            UpdateBoldedDates();
            UpdateListBoxWithAllLogEntries(db);
        }

        private void UpdateBoldedDates()
        {
            var db = new SQLiteConnection("diary");
            List<LogEntry> l = db.Query<LogEntry>("select * from LogEntry order by id DESC");
            List<LogEntry> listWithAllLogEntries = db.Query<LogEntry>("select * from LogEntry order by id DESC");
            List<DateTime> boldedDates = new List<DateTime>();
            foreach (LogEntry logEntry in listWithAllLogEntries)
            {
                boldedDates.Add(logEntry.Time);
            }
            monthCalendar1.BoldedDates = boldedDates.ToArray();
        }

        private void UpdateListBoxWithAllLogEntries(SQLiteConnection db)
        {
            List<LogEntry> allLogentries = db.Query<LogEntry>("select * from LogEntry order by id DESC");
            DateTime selectedDate = monthCalendar1.SelectionStart;
            var filteredList = filterDates(allLogentries, selectedDate);
            listBox1.DataSource = filteredList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = txtBoxLog.Text;
            var db = new SQLiteConnection("diary");
            var Id = db.Insert(new LogEntry()
            {
                Entry = s,
                Time = DateTime.Now
            });
           
            txtBoxLog.Text = "";
            UpdateListBoxWithAllLogEntries(db);
        }

   
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogEntry entry = listBox1.SelectedItem as LogEntry;
            logEntryBox.Text = entry.Entry;
        }

        private void taBortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var db = new SQLiteConnection("diary");
            LogEntry entry = listBox1.SelectedItem as LogEntry;
            db.Delete<LogEntry>(entry.Id);
            UpdateListBoxWithAllLogEntries(db);
            UpdateBoldedDates();
        }

        private void kopieraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogEntry entry = listBox1.SelectedItem as LogEntry;
            System.Windows.Forms.Clipboard.SetText(entry.Time + " " + entry.Entry);
        }

      

        private static List<LogEntry> filterDates(List<LogEntry> l, DateTime day)
        {
            return l.Where(item => item.Time.Date.CompareTo(day.Date) == 0).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var db = new SQLiteConnection("diary");
            UpdateListBoxWithAllLogEntries(db);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            List<LogEntry> logEntryForSelectedDate = GetLogEntryForDateSelecedInCalendar();
            listBox1.DataSource = logEntryForSelectedDate;
            logEntryBox.Text = "";
        }

        private List<LogEntry> GetLogEntryForDateSelecedInCalendar()
        {
            var db = new SQLiteConnection("diary");
            List<LogEntry> allLogEntries = db.Query<LogEntry>("select * from LogEntry order by id DESC");
            List<LogEntry> filteredList;
            DateTime selectedDate = monthCalendar1.SelectionStart;
            filteredList = filterDates(allLogEntries, selectedDate);
            return filteredList;
        }

        private void ExportAllLogs(object sender, EventArgs e)
        {
            var db = new SQLiteConnection("diary");
            List<LogEntry> listWithAllLogEntries = db.Query<LogEntry>("select * from LogEntry order by time DESC");
            ExportLogEntries(listWithAllLogEntries);

        }

        private static void ExportLogEntries(List<LogEntry> listWithAllLogEntries)
        {
            var exportFile = new StreamWriter(exportFileName, false, System.Text.Encoding.UTF8);

            foreach (LogEntry logEntry in listWithAllLogEntries)
            {
                exportFile.WriteLine(logEntry.ExportToFileFormat());
            }

            exportFile.Close();
            Process.Start(exportFileName);
        }

        private void ExportLogForSpecificDate(object sender, EventArgs e)
        {
            List<LogEntry> logEntriesForSelectedDateInCalendar = GetLogEntryForDateSelecedInCalendar();
            ExportLogEntries(logEntriesForSelectedDateInCalendar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var db = new SQLiteConnection("diary");
            LogEntry entry = listBox1.SelectedItem as LogEntry;
            entry.Entry = logEntryBox.Text;
            db.Update(entry);
        }

        private void AboutProgram(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright: Johan Andersson. Licens: MIT. Använder kod från sqlite-net (MIT License).", "Om Loggare");
        }
    }
}
