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
    public partial class Aluguel : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;
        public Aluguel()
        {
            InitializeComponent();
        }

        private void Aluguel_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnInserirAlug_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "INSERT INTO Aluguel (IDCliente, DataAlug, DataDevolucao, ValorTotal) VALUES (@IDCliente, getdate(), getdate() + 5, round(replace(@valor, ',', '.'), 2))";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@IDCliente", txtIDClienteAlug.Text);
                comando.Parameters.AddWithValue("@Valor", txtValorAlug.Text);
                
            

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

        private void btnAlterarAlug_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "UPDATE Aluguel set IDCliente = @IDcliente, Valor = @Valor WHERE IDAlug = @IDAlug; " +
                         "UPDATE AluguelItem set IDCliente = @IDCLiente where IDAlug = @IDAlug";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@IDAlug", txtIDAlug.Text);
                comando.Parameters.AddWithValue("@IDCliente", txtIDClienteAlug.Text);
                comando.Parameters.AddWithValue("@Valor", txtValorAlug.Text);
            

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

        private void btnExibirAlug_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "SELECT * FROM ALUGUEL";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

                dtGridViewAlug.DataSource = ds.Tables[0];

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

        private void btnConsultarAlug_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "SELECT * FROM ALUGUEL where ValorTotal > 15";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

                dtGridViewAlug.DataSource = ds.Tables[0];

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

        private void btnExcluirAlug_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "DELETE FROM ALUGUEL  WHERE IDAlug = @IDAlug";

                comando = new SqlCommand(strSQL, conexao);



                comando.Parameters.AddWithValue("@IDAlug", txtIDAlug.Text);

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

        private void btnDevolvido_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "UPDATE Filme set status = 1 where IDFilme in (select IDFilme from AluguelItem where IDALug = @IDAlug)"; 

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@IDAlug", txtIDAlug.Text);
              

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

        private void btnExibirAlugFilmes_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "SELECT * FROM Filme Where status = 1";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

                dtGridAlugFilme.DataSource = ds.Tables[0];

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

        private void btnInserirAlugFilm_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "INSERT INTO AluguelItem (IDFilme, NomeFilme, IDDiretor, IDCliente, IDAlug) " +
                         "VALUES (@IDFilme, (Select titulo from filme where idfilme = @IDFilme), " +
                         "(select IDDiretor from filme where idfilme = @IDFilme), @IDCliente, (select max(idAlug) from aluguel))";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@IDCliente", txtIDClienteAlug.Text);
                comando.Parameters.AddWithValue("@IDFilme", txtIDFilmeAlug.Text);

                
                


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

        private void btnSalvarAlug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAPTOP-5P03T2RI\BDGUSTAVO ;Database=locadoras ; User Id=sa ;Password = nargazap69;");

                strSQL = "Exec Exb_Clientes";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

                dtGridViewAlug.DataSource = ds.Tables[0];

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
    }
}
