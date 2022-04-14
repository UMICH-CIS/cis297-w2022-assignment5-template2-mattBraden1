using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorGUI
{
   public partial class CalculatorGUIForm : Form
   {
      public CalculatorGUIForm()
      {
         InitializeComponent();
      }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Writes 0 in text box
        /// </summary>
        private void btn0_Click(object sender, EventArgs e)
        {
            textBox.Text += 0;
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Writes 1 in text box
        /// </summary>
        private void btn1_Click(object sender, EventArgs e)
        {
            textBox.Text += 1;
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Writes 2 in text box
        /// </summary>
        private void btn2_Click(object sender, EventArgs e)
        {
            textBox.Text += 2;
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Writes 3 in text box
        /// </summary>
        private void btn3_Click(object sender, EventArgs e)
        {
            textBox.Text += 3;
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Writes 4 in text box
        /// </summary>
        private void btn4_Click(object sender, EventArgs e)
        {
            textBox.Text += 4;
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Writes 5 in text box
        /// </summary>
        private void btn5_Click(object sender, EventArgs e)
        {
            textBox.Text += 5;
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Writes 6 in text box
        /// </summary>
        private void btn6_Click(object sender, EventArgs e)
        {
            textBox.Text += 6;
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Writes 7 in text box
        /// </summary>
        private void btn7_Click(object sender, EventArgs e)
        {
            textBox.Text += 7;
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Writes 8 in text box
        /// </summary>
        private void btn8_Click(object sender, EventArgs e)
        {
            textBox.Text += 8;
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Writes 9 in text box
        /// </summary>
        private void btn9_Click(object sender, EventArgs e)
        {
            textBox.Text += 9;
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Writes / in text box
        /// </summary>
        private void btnSlash_Click(object sender, EventArgs e)
        {
            textBox.Text += "/";
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Writes * in text box
        /// </summary>
        private void btnTimes_Click(object sender, EventArgs e)
        {
            textBox.Text += "*";
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Writes = in text box
        /// </summary>
        private void btnEq_Click(object sender, EventArgs e)
        {
            textBox.Text += "=";
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Writes . in text box
        /// </summary>
        private void btnDot_Click(object sender, EventArgs e)
        {
            textBox.Text += ".";
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Removes all whitespaces in the string
        /// </summary>
        private void remWS_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text.Replace(" ", "");
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Flips the string around
        /// </summary>
        private void revStr_Click(object sender, EventArgs e)
        {
            string temp = textBox.Text;
            textBox.Text = "";
            foreach (char obj in temp.ToCharArray())
                textBox.Text = obj + textBox.Text;
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Passes the first number in a string back as a reference
        /// </summary>
        private void getNum(string s, ref decimal a)
        {
            bool firstInt = true;
            bool firstDec = true;
            bool firstNegative = false;
            string strA = "";
            foreach (char obj in s.ToCharArray())
                if (obj <= 57 && obj >= 48)
                {
                    if (firstInt)
                        strA += obj;
                }
                else if (obj == 46)
                {
                    if (firstInt && firstDec)
                    {
                        strA += '.';
                        firstDec = false;
                    }
                    else
                        break;

                }
                else if (strA == "" && obj == 45)
                    firstNegative = true;
                else if (strA != "")
                    break;
            if (strA != "" && !firstNegative)
                a = Convert.ToDecimal(strA);
            else if (strA != "")
                a = Convert.ToDecimal("-" + strA);
            else
                a = 0;
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Passes the first two numbers in a string back as a reference
        /// </summary>
        private void getNum(string s, ref decimal a, ref decimal b)
        {
            bool firstInt = true;
            bool firstDec = true, secondDec = true;
            bool firstNegative = false, secondNegative = false;
            string strA = "", strB = "";
            foreach (char obj in s.ToCharArray())
                if (obj <= 57 && obj >= 48)
                    if (firstInt)
                        strA += obj;
                    else
                        strB += obj;
                else if (obj == 46) {
                    if (firstInt && firstDec)
                    {
                        strA += '.';
                        firstDec = false;
                    }
                    else if (firstInt)
                        firstInt = false;
                    else if (secondDec)
                    {
                        strB += '.';
                        secondDec = false;
                    }
                    else
                        break;
                }
                else if (strA == "" && obj == 45 && firstInt)
                    firstNegative = true;
                else if (strA != "" && firstInt)
                     firstInt = false;
                else if (strB == "" && obj == 45)
                    secondNegative = true;
                else if (strB != "")
                     break;

            if (strA != "" && !firstNegative)
                a = Convert.ToDecimal(strA);
            else if (strA != "")
                a = Convert.ToDecimal("-" + strA);
            else
                a = 0;
            if (strB != "" && !secondNegative)
                b = Convert.ToDecimal(strB);
            else if (strB != "")
                b = Convert.ToDecimal("-" + strB);
            else
                b = 0;
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Passes the first three numbers in a string back as a reference
        /// </summary>
        private void getNum(string s, ref decimal a, ref decimal b, ref decimal c)
        {
            bool firstInt = true, secondInt = true;
            bool firstDec = true, secondDec = true, thirdDec = true;
            bool firstNegative = false, secondNegative = false, thirdNegative = false;
            string strA = "", strB = "", strC = "";
            foreach (char obj in s.ToCharArray())
                if (obj <= 57 && obj >= 48)
                {
                    if (firstInt)
                        strA += obj;
                    else if (secondInt)
                        strB += obj;
                    else
                        strC += obj;
                }
                else if (obj == 46)
                {
                    if (firstInt && firstDec)
                    {
                        strA += '.';
                        firstDec = false;
                    }
                    else if (firstInt)
                        firstInt = false;
                    else if (secondInt && secondDec)
                    {
                        strB += '.';
                        secondDec = false;
                    }
                    else if (secondInt)
                        secondInt = false;
                    else if (thirdDec)
                    {
                        strC += '.';
                        thirdDec = false;
                    }
                    else
                        break;
                }
                else if (strA == "" && obj == 45 && firstInt)
                    firstNegative = true;
                else if (strA != "" && firstInt)
                    firstInt = false;
                else if (strB == "" && obj == 45 && secondInt)
                    secondNegative = true;
                else if (strB != "" && secondInt)
                    secondInt = false;
                else if (strC == "" && obj == 45)
                    thirdNegative = true;
                else if (strC != "")
                    break;
            if (strA != "" && !firstNegative)
                a = Convert.ToDecimal(strA);
            else if (strA != "")
                a = Convert.ToDecimal("-" + strA);
            else
                a = 0;
            if (strB != "" && !secondNegative)
                b = Convert.ToDecimal(strB);
            else if (strB != "")
                b = Convert.ToDecimal("-" + strB);
            else
                b = 0;
            if (strC != "" && !thirdNegative)
                c = Convert.ToDecimal(strC);
            else if (strC != "")
                c = Convert.ToDecimal("-" + strC);
            else
                c = 0;
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Gets the quotient and remainder of a number
        /// </summary>
        private void quoRem_Click(object sender, EventArgs e)
        {
            decimal num = 0, quotient = 0;
            int rem = 0, numInt = 0, quoInt = 0;
            getNum(textBox.Text, ref num, ref quotient);
            if (quotient != 0)
            {
                numInt = Convert.ToInt32(num);
                quoInt = Convert.ToInt32(quotient);
                textBox.Text = numInt + "/" + quoInt + "=" + Math.DivRem(numInt, quoInt, out rem) + " with a remainder of " + rem;
            }
            else
                textBox.Text = "Cannot divide by zero!";
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Gets the log base 10 of a number
        /// </summary>
        private void logTen_Click(object sender, EventArgs e)
        {
            decimal num = 0;
            getNum(textBox.Text, ref num);
            textBox.Text = "The log10 of "+num+" is "+Math.Log10(Convert.ToDouble(num));
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Gets the log base N of a number
        /// </summary>
        private void logN_Click(object sender, EventArgs e)
        {
            decimal num = 0, myBase = 0;
            getNum(textBox.Text, ref num, ref myBase);
            textBox.Text = "The log"+myBase+" of " + num + " is " + Math.Log(Convert.ToDouble(num),Convert.ToDouble(myBase));
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Gets the max and min numbers
        /// </summary>
        private void minMax_Click(object sender, EventArgs e)
        {
            decimal a = 0, b = 0;
            getNum(textBox.Text, ref a, ref b);
            textBox.Text = "Min: "+Math.Min(a,b)+" Max: "+Math.Max(a,b);
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Gets a number to a power N
        /// </summary>
        private void getPwr_Click(object sender, EventArgs e)
        {
            decimal a = 0, b = 0;
            getNum(textBox.Text, ref a, ref b);
            textBox.Text = a+"^"+b+"= " + Math.Pow(Convert.ToDouble(a),Convert.ToDouble(b));
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Finds the roots of a, b, and c
        /// </summary>
        private void findRoot_Click(object sender, EventArgs e)
        {
            decimal a = 0, b = 0, c = 0;
            if (a != 0)
            {
                getNum(textBox.Text, ref a, ref b, ref c);
                double dA = Convert.ToDouble(a), dB = Convert.ToDouble(b), dC = Convert.ToDouble(c), rootA = 0, rootB = 0;
                rootA = (-dB + Math.Sqrt(Math.Pow(dB, 2) - (4 * dA * dC))) / (2 * dA);
                rootB = (-dB - Math.Sqrt(Math.Pow(dB, 2) - (4 * dA * dC))) / (2 * dA);
                textBox.Text = "1st root: " + rootA + " 2nd root:" + rootB;
            }
            else
                textBox.Text = "A cannot be zero!";
        }
        /// <summary>
        /// Matthew Braden, Winter 2022
        /// Gets the square root of a number
        /// </summary>
        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            decimal a = 0;
            getNum(textBox.Text, ref a);
            double dA = Convert.ToDouble(a);
            textBox.Text = "Square root of "+dA+" is "+Math.Sqrt(dA);
        }
    }
}
/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/