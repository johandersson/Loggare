using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
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
            List<LogEntry> l = db.Query<LogEntry>("select * from LogEntry order by id DESC");
            listBox1.DataSource = l;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogEntry entry = listBox1.SelectedItem as LogEntry;
            textBox1.Text = entry.Entry;
        }

        private void taBortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var db = new SQLiteConnection("diary");
            LogEntry entry = listBox1.SelectedItem as LogEntry;
            db.Delete<LogEntry>(entry.Id);
            UpdateListBoxWithAllLogEntries(db);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void kopieraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogEntry entry = listBox1.SelectedItem as LogEntry;
            System.Windows.Forms.Clipboard.SetText(entry.Time + " " + entry.Entry);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private static List<LogEntry> filterDates(List<LogEntry> l, DateTime day)
        {
            return l.Where(item => item.Time.Date.CompareTo(day.Date) == 0).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }


        private void button3_Click(object sender, EventArgs e)
        {
            var db = new SQLiteConnection("diary");
            UpdateListBoxWithAllLogEntries(db);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
                Console.WriteLine(monthCalendar1.SelectionStart);

                var db = new SQLiteConnection("diary");
                List<LogEntry> allLogEntries = db.Query<LogEntry>("select * from LogEntry order by id DESC");
                List<LogEntry> filteredList;
                DateTime selectedDate = monthCalendar1.SelectionStart;
                filteredList = filterDates(allLogEntries, selectedDate);
                listBox1.DataSource = filteredList;
            
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
