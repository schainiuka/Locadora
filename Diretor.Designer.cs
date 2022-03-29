namespace Locadora
{
    partial class Diretor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaisDiretor = new System.Windows.Forms.TextBox();
            this.txtNomeDiretor = new System.Windows.Forms.TextBox();
            this.txtIDDiretor = new System.Windows.Forms.TextBox();
            this.btnConsultarDiretor = new System.Windows.Forms.Button();
            this.btnAlterarDiretor = new System.Windows.Forms.Button();
            this.btnExibirDiretor = new System.Windows.Forms.Button();
            this.btnInserirDiretor = new System.Windows.Forms.Button();
            this.btnExcluirDiretor = new System.Windows.Forms.Button();
            this.dtGridDiretor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDiretor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = " NOME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = " PAÍS:";
            // 
            // txtPaisDiretor
            // 
            this.txtPaisDiretor.Location = new System.Drawing.Point(94, 114);
            this.txtPaisDiretor.Name = "txtPaisDiretor";
            this.txtPaisDiretor.Size = new System.Drawing.Size(282, 26);
            this.txtPaisDiretor.TabIndex = 5;
            // 
            // txtNomeDiretor
            // 
            this.txtNomeDiretor.Location = new System.Drawing.Point(94, 76);
            this.txtNomeDiretor.Name = "txtNomeDiretor";
            this.txtNomeDiretor.Size = new System.Drawing.Size(282, 26);
            this.txtNomeDiretor.TabIndex = 7;
            // 
            // txtIDDiretor
            // 
            this.txtIDDiretor.Location = new System.Drawing.Point(94, 42);
            this.txtIDDiretor.Name = "txtIDDiretor";
            this.txtIDDiretor.Size = new System.Drawing.Size(42, 26);
            this.txtIDDiretor.TabIndex = 9;
            // 
            // btnConsultarDiretor
            // 
            this.btnConsultarDiretor.Location = new System.Drawing.Point(380, 168);
            this.btnConsultarDiretor.Name = "btnConsultarDiretor";
            this.btnConsultarDiretor.Size = new System.Drawing.Size(134, 34);
            this.btnConsultarDiretor.TabIndex = 10;
            this.btnConsultarDiretor.Text = "CONSULTAR - BR";
            this.btnConsultarDiretor.UseVisualStyleBackColor = true;
            this.btnConsultarDiretor.Click += new System.EventHandler(this.btnConsultarDiretor_Click);
            // 
            // btnAlterarDiretor
            // 
            this.btnAlterarDiretor.Location = new System.Drawing.Point(185, 168);
            this.btnAlterarDiretor.Name = "btnAlterarDiretor";
            this.btnAlterarDiretor.Size = new System.Drawing.Size(88, 34);
            this.btnAlterarDiretor.TabIndex = 12;
            this.btnAlterarDiretor.Text = "ALTERAR";
            this.btnAlterarDiretor.UseVisualStyleBackColor = true;
            this.btnAlterarDiretor.Click += new System.EventHandler(this.btnAlterarDiretor_Click);
            // 
            // btnExibirDiretor
            // 
            this.btnExibirDiretor.Location = new System.Drawing.Point(283, 168);
            this.btnExibirDiretor.Name = "btnExibirDiretor";
            this.btnExibirDiretor.Size = new System.Drawing.Size(84, 34);
            this.btnExibirDiretor.TabIndex = 14;
            this.btnExibirDiretor.Text = "EXIBIR";
            this.btnExibirDiretor.UseVisualStyleBackColor = true;
            this.btnExibirDiretor.Click += new System.EventHandler(this.btnExibirDiretor_Click);
            // 
            // btnInserirDiretor
            // 
            this.btnInserirDiretor.Location = new System.Drawing.Point(94, 168);
            this.btnInserirDiretor.Name = "btnInserirDiretor";
            this.btnInserirDiretor.Size = new System.Drawing.Size(79, 34);
            this.btnInserirDiretor.TabIndex = 16;
            this.btnInserirDiretor.Text = "INSERIR";
            this.btnInserirDiretor.UseVisualStyleBackColor = true;
            this.btnInserirDiretor.Click += new System.EventHandler(this.btnInserirDiretor_Click);
            // 
            // btnExcluirDiretor
            // 
            this.btnExcluirDiretor.Location = new System.Drawing.Point(524, 168);
            this.btnExcluirDiretor.Name = "btnExcluirDiretor";
            this.btnExcluirDiretor.Size = new System.Drawing.Size(85, 34);
            this.btnExcluirDiretor.TabIndex = 18;
            this.btnExcluirDiretor.Text = "EXCLUIR";
            this.btnExcluirDiretor.UseVisualStyleBackColor = true;
            this.btnExcluirDiretor.Click += new System.EventHandler(this.btnExcluirDiretor_Click);
            // 
            // dtGridDiretor
            // 
            this.dtGridDiretor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDiretor.Location = new System.Drawing.Point(94, 223);
            this.dtGridDiretor.Name = "dtGridDiretor";
            this.dtGridDiretor.RowHeadersWidth = 49;
            this.dtGridDiretor.RowTemplate.Height = 28;
            this.dtGridDiretor.Size = new System.Drawing.Size(515, 215);
            this.dtGridDiretor.TabIndex = 19;
            // 
            // Diretor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.dtGridDiretor);
            this.Controls.Add(this.btnExcluirDiretor);
            this.Controls.Add(this.btnInserirDiretor);
            this.Controls.Add(this.btnExibirDiretor);
            this.Controls.Add(this.btnAlterarDiretor);
            this.Controls.Add(this.btnConsultarDiretor);
            this.Controls.Add(this.txtIDDiretor);
            this.Controls.Add(this.txtNomeDiretor);
            this.Controls.Add(this.txtPaisDiretor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Diretor";
            this.Text = "Diretor";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDiretor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPaisDiretor;
        private TextBox txtNomeDiretor;
        private TextBox txtIDDiretor;
        private Button btnConsultarDiretor;
        private Button btnAlterarDiretor;
        private Button btnExibirDiretor;
        private Button btnInserirDiretor;
        private Button btnExcluirDiretor;
        private DataGridView dtGridDiretor;
    }
}