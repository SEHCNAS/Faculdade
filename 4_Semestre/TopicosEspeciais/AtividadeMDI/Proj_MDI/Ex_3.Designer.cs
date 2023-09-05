namespace Proj_MDI
{
    partial class Ex_3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Grid = new DataGridView();
            ColIdentificador = new DataGridViewTextBoxColumn();
            ColNome = new DataGridViewTextBoxColumn();
            ColNota1 = new DataGridViewTextBoxColumn();
            ColNota2 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtReprovados = new TextBox();
            txtExame = new TextBox();
            txtAprovados = new TextBox();
            txtMedia = new TextBox();
            btCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // Grid
            // 
            Grid.AllowUserToAddRows = false;
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.Columns.AddRange(new DataGridViewColumn[] { ColIdentificador, ColNome, ColNota1, ColNota2 });
            Grid.Location = new Point(12, 12);
            Grid.Name = "Grid";
            Grid.RowTemplate.Height = 25;
            Grid.Size = new Size(444, 426);
            Grid.TabIndex = 0;
            Grid.CellValidating += Grid_CellValidating;
            // 
            // ColIdentificador
            // 
            ColIdentificador.HeaderText = "Identificador";
            ColIdentificador.Name = "ColIdentificador";
            ColIdentificador.ReadOnly = true;
            // 
            // ColNome
            // 
            ColNome.HeaderText = "Nome";
            ColNome.Name = "ColNome";
            // 
            // ColNota1
            // 
            ColNota1.HeaderText = "Nota 1";
            ColNota1.Name = "ColNota1";
            // 
            // ColNota2
            // 
            ColNota2.HeaderText = "Nota 2";
            ColNota2.Name = "ColNota2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 12);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Media da classe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(462, 36);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantidade de aprovados:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(462, 62);
            label3.Name = "label3";
            label3.Size = new Size(180, 15);
            label3.TabIndex = 3;
            label3.Text = "Quantidade de alunos de exame:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 91);
            label4.Name = "label4";
            label4.Size = new Size(188, 15);
            label4.TabIndex = 4;
            label4.Text = "Quantidade de alunos reprovados:";
            // 
            // txtReprovados
            // 
            txtReprovados.Location = new Point(656, 83);
            txtReprovados.Name = "txtReprovados";
            txtReprovados.Size = new Size(100, 23);
            txtReprovados.TabIndex = 5;
            // 
            // txtExame
            // 
            txtExame.Location = new Point(656, 54);
            txtExame.Name = "txtExame";
            txtExame.Size = new Size(100, 23);
            txtExame.TabIndex = 6;
            // 
            // txtAprovados
            // 
            txtAprovados.Location = new Point(656, 28);
            txtAprovados.Name = "txtAprovados";
            txtAprovados.Size = new Size(100, 23);
            txtAprovados.TabIndex = 7;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(656, 4);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(100, 23);
            txtMedia.TabIndex = 8;
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(462, 124);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(294, 23);
            btCalcular.TabIndex = 9;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // Ex_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btCalcular);
            Controls.Add(txtMedia);
            Controls.Add(txtAprovados);
            Controls.Add(txtExame);
            Controls.Add(txtReprovados);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Grid);
            Name = "Ex_3";
            Text = "Ex_3";
            Load += Ex_3_Load;
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grid;
        private DataGridViewTextBoxColumn ColIdentificador;
        private DataGridViewTextBoxColumn ColNome;
        private DataGridViewTextBoxColumn ColNota1;
        private DataGridViewTextBoxColumn ColNota2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtReprovados;
        private TextBox txtExame;
        private TextBox txtAprovados;
        private TextBox txtMedia;
        private Button btCalcular;
    }
}