using practica1pr.AORUSDataSetTableAdapters;
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
using System.Data;

namespace practica1pr
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        ColorTableAdapter color = new ColorTableAdapter(); 
        public FirstPage()
        {
            InitializeComponent();
            ColorDataGrid.ItemsSource = color.GetData();
            ColorDataGrid.DisplayMemberPath = "color_name";
            
        }

        private void ThreePage_Click(object sender, RoutedEventArgs e)
        {
            object id = (ColorDataGrid.SelectedItem as DataRowView).Row[0];
            color.DeleteQuery(Convert.ToInt32(id));
        }
    }
}
