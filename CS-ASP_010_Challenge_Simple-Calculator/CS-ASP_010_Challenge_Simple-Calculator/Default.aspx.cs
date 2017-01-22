using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_010_Challenge_Simple_Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void additionButton_Click(object sender, EventArgs e)
        {
            string firstValueInput = firstValueTextBox.Text;
            string secondValueInput = secondValueTextBox.Text;

            double firstValueInputDouble = double.Parse(firstValueInput);
            double secondValueInputDouble = double.Parse(secondValueInput);

            double result = firstValueInputDouble + secondValueInputDouble;

            resultLabel.Text = result.ToString();
        }

        protected void subtractionButton_Click(object sender, EventArgs e)
        {
            string firstValueInput = firstValueTextBox.Text;
            string secondValueInput = secondValueTextBox.Text;

            double firstValueInputDouble = double.Parse(firstValueInput);
            double secondValueInputDouble = double.Parse(secondValueInput);

            double result = firstValueInputDouble - secondValueInputDouble;

            resultLabel.Text = result.ToString();
        }

        protected void multiplicationButton_Click(object sender, EventArgs e)
        {
            string firstValueInput = firstValueTextBox.Text;
            string secondValueInput = secondValueTextBox.Text;

            double firstValueInputDouble = double.Parse(firstValueInput);
            double secondValueInputDouble = double.Parse(secondValueInput);

            double result = firstValueInputDouble * secondValueInputDouble;

            resultLabel.Text = result.ToString();
        }

        protected void divisionButton_Click(object sender, EventArgs e)
        {
            string firstValueInput = firstValueTextBox.Text;
            string secondValueInput = secondValueTextBox.Text;

            double firstValueInputDouble = double.Parse(firstValueInput);
            double secondValueInputDouble = double.Parse(secondValueInput);

            double result = firstValueInputDouble / secondValueInputDouble;

            resultLabel.Text = result.ToString();
        }
    }
}