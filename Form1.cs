using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;






namespace Locadora
{
    public partial class Form1 : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;



        public Form1()
        {
            InitializeComponent();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente Cli = new Cliente();
            Cli.ShowDialog();   
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dIRETORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diretor Dir = new Diretor();
            Dir.ShowDialog();
        }

        private void fILMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filme Fil = new Filme();
            Fil.ShowDialog();
        }

        private void aLUGUELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aluguel Alug = new Aluguel();
            Alug.ShowDialog();  
        }
    }
}