using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZimmerSystems
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
        }

        private void almacemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalendario frmCalendario = new FrmCalendario();
            frmCalendario.Show();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
