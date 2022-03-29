namespace Locadora
{
    partial class Filme
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
            this.btnInserirFilme = new System.Windows.Forms.Button();
            this.btnExibirFilme = new System.Windows.Forms.Button();
            this.btnConsultarFilme = new System.Windows.Forms.Button();
            this.btnExcluirFilme = new System.Windows.Forms.Button();
            this.btnAlterarFilme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatusFilme = new System.Windows.Forms.TextBox();
            this.txtFaixaFilme = new System.Windows.Forms.TextBox();
            this.txtIDDIretorFilme = new System.Windows.Forms.TextBox();
            this.txtTituloFilme = new System.Windows.Forms.TextBox();
            this.txtIDFilme = new System.Windows.Forms.TextBox();
            this.dtGridFilme = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFilme)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserirFilme
            // 
            this.btnInserirFilme.Location = new System.Drawing.Point(130, 135);
            this.btnInserirFilme.Name = "btnInserirFilme";
            this.btnInserirFilme.Size = new System.Drawing.Size(71, 28);
            this.btnInserirFilme.TabIndex = 0;
            this.btnInserirFilme.Text = "INSERIR";
            this.btnInserirFilme.UseVisualStyleBackColor = true;
            this.btnInserirFilme.Click += new System.EventHandler(this.btnInserirFilme_Click);
            // 
            // btnExibirFilme
            // 
            this.btnExibirFilme.Location = new System.Drawing.Point(297, 135);
            this.btnExibirFilme.Name = "btnExibirFilme";
            this.btnExibirFilme.Size = new System.Drawing.Size(70, 28);
            this.btnExibirFilme.TabIndex = 2;
            this.btnExibirFilme.Text = " EXIBIR";
            this.btnExibirFilme.UseVisualStyleBackColor = true;
            this.btnExibirFilme.Click += new System.EventHandler(this.btnExibirFilme_Click);
            // 
            // btnConsultarFilme
            // 
            this.btnConsultarFilme.Location = new System.Drawing.Point(373, 135);
            this.btnConsultarFilme.Name = "btnConsultarFilme";
            this.btnConsultarFilme.Size = new System.Drawing.Size(134, 28);
            this.btnConsultarFilme.TabIndex = 4;
            this.btnConsultarFilme.Text = " CONSULTAR +18";
            this.btnConsultarFilme.UseVisualStyleBackColor = true;
            this.btnConsultarFilme.Click += new System.EventHandler(this.btnConsultarFilme_Click);
            // 
            // btnExcluirFilme
            // 
            this.btnExcluirFilme.Location = new System.Drawing.Point(513, 135);
            this.btnExcluirFilme.Name = "btnExcluirFilme";
            this.btnExcluirFilme.Size = new System.Drawing.Size(82, 28);
            this.btnExcluirFilme.TabIndex = 6;
            this.btnExcluirFilme.Text = " EXCLUIR";
            this.btnExcluirFilme.UseVisualStyleBackColor = true;
            this.btnExcluirFilme.Click += new System.EventHandler(this.btnExcluirFilme_Click);
            // 
            // btnAlterarFilme
            // 
            this.btnAlterarFilme.Location = new System.Drawing.Point(207, 135);
            this.btnAlterarFilme.Name = "btnAlterarFilme";
            this.btnAlterarFilme.Size = new System.Drawing.Size(84, 28);
            this.btnAlterarFilme.TabIndex = 8;
            this.btnAlterarFilme.Text = " ALTERAR";
            this.btnAlterarFilme.UseVisualStyleBackColor = true;
            this.btnAlterarFilme.Click += new System.EventHandler(this.btnAlterarFilme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = " ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "TÍTULO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = " ID DIRETOR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "STATUS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "FAIXA ETÁRIA:";
            // 
            // txtStatusFilme
            // 
            this.txtStatusFilme.Location = new System.Drawing.Point(262, 86);
            this.txtStatusFilme.Name = "txtStatusFilme";
            this.txtStatusFilme.Size = new System.Drawing.Size(32, 26);
            this.txtStatusFilme.TabIndex = 18;
            // 
            // txtFaixaFilme
            // 
            this.txtFaixaFilme.Location = new System.Drawing.Point(424, 86);
            this.txtFaixaFilme.Name = "txtFaixaFilme";
            this.txtFaixaFilme.Size = new System.Drawing.Size(41, 26);
            this.txtFaixaFilme.TabIndex = 20;
            // 
            // txtIDDIretorFilme
            // 
            this.txtIDDIretorFilme.Location = new System.Drawing.Point(133, 83);
            this.txtIDDIretorFilme.Name = "txtIDDIretorFilme";
            this.txtIDDIretorFilme.Size = new System.Drawing.Size(41, 26);
            this.txtIDDIretorFilme.TabIndex = 22;
            // 
            // txtTituloFilme
            // 
            this.txtTituloFilme.Location = new System.Drawing.Point(262, 37);
            this.txtTituloFilme.Name = "txtTituloFilme";
            this.txtTituloFilme.Size = new System.Drawing.Size(299, 26);
            this.txtTituloFilme.TabIndex = 24;
            // 
            // txtIDFilme
            // 
            this.txtIDFilme.Location = new System.Drawing.Point(133, 40);
            this.txtIDFilme.Name = "txtIDFilme";
            this.txtIDFilme.Size = new System.Drawing.Size(41, 26);
            this.txtIDFilme.TabIndex = 26;
            // 
            // dtGridFilme
            // 
            this.dtGridFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridFilme.Location = new System.Drawing.Point(130, 169);
            this.dtGridFilme.Name = "dtGridFilme";
            this.dtGridFilme.RowHeadersWidth = 49;
            this.dtGridFilme.RowTemplate.Height = 28;
            this.dtGridFilme.Size = new System.Drawing.Size(465, 251);
            this.dtGridFilme.TabIndex = 27;
            // 
            // Filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.dtGridFilme);
            this.Controls.Add(this.txtIDFilme);
            this.Controls.Add(this.txtTituloFilme);
            this.Controls.Add(this.txtIDDIretorFilme);
            this.Controls.Add(this.txtFaixaFilme);
            this.Controls.Add(this.txtStatusFilme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterarFilme);
            this.Controls.Add(this.btnExcluirFilme);
            this.Controls.Add(this.btnConsultarFilme);
            this.Controls.Add(this.btnExibirFilme);
            this.Controls.Add(this.btnInserirFilme);
            this.Name = "Filme";
            this.Text = "Filme";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFilme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnInserirFilme;
        private Button btnExibirFilme;
        private Button btnConsultarFilme;
        private Button btnExcluirFilme;
        private Button btnAlterarFilme;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtStatusFilme;
        private TextBox txtFaixaFilme;
        private TextBox txtIDDIretorFilme;
        private TextBox txtTituloFilme;
        private TextBox txtIDFilme;
        private DataGridView dtGridFilme;
    }
}