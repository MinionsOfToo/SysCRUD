using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace syscrud
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
         InitializeComponent();
        }

        private void frm_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void atendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frm_atendentes aten = new frm_atendentes();
            aten.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            frm_atendentes aten = new frm_atendentes();

            aten.Show();
        }
    }
}
