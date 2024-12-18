using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pr9_psyho_osestvo.ApplicationData
{
    public class DataService
    {
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        public DataService()
        {
            // Добавьте тестовые данные (для примера)
            Clients.Add(new Client { FullName = "Иван Иванов", ContactInfo = "ivanov@example.com" });
            Doctors.Add(new Doctor { FullName = "Анна Петрова", Specialization = "Психолог" });
        }
    }
}
