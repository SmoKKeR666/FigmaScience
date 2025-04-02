using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using FigmaScience.Model;

namespace FigmaScience
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static FigmaScienceEntities1 context = new FigmaScienceEntities1();

        public static Users currentUser;
    }
}
