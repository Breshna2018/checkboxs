using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
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

namespace checkboxs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            perload();
        }

         void perload()
        {
            large.IsChecked=true;
            smalldrink.IsChecked=true;

        }

        private void topping_Click(object sender, RoutedEventArgs e)
        {
            double amount = 0;
            double price = 0;
            showorderone.Text = "";
            // showorderone.Text = "what kids of pizza do want order";
            bool haschicken = chicken.IsChecked.Value;
            bool hastomato=tomato.IsChecked.Value;
            bool haspaper=paper.IsChecked.Value;
            bool hasonion=onion.IsChecked.Value;
            bool sizesmall=small1.IsChecked.Value;
            bool sizemediem=mediem.IsChecked.Value;
            bool sizelarge= large.IsChecked.Value;
            bool sizeextrlarage = family.IsChecked.Value;




            bool drinksmall=smalldrink.IsChecked.Value;
            bool mediemmdrink = mediemdrink.IsChecked.Value;
            bool largedrinkk=bigdrink.IsChecked.Value;
            bool familysizedrink = largedrink.IsChecked.Value;
            if(drinksmall) {
                showorderone.Text += "small drink";
                amount = 2;
            }
            if (mediemmdrink)
            {
                amount = 2;
                showorderone.Text += "mediem drink";
            }
            if (largedrinkk)
            {
                amount += 3;
                showorderone.Text += "large drink";
            }
            if (familysizedrink)
            {
                amount *= 2;
                showorderone.Text += "extr large drink";
            }

            showorderone.Text +="-"+ amount.ToString("c");
            amount += price;

            if (sizesmall)
            {
                price = 12;
                showorderone.Text += "small";
            }
           else if (sizemediem) {
                price = 12;
                showorderone.Text += "mediemsize \n";

            }
           else if (sizeextrlarage)
            {
                price = 16;
                showorderone.Text += "etralarge\n";
            }
           else if (sizelarge) {
                price += 16;
                showorderone.Text += "large size \n";
            }
            else
            {
                MessageBox.Show("please select pizza size");
            }

            showorderone.Text = "topping added\n";
            if (haschicken) {
                double toppingprice = 3; 
                showorderone.Text += "chicken -{toppingprice.ToString("c")}\n";
            }
            if(hastomato==true) {

                showorderone.Text+="tomato\n";
            }
            if (haspaper==true)
            {
                showorderone.Text += "paper\n";
            }
            if (!hasonion==true)
            {
                showorderone.Text += "onion\n";
            }
            //  showorderone.Text += haschicken;

            double taxAmount = .1;
            double calculatedTax = amount * taxAmount;
            double totalAmount = amount + calculatedTax;



            showorderone.Text += $"\n\n" +
                $"Subtotal: {amount.ToString("c")}\n" +
                $"Tax Amount: {calculatedTax.ToString("c")}\n" +
                $"Total Price: {totalAmount.ToString("c")} ";

        }

        public string FormatItem(string item, double amount)
        {

            return $"{item} - {amount.ToString("c")}\n";

        }
    }
}
