using Calculadora.Model;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private CalculadoraLogica calculadora = new CalculadoraLogica();

        public Form1()
        {
            InitializeComponent();
        }

        private void OperacaoClicada(object sender, EventArgs e)
        {
            Button botao = sender as Button;

       
            if (!string.IsNullOrEmpty(txb_display.Text) &&
                "+-x÷".Contains(txb_display.Text[^1].ToString()))
            {
                txb_display.Text = txb_display.Text[..^1] + botao.Text; 
            }
            else
            {
                txb_display.Text += botao.Text; 
            }
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                string expressao = txb_display.Text.Replace("x", "*").Replace("÷", "/");
                var resultado = new System.Data.DataTable().Compute(expressao, null);

                txb_display.Text += $" = {resultado}"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na expressão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumeroClicado(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            txb_display.Text += botao.Text; 
        }

        private void BtnVirgula_Click(object sender, EventArgs e)
        {
            if (!txb_display.Text.Contains(","))
            {
                if (string.IsNullOrEmpty(txb_display.Text))
                {
                    txb_display.Text = "0,";
                }
                else
                {
                    txb_display.Text += ",";
                }
            }
        }

        private void btn_AC_Click(object sender, EventArgs e)
        {
            txb_display.Clear();
            calculadora = new CalculadoraLogica();
        }

        private void Btn_Sinal_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txb_display.Text, out double numero))
            {
                txb_display.Text = (-numero).ToString();
            }
        }

        private void Btn_Porcentagem_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txb_display.Text, out double numero))
            {
                txb_display.Text = (numero / 100).ToString();
            }
        }
    }
}