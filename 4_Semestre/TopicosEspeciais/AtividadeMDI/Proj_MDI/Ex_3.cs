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
    public partial class Ex_3 : Form
    {
        public Ex_3()
        {
            InitializeComponent();
        }

        private void Ex_3_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                Grid.Rows.Add(i, "", "", "");
            }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {

            double Nota1 = 0, Nota2 = 0, MediaAluno = 0, MediaSala = 0;
            int QtdAprovados = 0, QtdReprovado = 0, QtdExame = 0, QtdAlunos = 0;

            foreach (DataGridViewRow row in Grid.Rows)
            {

                // Verifica se a linha não é a linha de cabeçalho e não está marcada como nova
                if (!row.IsNewRow && row.Cells["ColNome"].Value != "")
                {
                    Nota1 = 0;
                    Nota2 = 0;
                    MediaAluno = 0;

                    if (row.Cells["ColNota1"].Value != "")
                    {
                        Nota1 = Convert.ToDouble(row.Cells["ColNota1"].Value);
                    }

                    if (row.Cells["ColNota2"].Value != "")
                    {
                        Nota2 = Convert.ToDouble(row.Cells["ColNota2"].Value);
                    }

                    QtdAlunos++;
                    MediaAluno = (Nota1 + Nota2) / 2;
                    MediaSala += MediaAluno;

                    switch (MediaAluno)
                    {
                        case >= 6:
                            QtdAprovados += 1;
                            break;
                        case < 6:
                            if (((Nota1 / 2) >= 3) || ((Nota2 / 2) >= 3))
                            {
                                QtdExame += 1;
                            }
                            else
                            {
                                QtdReprovado += 1;
                            }
                            break;
                    }
                }
            }

            txtAprovados.Text = QtdAprovados.ToString();
            txtExame.Text = QtdExame.ToString();
            txtMedia.Text = MediaSala.ToString();
            txtReprovados.Text = QtdReprovado.ToString();

        }

        private void Grid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Verifica se a coluna atual é a coluna desejada
            if (Grid.Columns[e.ColumnIndex].Name == "ColNota1" || Grid.Columns[e.ColumnIndex].Name == "ColNota2")
            {
                string valor = e.FormattedValue.ToString();

                // Tente converter o valor em um número
                if (!double.TryParse(valor, out double resultado))
                {
                    e.Cancel = true; // Impede que o usuário saia da célula
                    MessageBox.Show("Por favor, insira um número válido na coluna de nota.", "Erro de validação");
                }
            }
        }
    }
}
