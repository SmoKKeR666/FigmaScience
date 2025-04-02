using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FigmaScience.AppData;
using FigmaScience.Model;

namespace FigmaScience.View.Pages.TestPages
{
    /// <summary>
    /// Логика взаимодействия для TestPage1.xaml
    /// </summary>
    public partial class TestPage1 : Page
    {
        int b = 0;
        int c = 0;
        public TestPage1()
        {
            InitializeComponent();
        }

        private void p1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "1")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");
            p1.Visibility = Visibility.Collapsed;
            Basics.SelectedItem = v2;
        }

        private void p2_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox2.Text == "2")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");
            p2.Visibility = Visibility.Collapsed;
            Basics.SelectedItem = v3;
        }

        private void p3_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox3.Text == "2")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");
            p3.Visibility = Visibility.Collapsed;
            Basics.SelectedItem = v4;
        }

        private void p4_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox4.Text == "2")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");
            p4.Visibility = Visibility.Collapsed;
            Basics.SelectedItem = v5;
        }
        private void p5_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox5.Text == "4")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
            }
            else MessageBox.Show("Неправильно");
            p5.Visibility = Visibility.Collapsed;
            Basics.SelectedItem = Result;
        }

        private void ShowResultBtn_Click(object sender, RoutedEventArgs e)
        {
            if (b == 5) c = 5;
            if (b == 4) c = 4;
            if (b == 3) c = 3;
            if (b == 2) c = 2;
            if (b == 1) c = 1;
            ScoresTxb.Text = "Ваши баллы: " + Convert.ToString(b);
            MarkTxb.Text = "Ваша оценка: " + Convert.ToString(c);
        }

        private void SaveResultBtn_Click(object sender, RoutedEventArgs e)
        {
            TestResults testResults = new TestResults()
            {
                User = 1,
                Test = 1,
                DateOfCompleting = DateTime.Today,
                Scores = b,
                Mark = c
            };

            App.context.TestResults.Add(testResults);
            App.context.SaveChanges();
            ClassFrame.mainFrame.Navigate(new StartPage());
            MessageBox.Show("Результаты добавлены!");
        }
    }
}
