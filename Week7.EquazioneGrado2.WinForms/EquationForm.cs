using Equazione;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7.EquazioneGrado2.WinForms
{
    public partial class EquationForm : Form
    {
        private double a, b, c, res;
        private Equation equation = new Equation();
     
        public EquationForm()
        {
            InitializeComponent();
        }

        //private void txtB_TextChanged(object sender, EventArgs e)
        //{
        //    b = double.Parse(txtB.Text);
        //    if (b > 0)
        //    {
        //        textBox3.Text = $"+{b}";
        //    }
        //    else
        //    {
        //        textBox3.Text = $"-{b}";
        //    }
        //}

        //private void txtC_TextChanged(object sender, EventArgs e)
        //{
        //    c = double.Parse(txtC.Text);
        //    if (c > 0)
        //    {
        //        textBox2.Text = $"+{c}";
        //    }
        //    else
        //    {
        //        textBox2.Text = $"{c}";
        //    }
        //}

        private void txtDelta_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtX1.Clear();
            txtX2.Clear();
            txtDelta.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void btnUguale_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtA.Text);
            textBox1.Text = $"{a}";

            b = double.Parse(txtB.Text);
            if (b > 0)
            {
                textBox3.Text = $"+{b}";
            }
            else
            {
                textBox3.Text = $"{b}";
            }


            c = double.Parse(txtC.Text);
            if (c > 0)
            {
                textBox2.Text = $"+{c}";
            }
            else
            {
                textBox2.Text = $"{c}";
            }

            var risultato = equation.RisolviEquazioneSecondoGrado(a, b, c);
            if (risultato == null)
            {
                double delta = Math.Pow(b, 2) - (4 * a * c);
                txtDelta.Text = $"{delta.ToString()}";
                textBox4.Text = "Non ci sono soluzioni in R";
            }
            else if (risultato.Count() >= 1)
            {
                txtX1.Text = $"{risultato[0]}";
                txtX2.Text = $"{risultato[1]}";
                double delta = Math.Pow(b, 2) - (4 * a * c);
                if (delta > 0)
                {

                    txtDelta.Text = $"{delta.ToString()}";
                    textBox4.Text = "2 radici reali e distinte";
                }
                else if (delta == 0)
                {
                    txtDelta.Text = $"{delta.ToString()} ";
                    textBox4.Text = "2 radici reali e coincidenti";
                }
              

               
               
               
            }
          
        }
    

        //private void txtA_TextChanged(object sender, EventArgs e)
        //{
        //    a = double.Parse(txtA.Text);
        //    textBox1.Text = $"{a}";

        //}

        private void SetEquation(string contentValueA, string contentValueB, string contentValueC, string operationToDo)
        {
            a = double.Parse(contentValueA);
            b = double.Parse(contentValueB);
            c = double.Parse(contentValueC);
          
        }
    }
}
