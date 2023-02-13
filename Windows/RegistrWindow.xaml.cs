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
using AndrKarmStore.ClassHelper;
using AndrKarmStore.Windows;
using AndrKarmStore.DB;


namespace AndrKarmStore.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrWindow.xaml
    /// </summary>
    public partial class RegistrWindow : Window
    {
        public RegistrWindow()
        {
            InitializeComponent();
            GenderBox.SelectedIndex = 0;
            GenderBox.DisplayMemberPath = "Name";
            GenderBox.ItemsSource = EFClass.Context.Gender.ToList();
            
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DoneButto_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginBox.Text))
            {
                MessageBox.Show("Логин не может быть пустым или состоять из пробелов");
                return;
            }
            if (string.IsNullOrWhiteSpace(NameBox.Text))
            {
                MessageBox.Show("Имя не может быть пустым или состоять из пробелов");
                return;
            }
            if (string.IsNullOrWhiteSpace(SurnameBox.Text))
            {
                MessageBox.Show("Фамилия не может быть пустым или состоять из пробелов");
                return;
            }
            if (string.IsNullOrWhiteSpace(SurnameBox.Text))
            {
                MessageBox.Show("Фамилия не может быть пустым или состоять из пробелов");
                return;
            }
            if (string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                MessageBox.Show("Пароль не может быть пустым или состоять из пробелов");
                return;
            }
            if (string.IsNullOrWhiteSpace(NumberBox.Text))
            {
                MessageBox.Show("Номер не может быть пустым или состоять из пробелов");
                return;
            }
            if (string.IsNullOrWhiteSpace(EmailBox.Text))
            {
                MessageBox.Show("Почта не может быть пустым или состоять из пробелов");
                return;
            }
            if (string.IsNullOrWhiteSpace(BirthdayBox.Text))
            {
                MessageBox.Show("Дата рождения не может быть пустым или состоять из пробелов");
                return;
            }
            if (string.IsNullOrWhiteSpace(GenderBox.Text))
            {
                MessageBox.Show("Пол не может быть пустым или состоять из пробелов");
                return;
            }

            EFClass.Context.User.Add(new User()
            {
                Login = LoginBox.Text,
                Password = PasswordBox.Password,
                LastName = SurnameBox.Text,
                FirstName = NameBox.Text,
                IdRole = 2,

                Mail = EmailBox.Text,
                Phone = NumberBox.Text,
                Birthday = BirthdayBox.SelectedDate.Value,
                IdGender = (GenderBox.SelectedItem as Gender).IdGender,

            });
            EFClass.Context.SaveChanges();
            MessageBox.Show("Ok");

        }
    }
}
