using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZimmerSystems.Controllers;

namespace ZimmerSystems
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.zs;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Login ln = new Login();
                ln.validateConnection();
                MessageBox.Show("Conexion Estable");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conexion:" + ex.ToString());             
            }
            
        }
    }
}
