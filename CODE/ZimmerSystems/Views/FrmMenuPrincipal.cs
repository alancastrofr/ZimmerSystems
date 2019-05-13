using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZimmerSystems
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        FrmInicio FrmInicio = new FrmInicio();
        
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
        }

        private void AlmacemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CalendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalendario frmCalendario = new FrmCalendario();
            frmCalendario.Show();
        }

        private void HistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NuevaSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            FrmInicio.UserVM.Pantalla = 1;
            FrmSolicitud fr = new FrmSolicitud();
            fr.Show();            
        }

        private void modificarSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInicio.UserVM.Pantalla = 2;
            FrmSolicitud fr = new FrmSolicitud();
            fr.Show();
        }

        private void cancelarSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInicio.UserVM.Pantalla = 3;
            FrmSolicitud fr = new FrmSolicitud();
            fr.Show();
        }
    }
}
