using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeBook
{
    class Validator
    {

        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }

            return true;

        }

        public static bool IsInt(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a integer value.", "Entry Error");
                textBox.Focus();
                return false;
            }

        }

        public static bool IsAlphabetic(TextBox textBox)
        {
            double number = 0;
            if (!(Double.TryParse(textBox.Text, out number)))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an Alphabetic value.", "Entry Error");
                textBox.Focus();
                return false;
            }

        }

        public static bool IsWithinRange(TextBox textBox, int min, int max)
        {
            int number = Convert.ToInt32(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min
                    + " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

    }
}
