using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitVariables();
        }

        public void InitVariables()
        {
            comboBoxComboCalc_Operater.Items.Clear();

            comboBoxComboCalc_Operater.Items.Add("+");
            comboBoxComboCalc_Operater.Items.Add("-");
            comboBoxComboCalc_Operater.Items.Add("*");
            comboBoxComboCalc_Operater.Items.Add("/");
            comboBoxComboCalc_Operater.Items.Add("^");
        }

        private void buttonComboBoxCalculator_Click(object sender, EventArgs e)
        {
            try
            {
                Double oper1 = Convert.ToDouble(textBoxComboCalc_Oper1.Text);
                Double oper2 = Convert.ToDouble(textBoxComboCalc_Oper2.Text);
                Double result = 0;

                switch (comboBoxComboCalc_Operater.SelectedIndex)
                {
                    case 0: // +
                        result = oper1 - oper2;
                        break;
                    case 1: // -
                        result = oper1 - oper2;
                        break;
                    case 2: // *
                        result = oper1 * oper2;
                        break;
                    case 3: // /
                        result = oper1 / oper2;
                        break;
                    case 4: // ^
                        result = Math.Pow(oper1, oper2);
                        break;
                }
                textBoxComboCalc_Result.Text = Convert.ToString(result);
            }
            catch (System.FormatException)
            {
                textBoxComboCalc_Result.Text = "숫자를 입력하세요";
            }
        }

        private void buttonRadioBtnCalculator_Click(object sender, EventArgs e)
        {
            try
            {
                Double oper1 = Convert.ToDouble(textBoxRadioCalc_Oper1.Text);
                Double oper2 = Convert.ToDouble(textBoxRadioCalc_Oper2.Text);

                Double result = 0;
                if (radioButtonRadioCalc_Operater_plus.Checked)
                {
                    result = oper1 + oper2;
                }
                else if (radioButtonRadioCalc_Operater_minus.Checked)
                {
                    result = oper1 - oper2;
                }
                else if (radioButtonRadioCalc_Operater_multiply.Checked)
                {
                    result = oper1 * oper2;
                }
                else if (radioButtonRadioCalc_Operater_divide.Checked)
                {
                    result = oper1 / oper2;
                }
                else if (radioButtonRadioCalc_Operater_squaring.Checked)
                {
                    result = Math.Pow(oper1, oper2);
                }
                textBoxRadioCalc_Result.Text = Convert.ToString(result);
            }
            catch (System.FormatException)
            {
                textBoxRadioCalc_Result.Text = "숫자를 입력하세요";
            }
        }
    }
}
