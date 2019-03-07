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

namespace number_pos_nega
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

        private void btnFindIfPositive_Click(object sender, RoutedEventArgs e)
        {
            //local variables
            double Number;
            double.TryParse(txtNumber.Text, out Number);

            if (Number >= 9000)
            {
                lblNumberr.Content = "HIS POWER LEVEL IS OVER 9000!";
            }
           else if (Number > 0)
            {
                lblNumberr.Content = "This number is positive";
            }
            else if (Number == 0)
            {
                lblNumberr.Content = "this number is zero";
            }
            else
                lblNumberr.Content = "this number is negative";
            }
        }
    }