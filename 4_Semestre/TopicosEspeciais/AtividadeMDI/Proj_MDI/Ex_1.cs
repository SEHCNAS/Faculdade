using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_MDI
{
    public partial class Ex_1 : Form
    {
        public Ex_1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // Converte o valor do TextBox para um número inteiro
            if (!int.TryParse(TxtIdade.Text, out int idade))
            {
                MessageBox.Show("Idade inválida. Informe um número válido.");
                return;
            }

            // Calcula a idade em dias (ano * 365 + mês * 30)
            int idadeEmDias = idade * 365;

            // Exibe o resultado no Label
            TxtResultado.Text = $"Sua idade em dias é: {idadeEmDias} dias";
        }

        private void TxtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede que caracteres não numéricos sejam inseridos
                MessageBox.Show("Idade inválida. Informe um número válido.");
                return;
            }
        }
    }
}
