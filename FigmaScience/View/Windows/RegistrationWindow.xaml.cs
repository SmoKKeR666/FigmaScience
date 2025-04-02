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
using FigmaScience.AppData;
using FigmaScience.Model;

namespace FigmaScience.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FullNameTb.Text))
            {
                MessageBox.Show("Введите ФИО");
            }
            if (string.IsNullOrWhiteSpace(LoginTb.Text))
            {
                MessageBox.Show("Введите логин");
            }
            if (string.IsNullOrWhiteSpace(PasswordPb.Password))
            {
                MessageBox.Show("Введите пароль");
            }
            Users users = new Users()
            {
                FullName = FullNameTb.Text,
                Login = LoginTb.Text,
                Password = PasswordPb.Password
            };

            App.context.Users.Add(users);
            App.context.SaveChanges();
            MessageBox.Show("Поздравляем с регистрацией!");

            FullNameTb.Text = "";
            LoginTb.Text = "";
            PasswordPb.Password = "";
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            EnterWindow enterWindow = new EnterWindow();
            enterWindow.Show();
            this.Close();
        }
    }
}
