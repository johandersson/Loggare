using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class LogEntry
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Indexed]
        public DateTime Time { get; set; }
        public String Entry { get; set; }


        public override string ToString()
        {
            return Time.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
