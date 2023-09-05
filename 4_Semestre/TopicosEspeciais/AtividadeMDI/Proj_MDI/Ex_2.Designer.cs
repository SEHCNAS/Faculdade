namespace Proj_MDI
{
    partial class Ex_2
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
            colNumeroLinha = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colSalario = new DataGridViewTextBoxColumn();
            colQtdFilhos = new DataGridViewTextBoxColumn();
            LabelMediaSalario = new Label();
            LabelMediaFilhos = new Label();
            LabelMaiorSalario = new Label();
            TxtMediaSalario = new TextBox();
            TxtMediaFilhos = new TextBox();
            TxtMaiorSalario = new TextBox();
            BtCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // Grid
            // 
            Grid.AllowUserToAddRows = false;
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.Columns.AddRange(new DataGridViewColumn[] { colNumeroLinha, colNome, colSalario, colQtdFilhos });
            Grid.Location = new Point(3, 12);
            Grid.Name = "Grid";
            Grid.RowTemplate.Height = 25;
            Grid.Size = new Size(505, 426);
            Grid.TabIndex = 0;
            Grid.CellValidating += Grid_CellValidating;
            // 
            // colNumeroLinha
            // 
            colNumeroLinha.HeaderText = "Identificador";
            colNumeroLinha.Name = "colNumeroLinha";
            colNumeroLinha.ReadOnly = true;
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            // 
            // colSalario
            // 
            colSalario.HeaderText = "Salario";
            colSalario.Name = "colSalario";
            // 
            // colQtdFilhos
            // 
            colQtdFilhos.HeaderText = "Quantidade de filhos";
            colQtdFilhos.Name = "colQtdFilhos";
            // 
            // LabelMediaSalario
            // 
            LabelMediaSalario.AutoSize = true;
            LabelMediaSalario.Location = new Point(522, 15);
            LabelMediaSalario.Name = "LabelMediaSalario";
            LabelMediaSalario.Size = new Size(168, 15);
            LabelMediaSalario.TabIndex = 1;
            LabelMediaSalario.Text = "Média dos salários informados";
            // 
            // LabelMediaFilhos
            // 
            LabelMediaFilhos.AutoSize = true;
            LabelMediaFilhos.Location = new Point(522, 44);
            LabelMediaFilhos.Name = "LabelMediaFilhos";
            LabelMediaFilhos.Size = new Size(150, 15);
            LabelMediaFilhos.TabIndex = 2;
            LabelMediaFilhos.Text = "Média do número de filhos";
            // 
            // LabelMaiorSalario
            // 
            LabelMaiorSalario.AutoSize = true;
            LabelMaiorSalario.Location = new Point(522, 72);
            LabelMaiorSalario.Name = "LabelMaiorSalario";
            LabelMaiorSalario.Size = new Size(155, 15);
            LabelMaiorSalario.TabIndex = 3;
            LabelMaiorSalario.Text = "Maior salário dos habitantes";
            // 
            // TxtMediaSalario
            // 
            TxtMediaSalario.Location = new Point(688, 15);
            TxtMediaSalario.Name = "TxtMediaSalario";
            TxtMediaSalario.ReadOnly = true;
            TxtMediaSalario.Size = new Size(100, 23);
            TxtMediaSalario.TabIndex = 4;
            // 
            // TxtMediaFilhos
            // 
            TxtMediaFilhos.Location = new Point(688, 44);
            TxtMediaFilhos.Name = "TxtMediaFilhos";
            TxtMediaFilhos.ReadOnly = true;
            TxtMediaFilhos.Size = new Size(100, 23);
            TxtMediaFilhos.TabIndex = 5;
            // 
            // TxtMaiorSalario
            // 
            TxtMaiorSalario.Location = new Point(688, 72);
            TxtMaiorSalario.Name = "TxtMaiorSalario";
            TxtMaiorSalario.ReadOnly = true;
            TxtMaiorSalario.Size = new Size(100, 23);
            TxtMaiorSalario.TabIndex = 6;
            // 
            // BtCalcular
            // 
            BtCalcular.Location = new Point(529, 108);
            BtCalcular.Name = "BtCalcular";
            BtCalcular.Size = new Size(259, 23);
            BtCalcular.TabIndex = 7;
            BtCalcular.Text = "Calcular";
            BtCalcular.UseVisualStyleBackColor = true;
            BtCalcular.Click += BtCalcular_Click;
            // 
            // Ex_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtCalcular);
            Controls.Add(TxtMaiorSalario);
            Controls.Add(TxtMediaFilhos);
            Controls.Add(TxtMediaSalario);
            Controls.Add(LabelMaiorSalario);
            Controls.Add(LabelMediaFilhos);
            Controls.Add(LabelMediaSalario);
            Controls.Add(Grid);
            Name = "Ex_2";
            Text = "Ex_2";
            Load += Ex_2_Load;
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grid;
        private DataGridViewTextBoxColumn colNumeroLinha;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colSalario;
        private DataGridViewTextBoxColumn colQtdFilhos;
        private Label LabelMediaSalario;
        private Label LabelMediaFilhos;
        private Label LabelMaiorSalario;
        private TextBox TxtMediaSalario;
        private TextBox TxtMediaFilhos;
        private TextBox TxtMaiorSalario;
        private Button BtCalcular;
    }
}