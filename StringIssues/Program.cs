using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StringIssues
{
    class Program
    {


        static void Main(string[] args)
        {
            BuildingStrings bs = new BuildingStrings{Count = 20000};
            bs.GenerateStringsConcatenation();
            bs.GenerateStringsBuilder();

        }

        private static int EnsureNegative(int number)
        {
            int resultNumber = 0;
            if (number > 0 || number < 0)
            {
                string numberString = "-" + number.ToString();
                numberString = numberString.Replace("--", "-");

                resultNumber = int.Parse(numberString);
            }
            return resultNumber;
        }


        static void ClearControls(Control parent)
        {
            Control control = parent.FindControl("textBox1");
            TextBox textBox = (TextBox)control;
            textBox.Text = string.Empty;
            control = parent.FindControl("textBox2");
            textBox = (TextBox)control;
            textBox.Text = string.Empty;
            control = parent.FindControl("textBox3");
            textBox = (TextBox)control;
            textBox.Text = string.Empty;
            control = parent.FindControl("textBox4");
            textBox = (TextBox)control;
            textBox.Text = string.Empty;
            control = parent.FindControl("textBox5");
            textBox = (TextBox)control;
            textBox.Text = string.Empty;

        }
        
        
    }
}
