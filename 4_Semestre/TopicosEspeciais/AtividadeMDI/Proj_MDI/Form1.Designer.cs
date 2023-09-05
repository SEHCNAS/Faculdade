namespace Proj_MDI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            exercicio1ToolStripMenuItem = new ToolStripMenuItem();
            exercicio2ToolStripMenuItem = new ToolStripMenuItem();
            exercicio3ToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exercicio1ToolStripMenuItem, exercicio2ToolStripMenuItem, exercicio3ToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // exercicio1ToolStripMenuItem
            // 
            exercicio1ToolStripMenuItem.Name = "exercicio1ToolStripMenuItem";
            exercicio1ToolStripMenuItem.Size = new Size(180, 22);
            exercicio1ToolStripMenuItem.Text = "Exercicio 1";
            exercicio1ToolStripMenuItem.Click += exercicio1ToolStripMenuItem_Click;
            // 
            // exercicio2ToolStripMenuItem
            // 
            exercicio2ToolStripMenuItem.Name = "exercicio2ToolStripMenuItem";
            exercicio2ToolStripMenuItem.Size = new Size(180, 22);
            exercicio2ToolStripMenuItem.Text = "Exercicio 2";
            exercicio2ToolStripMenuItem.Click += exercicio2ToolStripMenuItem_Click;
            // 
            // exercicio3ToolStripMenuItem
            // 
            exercicio3ToolStripMenuItem.Name = "exercicio3ToolStripMenuItem";
            exercicio3ToolStripMenuItem.Size = new Size(180, 22);
            exercicio3ToolStripMenuItem.Text = "Exercicio 3";
            exercicio3ToolStripMenuItem.Click += exercicio3ToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "AtividadeMDI";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem exercicio1ToolStripMenuItem;
        private ToolStripMenuItem exercicio2ToolStripMenuItem;
        private ToolStripMenuItem exercicio3ToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}