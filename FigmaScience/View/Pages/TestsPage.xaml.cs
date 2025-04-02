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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FigmaScience.AppData;
using FigmaScience.View.Pages.TestPages;

namespace FigmaScience.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TestsPage.xaml
    /// </summary>
    public partial class TestsPage : Page
    {
        public TestsPage()
        {
            InitializeComponent();

            TestCmb.SelectedValue = "ID";
            TestCmb.DisplayMemberPath = "Name";
            TestCmb.ItemsSource = App.context.Tests.ToList();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            if (TestCmb.Text == "Basics")
            {
                ClassFrame.mainFrame.Navigate(new TestPage1());
            }
            else if (TestCmb.Text == "Pro")
            {
                ClassFrame.mainFrame.Navigate(new TestPage2());
            }
            else
            {
                MessageBox.Show("Выберите тест");
            }
        }
    }
}
