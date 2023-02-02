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
using static AndrKarmStore.ClassHelper.EFClass;

namespace AndrKarmStore.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrWindow registrWindow = new RegistrWindow();
            registrWindow.ShowDialog();
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            var userAuth = Context.User.ToList().Where(i => i.Phone == PhoneBox.Text && i.Password == PasswordBox.Text).FirstOrDefault();



            if (userAuth != null)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
