using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Inicializa os componentes visuais do formulário (gerado automaticamente pelo designer do Visual Studio)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Evento disparado quando o formulário é carregado
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Evento de desenho do painel (não usado aqui)
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Evento de clique no label2 (não utilizado)
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Evento de clique no label4 (não utilizado)
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Evento de clique no label5 (não utilizado)
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Evento de clique em uma imagem (não utilizado)
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento de clique no label1 (não utilizado)
        }

        // Evento de clique no botão que calcula o IMC
        private void button13_Click(object sender, EventArgs e)
        {
            float peso, altura, IMC;

            // Lê os valores digitados nos campos de texto
            peso = float.Parse(txtPeso.Text);
            altura = float.Parse(txtAltura.Text);

            // Calcula o IMC: peso dividido pela altura ao quadrado
            IMC = peso / (float)(Math.Pow(altura, 2));

            // Exibe o resultado com duas casas decimais no campo txtIMC
            txtIMC.Text = IMC.ToString("N2");

            // Variável que armazenará a situação do usuário
            string situacao;

            // Classificação de acordo com o valor do IMC
            if (IMC < 19.1)
            {
                situacao = "Abaixo do Peso";
            }
            else if (IMC >= 19.1 && IMC < 25.8)
            {
                situacao = "Peso Normal";
            }
            else if (IMC >= 25.8 && IMC < 32.8)
            {
                situacao = "Acima do Peso";
            }
            else
            {
                situacao = "Obeso";
            }

            // Mostra a situação no label8
            label8.Text = situacao;
        }

        // Adiciona números nos campos de texto (peso ou altura)
        private void AddNumber(object sender, EventArgs e)
        {
            // Verifica qual campo está ativo (destacado em vermelho)
            if (txtPeso.BackColor == Color.Red)
            {
                // Impede que o usuário insira mais de uma vírgula
                if ((sender as Button).Text != "," || !txtPeso.Text.Contains(","))
                {
                    txtPeso.Text += (sender as Button).Text; // Adiciona o número ou vírgula no campo peso
                }
            }
            else
            {
                if ((sender as Button).Text != "," || !txtAltura.Text.Contains(","))
                {
                    txtAltura.Text += (sender as Button).Text; // Adiciona o número ou vírgula no campo altura
                }
            }
        }

        // Evento ao clicar no campo "Peso"
        private void txtPeso_Enter(object sender, EventArgs e)
        {
            txtPeso.BackColor = Color.Red;   // Destaca o campo peso
            txtAltura.BackColor = Color.White; // Retira destaque da altura
        }

        // Evento ao clicar no campo "Altura"
        private void txtAltura_Enter(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.Red;  // Destaca o campo altura
            txtPeso.BackColor = Color.White;  // Retira destaque do peso
        }

        // Evento de clique no botão de limpar (provavelmente "C")
        private void button10_Click(object sender, EventArgs e)
        {
            // Limpa o campo que está ativo (vermelho)
            if (txtPeso.BackColor == Color.Red)
            {
                txtPeso.ResetText();
            }
            if (txtAltura.BackColor == Color.Red)
            {
                txtAltura.ResetText();
            }
        }

        // Evento que ocorre quando o texto do IMC muda
        private void txtIMC_TextChanged(object sender, EventArgs e)
        {
            txtIMC.BackColor = Color.White; // Mantém o campo de IMC branco
        }
    }
}
