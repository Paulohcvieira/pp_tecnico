using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UC12_projetoPP
{
    public partial class FormRELATORIO : Form
    {
        public FormRELATORIO()
        {
            InitializeComponent();
            ClassSQL.conexao = new MySqlConnection(ClassSQL.server);
            ClassSQL.comando = ClassSQL.conexao.CreateCommand();
        }
        private void datagridPESSOASTECNICO()
        {
            ClassSQL.conexao.Open();
            ClassSQL.comando.CommandText = "SELECT nome AS 'Nomes',permissao AS 'Permissão' FROM login;";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(ClassSQL.comando);
            DataTable tabelaLOG = new DataTable();
            adaptador.Fill(tabelaLOG);
            try
            {
                ClassSQL.comando.ExecuteNonQuery();
                dataGridRELATORIO.DataSource = tabelaLOG;
            }
            catch (Exception ERRO)
            {
                MessageBox.Show(ERRO.Message);
            }
            finally
            {
                if (ClassSQL.conexao.State == ConnectionState.Open)
                {
                    ClassSQL.conexao.Close();
                }
            }
        }
        private void datagridPESSOASCADASTRADAS()
        {
            ClassSQL.conexao.Open();
            ClassSQL.comando.CommandText = "SELECT nome_cliente AS 'Clientes',contato AS 'Contato' FROM cliente;";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(ClassSQL.comando);
            DataTable tabelaLOG = new DataTable();
            adaptador.Fill(tabelaLOG);
            try
            {
                ClassSQL.comando.ExecuteNonQuery();
                dataGridRELATORIO.DataSource = tabelaLOG;
            }
            catch (Exception ERRO)
            {
                MessageBox.Show(ERRO.Message);
            }
            finally
            {
                if (ClassSQL.conexao.State == ConnectionState.Open)
                {
                    ClassSQL.conexao.Close();
                }
            }
        }
        private void datagridSTATUS()
        {
            ClassSQL.conexao.Open();
            ClassSQL.comando.CommandText = "SELECT nome_cliente AS 'Clientes',servico AS 'Serviços',status,descricao FROM cliente INNER JOIN servico ON (servico.fk_cliente = cliente.idcliente);";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(ClassSQL.comando);
            DataTable tabelaLOG = new DataTable();
            adaptador.Fill(tabelaLOG);
            try
            {
                ClassSQL.comando.ExecuteNonQuery();
                dataGridRELATORIO.DataSource = tabelaLOG;
            }
            catch (Exception ERRO)
            {
                MessageBox.Show(ERRO.Message);
            }
            finally
            {
                if (ClassSQL.conexao.State == ConnectionState.Open)
                {
                    ClassSQL.conexao.Close();
                }
            }
        }
        private void FormRELATORIO_Load(object sender, EventArgs e)
        {

        }

        private void PrincipalMENUSTRIP_Click(object sender, EventArgs e)
        {
            Form formtela = new FormTELA();
            formtela.Closed += (s, args) => this.Close();
            formtela.Show();
            this.Hide();
        }

        private void cadastrarMENUSTRIP_Click(object sender, EventArgs e)
        {
            Form formCADASTRAR = new FormCADASTRAR();
            formCADASTRAR.Closed += (s, args) => this.Close();
            formCADASTRAR.Show();
            this.Hide();
        }

        private void buttonPESQUISA_Click(object sender, EventArgs e)
        {
            if (checkBoxPESQUISACLIENTES.Checked)
            {
                datagridPESSOASCADASTRADAS();
                ClassSQL.conexao.Open();
                ClassSQL.comando.CommandText = "SELECT nome_cliente AS 'Clientes',contato AS 'Contato' FROM cliente WHERE nome_cliente like '" + textBoxRELATORIO.Text + "%';";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(ClassSQL.comando);
                DataTable tabelaLOG = new DataTable();
                adaptador.Fill(tabelaLOG);
                try
                {
                    ClassSQL.comando.ExecuteNonQuery();
                    dataGridRELATORIO.DataSource = tabelaLOG;
                }
                catch (Exception ERRO)
                {
                    MessageBox.Show(ERRO.Message);
                }
                finally
                {
                    if (ClassSQL.conexao.State == ConnectionState.Open)
                    {
                        ClassSQL.conexao.Close();
                    }
                }
            }
            if (checkBoxPESQUISATECNICO.Checked)
            {
                datagridPESSOASTECNICO();
                ClassSQL.conexao.Open();
                ClassSQL.comando.CommandText = "SELECT nome AS 'Nomes',permissao AS 'Permissão' FROM login WHERE nome like '" + textBoxRELATORIO.Text + "%';";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(ClassSQL.comando);
                DataTable tabelaLOG = new DataTable();
                adaptador.Fill(tabelaLOG);
                try
                {
                    ClassSQL.comando.ExecuteNonQuery();
                    dataGridRELATORIO.DataSource = tabelaLOG;
                }
                catch (Exception ERRO)
                {
                    MessageBox.Show(ERRO.Message);
                }
                finally
                {
                    if (ClassSQL.conexao.State == ConnectionState.Open)
                    {
                        ClassSQL.conexao.Close();
                    }
                }
            }
        }

        private void checkBoxPESQUISATECNICO_CheckedChanged(object sender, EventArgs e)
        {
            datagridPESSOASTECNICO();
        }

        private void checkBoxPESQUISACLIENTES_CheckedChanged(object sender, EventArgs e)
        {
            datagridPESSOASCADASTRADAS();
        }

        private void checkBoxSERVICOS_CheckedChanged(object sender, EventArgs e)
        {
            datagridSTATUS();
        }
    }
}
