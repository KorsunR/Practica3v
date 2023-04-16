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
using practica1pr.AORUSDataSetTableAdapters;

namespace practica1pr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PageFrame_Navigated(object sender, NavigationEventArgs e)
        {
             


        }

        private void PAGE_BUTTON1_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new FirstPage();
        }

        private void PAGE_BUTTON2_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new SecondPage();
        }
    }
}
