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

namespace oefInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnIntrest_Click(object sender, RoutedEventArgs e)
        {
            Bankrekening bankrekening = new Bankrekening(2.3, 1000);
            MessageBox.Show(bankrekening.ToString());
        }

        private void btnOppervlakte_Click(object sender, RoutedEventArgs e)
        {
            Figuur figuur = new Figuur(10, 30);
            MessageBox.Show(figuur.ToString());
        }
    }
}
