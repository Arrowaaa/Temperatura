using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(textBox1.Text);
            bool temdescricao = checkBox1.Checked;
            string descricao = "", mensagem = "";
            bool comalerta = checkBox2.Checked;


            if (radioButton1.Checked)
            {
                double Fahrenheit = 0 ;
                Fahrenheit = (numero * 1.8) + 32;

                if (temdescricao)
                {
                    descricao = " Graus Fahrenheit";
                }
                mensagem = Fahrenheit.ToString() + " ºF" + descricao;
                if (comalerta)
                {
                    MessageBox.Show(mensagem);
                }else
                {
                    label1.Text = mensagem;
                }


            }
            if (radioButton2.Checked)
            {
                double kelvin = 0 ;
                kelvin = numero + 273;

                if (temdescricao)
                {
                    descricao = " Graus Kelvin";
                }
                mensagem = kelvin.ToString() + " ºK" + descricao;
                if (comalerta)
                {
                    MessageBox.Show(mensagem);
                }
                else
                {
                    label1.Text = mensagem;
                }

                
            }
        }
    }
}
