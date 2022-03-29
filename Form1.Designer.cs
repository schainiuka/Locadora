namespace Locadora
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPÇÕESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIRETORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fILMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLUGUELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPÇÕESToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPÇÕESToolStripMenuItem
            // 
            this.oPÇÕESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTEToolStripMenuItem,
            this.dIRETORToolStripMenuItem,
            this.fILMEToolStripMenuItem,
            this.aLUGUELToolStripMenuItem});
            this.oPÇÕESToolStripMenuItem.Name = "oPÇÕESToolStripMenuItem";
            this.oPÇÕESToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.oPÇÕESToolStripMenuItem.Text = "OPÇÕES";
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.cLIENTEToolStripMenuItem.Text = "CLIENTE";
            this.cLIENTEToolStripMenuItem.Click += new System.EventHandler(this.cLIENTEToolStripMenuItem_Click);
            // 
            // dIRETORToolStripMenuItem
            // 
            this.dIRETORToolStripMenuItem.Name = "dIRETORToolStripMenuItem";
            this.dIRETORToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.dIRETORToolStripMenuItem.Text = "DIRETOR";
            this.dIRETORToolStripMenuItem.Click += new System.EventHandler(this.dIRETORToolStripMenuItem_Click);
            // 
            // fILMEToolStripMenuItem
            // 
            this.fILMEToolStripMenuItem.Name = "fILMEToolStripMenuItem";
            this.fILMEToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.fILMEToolStripMenuItem.Text = "FILME";
            this.fILMEToolStripMenuItem.Click += new System.EventHandler(this.fILMEToolStripMenuItem_Click);
            // 
            // aLUGUELToolStripMenuItem
            // 
            this.aLUGUELToolStripMenuItem.Name = "aLUGUELToolStripMenuItem";
            this.aLUGUELToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.aLUGUELToolStripMenuItem.Text = "ALUGUEL";
            this.aLUGUELToolStripMenuItem.Click += new System.EventHandler(this.aLUGUELToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 26.29565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(120, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOCADORA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem oPÇÕESToolStripMenuItem;
        private ToolStripMenuItem cLIENTEToolStripMenuItem;
        private ToolStripMenuItem sAIRToolStripMenuItem;
        private ToolStripMenuItem dIRETORToolStripMenuItem;
        private ToolStripMenuItem fILMEToolStripMenuItem;
        private ToolStripMenuItem aLUGUELToolStripMenuItem;
        private Label label1;
    }
}