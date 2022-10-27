using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            result01TextBox.Text = "";
            result02TextBox.Text = "";
            result03TextBox.Text = "";
            result04TextBox.Text = "";
            result05TextBox.Text = "";
            result06TextBox.Text = "";
            result07TextBox.Text = "";
            result08TextBox.Text = "";
            result09TextBox.Text = "";
            result10TextBox.Text = "";
            result03bTextBox.Text = "";
            result04bTextBox.Text = "";
            result05bTextBox.Text = "";
            result06bTextBox.Text = "";
            result07bTextBox.Text = "";
            result09bTextBox.Text = "";

            // 1.
            decimal subtotal = Convert.ToDecimal(input01aTextBox.Text);
            //result01TextBox.Text = (subtotal >= 250 && subtotal < 500).ToString();
            result01TextBox.Text = (LogicalOperations.q01(subtotal)).ToString();

            // 2.
            int timeInService = Convert.ToInt32(input02aTextBox.Text);
            //result02TextBox.Text = (timeInService <= 4 || timeInService >= 12).ToString();
            
                result02TextBox.Text = (LogicalOperations.q02(timeInService)
                    ).ToString();

            // 3. - .6 initialization
            bool isValid = Convert.ToBoolean(input03aTextBox.Text);
            int years = Convert.ToInt32(input03cTextBox.Text);

            // 3.
            int counter = Convert.ToInt32(input03bTextBox.Text);
            result03TextBox.Text = (
                    LogicalOperations.q03(isValid, years, counter)
                ).ToString();
            result03bTextBox.Text = counter.ToString();

            // 4.
            counter = Convert.ToInt32(input03bTextBox.Text);
            result04TextBox.Text = (
                    //isValid == true & counter++ < years
                    LogicalOperations.q04( isValid,  years,  counter)
        
                ).ToString();
            result04bTextBox.Text = counter.ToString();

            // 5.
            counter = Convert.ToInt32(input03bTextBox.Text);
            result05TextBox.Text = (
                    //isValid == true || counter++ < years
                     LogicalOperations.q05( isValid,  years,  counter)
                ).ToString();
            result05bTextBox.Text = counter.ToString();

            // 6.
            counter = Convert.ToInt32(input03bTextBox.Text);
            result06TextBox.Text = (
                    //isValid == true | counter++ < years
                    LogicalOperations.q06( isValid,  years,  counter)
                ).ToString();
            result06bTextBox.Text = counter.ToString();

            // 7.
            DateTime startDate = Convert.ToDateTime(input07aTextBox.Text);
            DateTime expirationDate = Convert.ToDateTime(input07bTextBox.Text);
            DateTime date = Convert.ToDateTime(input07cTextBox.Text);
            isValid = Convert.ToBoolean(input07dTextBox.Text);
            result07TextBox.Text = (
                   // date > startDate && date < expirationDate || isValid == true
                   (LogicalOperations.q07(startDate, expeirationDate, date, isValid)
                ).ToString();

            // 8.
            decimal thisYTD = Convert.ToDecimal(input08aTextBox.Text);
            decimal lastYTD = Convert.ToDecimal(input08bTextBox.Text);
            string empType = input08cTextBox.Text;
            int startYear = Convert.ToInt32(input08dTextBox.Text);
            int currentYear = Convert.ToInt32(input08eTextBox.Text);
            result08TextBox.Text = (
                //((thisYTD > lastYTD) || empType == "Part time") && startYear < currentYear
                LogicalOperations.q08( thisYTD,  lastYTD,  empType,  startYear, currentYear)
            ).ToString();

            // 9.
            counter = Convert.ToInt32(input09aTextBox.Text);
            years = Convert.ToInt32(input09bTextBox.Text);
            result09TextBox.Text = (
                    //!(counter++ >= years)
                    LogicalOperations.q08( thisYTD,  lastYTD,  empType,  startYear,  currentYear)
               ).ToString();
            result09bTextBox.Text = counter.ToString();

            // 10.
            int a = Convert.ToInt32(input10aTextBox.Text);
            int b = Convert.ToInt32(input10bTextBox.Text);
            int c = Convert.ToInt32(input10cTextBox.Text);
            int d = Convert.ToInt32(input10dTextBox.Text);
            result10TextBox.Text = (
            //        a + b * c - d
            //    ).ToString();
               
                //a > b && b < c || c < d
                LogicalOperations.q10( a,  b,  c,  d)
            ).ToString();
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
