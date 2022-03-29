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
    public partial class Cliente : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;
        public Cliente()
        {
            InitializeComponent();
        }

        private void btn_InserirCliente_Click(object sender, EventArgs e)
        {
            try 
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "INSERT INTO Cliente (Nome, Idade, CPF) VALUES (@Nome, @Idade, @CPF)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@Nome", txt_NomeCliente.Text);
                comando.Parameters.AddWithValue("@Idade", txt_IdadeCliente.Text);
                comando.Parameters.AddWithValue("@CPF", txt_CpfCliente.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

                

            }

            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            
            }
            finally
            {
                conexao.Close();
                comando.Clone();
                conexao=null;
                comando=null;

            }
                
         

        }

        private void btn_AlterarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "UPDATE Cliente set Nome = @nome, Idade = @Idade, CPF = @CPF WHERE IDCliente = @IDCliente";

                comando = new SqlCommand(strSQL, conexao);



                comando.Parameters.AddWithValue("@IDCliente", txt_IDCliente.Text);
                comando.Parameters.AddWithValue("@Nome", txt_NomeCliente.Text);
                comando.Parameters.AddWithValue("@Idade", txt_IdadeCliente.Text);
                comando.Parameters.AddWithValue("@CPF", txt_CpfCliente.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

            }

            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;

            }

        }

        private void btnExibirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "SELECT * FROM CLIENTE";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);
                
                conexao.Open();

                da.Fill(ds);

                dtGridCliente.DataSource = ds.Tables[0];

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                
                conexao = null;
                comando = null;

            }
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "SELECT * FROM CLIENTE where Idade > 30";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

                dtGridCliente.DataSource = ds.Tables[0];

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();

                conexao = null;
                comando = null;

            }
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "DELETE FROM CLIENTE  WHERE IDCliente = @IDCliente";

                comando = new SqlCommand(strSQL, conexao);



                comando.Parameters.AddWithValue("@IDCliente", txt_IDCliente.Text);
         
                conexao.Open();
                comando.ExecuteNonQuery();

            }

            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;

            }
        }
    }
}
