using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Loggare
{
    public partial class HistoricDateTimePicker : Form
    {
        private LoggareForm parentForm;
        private LogEntry logEntryToChange;

        public HistoricDateTimePicker(LogEntry logEntryToChange, LoggareForm callingForm)
        {
            this.logEntryToChange = logEntryToChange;
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker1.Value = logEntryToChange.Time;
            dateTimePicker1.MaxDate = DateTime.Now;
            this.parentForm = callingForm;
        }

        private void HistoricDateTimePicker_Load(object sender, EventArgs e)
        {

        }

        private void changeDateOKButton_Click(object sender, EventArgs e)
        {
            this.parentForm.setDateTimeForListBoxItem(dateTimePicker1.Value);
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
