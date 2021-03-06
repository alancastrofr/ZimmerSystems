﻿using System;
using System.Windows.Forms;
using ZimmerSystems.Controllers;
using ZimmerSystems.DataBases.ViewModel;

namespace ZimmerSystems
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        public static UserVM UserVM = new UserVM();

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.zs;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginController ln = new LoginController();
                if (ln.ValidationEmptyText(txtUser.Text, txtPassword.Text))
                {
                    UserVM = ln.ConsultarUsuario(txtUser.Text, txtPassword.Text);
                    if (!UserVM.ID.Equals(null) && !UserVM.ID.Equals(0))
                    {
                        if (UserVM.Active)
                        {
                            FrmMenuPrincipal fr = new FrmMenuPrincipal();
                            fr.Show();
                            this.Hide();
                        }
                        else
                            MessageBox.Show("Usuario Bloqueado");
                    }
                    else
                        MessageBox.Show("Usuario y/o Contraseña Incorrectos");
                }
                else
                    MessageBox.Show("Usuario y/o Contraseña Vacios");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conexion:" + ex.ToString());             
            }
            
        }
    }
}
