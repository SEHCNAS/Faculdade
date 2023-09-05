namespace Proj_MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria um novo formul·rio FrnEditorTexto
            Ex_1 Exercicio_1 = new Ex_1();
            //De«ine que ele serpa filho do Formul·rio principal
            Exercicio_1.MdiParent = this;
            //Exibe o formul·rio Filho
            Exercicio_1.Show();

        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria um novo formul·rio FrnEditorTexto
            Ex_2 Exercicio_2 = new Ex_2();
            //De«ine que ele serpa filho do Formul·rio principal
            Exercicio_2.MdiParent = this;
            //Exibe o formul·rio Filho
            Exercicio_2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria um novo formul·rio FrnEditorTexto
            Ex_3 Exercicio_3 = new Ex_3();
            //De«ine que ele serpa filho do Formul·rio principal
            Exercicio_3.MdiParent = this;
            //Exibe o formul·rio Filho
            Exercicio_3.Show();
        }
    }
}