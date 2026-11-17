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

namespace DeliveryOrder
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

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxtAddress.Text == string.Empty) {
                    throw new Exception("Address should be entered");
                }
                {
                    CustomerOrder order = new CustomerOrder();
                    order.Address = TxtAddress.Text;
                    order.Branch = ((ComboBoxItem)CmdBranch.SelectedItem).Content.ToString();
                    order.Weight = Convert.ToDouble(TxtWeight.Text);
                    order.DeliveryType = (RdbNormal.IsChecked == true) ? "normal" : "speed";
                    order.findCost();
                    TxtCost.Text = order.Cost.ToString();
                }
            }
            catch (NullReferenceException nex)
            {
                MessageBox.Show("Please select a branch.");
                CmdBranch.Focus();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Please enter a valid weight.");
                TxtWeight.Focus();
            }
            //for exam, use only this exception
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong:, Please contact developer");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Thank you for using our service...");
            }
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}