namespace Proj_MDI
{
    partial class Ex_1
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
            TxtIdade = new TextBox();
            label1 = new Label();
            btnCalcular = new Button();
            TxtResultado = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // TxtIdade
            // 
            TxtIdade.Location = new Point(118, 70);
            TxtIdade.Name = "TxtIdade";
            TxtIdade.Size = new Size(164, 23);
            TxtIdade.TabIndex = 0;
            TxtIdade.KeyPress += TxtIdade_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 78);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Idade:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(73, 149);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(209, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.Location = new Point(182, 111);
            TxtResultado.Name = "TxtResultado";
            TxtResultado.ReadOnly = true;
            TxtResultado.Size = new Size(100, 23);
            TxtResultado.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 119);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 4;
            label2.Text = "Resultado em dias:";
            // 
            // Ex_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(TxtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(label1);
            Controls.Add(TxtIdade);
            Name = "Ex_1";
            Text = "Ex_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtIdade;
        private Label label1;
        private Button btnCalcular;
        private TextBox TxtResultado;
        private Label label2;
    }
}