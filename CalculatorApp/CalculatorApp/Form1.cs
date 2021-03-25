using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }


        private double GetNum1()
        {
            return double.Parse(textBox1.Text);
        }

        
        private double GetNum2()
        {
            return double.Parse(textBox2.Text);
        }
        
        
        private double Additon(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        
        private double Subtraction(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        
        
        private double Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        
        
        private double Division(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
        
        
        
        // Events functions.....................................
        
        private void addButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = $"The result of addition is: {Additon(GetNum1(), GetNum2())}";
        }


        private void subtractionButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = $"The result of subtraction is: {Subtraction(GetNum1(), GetNum2())}";
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = $"The result of multiplication is: {Multiplication(GetNum1(), GetNum2())}";
        }

        private void divisioinButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = $"The result of division is: {Division(GetNum1(), GetNum2())}";
        }

        private void allCalculatioinsButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = ($"The result of addition is: {Additon(GetNum1(), GetNum2())}\r\n" +
                              $"The result of subtraction is: {Subtraction(GetNum1(), GetNum2())}\r\n" +
                              $"The result of multiplication is: {Multiplication(GetNum1(), GetNum2())}\r\n" +
                              $"The result of division is: {Division(GetNum1(), GetNum2())}");
        }
    }
}