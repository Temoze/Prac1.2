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

namespace Prac1._2
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private SampleDatabaseEntities context = new SampleDatabaseEntities();
        public Page1()
        {
            InitializeComponent();
            OrderDetailsDataGrid.ItemsSource = context.OrderDetails.ToList();
        }
    }
}
