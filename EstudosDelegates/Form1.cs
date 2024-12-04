using System;
using System.Windows.Forms;

namespace EstudosDelegates
{
    public partial class Calculadora : Form
    {
        private delegate int ExecutarOperacao(int numero1, int numero2);
        private ExecutarOperacao m_executarOperacao;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private int Calcular()
        {
            int numero1 = Convert.ToInt32(txbNumero1.Text);
            int numero2 = Convert.ToInt32(txbNumero2.Text);

            return m_executarOperacao(numero1, numero2);
        }

        private int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        private int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        private int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        private int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            m_executarOperacao = new ExecutarOperacao(Somar);
            txbResultado.Text = Calcular().ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            m_executarOperacao = new ExecutarOperacao(Subtrair);
            txbResultado.Text = Calcular().ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            m_executarOperacao = new ExecutarOperacao(Multiplicar);
            txbResultado.Text = Calcular().ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            m_executarOperacao = new ExecutarOperacao(Dividir);
            txbResultado.Text = Calcular().ToString();
        }
    }
}
