namespace Projeto_Somatório_dos_n_pares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i, num, soma = 0;

            num = Convert.ToInt32(txtNum.Text);

            for (i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    soma = soma + i;
                }

            }

            txtSoma.Text = soma.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSoma.Clear();
            txtNum.Clear();

            txtNum.Focus();
        }
    }
}