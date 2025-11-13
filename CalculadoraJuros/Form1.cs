using System.Diagnostics.Eventing.Reader;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;

namespace CalculadoraJuros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string mensagem1 = "Aviso, número máximo de caracteres!";
        string mensagem2 = "Aviso, zero a esquerda!";
        string mensagem3 = "Aviso, adicione um valor!";
        bool clicouPonto;
        bool caracteresMax = false;
        bool comecaEm0;
        bool estaVazio;
        bool primeiroClick;
        bool composto = false;
        bool simples = false;

        int meses;
        int juros;
        int valorOriginal;

        public void desativarBtns(object sender, EventArgs e)
        {
            num0.Enabled = false;
            num1.Enabled = false;
            num2.Enabled = false;
            num3.Enabled = false;
            num4.Enabled = false;
            num5.Enabled = false;
            num6.Enabled = false;
            num7.Enabled = false;
            num8.Enabled = false;
            num9.Enabled = false;
            apagar.Enabled = false;
        }

        public void ativatBtns(object sender, EventArgs e)
        {
            num0.Enabled = true;
            num1.Enabled = true;
            num2.Enabled = true;
            num3.Enabled = true;
            num4.Enabled = true;
            num5.Enabled = true;
            num6.Enabled = true;
            num7.Enabled = true;
            num8.Enabled = true;
            num9.Enabled = true;
            apagar.Enabled = true;
            jurosCompostos.Enabled = true;
            jurosSimples.Enabled = true;
        }

        public void checarCaracteres(object sender, EventArgs e)
        {
            if (clicouPonto)
            {
                string[] separacaoPonto = vlrOg.Text.Split('.');
                string antesDoPonto = separacaoPonto[0];
                string depoisDoPonto = separacaoPonto[1];

                if (antesDoPonto.Length > 3) caracteresMax = false;
                else if (depoisDoPonto.Length > 10) caracteresMax = false;
                else caracteresMax = true;
            }
            else
            {
                if (vlrOg.Text.Length > 9) caracteresMax = false;
                else caracteresMax = true;
            }
            if (vlrOg.Text.StartsWith("0")) comecaEm0 = true;
            else comecaEm0 = false;

            if (string.IsNullOrEmpty(vlrOg.Text)) estaVazio = true;
            else estaVazio = false;

        }

        private void num1_Click(object sender, EventArgs e)
        {
            vlrOg.Text += "1";
            checarCaracteres(sender, e);

            if (!caracteresMax)
            {
                vlrOg.Text = vlrOg.Text.Substring(0, vlrOg.Text.Length - 1);
                MessageBox.Show(mensagem1);
            }

            if (comecaEm0)
            {
                vlrOg.Text = "";
                MessageBox.Show(mensagem2);
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            vlrOg.Text += "2";
            checarCaracteres(sender, e);

            if (!caracteresMax)
            {
                vlrOg.Text = vlrOg.Text.Substring(0, vlrOg.Text.Length - 1);
                MessageBox.Show(mensagem1);
            }

            if (comecaEm0)
            {
                vlrOg.Text = "";
                MessageBox.Show(mensagem2);
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            vlrOg.Text += "3";
            checarCaracteres(sender, e);

            if (!caracteresMax)
            {
                vlrOg.Text = vlrOg.Text.Substring(0, vlrOg.Text.Length - 1);
                MessageBox.Show(mensagem1);
            }

            if (comecaEm0)
            {
                vlrOg.Text = "";
                MessageBox.Show(mensagem2);
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            vlrOg.Text += "4";
            checarCaracteres(sender, e);

            if (!caracteresMax)
            {
                vlrOg.Text = vlrOg.Text.Substring(0, vlrOg.Text.Length - 1);
                MessageBox.Show(mensagem1);
            }

            if (comecaEm0)
            {
                vlrOg.Text = "";
                MessageBox.Show(mensagem2);
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            vlrOg.Text += "5";
            checarCaracteres(sender, e);

            if (!caracteresMax)
            {
                vlrOg.Text = vlrOg.Text.Substring(0, vlrOg.Text.Length - 1);
                MessageBox.Show(mensagem1);
            }

            if (comecaEm0)
            {
                vlrOg.Text = "";
                MessageBox.Show(mensagem2);
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            vlrOg.Text += "6";
            checarCaracteres(sender, e);

            if (!caracteresMax)
            {
                vlrOg.Text = vlrOg.Text.Substring(0, vlrOg.Text.Length - 1);
                MessageBox.Show(mensagem1);
            }

            if (comecaEm0)
            {
                vlrOg.Text = "";
                MessageBox.Show(mensagem2);
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            vlrOg.Text += "7";
            checarCaracteres(sender, e);

            if (!caracteresMax)
            {
                vlrOg.Text = vlrOg.Text.Substring(0, vlrOg.Text.Length - 1);
                MessageBox.Show(mensagem1);
            }

            if (comecaEm0)
            {
                vlrOg.Text = "";
                MessageBox.Show(mensagem2);
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            vlrOg.Text += "8";
            checarCaracteres(sender, e);

            if (!caracteresMax)
            {
                vlrOg.Text = vlrOg.Text.Substring(0, vlrOg.Text.Length - 1);
                MessageBox.Show(mensagem1);
            }

            if (comecaEm0)
            {
                vlrOg.Text = "";
                MessageBox.Show(mensagem2);
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            vlrOg.Text += "9";
            checarCaracteres(sender, e);

            if (!caracteresMax)
            {
                vlrOg.Text = vlrOg.Text.Substring(0, vlrOg.Text.Length - 1);
                MessageBox.Show(mensagem1);
            }

            if (comecaEm0)
            {
                vlrOg.Text = "";
                MessageBox.Show(mensagem2);
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            vlrOg.Text += "0";
            checarCaracteres(sender, e);

            if (!caracteresMax)
            {
                vlrOg.Text = vlrOg.Text.Substring(0, vlrOg.Text.Length - 1);
                MessageBox.Show(mensagem1);
            }

            if (comecaEm0)
            {
                vlrOg.Text = "";
                MessageBox.Show(mensagem2);
            }
        }

        private void ponto_Click(object sender, EventArgs e)
        {
            clicouPonto = true;
            if (vlrOg.Text.Contains("."))
            {
                ponto.Enabled = false;
            }
            else
            {
                vlrOg.Text += ".";
            }
        }

        private void apagar_Click_1(object sender, EventArgs e)
        {
            vlrOg.Text = "";
        }

        private void jurosSimples_Click(object sender, EventArgs e)
        {
            checarCaracteres(sender, e);
            if (!estaVazio)
            {
                jurosSimples.BackColor = Color.Green;
                ogValor.Text = vlrOg.Text;
                jurosCompostos.Enabled = false;
                jurosSimples.Enabled = false;
                valorOgEmes.Text = "Digite a quantidade de meses";
                vlrOg.Text = "";
                ponto.Enabled = false;
                enter.Enabled = true;
                enter.Visible = true;
                primeiroClick = true;
                simples = true;
            }
            else
            {
                MessageBox.Show(mensagem3);
            }
        }

        private void jurosCompostos_Click(object sender, EventArgs e)
        {
            checarCaracteres(sender, e);
            if (!estaVazio)
            {
                jurosCompostos.BackColor = Color.Green;
                ogValor.Text = vlrOg.Text;
                jurosCompostos.Enabled = false;
                jurosSimples.Enabled = false;
                valorOgEmes.Text = "Digite a quantidade de meses";
                vlrOg.Text = "";
                ponto.Enabled = false;
                enter.Enabled = true;
                enter.Visible = true;
                primeiroClick = true;
                composto = true;
            }
            else
            {
                MessageBox.Show(mensagem3);
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (primeiroClick)
            {
                totalMeses.Text = vlrOg.Text;
                valorOgEmes.Text = "Digite a porcentagem de juros";
                vlrOg.Text = "";
                primeiroClick = false;
            }
            else
            {
                porcenJuros.Text = vlrOg.Text;
                enter.Enabled = false;
                enter.Visible = false;

                if (composto)
                {
                    meses = Convert.ToInt32(totalMeses.Text);
                    juros = Convert.ToInt32(vlrOg.Text);
                    valorOriginal = Convert.ToInt32(ogValor.Text);

                    double finalTotal = valorOriginal * Math.Pow(1 + juros / 100.0, meses);
                    double jurosVal = finalTotal - valorOriginal; // valor real dos juros ganhos

                    totalValor.Text = finalTotal.ToString("F2");
                    jurosValor.Text = jurosVal.ToString("F2");
                    desativarBtns(sender, e);
                }
                else if (simples)
                {
                    meses = Convert.ToInt32(totalMeses.Text);
                    juros = Convert.ToInt32(vlrOg.Text);
                    valorOriginal = Convert.ToInt32(ogValor.Text);


                    double jurosVal = valorOriginal * juros / 100 * meses;
                    double finalTotal = valorOriginal * juros / 100 * meses + valorOriginal;
                    totalValor.Text = finalTotal.ToString("F2");
                    jurosValor.Text = jurosVal.ToString("F2");
                    desativarBtns(sender, e);
                }
            }
        }

        private void refazer_Click(object sender, EventArgs e)
        {
            composto = false;
            simples = false;
            meses = 0;
            juros = 0;
            valorOriginal = 0;
            ogValor.Text = "";
            totalValor.Text = "";
            jurosValor.Text = "";
            totalMeses.Text = "";
            porcenJuros.Text = "";
            enter.Enabled = false;
            enter.Visible = false;
            valorOgEmes.Text = "Digite o valor original";
            vlrOg.Text = "";
            jurosCompostos.BackColor = Color.White;
            jurosSimples.BackColor = Color.White;
            ativatBtns(sender, e);
        }
    }
}
