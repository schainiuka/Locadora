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
    public partial class Filme : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;
        public Filme()
        {
            InitializeComponent();
        }

        private void btnInserirFilme_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "INSERT INTO Filme (Titulo, FaixaEtaria, IDDiretor, STATUS) VALUES (@Titulo, @FaixaEtaria, @IDDiretor, @STATUS)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@Titulo", txtTituloFilme.Text);
                comando.Parameters.AddWithValue("@FaixaEtaria", txtFaixaFilme.Text);
                comando.Parameters.AddWithValue("@IDDiretor", txtIDDIretorFilme.Text);
                comando.Parameters.AddWithValue("@STATUS", txtStatusFilme.Text);


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

        private void btnAlterarFilme_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "UPDATE Filme set Titulo = @Titulo, FaixaEtaria = @FaixaEtaria, IDDiretor = @IDDiretor, STATUS = @STATUS WHERE IDFilme = @IDFilme";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@IDFilme", txtIDFilme.Text);
                comando.Parameters.AddWithValue("@Titulo", txtTituloFilme.Text);
                comando.Parameters.AddWithValue("@FaixaEtaria", txtFaixaFilme.Text);
                comando.Parameters.AddWithValue("@IDDiretor", txtIDDIretorFilme.Text);
                comando.Parameters.AddWithValue("@Status", txtStatusFilme.Text);
     

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

        private void btnExibirFilme_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "exec Exb_Filme";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

                dtGridFilme.DataSource = ds.Tables[0];

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

        private void btnConsultarFilme_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "Exec Exb_ConsultaMais18";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

               dtGridFilme.DataSource = ds.Tables[0];

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

        private void btnExcluirFilme_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "DELETE FROM FILME  WHERE IDFilme = @IDFilme";

                comando = new SqlCommand(strSQL, conexao);



                comando.Parameters.AddWithValue("@IDDiretor", txtIDFilme.Text);

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
