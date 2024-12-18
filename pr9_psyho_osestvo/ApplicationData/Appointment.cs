using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pr9_psyho_osestvo.ApplicationData
{
    public class Appointment
    {
        public DateTime Time { get; set; }
        public string Doctor { get; set; }
        public string Status { get; set; }
        public string Client { get; set; } // Связь с клиентом
        public string Type { get; set; }
        public string Comment { get; set; }

    }
}
