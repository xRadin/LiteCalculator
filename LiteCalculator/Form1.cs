using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LiteCalculator
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        // Variables
        double a, b, c;
        bool IsTrueRem, IsTrueDiv, IsTrueAdd, IsTrueSub ,IsTrueMul;
        bool Flag;

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtResult.Text == "0")
            {
                txtResult.Text = null;
                txtResult.Text += 1;
            }
            else if (Flag == true)
            {
                txtResult.Text = null;
                txtResult.Text = "1";
                Flag = false;
            }
            else if (txtResult.Text == "ERROR" || txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
            {
                txtResult.Text = null;
                lblHistory.Text = null;
                txtResult.Text += 1;
            }
            else
            {
                txtResult.Text += 1;
            }    
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = null;
                txtResult.Text += 2;
            }
            else if (Flag == true)
            {
                txtResult.Text = null;
                txtResult.Text = "2";
                Flag = false;
            }
            else if (txtResult.Text == "ERROR" || txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
            {
                txtResult.Text = null;
                lblHistory.Text = null;
                txtResult.Text += 2;
            }
            else
            {
                txtResult.Text += 2;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = null;
                txtResult.Text += 3;
            }
            else if (Flag == true)
            {
                txtResult.Text = null;
                txtResult.Text = "3";
                Flag = false;
            }
            else if (txtResult.Text == "ERROR" || txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
            {
                txtResult.Text = null;
                lblHistory.Text = null;
                txtResult.Text += 3;
            }
            else
            {
                txtResult.Text += 3;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = null;
                txtResult.Text += 4;
            }
            else if (Flag == true)
            {
                txtResult.Text = null;
                txtResult.Text = "4";
                Flag = false;
            }
            else if (txtResult.Text == "ERROR" || txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
            {
                txtResult.Text = null;
                lblHistory.Text = null;
                txtResult.Text += 4;
            }
            else
            {
                txtResult.Text += 4;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = null;
                txtResult.Text += 5;
            }
            else if (Flag == true)
            {
                txtResult.Text = null;
                txtResult.Text = "5";
                Flag = false;
            }
            else if (txtResult.Text == "ERROR" || txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
            {
                txtResult.Text = null;
                lblHistory.Text = null;
                txtResult.Text += 5;
            }
            else
            {
                txtResult.Text += 5;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = null;
                txtResult.Text += 6;
            }
            else if (Flag == true)
            {
                txtResult.Text = null;
                txtResult.Text = "6";
                Flag = false;
            }
            else if (txtResult.Text == "ERROR" || txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
            {
                txtResult.Text = null;
                lblHistory.Text = null;
                txtResult.Text += 6;
            }
            else
            {
                txtResult.Text += 6;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = null;
                txtResult.Text += 7;
            }
            else if (Flag == true)
            {
                txtResult.Text = null;
                txtResult.Text = "7";
                Flag = false;
            }
            else if (txtResult.Text == "ERROR" || txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
            {
                txtResult.Text = null;
                lblHistory.Text = null;
                txtResult.Text += 7;
            }
            else
            {
                txtResult.Text += 7;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = null;
                txtResult.Text += 8;
            }
            else if (Flag == true)
            {
                txtResult.Text = null;
                txtResult.Text = "8";
                Flag = false;
            }
            else if (txtResult.Text == "ERROR" || txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
            {
                txtResult.Text = null;
                lblHistory.Text = null;
                txtResult.Text += 8;
            }
            else
            {
                txtResult.Text += 8;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = null;
                txtResult.Text += 9;
            }
            else if (Flag == true)
            {
                txtResult.Text = null;
                txtResult.Text = "9";
                Flag = false;
            }
            else if (txtResult.Text == "ERROR" || txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
            {
                txtResult.Text = null;
                lblHistory.Text = null;
                txtResult.Text += 9;
            }
            else
            {
                txtResult.Text += 9;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = null;
                txtResult.Text += 0;
            }
            else if (Flag == true)
            {
                txtResult.Text = null;
                txtResult.Text = "0";
                Flag = false;
            }
            else if(txtResult.Text == "ERROR" || txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
            {
                txtResult.Text = null;
                lblHistory.Text = null;
                txtResult.Text += 0;
            }
            else
            {
                txtResult.Text += 0;
            }
        }



        private void btnPowerOfTwo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text == "0")
                {

                }
                else if (txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
                {
                    txtResult.Text = "0";
                }
                else
                {
                    a = Convert.ToDouble(txtResult.Text);
                    lblHistory.Text = a.ToString() + "²";
                    a *= a;
                    txtResult.Text = a.ToString();
                }
            }
            catch
            {
                txtResult.Text = "ERROR";
                lblHistory.Text = null;
            }
        }

        private void btnRadical2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text == "0")
                {

                }
                else if(txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
                {
                    txtResult.Text = "0";
                }
                else
                {
                    a = Convert.ToDouble(txtResult.Text);
                    lblHistory.Text = "√" + a.ToString();
                    txtResult.Text = Math.Sqrt((double)a).ToString();
                }
            }
            catch
            {
                txtResult.Text = "ERROR";
                lblHistory.Text = null;
            }
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtResult.Text == "0")
                {

                }
                else if (txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
                {
                    txtResult.Text = "0";
                }
                else
                {
                    a = Convert.ToDouble(txtResult.Text);
                    lblHistory.Text = a.ToString() + " %";
                    IsTrueRem = true;
                    Flag = true;
                    IsTrueDiv = false;
                    IsTrueAdd = false;
                    IsTrueSub = false;
                    IsTrueMul = false;
                }
            }
            catch
            {
                txtResult.Text = "ERROR";
                lblHistory.Text = null;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // Reminder
            if (IsTrueRem == true)
            { 
                try
                {
                    if (txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
                    {
                        txtResult.Text = "0";
                    }
                    b = Convert.ToDouble(txtResult.Text);
                    c = a % b;
                    lblHistory.Text = b.ToString() + " %";
                    txtResult.Text = c.ToString();
                    IsTrueDiv = false;
                    IsTrueAdd = false;
                    IsTrueSub = false;
                    IsTrueMul = false;
                }
                catch
                {
                    txtResult.Text = "ERROR";
                    lblHistory.Text = null;
                }
            }
            // Division
            else if (IsTrueDiv == true)
            {
                try
                {
                    if (txtResult.Text == "0")
                    {
                        txtResult.Text = "Cannot divide by zero";
                        lblHistory.Text = null;
                    }
                    else if (txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
                    {
                        txtResult.Text = "0";
                    }
                    else
                    {
                        b = Convert.ToDouble(txtResult.Text);
                        c = a / b;
                        lblHistory.Text = b.ToString() + " ÷";
                        txtResult.Text = c.ToString();
                        IsTrueRem = false;
                        IsTrueAdd = false;
                        IsTrueSub = false;
                        IsTrueMul = false;
                    }
                }
                catch
                {
                    txtResult.Text = "ERROR";
                    lblHistory.Text = null;
                }
            }
            // Subtraction
            else if (IsTrueSub == true)
            {
                try
                {
                    if (txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
                    {
                        txtResult.Text = "0";
                    }
                    b = Convert.ToDouble(txtResult.Text);
                    lblHistory.Text = b.ToString() + " -";
                    c = a - b;
                    txtResult.Text = c.ToString();
                    IsTrueRem = false;
                    IsTrueAdd = false;
                    IsTrueDiv = false;
                    IsTrueMul = false;
                }
                catch
                {
                    txtResult.Text = "ERROR";
                    lblHistory.Text = null;
                }
            }

            // Multipilction
            else if (IsTrueMul == true)
            { 
                try
                {
                    if (txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
                    {
                        txtResult.Text = "0";
                    }
                    b = Convert.ToDouble(txtResult.Text);
                    lblHistory.Text = b.ToString() + " X";
                    c = a * b;
                    txtResult.Text = c.ToString();
                    IsTrueRem = false;
                    IsTrueAdd = false;
                    IsTrueSub = false;
                    IsTrueDiv = false;
                }
                catch
                {
                    txtResult.Text = "ERROR";
                    lblHistory.Text = null;
                }
            }

            // Addition
            else if (IsTrueAdd == true)
            {
                try
                {
                    if (txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
                    {
                        txtResult.Text = "0";
                    }
                    b = Convert.ToDouble(txtResult.Text);
                    lblHistory.Text = b.ToString() + " +";
                    c = a + b;
                    txtResult.Text = c.ToString();
                    IsTrueRem = false;
                    IsTrueDiv = false;
                    IsTrueSub = false;
                    IsTrueMul = false;
                }
                catch
                {
                    txtResult.Text = "ERROR";
                    lblHistory.Text = null;
                }
            }

        }

        private void btnDivison_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
                {
                    txtResult.Text = "0";
                }
                a = Convert.ToDouble(txtResult.Text);
                lblHistory.Text = a.ToString() + " ÷";
                Flag = true;
                IsTrueDiv = true;
                IsTrueRem = false;
                IsTrueAdd = false;
                IsTrueSub = false;
                IsTrueMul = false;
            }
            catch
            {
                txtResult.Text = "ERROR";
                lblHistory.Text = null;
            }
        }

        private void btnMultipliction_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
                {
                    txtResult.Text = "0";
                }
                a = Convert.ToDouble(txtResult.Text);
                lblHistory.Text = a.ToString() + " X";
                Flag = true;
                IsTrueMul = true;
                IsTrueRem = false;
                IsTrueAdd = false;
                IsTrueSub = false;
                IsTrueDiv = false;

            }
            catch
            {
                txtResult.Text = "ERROR";
                lblHistory.Text = null;
            }
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
                {
                    txtResult.Text = "0";
                }
                a = Convert.ToDouble(txtResult.Text);
                lblHistory.Text = a.ToString() + " -";
                Flag = true;
                IsTrueSub = true;
                IsTrueRem = false;
                IsTrueAdd = false;
                IsTrueDiv = false;
                IsTrueMul = false;
            }
            catch
            {
                txtResult.Text = "ERROR";
                lblHistory.Text = null;
            }
        }

        private void btnAddision_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
                {
                    txtResult.Text = "0";
                }
                a = Convert.ToDouble(txtResult.Text);
                lblHistory.Text = a.ToString() + " +";
                Flag = true;
                IsTrueAdd = true;
                IsTrueRem = false;
                IsTrueDiv = false;
                IsTrueSub = false;
                IsTrueMul = false;
            }
            catch
            {
                txtResult.Text = "ERROR";
                lblHistory.Text = null;
            }
        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "ERROR" || txtResult.Text == "Cannot divide by zero" || txtResult.Text == "Overflow")
            {
                txtResult.Text = "0.";
            }
            else if (Flag == true)
            {
                txtResult.Text = null;
                txtResult.Text = "0.";
                Flag = false;
            }
            else
                txtResult.Text += ".";
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text) && txtResult.Text.LastIndexOf('.') == txtResult.Text.Length - 1)
            {
                if (txtResult.Text.Substring(0, txtResult.Text.Length - 1).Contains("."))
                {
                    txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
                }
            }
            else if(txtResult.Text == "∞")
            {
                txtResult.Text = "Overflow";
                lblHistory.Text = null;
            }
        }

        private void CopyContext_Click(object sender, EventArgs e)
        { 
            try
            {
                if (txtResult.Text == "ERROR")
                    MessageBox.Show("You're Not Allowed to Copy this Value", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    Clipboard.SetText(txtResult.Text.ToString());
            }
            catch (System.Runtime.InteropServices.ExternalException ex)
            {
                // Handle the exception if the Clipboard operation fails
                MessageBox.Show("Clipboard copy failed : " + ex.Message, "Unexepted Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lblHistory.Text = null;
            a = 0;
            b = 0;
            c = 0;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "0";
            }
            else if(txtResult.Text == "ERROR" || txtResult.Text == "Cannot divide by zero")
            {
                txtResult.Text = "0";
            }
            else
            {
                if ((String.Compare(txtResult.Text, " ") < 0) && txtResult.Text != null)
                {
                    txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1 + 1);
                }
                else if (txtResult.Text.Length == 1 && txtResult.Text != "0")
                {
                    txtResult.Text = "0";
                }
                else
                {
                    txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
                }
            }

        }
    }
}