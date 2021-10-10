/// Week 7 Lab 1
///
/// @author: Julian Trupe
/// Date:  October 10, 2021
///
/// Problem Statement: Create a GUI program to do a simple mathematic calculation
//
/// Overall Plan:
/// 1) Draw text boxes, list box for operation, calculate button
/// 2) Display error message is divide by 0 occurs

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

namespace Lab1
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Operation = operandListBox.SelectedIndex;
                decimal leftHand = Convert.ToDecimal(leftBox.Text);
                decimal rightHand = Convert.ToDecimal(rightBox.Text);
                decimal result = 0;
                switch (Operation)
                {
                    case 0:
                        result = leftHand + rightHand;
                        resultBox.Text = result.ToString();
                        break;
                    case 1:
                        result = leftHand - rightHand;
                        resultBox.Text = result.ToString();
                        break;
                    case 2:
                        result = leftHand * rightHand;
                        resultBox.Text = result.ToString();
                        break;
                    case 3:
                        result = leftHand / rightHand;
                        resultBox.Text = result.ToString();
                        break;
                    case 4:
                        result = leftHand % rightHand;
                        resultBox.Text = result.ToString();
                        break;
                    default:
                        result = 0;
                        MessageBox.Show("No operand selected");
                        break;

                }
            }
            catch (DivideByZeroException f)
            {
                MessageBox.Show("error: Cannot divide by zero");
            }
        }
    }
}
