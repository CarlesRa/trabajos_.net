using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class FMain : Form
    {
        private decimal operand;
        private string operandTxt;

        public FMain()
        {
            InitializeComponent();
            
        }

        private void setOperandTxt (string value)
        {
            operandTxt = operandTxt + value;
            mostrarResulatado.Text = operandTxt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            setOperandTxt("1");
        }

        private void Button02_Click(object sender, EventArgs e)
        {
            setOperandTxt("2");
        }

        private void Button03_Click(object sender, EventArgs e)
        {
            setOperandTxt("3");
        }

        private void Button04_Click(object sender, EventArgs e)
        {
            setOperandTxt("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            setOperandTxt("5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            setOperandTxt("6");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            setOperandTxt("7");
        }

        private void Button08_Click(object sender, EventArgs e)
        {
            setOperandTxt("8");
        }

        private void Button09_Click(object sender, EventArgs e)
        {
            setOperandTxt("9");
        }



        private void Button13_Click(object sender, EventArgs e)
        {

        }

       

        

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            setOperandTxt(e.KeyChar.ToString());
        }
    }
}
