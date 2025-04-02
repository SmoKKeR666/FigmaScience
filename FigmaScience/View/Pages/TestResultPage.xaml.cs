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

namespace FigmaScience.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TestResultPage.xaml
    /// </summary>
    public partial class TestResultPage : Page
    {
        public TestResultPage()
        {
            InitializeComponent();

            DatGr.ItemsSource = App.context.TestResults.ToList();

            TestCmb.SelectedValue = "ID";
            TestCmb.DisplayMemberPath = "Name";
            TestCmb.ItemsSource = App.context.Tests.ToList();
        }

        private void DatGr_Loaded(object sender, RoutedEventArgs e)
        {
            DatGr.ItemsSource = App.context.TestResults.ToList();
        }

        private void TestCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedTest = Convert.ToInt32(TestCmb.SelectedValue);
            DatGr.ItemsSource = App.context.FigmaScience.Where(test => test.ID == selectedTest).ToList();
        }
    }
}
