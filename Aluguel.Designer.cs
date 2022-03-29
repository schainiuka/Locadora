namespace Locadora
{
    partial class Aluguel
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
            this.txtIDClienteAlug = new System.Windows.Forms.TextBox();
            this.txtIDAlug = new System.Windows.Forms.TextBox();
            this.txtValorAlug = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInserirAlug = new System.Windows.Forms.Button();
            this.btnAlterarAlug = new System.Windows.Forms.Button();
            this.btnExibirAlug = new System.Windows.Forms.Button();
            this.btnConsultarAlug = new System.Windows.Forms.Button();
            this.btnExcluirAlug = new System.Windows.Forms.Button();
            this.dtGridViewAlug = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExibirAlugFilmes = new System.Windows.Forms.Button();
            this.dtGridAlugFilme = new System.Windows.Forms.DataGridView();
            this.btnInserirAlugFilm = new System.Windows.Forms.Button();
            this.txtIDFilmeAlug = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvarAlug = new System.Windows.Forms.Button();
            this.btnDevolvido = new System.Windows.Forms.Button();
            this.btnMostrarClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewAlug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAlugFilme)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = " ID Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = " Valor Aluguel:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtIDClienteAlug
            // 
            this.txtIDClienteAlug.Location = new System.Drawing.Point(253, 52);
            this.txtIDClienteAlug.Name = "txtIDClienteAlug";
            this.txtIDClienteAlug.Size = new System.Drawing.Size(49, 26);
            this.txtIDClienteAlug.TabIndex = 5;
            // 
            // txtIDAlug
            // 
            this.txtIDAlug.Location = new System.Drawing.Point(111, 52);
            this.txtIDAlug.Name = "txtIDAlug";
            this.txtIDAlug.Size = new System.Drawing.Size(49, 26);
            this.txtIDAlug.TabIndex = 7;
            // 
            // txtValorAlug
            // 
            this.txtValorAlug.Location = new System.Drawing.Point(430, 52);
            this.txtValorAlug.Name = "txtValorAlug";
            this.txtValorAlug.Size = new System.Drawing.Size(72, 26);
            this.txtValorAlug.TabIndex = 8;
            this.txtValorAlug.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(75, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = " ALUGUEL";
            // 
            // btnInserirAlug
            // 
            this.btnInserirAlug.Location = new System.Drawing.Point(111, 107);
            this.btnInserirAlug.Name = "btnInserirAlug";
            this.btnInserirAlug.Size = new System.Drawing.Size(76, 28);
            this.btnInserirAlug.TabIndex = 10;
            this.btnInserirAlug.Text = "INSERIR";
            this.btnInserirAlug.UseVisualStyleBackColor = true;
            this.btnInserirAlug.Click += new System.EventHandler(this.btnInserirAlug_Click);
            // 
            // btnAlterarAlug
            // 
            this.btnAlterarAlug.Location = new System.Drawing.Point(193, 107);
            this.btnAlterarAlug.Name = "btnAlterarAlug";
            this.btnAlterarAlug.Size = new System.Drawing.Size(85, 28);
            this.btnAlterarAlug.TabIndex = 12;
            this.btnAlterarAlug.Text = " ALTERAR";
            this.btnAlterarAlug.UseVisualStyleBackColor = true;
            this.btnAlterarAlug.Click += new System.EventHandler(this.btnAlterarAlug_Click);
            // 
            // btnExibirAlug
            // 
            this.btnExibirAlug.Location = new System.Drawing.Point(284, 107);
            this.btnExibirAlug.Name = "btnExibirAlug";
            this.btnExibirAlug.Size = new System.Drawing.Size(64, 28);
            this.btnExibirAlug.TabIndex = 14;
            this.btnExibirAlug.Text = " EXIBIR";
            this.btnExibirAlug.UseVisualStyleBackColor = true;
            this.btnExibirAlug.Click += new System.EventHandler(this.btnExibirAlug_Click);
            // 
            // btnConsultarAlug
            // 
            this.btnConsultarAlug.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarAlug.Location = new System.Drawing.Point(354, 107);
            this.btnConsultarAlug.Name = "btnConsultarAlug";
            this.btnConsultarAlug.Size = new System.Drawing.Size(139, 28);
            this.btnConsultarAlug.TabIndex = 16;
            this.btnConsultarAlug.Text = " CONSULTAR > 15,00";
            this.btnConsultarAlug.UseVisualStyleBackColor = true;
            this.btnConsultarAlug.Click += new System.EventHandler(this.btnConsultarAlug_Click);
            // 
            // btnExcluirAlug
            // 
            this.btnExcluirAlug.Location = new System.Drawing.Point(499, 107);
            this.btnExcluirAlug.Name = "btnExcluirAlug";
            this.btnExcluirAlug.Size = new System.Drawing.Size(87, 28);
            this.btnExcluirAlug.TabIndex = 18;
            this.btnExcluirAlug.Text = " EXCLUIR";
            this.btnExcluirAlug.UseVisualStyleBackColor = true;
            this.btnExcluirAlug.Click += new System.EventHandler(this.btnExcluirAlug_Click);
            // 
            // dtGridViewAlug
            // 
            this.dtGridViewAlug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewAlug.Location = new System.Drawing.Point(111, 155);
            this.dtGridViewAlug.Name = "dtGridViewAlug";
            this.dtGridViewAlug.RowHeadersWidth = 49;
            this.dtGridViewAlug.RowTemplate.Height = 28;
            this.dtGridViewAlug.Size = new System.Drawing.Size(475, 129);
            this.dtGridViewAlug.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(483, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "-------------------------------------------------------------------------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(110, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "FILMES";
            // 
            // btnExibirAlugFilmes
            // 
            this.btnExibirAlugFilmes.Location = new System.Drawing.Point(111, 363);
            this.btnExibirAlugFilmes.Name = "btnExibirAlugFilmes";
            this.btnExibirAlugFilmes.Size = new System.Drawing.Size(76, 52);
            this.btnExibirAlugFilmes.TabIndex = 22;
            this.btnExibirAlugFilmes.Text = " EXIBIR FILMES";
            this.btnExibirAlugFilmes.UseVisualStyleBackColor = true;
            this.btnExibirAlugFilmes.Click += new System.EventHandler(this.btnExibirAlugFilmes_Click);
            // 
            // dtGridAlugFilme
            // 
            this.dtGridAlugFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridAlugFilme.Location = new System.Drawing.Point(207, 325);
            this.dtGridAlugFilme.Name = "dtGridAlugFilme";
            this.dtGridAlugFilme.RowHeadersWidth = 49;
            this.dtGridAlugFilme.RowTemplate.Height = 28;
            this.dtGridAlugFilme.Size = new System.Drawing.Size(460, 203);
            this.dtGridAlugFilme.TabIndex = 23;
            // 
            // btnInserirAlugFilm
            // 
            this.btnInserirAlugFilm.Location = new System.Drawing.Point(111, 500);
            this.btnInserirAlugFilm.Name = "btnInserirAlugFilm";
            this.btnInserirAlugFilm.Size = new System.Drawing.Size(76, 28);
            this.btnInserirAlugFilm.TabIndex = 24;
            this.btnInserirAlugFilm.Text = "INSERIR";
            this.btnInserirAlugFilm.UseVisualStyleBackColor = true;
            this.btnInserirAlugFilm.Click += new System.EventHandler(this.btnInserirAlugFilm_Click);
            // 
            // txtIDFilmeAlug
            // 
            this.txtIDFilmeAlug.Location = new System.Drawing.Point(153, 456);
            this.txtIDFilmeAlug.Name = "txtIDFilmeAlug";
            this.txtIDFilmeAlug.Size = new System.Drawing.Size(34, 26);
            this.txtIDFilmeAlug.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "ID:";
            // 
            // btnSalvarAlug
            // 
            this.btnSalvarAlug.Location = new System.Drawing.Point(673, 500);
            this.btnSalvarAlug.Name = "btnSalvarAlug";
            this.btnSalvarAlug.Size = new System.Drawing.Size(90, 28);
            this.btnSalvarAlug.TabIndex = 27;
            this.btnSalvarAlug.Text = "SALVAR";
            this.btnSalvarAlug.UseVisualStyleBackColor = true;
            this.btnSalvarAlug.Click += new System.EventHandler(this.btnSalvarAlug_Click);
            // 
            // btnDevolvido
            // 
            this.btnDevolvido.Location = new System.Drawing.Point(592, 256);
            this.btnDevolvido.Name = "btnDevolvido";
            this.btnDevolvido.Size = new System.Drawing.Size(128, 28);
            this.btnDevolvido.TabIndex = 28;
            this.btnDevolvido.Text = "DEVOLVIDO";
            this.btnDevolvido.UseVisualStyleBackColor = true;
            this.btnDevolvido.Click += new System.EventHandler(this.btnDevolvido_Click);
            // 
            // btnMostrarClientes
            // 
            this.btnMostrarClientes.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarClientes.Location = new System.Drawing.Point(592, 198);
            this.btnMostrarClientes.Name = "btnMostrarClientes";
            this.btnMostrarClientes.Size = new System.Drawing.Size(128, 43);
            this.btnMostrarClientes.TabIndex = 30;
            this.btnMostrarClientes.Text = "MOSTRAR CLIENTES";
            this.btnMostrarClientes.UseVisualStyleBackColor = true;
            this.btnMostrarClientes.Click += new System.EventHandler(this.btnMostrarClientes_Click);
            // 
            // Aluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.btnMostrarClientes);
            this.Controls.Add(this.btnDevolvido);
            this.Controls.Add(this.btnSalvarAlug);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIDFilmeAlug);
            this.Controls.Add(this.btnInserirAlugFilm);
            this.Controls.Add(this.dtGridAlugFilme);
            this.Controls.Add(this.btnExibirAlugFilmes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtGridViewAlug);
            this.Controls.Add(this.btnExcluirAlug);
            this.Controls.Add(this.btnConsultarAlug);
            this.Controls.Add(this.btnExibirAlug);
            this.Controls.Add(this.btnAlterarAlug);
            this.Controls.Add(this.btnInserirAlug);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorAlug);
            this.Controls.Add(this.txtIDAlug);
            this.Controls.Add(this.txtIDClienteAlug);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Aluguel";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Aluguel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewAlug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAlugFilme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIDClienteAlug;
        private TextBox txtIDAlug;
        private TextBox txtValorAlug;
        private Label label4;
        private Button btnInserirAlug;
        private Button btnAlterarAlug;
        private Button btnExibirAlug;
        private Button btnConsultarAlug;
        private Button btnExcluirAlug;
        private DataGridView dtGridViewAlug;
        private Label label5;
        private Label label6;
        private Button btnExibirAlugFilmes;
        private DataGridView dtGridAlugFilme;
        private Button btnInserirAlugFilm;
        private TextBox txtIDFilmeAlug;
        private Label label7;
        private Button btnSalvarAlug;
        private Button btnDevolvido;
        private Button btnMostrarClientes;
    }
}