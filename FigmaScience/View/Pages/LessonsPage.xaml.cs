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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FigmaScience.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для LessonsPage.xaml
    /// </summary>
    public partial class LessonsPage : Page
    {
        public LessonsPage()
        {
            InitializeComponent();

            DatGr.ItemsSource = App.context.Lessons.ToList();
        }

        private void DatGr_Loaded(object sender, RoutedEventArgs e)
        {
            DatGr.ItemsSource = App.context.Lessons.ToList();
        }
    }
}
