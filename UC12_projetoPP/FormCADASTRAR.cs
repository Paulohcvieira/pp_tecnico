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
    public partial class FormCADASTRAR : Form
    {
        string tipocadastro = "";
        public FormCADASTRAR()
        {
            InitializeComponent();
            ClassSQL.conexao = new MySqlConnection(ClassSQL.server);
            ClassSQL.comando = ClassSQL.conexao.CreateCommand();
            if (ClassSQL.permissaobd == "ADM")
            {
                checkBoxADM.Enabled = true;
                relatoriomenustrip.Enabled = true;
                panelSERVICO.Enabled = true;
                textBoxCADASTROLOGIN.Enabled = true;
                textBoxCADASTROSENHA.Enabled = true;
                checkBoxTECNICO.Enabled = true;
            }
            else
            {
                checkBoxTECNICO.Enabled = false;
                checkBoxADM.Enabled = false;
                relatoriomenustrip.Enabled = false;
                panelSERVICO.Enabled = false;
                textBoxCADASTROLOGIN.Enabled = false;
                textBoxCADASTROSENHA.Enabled = false;
            }
            
            buttonCONFIRMCLIENTE.Enabled = false;
            textBoxCONTATO.Enabled = false;
            textBoxCADASTRONOME.Enabled = false;
            textBoxCADASTROLOGIN.Enabled = false;
            textBoxCADASTROSENHA.Enabled = false;
            textBoxSERVICOCADASTRO.Enabled = false;
            textBoxVALORCADASTRO.Enabled = false;
            buttonCADASTROSERVICO.Enabled = false;


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
                dataGridPESSOAS.DataSource = tabelaLOG;
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
                dataGridPESSOAS.DataSource = tabelaLOG;
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
        private void FormCADASTRAR_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxUSUARIO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUSUARIO.Checked)
            {
                textBoxCADASTRONOME.Enabled = true;
                textBoxCONTATO.Enabled = true;
                buttonCONFIRMCLIENTE.Enabled = true;
            }
            else
            {
                textBoxCADASTRONOME.Enabled = false;
                textBoxCONTATO.Enabled = false;
                buttonCONFIRMCLIENTE.Enabled = false;
            }
        }

        private void checkBoxTECNICO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTECNICO.Checked)
            {
                textBoxCADASTRONOME.Enabled = true;
                textBoxCADASTROLOGIN.Enabled = true;
                textBoxCADASTROSENHA.Enabled = true;
                buttonCONFIRMCLIENTE.Enabled = true;
            }
            else
            {
                textBoxCADASTRONOME.Enabled = false;
                textBoxCADASTROLOGIN.Enabled = false;
                textBoxCADASTROSENHA.Enabled = false;
                buttonCONFIRMCLIENTE.Enabled = false;
            }
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formtela = new FormTELA();
            formtela.Closed += (s, args) => this.Close();
            formtela.Show();
            this.Hide();
        }

        private void buttonCONFIRMCLIENTE_Click(object sender, EventArgs e)
        {
            string permitcadastro = "";
            string permitnumero = "";
            if (checkBoxTECNICO.Checked || checkBoxADM.Checked)
            {
                ClassSQL.conexao.Open();
                ClassSQL.comando.CommandText = "SELECT login.login FROM login WHERE login.login = '" + textBoxCADASTROLOGIN.Text + "' ;";
                MySqlDataReader resultado;

                try
                {
                    resultado = ClassSQL.comando.ExecuteReader();
                    if (resultado.Read())
                    {
                        permitcadastro = resultado.GetString(0);
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
            if (checkBoxUSUARIO.Checked)
            {
                ClassSQL.conexao.Open();
                ClassSQL.comando.CommandText = "SELECT contato FROM cliente WHERE  contato = '" + textBoxCONTATO.Text + "';";
                MySqlDataReader resultado3;

                try
                {
                    resultado3 = ClassSQL.comando.ExecuteReader();
                    if (resultado3.Read())
                    {
                        permitnumero = resultado3.GetString(0);
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
                if (permitnumero == "")
                {
                    ClassSQL.conexao.Open();
                    ClassSQL.comando.CommandText = "INSERT INTO cliente (nome_cliente,contato) VALUES ('" + textBoxCADASTRONOME.Text + "','" + textBoxCONTATO.Text + "');";
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
                else
                {
                    MessageBox.Show("Número de telefone ja cadastrado");
                }
            }
           

            if (permitcadastro == "")
            {
                if (checkBoxTECNICO.Checked)
                {
                    ClassSQL.conexao.Open();
                    ClassSQL.comando.CommandText = "INSERT INTO login (login,senha,nome,permissao) VALUES ('" + textBoxCADASTROLOGIN.Text + "','" + textBoxCADASTROSENHA.Text + "','" + textBoxCADASTRONOME.Text + "','Técnico');";
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
                if (checkBoxADM.Checked)
                {
                    ClassSQL.conexao.Open();
                    ClassSQL.comando.CommandText = "INSERT INTO login (login,senha,nome,permissao) VALUES ('" + textBoxCADASTROLOGIN.Text + "','" + textBoxCADASTROSENHA.Text + "','" + textBoxCADASTRONOME.Text + "','ADM');";
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
                textBoxCADASTRONOME.Text = string.Empty;
                textBoxCADASTROLOGIN.Text = string.Empty;
                textBoxCADASTROSENHA.Text = string.Empty;
                textBoxCONTATO.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Login ou Senha ja cadastrados");
            }

            datagridPESSOASCADASTRADAS();
        }

        private void buttonPESQUISACLIENTE_Click(object sender, EventArgs e)
        {
            if (checkBoxPESQUISACLIENTES.Checked)
            {
                datagridPESSOASCADASTRADAS();
                ClassSQL.conexao.Open();
                ClassSQL.comando.CommandText = "SELECT nome_cliente AS 'Clientes',contato AS 'Contato' FROM cliente WHERE nome_cliente like '" + textBoxPESQUISACADASTRO.Text + "%';";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(ClassSQL.comando);
                DataTable tabelaLOG = new DataTable();
                adaptador.Fill(tabelaLOG);
                try
                {
                    ClassSQL.comando.ExecuteNonQuery();
                    dataGridPESSOAS.DataSource = tabelaLOG;
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
                ClassSQL.comando.CommandText = "SELECT nome AS 'Nomes',permissao AS 'Permissão' FROM login WHERE nome like '" + textBoxPESQUISACADASTRO.Text + "%';";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(ClassSQL.comando);
                DataTable tabelaLOG = new DataTable();
                adaptador.Fill(tabelaLOG);
                try
                {
                    ClassSQL.comando.ExecuteNonQuery();
                    dataGridPESSOAS.DataSource = tabelaLOG;
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

        private void relatoriomenustrip_Click(object sender, EventArgs e)
        {
            Form formRELATORIO = new FormRELATORIO();
            formRELATORIO.Closed += (s, args) => this.Close();
            formRELATORIO.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string permitservico = "";
            ClassSQL.conexao.Open();
            ClassSQL.comando.CommandText = "SELECT servico FROM servico WHERE servico = '" + textBoxSERVICOCADASTRO.Text + "';";
            MySqlDataReader resultado2;

            try
            {
                resultado2 = ClassSQL.comando.ExecuteReader();
                if (resultado2.Read())
                {
                    permitservico = resultado2.GetString(0);
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
            if (textBoxSERVICOCADASTRO.Text != string.Empty && textBoxVALORCADASTRO.Text != string.Empty)
            {
                if (permitservico == "")
                {
                    ClassSQL.conexao.Open();
                    ClassSQL.comando.CommandText = "INSERT INTO servico (valor,servico) VALUES (" + textBoxVALORCADASTRO.Text + ",'" + textBoxSERVICOCADASTRO.Text + "');";
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
            }
            else
            {
                MessageBox.Show("Preencha os campos acima corretamente");
            }
            textBoxVALORCADASTRO.Text = string.Empty;
            textBoxSERVICOCADASTRO.Text = string.Empty;
        }

        private void checkboxPERMITIRCADASTROSERVICO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxPERMITIRCADASTROSERVICO.Checked)
            {
                textBoxSERVICOCADASTRO.Enabled = true;
                textBoxVALORCADASTRO.Enabled = true;
                buttonCADASTROSERVICO.Enabled = true;


            }
            else
            {
                textBoxSERVICOCADASTRO.Enabled = false;
                textBoxVALORCADASTRO.Enabled = false;
                buttonCADASTROSERVICO.Enabled = false;

            }
        }

        private void checkBoxADM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxADM.Checked)
            {
                textBoxCADASTRONOME.Enabled = true;
                textBoxCADASTROLOGIN.Enabled = true;
                textBoxCADASTROSENHA.Enabled = true;
                buttonCONFIRMCLIENTE.Enabled = true;
            }
            else
            {
                textBoxCADASTRONOME.Enabled = false;
                textBoxCADASTROLOGIN.Enabled = false;
                textBoxCADASTROSENHA.Enabled = false;
                buttonCONFIRMCLIENTE.Enabled = false;
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
    }
}
