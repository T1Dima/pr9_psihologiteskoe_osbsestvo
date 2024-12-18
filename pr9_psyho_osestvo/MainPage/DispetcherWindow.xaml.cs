using pr9_psyho_osestvo.ApplicationData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace pr9_psyho_osestvo.MainPage
{
    /// <summary>
    /// Логика взаимодействия для DispetcherWindow.xaml
    /// </summary>
    public partial class DispetcherWindow : Window
    {
        public ObservableCollection<Appointment> Appointments { get; set; }
        public DispetcherWindow()
        {
            InitializeComponent();
            Appointments = new ObservableCollection<Appointment>();
            AppointmentsListView.ItemsSource = Appointments;
        }

        private void AddAppointment_Click(object sender, RoutedEventArgs e)
        {
            DateTime selectedDate = AppointmentsCalendar.SelectedDate ?? DateTime.Now;
            Appointment newAppointment = new Appointment { Time = selectedDate, Doctor = "Doctor Name", Status = "Pending" };
            Appointments.Add(newAppointment);
        }
        private void AppointmentsCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime selectedDate = AppointmentsCalendar.SelectedDate ?? DateTime.Now;
        }
    }
}
