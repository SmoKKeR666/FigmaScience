﻿using System;
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

namespace FigmaScience.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для EnterWindow.xaml
    /// </summary>
    public partial class EnterWindow : Window
    {
        public EnterWindow()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTb.Text) && string.IsNullOrEmpty(PasswordPb.Password))
            {
                MessageBox.Show("Введите логин и пароль");
            }
            else if (string.IsNullOrEmpty(LoginTb.Text))
            {
                MessageBox.Show("Введите логин");
            }
            else if (string.IsNullOrEmpty(PasswordPb.Password))
            {
                MessageBox.Show("Введите пароль");
            }
            else
            {
                App.currentUser = App.context.Users.FirstOrDefault(user => user.Login == LoginTb.Text && user.Password == PasswordPb.Password);

                if (App.currentUser != null)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
            }
        }
    }
}
