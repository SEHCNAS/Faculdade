using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Proj_MDI
{
    public partial class Ex_2 : Form
    {
        public Ex_2()
        {
            InitializeComponent();
        }


        private void Ex_2_Load(object sender, EventArgs e)
        {
           
            for (int i = 1; i <= 20; i++)
            {
                Grid.Rows.Add(i, "", "", "");
            }

        }


        private void Grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            double QtdFilho = 0, MediaSalario = 0, MediaFilho = 0, MaiorSalario = 0, Somasalario = 0, salario = 0;
            int  CountFilho = 0, CountSalario = 0;

            foreach (DataGridViewRow row in Grid.Rows)
            {

                // Verifica se a linha não é a linha de cabeçalho e não está marcada como nova
                if (!row.IsNewRow)
                {
                  
                    if (row.Cells["colSalario"].Value != "")
                    {
                        salario = Convert.ToDouble(row.Cells["colSalario"].Value);
                        Somasalario += salario;
                        CountSalario += 1;
                        MaiorSalario = salario > MaiorSalario ? salario : MaiorSalario;
                    }

                    if (row.Cells["colQtdFilhos"].Value != "")
                    {
                        QtdFilho += Convert.ToInt32(row.Cells["colQtdFilhos"].Value);
                        CountFilho += 1;
                    }
                }
            }

            MediaSalario = Somasalario / CountSalario;
            MediaFilho = QtdFilho / CountFilho;

            TxtMediaSalario.Text = MediaSalario.ToString();
            TxtMediaFilhos.Text = MediaFilho.ToString();
            TxtMaiorSalario.Text = MaiorSalario.ToString();

        }

        private void Grid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Verifica se a coluna atual é a coluna desejada
            if (Grid.Columns[e.ColumnIndex].Name == "colSalario")
            {
                string valor = e.FormattedValue.ToString();

                // Tente converter o valor em um número
                if (!double.TryParse(valor, out double resultado))
                {
                    e.Cancel = true; // Impede que o usuário saia da célula
                    MessageBox.Show("Por favor, insira um número válido na coluna Salário.", "Erro de validação");
                }
            }

            if (Grid.Columns[e.ColumnIndex].Name == "colQtdFilhos")
            {
                string valor = e.FormattedValue.ToString();

                // Tente converter o valor em um número
                if (!int.TryParse(valor, out int resultado))
                {
                    e.Cancel = true; // Impede que o usuário saia da célula
                    MessageBox.Show("Por favor, insira um número válido na coluna Quantida de filhos.", "Erro de validação");
                }
            }
        }
    }
}
