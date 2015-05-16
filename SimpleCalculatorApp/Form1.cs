using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorApp
{
    public partial class simpleCaculatorUI : Form
    {
         double firstNumber, secondNumber, result;
        
        public simpleCaculatorUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            
            result = firstNumber + secondNumber;
            resultTextBox.Text = Convert.ToString(result);
        }

        private void firstNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
        }

        private void secondNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            result = firstNumber - secondNumber;
            resultTextBox.Text = Convert.ToString(result);
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            result = firstNumber / secondNumber;
            resultTextBox.Text = Convert.ToString(result);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            result = firstNumber*secondNumber;
            resultTextBox.Text = Convert.ToString(result);
        }

     
    }
}
