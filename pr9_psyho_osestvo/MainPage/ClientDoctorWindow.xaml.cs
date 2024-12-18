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
    /// Логика взаимодействия для ClientDoctorWindow.xaml
    /// </summary>
    public partial class ClientDoctorWindow : Window
    {
        private readonly object _entity;
        public ClientDoctorWindow(object entity = null)
        {
            InitializeComponent();
            _entity = entity;

            // Заполнение данных для клиента
            if (_entity is Client client)
            {
                NameTextBox.Text = client.FullName; 
                ContactInfoTextBox.Text = client.ContactInfo;

                SpecializationTextBox.Visibility = Visibility.Collapsed;
                var specializationLabel = (TextBlock)FindName("SpecializationTextBlock");
                if (specializationLabel != null)
                    specializationLabel.Visibility = Visibility.Collapsed;
            }
            // Заполнение данных для врача
            else if (_entity is Doctor doctor)
            {
                NameTextBox.Text = doctor.FullName; 
                SpecializationTextBox.Text = doctor.Specialization;

                ContactInfoTextBox.Visibility = Visibility.Collapsed;
                var contactLabel = (TextBlock)FindName("ContactInfoTextBlock");
                if (contactLabel != null)
                    contactLabel.Visibility = Visibility.Collapsed;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (_entity is Client client)
            {
                client.FullName = NameTextBox.Text;
                client.ContactInfo = ContactInfoTextBox.Text;
            }
            else if (_entity is Doctor doctor)
            {
                doctor.FullName = NameTextBox.Text;
                doctor.Specialization = SpecializationTextBox.Text;
            }

            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
