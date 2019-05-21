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

namespace _21._05._2019Telegram
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public event RoutedPropertyChangedEventHandler<string> ThemeChanged;

        public MainWindow()
        {
            InitializeComponent();
            ThemeChange("LightTheme.xaml");
        }

        private void LightButtonClick(object sender, RoutedEventArgs e)
        {
            ThemeChange("LightTheme.xaml");
        }

        private void DarkButtonClick(object sender, RoutedEventArgs e)
        {
            ThemeChange("DarkTheme.xaml");
        }

        private void ThemeChange(string ThemeNameFile)
        {
            var uri = new Uri(ThemeNameFile, UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
    }
}