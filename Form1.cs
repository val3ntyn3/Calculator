using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        ArrayList operatorsArrayList = new ArrayList();
        ArrayList numbersArrayList = new ArrayList();
        string lastChar;
        decimal numberLessThenZero, numberReplace;
        int operatorsArrayListLenght;

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                lastChar = textBox1.Text.Substring(textBox1.Text.Length - 1);
            }

            if (textBox1.Text.Length > 0 && lastChar != "," && lastChar != "-" && !(textBox1.Text.Contains(",")))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0 && textBox1.Text.Length > 0 && textBox1.Text != "-")
            {
                numberLessThenZero = Convert.ToDecimal(textBox1.Text);
                if (numberLessThenZero < 0)
                {
                    textBox2.Text = "(" + textBox1.Text + ") + ";
                }
                else
                {
                    textBox2.Text = textBox1.Text + " + ";
                }
                operatorsArrayList.Add("+");
                numbersArrayList.Add(textBox1.Text);
                textBox1.Text = null;
            }
            else if (textBox2.Text.Length > 0 && textBox1.Text.Length > 0 && textBox1.Text != "-")
            {
                textBox2.SelectionStart = textBox2.Text.Length - 1;
                numberLessThenZero = Convert.ToDecimal(textBox1.Text);
                lastChar = textBox2.Text.Substring(textBox2.Text.Length - 1);
                if (lastChar == "=")
                {
                    if (numberLessThenZero < 0)
                    {
                        textBox2.Text = textBox2.Text + " (" + textBox1.Text + ") + ";
                    }
                    else
                    {
                        textBox2.Text = textBox2.Text + " " + textBox1.Text + " + ";
                    }
                }
                else
                {
                    if (numberLessThenZero < 0)
                    {
                        textBox2.Text = textBox2.Text + "(" + textBox1.Text + ") + ";
                    }
                    else
                    {
                        textBox2.Text = textBox2.Text + textBox1.Text + " + ";
                    }
                }
                operatorsArrayList.Add("+");
                numbersArrayList.Add(textBox1.Text);
                textBox1.Text = null;
                textBox2.SelectionStart = textBox2.Text.Length - 1;
            }
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "-";
            }
            else if (textBox2.Text.Length == 0 && textBox1.Text.Length > 0 && textBox1.Text != "-")
            {
                numberLessThenZero = Convert.ToDecimal(textBox1.Text);
                if (numberLessThenZero < 0)
                {
                    textBox2.Text = "(" + textBox1.Text + ") - ";
                }
                else
                {
                    textBox2.Text = textBox1.Text + " - ";
                }
                operatorsArrayList.Add("-");
                numbersArrayList.Add(textBox1.Text);
                textBox1.Text = null;
            }
            else if (textBox2.Text.Length > 0 && textBox1.Text.Length > 0 && textBox1.Text != "-")
            {
                textBox2.SelectionStart = textBox2.Text.Length - 1;
                numberLessThenZero = Convert.ToDecimal(textBox1.Text);
                lastChar = textBox2.Text.Substring(textBox2.Text.Length - 1);
                if (lastChar == "=")
                {
                    if (numberLessThenZero < 0)
                    {
                        textBox2.Text = textBox2.Text + " (" + textBox1.Text + ") - ";
                    }
                    else
                    {
                        textBox2.Text = textBox2.Text + " " + textBox1.Text + " - ";
                    }
                }
                else
                {
                    if (numberLessThenZero < 0)
                    {
                        textBox2.Text = textBox2.Text + "(" + textBox1.Text + ") - ";
                    }
                    else
                    {
                        textBox2.Text = textBox2.Text + textBox1.Text + " - ";
                    }
                }
                operatorsArrayList.Add("-");
                numbersArrayList.Add(textBox1.Text);
                textBox1.Text = null;
                textBox2.SelectionStart = textBox2.Text.Length - 1;
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0 && textBox1.Text.Length > 0 && textBox1.Text != "-")
            {
                numberLessThenZero = Convert.ToDecimal(textBox1.Text);
                if (numberLessThenZero < 0)
                {
                    textBox2.Text = "(" + textBox1.Text + ") * ";
                }
                else
                {
                    textBox2.Text = textBox1.Text + " * ";
                }
                operatorsArrayList.Add("*");
                numbersArrayList.Add(textBox1.Text);
                textBox1.Text = null;
                textBox2.SelectionStart = textBox2.Text.Length - 1;
            }
            else if (textBox2.Text.Length > 0 && textBox1.Text.Length > 0 && textBox1.Text != "-")
            {
                textBox2.SelectionStart = textBox2.Text.Length - 1;
                numberLessThenZero = Convert.ToDecimal(textBox1.Text);
                lastChar = textBox2.Text.Substring(textBox2.Text.Length - 1);
                if (lastChar == "=")
                {
                    if (numberLessThenZero < 0)
                    {
                        textBox2.Text = textBox2.Text + " (" + textBox1.Text + ") * ";
                    }
                    else
                    {
                        textBox2.Text = textBox2.Text + " " + textBox1.Text + " * ";
                    }
                }
                else
                {
                    if (numberLessThenZero < 0)
                    {
                        textBox2.Text = textBox2.Text + "(" + textBox1.Text + ") * ";
                    }
                    else
                    {
                        textBox2.Text = textBox2.Text + textBox1.Text + " * ";
                    }
                }
                operatorsArrayList.Add("*");
                numbersArrayList.Add(textBox1.Text);
                textBox1.Text = null;
                textBox2.SelectionStart = textBox2.Text.Length - 1;
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0 && textBox1.Text.Length > 0 && textBox1.Text != "-")
            {
                numberLessThenZero = Convert.ToDecimal(textBox1.Text);
                if (numberLessThenZero < 0)
                {
                    textBox2.Text = "(" + textBox1.Text + ") / ";
                }
                else
                {
                    textBox2.Text = textBox1.Text + " / ";
                }
                operatorsArrayList.Add("/");
                numbersArrayList.Add(textBox1.Text);
                textBox1.Text = null;
            }
            else if (textBox2.Text.Length > 0 && textBox1.Text.Length > 0 && textBox1.Text != "-")
            {
                textBox2.SelectionStart = textBox2.Text.Length - 1;
                numberLessThenZero = Convert.ToDecimal(textBox1.Text);
                lastChar = textBox2.Text.Substring(textBox2.Text.Length - 1);
                if (lastChar == "=")
                {
                    if (numberLessThenZero < 0)
                    {
                        textBox2.Text = textBox2.Text + " (" + textBox1.Text + ") / ";
                    }
                    else
                    {
                        textBox2.Text = textBox2.Text + " " + textBox1.Text + " / ";
                    }
                }
                else
                {
                    if (numberLessThenZero < 0)
                    {
                        textBox2.Text = textBox2.Text + "(" + textBox1.Text + ") / ";
                    }
                    else
                    {
                        textBox2.Text = textBox2.Text + textBox1.Text + " / ";
                    }
                }
                operatorsArrayList.Add("/");
                numbersArrayList.Add(textBox1.Text);
                textBox1.Text = null;
                textBox2.SelectionStart = textBox2.Text.Length - 1;
            }
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox1.Text.Length == 1)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            textBox2.SelectionStart = textBox2.Text.Length - 1;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            operatorsArrayList.Clear();
            numbersArrayList.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                lastChar = textBox2.Text.Substring(textBox2.Text.Length - 1);
            }
            if (textBox1.Text.Length > 0 && lastChar != "=" && textBox1.Text != "-")
            {
                numberLessThenZero = Convert.ToDecimal(textBox1.Text);
                if (numberLessThenZero < 0)
                {
                    textBox2.Text = textBox2.Text + "(" + textBox1.Text + ") =";
                }
                else
                {
                    textBox2.Text = textBox2.Text + textBox1.Text + " =";
                }
                numbersArrayList.Add(textBox1.Text);
                textBox1.Text = null;
            }

            operatorsArrayListLenght = operatorsArrayList.Count;

            while (operatorsArrayListLenght > 0)
            {
                while (operatorsArrayList.Contains("*") || operatorsArrayList.Contains("/"))
                {
                    for (int i = 0; i < operatorsArrayListLenght; i++)
                    {
                        numberReplace = 0;
                        if ((operatorsArrayList[i].ToString() == "*") || (operatorsArrayList[i].ToString() == "/"))
                        {

                            //MessageBox.Show($"Numar {i}: " + numbersArrayList[i].ToString());
                            //MessageBox.Show($"Operator {i}: " + operatorsArrayList[i].ToString());
                            //MessageBox.Show($"Numar {i + 1}: " + numbersArrayList[i + 1].ToString());

                            if (operatorsArrayList[i].ToString() == "*")
                            {
                                numberReplace = (Convert.ToDecimal(numbersArrayList[i]) * Convert.ToDecimal(numbersArrayList[i + 1]));
                            }
                            if (operatorsArrayList[i].ToString() == "/")
                            {
                                if (Convert.ToDecimal(numbersArrayList[i + 1]) == 0)
                                {
                                    textBox2.Text = "You cannot divide a number by zero! ";
                                    textBox1.Text = "";
                                }
                                else
                                {
                                    numberReplace = (Convert.ToDecimal(numbersArrayList[i]) / Convert.ToDecimal(numbersArrayList[i + 1]));
                                }
                            }

                            operatorsArrayList.RemoveAt(i);
                            numbersArrayList.RemoveAt(i);
                            numbersArrayList.RemoveAt(i);
                            numbersArrayList.Insert(i, numberReplace);
                            operatorsArrayListLenght -= 1;
                            i -= 1;

                            if (numberReplace > -1 && numberReplace < 1)
                            {
                                textBox1.Text = "0" + numberReplace.ToString("#.##"); ;
                            }
                            else if (numberReplace == 0)
                            {
                                textBox1.Text = "0";
                            }
                            else
                            {
                                textBox1.Text = numberReplace.ToString("#.##");
                            }
                        }
                    }
                }

                while (operatorsArrayList.Contains("+") || operatorsArrayList.Contains("-"))
                {
                    for (int i = 0; i < operatorsArrayListLenght; i++)
                    {
                        numberReplace = 0;

                        //MessageBox.Show($"Numar {i}: " + numbersArrayList[i].ToString());
                        //MessageBox.Show($"Operator {i}: " + operatorsArrayList[i].ToString());
                        //MessageBox.Show($"Numar {i + 1}: " + numbersArrayList[i + 1].ToString());

                        if ((operatorsArrayList[i].ToString() == "+") || (operatorsArrayList[i].ToString() == "-"))
                        {
                            if (operatorsArrayList[i].ToString() == "+")
                            {
                                numberReplace = (Convert.ToDecimal(numbersArrayList[i]) + Convert.ToDecimal(numbersArrayList[i + 1]));
                            }
                            if (operatorsArrayList[i].ToString() == "-")
                            {
                                numberReplace = (Convert.ToDecimal(numbersArrayList[i]) - Convert.ToDecimal(numbersArrayList[i + 1]));
                            }

                            operatorsArrayList.RemoveAt(i);
                            numbersArrayList.RemoveAt(i);
                            numbersArrayList.RemoveAt(i);
                            numbersArrayList.Insert(i, numberReplace);
                            operatorsArrayListLenght -= 1;
                            i -= 1;

                            if (numberReplace > -1 && numberReplace < 1)
                            {
                                textBox1.Text = "0" + numberReplace.ToString("#.##"); ;
                            }
                            else if (numberReplace == 0)
                            {
                                textBox1.Text = "0";
                            }
                            else
                            {
                                textBox1.Text = numberReplace.ToString("#.##");
                            }
                        }
                    }
                }
            }

            operatorsArrayList.Clear();
            numbersArrayList.Clear();
        }
    }
}