using Loggare;
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
    public partial class LoggareForm : Form
    {
        private const string exportFileName = "export-loggar.txt";
        private const string DatabasePath = "diary";
        private const string queryToSelectAllLogEntries = "select * from LogEntry order by id DESC";
        private HistoricDateTimePicker HISTORIC_DATEPICKER_INST;
        BindingList<LogEntry> logEntries;
        SQLiteConnection db;
        public LoggareForm()
        {
            InitializeComponent();

            db = new SQLiteConnection(DatabasePath);
            db.CreateTable<LogEntry>();
            ReadAllLogEntriesFromDB();
            
            UpdateBoldedDates();
            UpdateListBoxWithAllLogEntries();
            monthCalendar1.MaxDate = DateTime.Today;
          
        }

        public void ReadAllLogEntriesFromDB()
        {
            logEntries = new BindingList<LogEntry>(db.Query<LogEntry>(queryToSelectAllLogEntries));
        }

        private void UpdateBoldedDates()
        {
            logEntries = new BindingList<LogEntry>(db.Query<LogEntry>(queryToSelectAllLogEntries));
            List<DateTime> boldedDates = new List<DateTime>();
            foreach (LogEntry logEntry in logEntries)
            {
                boldedDates.Add(logEntry.Time);
            }
            monthCalendar1.BoldedDates = boldedDates.ToArray();
        }

        private void UpdateListBoxWithAllLogEntries()
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
            logEntries = new BindingList<LogEntry>(db.Query<LogEntry>(queryToSelectAllLogEntries));
            var filteredList = filterDates(logEntries, selectedDate);
            listBox1.DataSource = filteredList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = txtBoxLog.Text;
            var logEntryToAdd = new LogEntry();
            if (monthCalendar1.SelectionStart == DateTime.Today)
            {
                logEntryToAdd = new LogEntry(){ Entry=s, Time=DateTime.Now};
            }
            else
            {
                logEntryToAdd = new LogEntry()
                {
                    Entry = s,
                    Time = monthCalendar1.SelectionStart
                };
            }


            var Id = db.Insert(logEntryToAdd); 
           
            txtBoxLog.Text = "";
            UpdateListBoxWithAllLogEntries();
        }

   
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogEntry entry = listBox1.SelectedItem as LogEntry;
            logEntryBox.Text = entry.Entry;
        }

        private void taBortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogEntry entry = listBox1.SelectedItem as LogEntry;
            var truncatedEntry = new string(entry.Entry.Take(200).ToArray());
            DialogResult deleteAnswer = MessageBox.Show("Följande logg kommer att raderas:" + Environment.NewLine 
                + Environment.NewLine + entry.Time 
                + Environment.NewLine + Environment.NewLine + truncatedEntry + "...", "Vill du ta bort loggen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(deleteAnswer == DialogResult.Yes)
            {
                db.Delete<LogEntry>(entry.Id);
                UpdateListBoxWithAllLogEntries();
                UpdateBoldedDates();
            }

        }

        private void kopieraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogEntry entry = listBox1.SelectedItem as LogEntry;
            System.Windows.Forms.Clipboard.SetText(entry.Time + " " + entry.Entry);
            MessageBox.Show("Loggen är kopierad till urklipp", "Kopierad till urklipp", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      

        private static List<LogEntry> filterDates(BindingList<LogEntry> l, DateTime day)
        {
            return l.Where(item => item.Time.Date.CompareTo(day.Date) == 0).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(DatabasePath);
            UpdateListBoxWithAllLogEntries();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            List<LogEntry> logEntryForSelectedDate = GetLogEntriesForDateSelecedInCalendar(logEntries);
            listBox1.DataSource = logEntryForSelectedDate;
            logEntryBox.Text = "";
            if (listBox1.Items.Count > 0)
            {
                listBox1_SelectedIndexChanged(sender, e);
            } 
        }

        private List<LogEntry> GetLogEntriesForDateSelecedInCalendar(BindingList<LogEntry> l)
        {
            return l.Where(item => item.Time.Date.CompareTo(monthCalendar1.SelectionStart) == 0).ToList();
        }

        private void ExportAllLogs(object sender, EventArgs e)
        { 
            ExportLogEntries(logEntries.ToList());
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
            List<LogEntry> logEntriesForSelectedDateInCalendar = GetLogEntriesForDateSelecedInCalendar(logEntries).ToList();
            ExportLogEntries(logEntriesForSelectedDateInCalendar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogEntry entry = listBox1.SelectedItem as LogEntry;
            entry.Entry = logEntryBox.Text;
            db.Update(entry);
        }

        private void AboutProgram(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright: Johan Andersson. Licens: MIT. Använder kod från sqlite-net (MIT License).", "Om Loggare");
        }

       

        private void ändraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogEntry pickedLogEntry = listBox1.SelectedItem as LogEntry;
            if (HISTORIC_DATEPICKER_INST == null)
            {
                HISTORIC_DATEPICKER_INST = new HistoricDateTimePicker(pickedLogEntry, this);
                HISTORIC_DATEPICKER_INST.FormClosing += new FormClosingEventHandler(HISTORIC_DATEPICKER_INST_FormClosing);
            }

            HISTORIC_DATEPICKER_INST.Show();
            if (Form.ActiveForm != HISTORIC_DATEPICKER_INST)
            {
                HISTORIC_DATEPICKER_INST.Activate();
            }
        }

        void HISTORIC_DATEPICKER_INST_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            HISTORIC_DATEPICKER_INST = null;
        }

        public void setDateTimeForListBoxItem(DateTime dateTime)
        {
            LogEntry l = listBox1.SelectedItem as LogEntry;
            l.Time = dateTime;
            db.Update(l);
            monthCalendar1.SetDate(dateTime);
            UpdateListBoxWithAllLogEntries();
            UpdateBoldedDates();
        }
    }
}
