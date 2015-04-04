using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text; 
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Windows.Input;
using Windows.UI.Core;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace calc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public double n1 = 0;
        public double n2 = 0;
        string opr = "";
        public string tmp1;

        public MainPage()
        {
            this.InitializeComponent();
            tb.TextAlignment = TextAlignment.Right;
        }
        private void tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "2";
            else
                tb.Text += 2;

        }

        private void bdot_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.IndexOf(".") == -1)
                tb.Text += ".";
            else
                return;

        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "1";
            else
                tb.Text += 1;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "3";
            else
                tb.Text += 3;
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "4";
            else
                tb.Text += 4;

        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "5";
            else
                tb.Text += 5;
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "6";
            else
                tb.Text += 6;

        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "7";
            else
                tb.Text += 7;
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "8";
            else
                tb.Text += 8;
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "9";
            else
                tb.Text += 9;
        }

        private void b0_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                return;
            else
                tb.Text += 0;
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            opr = "+";
            n1 = Convert.ToDouble(tb.Text);
            tb.Text = "";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            opr = "-";
            n1 = Convert.ToDouble(tb.Text);
            tb.Text = "";
        }

        private void multply_Click(object sender, RoutedEventArgs e)
        {
            opr = "*";
            n1 = Convert.ToDouble(tb.Text);
            tb.Text = "";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            opr = "/";
            n1 = Convert.ToDouble(tb.Text);
            tb.Text = "";
        }
        private void per_Click(object sender, RoutedEventArgs e)
        {
            opr = "%";
            n1 = Convert.ToDouble(tb.Text);
            tb.Text = "";
        }
        private void root_Click(object sender, RoutedEventArgs e)
        {
            opr = "root";
            n1 = Convert.ToDouble(tb.Text);
            tb.Text = "";
        }
        private void equal_Click(object sender, RoutedEventArgs e)
        {
            n2 = Convert.ToDouble(tb.Text);
            tb.Text= Convert.ToString(ans(n1,n2));
        }
        public double ans(double n1, double n2)
        {
            double a = 0;
            switch (opr)
            {
                case "+":
                    a = n1 + n2;
                break;
                case "-":
                    a = n1 - n2;
                break;
                case "*":
                    a = n1 * n2;
                break;
                case "/":
                    a = n1 / n2;
                break;
                case "%":
                     
                break; 
                default:
                    tb.Text = "Invalid Input";
                break;
            }
            return a;
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            tb.Text="0";
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {

       
            if (tb.Text.Length != 1)
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
            else
            {
                tb.Text = "0";
            }
            
        }

        private void tb_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            tmp1 = tb.Text;
            if (System.Text.RegularExpressions.Regex.IsMatch(tb.Text, "^[0-9]"))
            {
            }
            else
            {
                tb.Text = "Invalid Input.!";
                WaitForTwoSeconds(); 
            }

        }
        private async void WaitForTwoSeconds()
        {
            await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(2));
            tb.Text = tmp1;
        }
        
    }
}
