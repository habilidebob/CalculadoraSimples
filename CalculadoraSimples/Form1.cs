using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Pegar os números da interface:
            int n1, n2;
            n1 = (int)nudNumero1.Value;
            n2 = (int)nudNumero2.Value;

            // Verificar qual opc está marcada:
            if (rbSoma.Checked)
            {
                // Realizar a soma e mostrar no txbResultado
                txbResultado.Text = (n1 + n2).ToString();
            }
            else if (rbSubtracao.Checked)
            {
                // Realizar a subtração e mostrar no txbResultado
                txbResultado.Text = (n1 - n2).ToString();
            }
            else if (rbMultiplicacao.Checked)
            {
                txbResultado.Text = (n1 * n2).ToString();
            }
            else if (rbDivisao.Checked)
            {
                // Verificar se o divisor é 0:
                if(n2 != 0)
                {
                    txbResultado.Text = (n1 / n2).ToString();
                }
                else
                {
                    txbResultado.Text = "ERRO!";
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Retornar os nud's aos valores originais:
            nudNumero1.Value = 0;
            nudNumero2.Value = 0;

            // Retornar os radios para false:
            rbDivisao.Checked = false;
            rbSubtracao.Checked = false;
            rbMultiplicacao.Checked = false;
            rbSoma.Checked = false;

            // Limpar a caixa de resultado:
            txbResultado.Text = "";
            txbResultado.Clear(); // igual ao de cima
        }
    }
}
