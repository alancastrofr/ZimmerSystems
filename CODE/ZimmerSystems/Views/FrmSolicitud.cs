using System;
using System.Drawing;
using System.Windows.Forms;
using ZimmerSystems.Controllers;
using ZimmerSystems.DataBases.ViewModel;

namespace ZimmerSystems
{
    public partial class FrmSolicitud : Form
    {
        public FrmSolicitud()
        {
            InitializeComponent();
        }

        UserVM VM = ZimmerSystems.FrmInicio.UserVM;

        private void FrmSolicitud_Load(object sender, EventArgs e)
        {
            ConfigurarPantalla();
        }       

        private void ConfigurarPantalla()
        {
            switch (VM.Pantalla)
            {
                case 1:
                    lblTitle.Text = "Nueva Solicitud";
                    this.Text = "Nueva Solicitud";
                    txtMotivoCancelacion.Visible = false;
                    lblMotivoCancelacion.Visible = false;
                    errorMotivoCancelacion.Hide();
                    txtFolio.Enabled = false;
                    btnSolicitud.Text = "Crear Solicitud";
                    btnBuscar.Hide();
                    dtpFecha.Text = DateTime.Today.ToString();
                    dtpFechaRegreso.MinDate = DateTime.Today;
                    dtpFecha.Enabled = false;
                    errorFecha.Hide();
                    break;
                case 2:
                    lblTitle.Text = "Modificar Solicitud";
                    this.Text = "Modificar Solicitud";
                    txtMotivoCancelacion.Visible = false;
                    lblMotivoCancelacion.Visible = false;
                    errorMotivoCancelacion.Hide();
                    btnSolicitud.Text = "Modificar Solicitud";

                    txtFolio.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtDireccion.Enabled = false;
                    dtpFecha.Enabled = false;
                    txtEquipo.Enabled = false;
                    txtModelo.Enabled = false;
                    txtMarca.Enabled = false;
                    txtColor.Enabled = false;
                    txtSerie.Enabled = false;

                    dtpFechaRegreso.MinDate = DateTime.Today;

                    errorNombre.Hide();
                    errorApellido.Hide();
                    errorDireccion.Hide();
                    errorFecha.Hide();
                    errorEquipo.Hide();
                    errorModelo.Hide();
                    errorMarca.Hide();
                    errorColor.Hide();
                    errorSerie.Hide();

                    break;
                case 3:
                    this.Text = "Cancelar Solicitud";
                    lblTitle.Text = "Cancelar Solicitud";
                    txtMotivoCancelacion.Visible = true;
                    lblMotivoCancelacion.Visible = true;
                    errorMotivoCancelacion.Show();
                    btnSolicitud.Text = "Cancelar Solicitud";

                    txtFolio.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtDireccion.Enabled = false;
                    dtpFecha.Enabled = false;
                    txtEquipo.Enabled = false;
                    txtModelo.Enabled = false;
                    txtMarca.Enabled = false;
                    txtColor.Enabled = false;
                    txtSerie.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtDescripcion.Enabled = false;
                    dtpFechaRegreso.Enabled = false;

                    errorNombre.Hide();
                    errorApellido.Hide();
                    errorDireccion.Hide();
                    errorFecha.Hide();
                    errorEquipo.Hide();
                    errorModelo.Hide();
                    errorMarca.Hide();
                    errorColor.Hide();
                    errorSerie.Hide();
                    errorTelefono.Hide();
                    errorDescripcion.Hide();
                    errorFechaRetorno.Hide();

                    break;
                default:
                    break;
            }
        }

        private void BtnSolicitud_Click(object sender, EventArgs e)
        {
            switch (VM.Pantalla)
            {
                case 1: ReglasnCrearSolicitud();
                    break;
                case 2: ReglasModificarSolicitud();
                    break;
                case 3: ReglasCancelarSolicitud();
                    break;
                default:
                    break;
            }
        }

