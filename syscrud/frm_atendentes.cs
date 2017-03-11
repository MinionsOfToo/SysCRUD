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

namespace syscrud
{
    public partial class frm_atendentes : Form
    {
        public frm_atendentes()
        {
            InitializeComponent();
        }

        private void frm_atendentes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbSistemaDataSet.tbl_login'. Você pode movê-la ou removê-la conforme necessário.
           

        }

       

        private void frm_atendentes_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_principal prin = new frm_principal();
            prin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnome.Text = "";
            txtpass.Text = "";
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "" || txtpass.Text =="")
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatórios!");
            }
            else
            {
                //string de conexao
                SqlConnection sqlcon = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbSistema;Data Source=MINIONS\SQLEXPRESS");
                SqlCommand comm = new SqlCommand("INSERT INTO tbl_login(usuario, senha) VALUES(@usuario, @senha)", sqlcon);
                comm.Parameters.AddWithValue("@usuario", SqlDbType.VarChar).Value = txtnome.Text;
                comm.Parameters.AddWithValue("@senha", SqlDbType.VarChar).Value = txtpass.Text;
                try
                {
                    sqlcon.Open();
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Atendente cadastrado com sucesso!", "Cadastro de atemdentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlcon.Close();
                }
                txtnome.Text = "";
                txtpass.Text = "";
            }
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

        
    }


