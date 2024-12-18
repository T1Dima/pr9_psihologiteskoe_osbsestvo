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
using pr9_psyho_osestvo.ApplicationData;

namespace pr9_psyho_osestvo.MainPage
{
    /// <summary>
    /// Логика взаимодействия для DoctorCommentWindow.xaml
    /// </summary>
    public partial class DoctorCommentWindow : Window
    {
        private readonly Appointment _appointment;
        public DoctorCommentWindow(Appointment appointment)
        {
            InitializeComponent();
            _appointment = appointment;

            // Заполнение комментария, если он уже есть
            CommentTextBox.Text = _appointment.Comment;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _appointment.Comment = CommentTextBox.Text;
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
