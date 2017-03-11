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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void bt_logar_Click(object sender, EventArgs e)
        {

            if (txtlogin.Text == "" || txtsenha.Text == "") {
                MessageBox.Show("Os campos login e senha são de preenchimento obrigatórios!");
            }
            else
            {

                SqlConnection strconn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbSistema;Data Source=MINIONS\SQLEXPRESS");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT count (*) FROM tbl_login WHERE usuario='" + txtlogin.Text + "' AND senha='" + txtsenha.Text + "'", strconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    Hide();

                    frm_principal ss = new frm_principal();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos!");

                }
                strconn.Close();
            }
        }

         private void bt_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
