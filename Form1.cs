using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Assignment4_2Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelDecimal.Visible = true;
            pictureBoxUnderDecimal.Visible = false;
            panelRomanNumerals.Visible = false;
            //StringStorage display=new StringStorage();
            //display.
            
            txtInputDisplay.Text = "";
            richTextBoxDisplayHistory.Text = "";
            lblCurrentDisplay.Text = "";
            numericUpDownDecimal.Value = 3;

            
        }

        private void checkBoxConvertToRN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxConvertToRN.Checked)
            {
                panelRomanNumerals.Visible = true;
                panelDecimal.Visible = false;
                pictureBoxUnderDecimal.Visible = true;
                lblDecimalPlaces.Visible = false;
                numericUpDownDecimal.Visible = false;
                txtInputDisplay.Clear();
                Refresh();
            }
            else
            {
                panelDecimal.Visible = true;
                pictureBoxUnderDecimal.Visible = false;
                panelRomanNumerals.Visible = false;
                lblDecimalPlaces.Visible = true;
                numericUpDownDecimal.Visible = true;
                txtInputDisplay.Clear();
                Refresh();

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Clear();
            lblCurrentDisplay.Text="";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if(txtInputDisplay.Text.Length != 0)
            {
                txtInputDisplay.Text += "0";
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if(!txtInputDisplay.Text.Contains(".")) 
            {
                txtInputDisplay.Text += ".";
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (txtInputDisplay.Text.Contains("-"))
            {
                txtInputDisplay.Text=txtInputDisplay.Text.Remove(0,1);
                txtInputDisplay.Refresh();
            }
            else
            {
                txtInputDisplay.Text="-"+txtInputDisplay.Text;
                //- Alt 45
                //↕ Alt 8722
                //‼ Alt 8211
                //¶ Alt 8212
                //_ Alt95
               //***********    ─//Alt 196
                
            }
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text= "3.14159265";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblCurrentDisplay.Text = txtInputDisplay.Text;
            if (!Regex.IsMatch(lblCurrentDisplay.Text, @"[\+\─\/X]") && txtInputDisplay.Text.Length > 0)//minus sign is Alt 196
            {
                lblCurrentDisplay.Text=lblCurrentDisplay.Text + "+";
                txtInputDisplay.Clear();
            }
        }

        
        private void btnEquals_Click(object sender, EventArgs e)
        {

            string oldHistory = richTextBoxDisplayHistory.Text;

            string equation = lblCurrentDisplay.Text + txtInputDisplay.Text;

            string[] values=equation.Split(new char[] { '+', '─', 'X', '/' });
            string operation = "";

            if (values.Length == 2)
            {
                double num1=0, num2 = 0;
                    
                string result = "";
                operation = lblCurrentDisplay.Text.Substring(lblCurrentDisplay.Text.Length - 1, 1);

                try
                {
                    num1 = float.Parse(values[0]);
                    num2 = float.Parse(values[1]);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("There was an input error. Please try again");
                    MessageBox.Show($"Error: {ex.Message}");
                    result = "Error";
                }
                

                //MessageBox.Show($"{num1} + {num2}={num1 + num2}");
                Matematica matematica = new Matematica();
                
                AddingOperations add = new AddingOperations(matematica.Add);
                SubtractingOperations subtract = new SubtractingOperations(matematica.Subtract);
                DividingOperations division = new DividingOperations(matematica.Divide);
                MultiplicationOperations multiply = new MultiplicationOperations(matematica.Multiply);

                try
                {
                    if (operation == "+") result = add(num1, num2).ToString($"F{numericUpDownDecimal.Value}");
                    else if (operation == "─") result = subtract(num1, num2).ToString($"F{numericUpDownDecimal.Value}");
                    else if (operation == "/")
                    {
                        if (num2 == 0) {
                            DivideByZeroError divideByZeroError = new DivideByZeroError();
                            divideByZeroError.Visible = true;
                            result = "To infinite, and beyond!";
                        }
                        else { result = division(num1, num2).ToString($"F{numericUpDownDecimal.Value}"); }
                    }
                    else if (operation == "X") result = multiply(num1, num2).ToString($"F{numericUpDownDecimal.Value}");
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
                                                                
                lblCurrentDisplay.Text = equation + "=" + result; ;
                richTextBoxDisplayHistory.Text = lblCurrentDisplay.Text + "\n" + oldHistory;
                txtInputDisplay.Text = result;
                
                if (num2 == 0)
                {
                    txtInputDisplay.Clear();
                }
            }

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            //─ Alt 196  //─ Alt 196 //─ Alt 196 //─ Alt 196 //─ Alt 196 //─ Alt 196    ─
            lblCurrentDisplay.Text = txtInputDisplay.Text;
            if (!Regex.IsMatch(lblCurrentDisplay.Text, @"[\+\─\/X]") && txtInputDisplay.Text.Length > 0)//minus sign is Alt 196
            {
                lblCurrentDisplay.Text = lblCurrentDisplay.Text + "─";
                txtInputDisplay.Clear();
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblCurrentDisplay.Text = txtInputDisplay.Text;
            if (!Regex.IsMatch(lblCurrentDisplay.Text, @"[\+\─\/X]") && txtInputDisplay.Text.Length > 0)//minus sign is Alt 196
            {
                lblCurrentDisplay.Text = lblCurrentDisplay.Text + "X";
                txtInputDisplay.Clear();
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //StaticMethods.OperationsDisplayButton("/", lblCurrentDisplay, txtInputDisplay);
            lblCurrentDisplay.Text = txtInputDisplay.Text;
            if (!Regex.IsMatch(lblCurrentDisplay.Text, @"[\+\─\/X]")&&txtInputDisplay.Text.Length>0)//minus sign is Alt 196
            {
                lblCurrentDisplay.Text = lblCurrentDisplay.Text + "/";
                txtInputDisplay.Clear();
            }
                      

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            string oldHistory = richTextBoxDisplayHistory.Text;
            if (!Regex.IsMatch(lblCurrentDisplay.Text, @"[\+\─\/X]") && txtInputDisplay.Text.Length > 0)
            {
                string result = Math.Sqrt(double.Parse(txtInputDisplay.Text)).ToString($"F{numericUpDownDecimal.Value}");
                lblCurrentDisplay.Text= $"sqrt({txtInputDisplay.Text})={result}";
                txtInputDisplay.Text = result;
                richTextBoxDisplayHistory.Text = $"{lblCurrentDisplay.Text}\n{oldHistory}";
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            string oldHistory = richTextBoxDisplayHistory.Text;
            if (!Regex.IsMatch(lblCurrentDisplay.Text, @"[\+\─\/X]") && txtInputDisplay.Text.Length > 0)
            {
                string result= (double.Parse(txtInputDisplay.Text) * double.Parse(txtInputDisplay.Text)).ToString($"F{numericUpDownDecimal.Value}");
                lblCurrentDisplay.Text = $"{txtInputDisplay.Text}^2={result}";
                txtInputDisplay.Text = result;
                richTextBoxDisplayHistory.Text = $"{lblCurrentDisplay.Text}\n{oldHistory}";
            }
            
            
        }

        private void btnConvertToRomanNumerals_Click(object sender, EventArgs e)
        {
            RomanNumerals marbleSlate = new RomanNumerals();
            IntToRomanNumeralsDelegate ConvertToRomanNumerals = new IntToRomanNumeralsDelegate(marbleSlate.IntToRoman);

            string result = ConvertToRomanNumerals((int) double.Parse(txtInputDisplay.Text));

            lblCurrentDisplay.Text = txtInputDisplay.Text + "=>" + result;
            string oldHistory = richTextBoxDisplayHistory.Text;
            richTextBoxDisplayHistory.Text = $"{lblCurrentDisplay.Text}\n{oldHistory}";
            txtInputDisplay.Clear();
                    

        }
        //ROMAN NUMERAL CODE PANEL BOX IS BELOW. ABOVE IS MAIN CODE PANEL
        private void btnRN_I_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text += "I";
        }

        private void btnRN_V_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text += "V";
        }

        private void btnRN_X_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text += "X";
        }

        private void btnRN_L_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text += "L";
        }

        private void btnRN_C_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text += "C";
        }

        private void btnRN_D_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text += "D";
        }

        private void btnRN_M_Click(object sender, EventArgs e)
        {
            txtInputDisplay.Text += "M";
        }

        private void btnRNtoDecimalConvert_Click(object sender, EventArgs e)
        {
            RomanNumerals JuliusCeaser = new RomanNumerals();
            RomanNumeralToInt romanNumeralToIntConversion=new RomanNumeralToInt(JuliusCeaser.RomanNumeralToInt);

            string result= romanNumeralToIntConversion(txtInputDisplay.Text).ToString();
            lblCurrentDisplay.Text = txtInputDisplay.Text + "=>" + result;
            string oldHistory = richTextBoxDisplayHistory.Text;
            richTextBoxDisplayHistory.Text = $"{lblCurrentDisplay.Text}\n{oldHistory}";
            txtInputDisplay.Clear();

        }
    }
}
