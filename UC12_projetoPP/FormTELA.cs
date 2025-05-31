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
    public partial class FormTELA : Form
    {

        public FormTELA()
        {
            InitializeComponent();
            ClassSQL.conexao = new MySqlConnection(ClassSQL.server);
            ClassSQL.comando = ClassSQL.conexao.CreateCommand();
            datagridprodutos();
            if (comboBoxCLIENTES.Text == string.Empty)
            {
                buttonSTARTVENDA.Enabled = false;
            }

            ClassSQL.conexao.Open();
            ClassSQL.comando.CommandText = "SELECT idcliente,nome_cliente FROM cliente;";
            MySqlDataReader resultado;
            try
            {
                resultado = ClassSQL.comando.ExecuteReader();

                while (resultado.Read())
                {
                    comboBoxCLIENTES.Items.Add(resultado["nome_cliente"]);
                }
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


        private void datagridprodutos()
        {
            ClassSQL.conexao.Open();
            ClassSQL.comando.CommandText = "SELECT servico AS 'Serviço',valor AS 'Valores' FROM servico;";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(ClassSQL.comando);
            DataTable tabelaLOG = new DataTable();
            adaptador.Fill(tabelaLOG);
            try
            {
                ClassSQL.comando.ExecuteNonQuery();
                dataGridCLIENTE.DataSource = tabelaLOG;
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


        private void FormTELA_Load(object sender, EventArgs e)
        {

        }



        private void buttonADICIONAR_Click(object sender, EventArgs e)
        {
            ClassSQL.conexao.Open();
            ClassSQL.comando.CommandText = "SELECT nome_cliente ;";


            try
            {
                ClassSQL.comando.ExecuteNonQuery();
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

        private void buttonRETIRAR_Click(object sender, EventArgs e)
        {

        }

        private void buttonPESQUISACLIENTE_Click(object sender, EventArgs e)
        {

        }

        private void dataGridCLIENTE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formcadastrar = new FormCADASTRAR();
            formcadastrar.Closed += (s, args) => this.Close();
            formcadastrar.Show();
            this.Hide();
        }

        private void relatoriomenustrip_Click(object sender, EventArgs e)
        {
            Form formRELATORIO = new FormRELATORIO();
            formRELATORIO.Closed += (s, args) => this.Close();
            formRELATORIO.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSTARTVENDA.Enabled = true;
        }

        private void buttonSTARTVENDA_Click(object sender, EventArgs e)
        {

        }
    }
}
