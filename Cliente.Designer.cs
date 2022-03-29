namespace Locadora
{
    partial class Cliente
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_IDCliente = new System.Windows.Forms.TextBox();
            this.txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.txt_IdadeCliente = new System.Windows.Forms.TextBox();
            this.txt_CpfCliente = new System.Windows.Forms.TextBox();
            this.btn_InserirCliente = new System.Windows.Forms.Button();
            this.btn_AlterarCliente = new System.Windows.Forms.Button();
            this.dtGridCliente = new System.Windows.Forms.DataGridView();
            this.btnExibirCliente = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = " NOME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = " IDADE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = " CPF:";
            // 
            // txt_IDCliente
            // 
            this.txt_IDCliente.Location = new System.Drawing.Point(108, 21);
            this.txt_IDCliente.Name = "txt_IDCliente";
            this.txt_IDCliente.Size = new System.Drawing.Size(43, 26);
            this.txt_IDCliente.TabIndex = 7;
            // 
            // txt_NomeCliente
            // 
            this.txt_NomeCliente.Location = new System.Drawing.Point(108, 60);
            this.txt_NomeCliente.Name = "txt_NomeCliente";
            this.txt_NomeCliente.Size = new System.Drawing.Size(364, 26);
            this.txt_NomeCliente.TabIndex = 9;
            // 
            // txt_IdadeCliente
            // 
            this.txt_IdadeCliente.Location = new System.Drawing.Point(109, 99);
            this.txt_IdadeCliente.Name = "txt_IdadeCliente";
            this.txt_IdadeCliente.Size = new System.Drawing.Size(42, 26);
            this.txt_IdadeCliente.TabIndex = 11;
            // 
            // txt_CpfCliente
            // 
            this.txt_CpfCliente.Location = new System.Drawing.Point(108, 140);
            this.txt_CpfCliente.Name = "txt_CpfCliente";
            this.txt_CpfCliente.Size = new System.Drawing.Size(203, 26);
            this.txt_CpfCliente.TabIndex = 13;
            // 
            // btn_InserirCliente
            // 
            this.btn_InserirCliente.Location = new System.Drawing.Point(109, 189);
            this.btn_InserirCliente.Name = "btn_InserirCliente";
            this.btn_InserirCliente.Size = new System.Drawing.Size(77, 28);
            this.btn_InserirCliente.TabIndex = 14;
            this.btn_InserirCliente.Text = "INSERIR";
            this.btn_InserirCliente.UseVisualStyleBackColor = true;
            this.btn_InserirCliente.Click += new System.EventHandler(this.btn_InserirCliente_Click);
            // 
            // btn_AlterarCliente
            // 
            this.btn_AlterarCliente.Location = new System.Drawing.Point(193, 189);
            this.btn_AlterarCliente.Name = "btn_AlterarCliente";
            this.btn_AlterarCliente.Size = new System.Drawing.Size(96, 28);
            this.btn_AlterarCliente.TabIndex = 15;
            this.btn_AlterarCliente.Text = "ALTERAR";
            this.btn_AlterarCliente.UseVisualStyleBackColor = true;
            this.btn_AlterarCliente.Click += new System.EventHandler(this.btn_AlterarCliente_Click);
            // 
            // dtGridCliente
            // 
            this.dtGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCliente.Location = new System.Drawing.Point(108, 241);
            this.dtGridCliente.Name = "dtGridCliente";
            this.dtGridCliente.RowHeadersWidth = 49;
            this.dtGridCliente.RowTemplate.Height = 28;
            this.dtGridCliente.Size = new System.Drawing.Size(615, 230);
            this.dtGridCliente.TabIndex = 16;
            // 
            // btnExibirCliente
            // 
            this.btnExibirCliente.Location = new System.Drawing.Point(301, 189);
            this.btnExibirCliente.Name = "btnExibirCliente";
            this.btnExibirCliente.Size = new System.Drawing.Size(71, 29);
            this.btnExibirCliente.TabIndex = 17;
            this.btnExibirCliente.Text = "EXIBIR";
            this.btnExibirCliente.UseVisualStyleBackColor = true;
            this.btnExibirCliente.Click += new System.EventHandler(this.btnExibirCliente_Click);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(384, 189);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(126, 30);
            this.btnConsultarCliente.TabIndex = 18;
            this.btnConsultarCliente.Text = "CONSULTA + 30";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.Location = new System.Drawing.Point(526, 189);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(105, 30);
            this.btnExcluirCliente.TabIndex = 19;
            this.btnExcluirCliente.Text = "EXCLUIR";
            this.btnExcluirCliente.UseVisualStyleBackColor = true;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 514);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.btnConsultarCliente);
            this.Controls.Add(this.btnExibirCliente);
            this.Controls.Add(this.dtGridCliente);
            this.Controls.Add(this.btn_AlterarCliente);
            this.Controls.Add(this.btn_InserirCliente);
            this.Controls.Add(this.txt_CpfCliente);
            this.Controls.Add(this.txt_IdadeCliente);
            this.Controls.Add(this.txt_NomeCliente);
            this.Controls.Add(this.txt_IDCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cliente";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_IDCliente;
        private TextBox txt_NomeCliente;
        private TextBox txt_IdadeCliente;
        private TextBox txt_CpfCliente;
        private Button btn_InserirCliente;
        private Button btn_AlterarCliente;
        private DataGridView dtGridCliente;
        private Button btnExibirCliente;
        private Button btnConsultarCliente;
        private Button btnExcluirCliente;
    }
}