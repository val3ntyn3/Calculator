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
    public partial class Form1 : Form
    {
        //static class Globals
        //{
        //    public static ArrayList operatorsArrayList = new ArrayList();
        //    public static ArrayList numbersArrayList = new ArrayList();
        //}

        public Form1()
        {
            InitializeComponent();
        }

        ArrayList operatorsArrayList = new ArrayList();
        ArrayList numbersArrayList = new ArrayList();

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
            string lastChar = "d";

            if (textBox1.Text.Length > 0)
            {
                lastChar = textBox1.Text.Substring(textBox1.Text.Length - 1);
            }

            if ((textBox1.Text.Length > 0) && (lastChar != ",") && (lastChar != "+") && (lastChar != "-") && (lastChar != "*") && (lastChar != "/"))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox1.Text + " + ";
            }
            else
            {
                textBox2.Text = textBox2.Text + textBox1.Text + " + ";
            }
            operatorsArrayList.Add("+");
            numbersArrayList.Add(textBox1.Text);
            textBox1.Text = null;
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox1.Text + " - ";
            }
            else
            {
                textBox2.Text = textBox2.Text + textBox1.Text + " - ";
            }
            operatorsArrayList.Add("-");
            numbersArrayList.Add(textBox1.Text);
            textBox1.Text = null;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox1.Text + " * ";
            }
            else
            {
                textBox2.Text = textBox2.Text + textBox1.Text + " * ";
            }
            operatorsArrayList.Add("*");
            numbersArrayList.Add(textBox1.Text);
            textBox1.Text = null;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox1.Text + " / ";
            }
            else
            {
                textBox2.Text = textBox2.Text + textBox1.Text + " / ";
            }
            operatorsArrayList.Add("/");
            numbersArrayList.Add(textBox1.Text);
            textBox1.Text = null;
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
            numbersArrayList.Add(textBox1.Text);

            textBox2.Text = textBox2.Text + textBox1.Text + " =";
            int operatorsArrayListLenght = operatorsArrayList.Count;
            decimal numberReplace;
            //int numberReplace = 0;
            textBox1.Text = null;


            while (operatorsArrayListLenght > 0)
            {
                while (operatorsArrayList.Contains("*") || operatorsArrayList.Contains("/"))
                {
                    for (int i = 0; i < operatorsArrayListLenght; i++)
                    {
                        //i = 0;
                        numberReplace = 0;
                        if ((operatorsArrayList[i].ToString() == "*") || (operatorsArrayList[i].ToString() == "/"))
                        {
                            if (operatorsArrayList[i].ToString() == "*")
                            {
                                numberReplace = (Convert.ToDecimal(numbersArrayList[i]) * Convert.ToDecimal(numbersArrayList[i + 1]));
                            }
                            if (operatorsArrayList[i].ToString() == "/")
                            {
                                numberReplace = (Convert.ToDecimal(numbersArrayList[i]) / Convert.ToDecimal(numbersArrayList[i + 1]));
                            }

                            MessageBox.Show($"Numar {i}: " + numbersArrayList[i].ToString());
                            MessageBox.Show($"Operator {i}: " + operatorsArrayList[i].ToString());
                            MessageBox.Show($"Numar {i}: " + numbersArrayList[i + 1].ToString());

                            operatorsArrayList.RemoveAt(i);
                            numbersArrayList.RemoveAt(i);
                            numbersArrayList.RemoveAt(i);
                            numbersArrayList.Insert(i, numberReplace);
                            operatorsArrayListLenght = operatorsArrayListLenght - 1;
                            textBox1.Text = numberReplace.ToString("#.##");
                        }
                    }
                }

                while (operatorsArrayList.Contains("+") || operatorsArrayList.Contains("-"))
                {
                    for (int i = 0; i < operatorsArrayListLenght; i++)
                    {
                        i = 0;
                        numberReplace = 0;
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

                            MessageBox.Show($"Numar {i}: " + numbersArrayList[i].ToString());
                            MessageBox.Show($"Operator {i}: " + operatorsArrayList[i].ToString());
                            MessageBox.Show($"Numar {i + 1}: " + numbersArrayList[i + 1].ToString());

                            operatorsArrayList.RemoveAt(i);
                            numbersArrayList.RemoveAt(i);
                            numbersArrayList.RemoveAt(i);
                            numbersArrayList.Insert(i, numberReplace);
                            operatorsArrayListLenght = operatorsArrayListLenght - 1;
                            textBox1.Text = numberReplace.ToString("#.##");
                        }
                    }
                }
            }
        }
    }
}