using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExMenu
{
    public partial class FrmAzul : Form
    {
        public FrmAzul()
        {
            InitializeComponent();
        }

        private void fomrAzulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAzul frm = new FrmAzul(); // indico qual sera aberto
            this.Hide(); // fechar o atual
            frm.ShowDialog();
        }

        private void forrmPretoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPreto frm = new FrmPreto(); // indico qual sera aberto
            this.Hide(); // fechar o atual
            frm.ShowDialog();
        }

        private void formVermelhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVermelho frm = new FrmVermelho(); // indico qual sera aberto
            this.Hide(); // fechar o atual
            frm.ShowDialog();
        }
    }
}
