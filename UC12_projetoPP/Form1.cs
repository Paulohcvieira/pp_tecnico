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
    public partial class FormLOGIN : Form
    {
        string tabela;
        string loginbd;
        string senhabd;
        
        public FormLOGIN()
        {
            InitializeComponent();
            ClassSQL.conexao = new MySqlConnection(ClassSQL.server);
            ClassSQL.comando = ClassSQL.conexao.CreateCommand();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLOGIN.Text != string.Empty & textBoxSENHA.Text != string.Empty)
            {
                ClassSQL.conexao.Open();
                ClassSQL.comando.CommandText = "SELECT login.login FROM login WHERE login.login = '"+ textBoxLOGIN.Text +"';";
                MySqlDataReader resultado;
                
                try
                {
                    resultado = ClassSQL.comando.ExecuteReader();
                    if (resultado.Read())
                    {
                        loginbd = resultado.GetString(0);
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
                // ===================================================================================
                ClassSQL.conexao.Open();
                ClassSQL.comando.CommandText = "SELECT login.senha FROM login WHERE senha = '"+ textBoxSENHA.Text +"';";
                MySqlDataReader resultado2;

                try
                {
                    resultado2 = ClassSQL.comando.ExecuteReader();
                    if (resultado2.Read())
                    {
                       senhabd = resultado2.GetString(0) ;
                       
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
                //=========================================================
                ClassSQL.conexao.Open();
                ClassSQL.comando.CommandText = "SELECT permissao FROM login WHERE login = '"+ textBoxLOGIN.Text +"';";
                MySqlDataReader resultado3;

                try
                {
                    resultado3 = ClassSQL.comando.ExecuteReader();
                    if (resultado3.Read())
                    {
                        ClassSQL.permissaobd = resultado3.GetString(0);

                    }
                }
                catch (Exception ERRO)
                {
                    MessageBox.Show(ERRO.Message);
                    MessageBox.Show("erro permissao");
                }
                finally
                {
                    if (ClassSQL.conexao.State == ConnectionState.Open)
                    {
                        ClassSQL.conexao.Close();
                    }
                }
                //=========================================================
                if (textBoxLOGIN.Text == loginbd && textBoxSENHA.Text == senhabd)
                {
                    
                    MessageBox.Show("Login Efetuado com sucesso");
                    Form formtela = new FormTELA();
                    formtela.Closed += (s, args) => this.Close();
                    formtela.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Login ou Senha incorretas");
                }
               

            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
