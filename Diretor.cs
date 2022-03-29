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
    public partial class Diretor : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;
        public Diretor()
        {
            InitializeComponent();
        }

        private void btnInserirDiretor_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "INSERT INTO Diretor (Nome, Pais) VALUES (@Nome, @Pais)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@Nome", txtNomeDiretor.Text);
                comando.Parameters.AddWithValue("@Pais", txtPaisDiretor.Text);
                
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

        private void btnAlterarDiretor_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "UPDATE Diretor set Nome = @nome, Pais = @pais WHERE IDDiretor = @IDDiretor";

                comando = new SqlCommand(strSQL, conexao);



                comando.Parameters.AddWithValue("@IDDiretor", txtIDDiretor.Text);
                comando.Parameters.AddWithValue("@nome", txtNomeDiretor.Text);
                comando.Parameters.AddWithValue("@pais", txtPaisDiretor.Text);
                
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

        private void btnExibirDiretor_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "exec Exb_Diretor";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

                dtGridDiretor.DataSource = ds.Tables[0];

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

        private void btnConsultarDiretor_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "Exec Exb_DiretorBrasil";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

                dtGridDiretor.DataSource = ds.Tables[0];

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

        private void btnExcluirDiretor_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "DELETE FROM DIRETOR  WHERE IDDiretor = @IDDiretor";

                comando = new SqlCommand(strSQL, conexao);



                comando.Parameters.AddWithValue("@IDDiretor", txtIDDiretor.Text);

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
