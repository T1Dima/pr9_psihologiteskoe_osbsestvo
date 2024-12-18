using pr9_psyho_osestvo.ApplicationData;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для AddAppointmentWindow.xaml
    /// </summary>
    public partial class AddAppointmentWindow : Window
    {
        private readonly DataService _dataService;
        private readonly Appointment _appointment;
        public AddAppointmentWindow(DataService dataService, Appointment appointment = null)
        {
            InitializeComponent();
            _dataService = dataService;
            _appointment = appointment ?? new Appointment();

            // Заполнение выпадающих списков
            ClientComboBox.ItemsSource = _dataService.Clients;
            DoctorComboBox.ItemsSource = _dataService.Doctors;

            // Если редактируем существующую запись, заполняем поля
            if (appointment != null)
            {
                ClientComboBox.SelectedItem = _appointment.Client;
                DoctorComboBox.SelectedItem = _appointment.Doctor;
                TypeComboBox.Text = _appointment.Type;
                TimeTextBox.Text = _appointment.Time.ToString("yyyy-MM-dd HH:mm"); // Преобразование даты
            }
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