        private void ReglasnCrearSolicitud()
        {
            try
            {
                SolicitudController controller = new SolicitudController();                               

                if (ValidationEmptyTextNewRequest())
                {
                    RequestVM vm = new RequestVM();

                    vm.Name = txtNombre.Text;
                    vm.LastName = txtApellido.Text;
                    vm.Phone = txtTelefono.Text;
                    vm.Address = txtDireccion.Text;
                    vm.DateSolution = DateTime.Parse(dtpFechaRegreso.Text);
                    vm.EquipmentID = int.Parse(txtEquipo.Text);
                    vm.Model = txtModelo.Text;
                    vm.Color = txtColor.Text;
                    vm.S_N = txtSerie.Text;
                    vm.ErrorDescription = txtDescripcion.Text;
                    vm.Status = "En Progreso";

                    if (controller.CreateRequest(vm))
                    {
                        MessageBox.Show("Solicitud Creada");
                    }
                    else
                        MessageBox.Show("Error al guardar");

                }
                else
                    MessageBox.Show("Ingresar Datos Requeridos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString() );
            }
            
        }

        private bool ValidationEmptyTextNewRequest()
        {
            bool validado = true;

            if (txtNombre.Text.Equals("") || txtNombre.Text.Equals(null))
            {
                txtNombre.BackColor = Color.Firebrick;
                errorNombre.Show();
                validado = false;
            }

            if (txtApellido.Text.Equals(""))
            {
                txtApellido.BackColor = Color.Firebrick;
                errorApellido.Show();
                validado = false;
            }

            if (txtTelefono.Text.Equals(""))
            {
                txtTelefono.BackColor = Color.Firebrick;
                errorTelefono.Show();
                validado = false;
            }

            if (txtDireccion.Text.Equals(""))
            {
                txtDireccion.BackColor = Color.Firebrick;
                errorDireccion.Show();
                validado = false;
            }

            if (txtEquipo.Text.Equals(""))
            {
                txtEquipo.BackColor = Color.Firebrick;
                errorEquipo.Show();
                validado = false;
            }

            if (txtModelo.Text.Equals(""))
            {
                txtModelo.BackColor = Color.Firebrick;
                errorModelo.Show();
                validado = false;
            }

            if (txtColor.Text.Equals(""))
            {
                txtColor.BackColor = Color.Firebrick;
                errorColor.Show();
                validado = false;
            }

            if (txtSerie.Text.Equals(""))
            {
                txtSerie.BackColor = Color.Firebrick;
                errorSerie.Show();
                validado = false;
            }

            if (txtDescripcion.Text.Equals(""))
            {
                txtDescripcion.BackColor = Color.Firebrick;
                errorDescripcion.Show();
                validado = false;
            }

            if (txtMarca.Text.Equals(""))
            {
                txtMarca.BackColor = Color.Firebrick;
                errorMarca.Show();
                validado = false;
            }

            if (dtpFechaRegreso.Text.Equals(""))
            {
                dtpFechaRegreso.BackColor = Color.Firebrick;
                errorFechaRetorno.Show();
                validado = false;
            }

            return validado;
        }

        private void ReglasModificarSolicitud()
        {
            try
            {
                SolicitudController controller = new SolicitudController();

                if (ValidationEmptyTextChangeRequest())
                {

                    RequestVM vm = new RequestVM();

                    vm.Folio = int.Parse(txtFolio.Text);
                    vm.Phone = txtTelefono.Text;
                    vm.DateSolution = DateTime.Parse(dtpFechaRegreso.Text);
                    vm.ErrorDescription = txtDescripcion.Text;

                    if (controller.ChangeRequest(vm))
                    {
                        MessageBox.Show("Solicitud Modificada");
                    }
                    else
                        MessageBox.Show("Error al Modificar");

                }
                else
                    MessageBox.Show("Ingresar Datos Requeridos");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.ToString());
            }
        }

        private bool ValidationEmptyTextChangeRequest()
        {
            bool validado = true;

            if (txtTelefono.Text.Equals(""))
            {
                txtTelefono.BackColor = Color.Firebrick;
                errorTelefono.Show();
                validado = false;
            }

            if (txtDescripcion.Text.Equals(""))
            {
                txtDescripcion.BackColor = Color.Firebrick;
                errorDescripcion.Show();
                validado = false;
            }

            if (dtpFechaRegreso.Text.Equals(""))
            {
                dtpFechaRegreso.BackColor = Color.Firebrick;
                errorFechaRetorno.Show();
                validado = false;
            }

            if (txtMotivoCancelacion.Text.Equals(""))
            {
                txtMotivoCancelacion.BackColor = Color.Firebrick;
                errorFechaRetorno.Show();
                validado = false;
            }

            return validado;
        }

        private void ReglasCancelarSolicitud()
        {
            try
            {
                SolicitudController controller = new SolicitudController();
                
                if (ValidationEmptyTextCancelRequest())
                {
                    RequestVM vm = new RequestVM();

                    vm.Folio = int.Parse(txtFolio.Text);
                    vm.CancelDescription = txtMotivoCancelacion.Text;
                    vm.Status = "Cancelado";

                    if (controller.CancelRequest(vm))
                    {
                        MessageBox.Show("Solicitud Cancelada");
                    }
                    else
                        MessageBox.Show("Error al Cancelar");

                }
                else
                    MessageBox.Show("Ingresar Datos Requeridos");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.ToString());
            }
        }

        private bool ValidationEmptyTextCancelRequest()
        {
            bool validado = true;

            if (txtMotivoCancelacion.Text.Equals(""))
            {
                txtMotivoCancelacion.BackColor = Color.Firebrick;
                errorMotivoCancelacion.Show();
                validado = false;
            }            

            return validado;
        }


        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.White;
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            txtApellido.BackColor = Color.White;
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.BackColor = Color.White;
        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {
            txtDireccion.BackColor = Color.White;
        }

        private void TxtMotivoCancelacion_TextChanged(object sender, EventArgs e)
        {
            txtMotivoCancelacion.BackColor = Color.White;
        }

        private void TxtEquipo_TextChanged(object sender, EventArgs e)
        {
            txtEquipo.BackColor = Color.White;
        }

        private void TxtModelo_TextChanged(object sender, EventArgs e)
        {
            txtModelo.BackColor = Color.White;
        }

        private void TxtMarca_TextChanged(object sender, EventArgs e)
        {
            txtMarca.BackColor = Color.White;
        }

        private void TxtColor_TextChanged(object sender, EventArgs e)
        {
            txtColor.BackColor = Color.White;
        }

        private void TxtSerie_TextChanged(object sender, EventArgs e)
        {
            txtSerie.BackColor = Color.White;
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = Color.White;
        }
    }
}
