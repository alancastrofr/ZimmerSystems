using System;
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

        FrmInicio Frm = new FrmInicio();

        private void FrmSolicitud_Load(object sender, EventArgs e)
        {
            ConfigurarPantalla();
            
        }

        private void ConfigurarPantalla()
        {
            switch (Frm.UserVM.Pantalla)
            {
                case 1:
                    lblTitle.Text = "Nueva Solicitud";
                    this.Text = "Nueva Solicitud";
                    txtMotivoCancelacion.Visible = false;
                    lblMotivoCancelacion.Visible = false;
                    txtFolio.Enabled = false;
                    btnSolicitud.Text = "Crear Solicitud";
                    break;
                case 2:
                    lblTitle.Text = "Modificar Solicitud";
                    this.Text = "Modificar Solicitud";
                    txtMotivoCancelacion.Visible = false;
                    lblMotivoCancelacion.Visible = false;
                    btnSolicitud.Text = "Modificar Solicitud";

                    txtFolio.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtFecha.Enabled = false;
                    txtEquipo.Enabled = false;
                    txtModelo.Enabled = false;
                    txtMarca.Enabled = false;
                    txtColor.Enabled = false;
                    txtSerie.Enabled = false;
                    
                    break;
                case 3:
                    this.Text = "Cancelar Solicitud";
                    lblTitle.Text = "Cancelar Solicitud";
                    txtMotivoCancelacion.Visible = true;
                    lblMotivoCancelacion.Visible = true;
                    btnSolicitud.Text = "Cancelar Solicitud";

                    txtFolio.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtFecha.Enabled = false;
                    txtEquipo.Enabled = false;
                    txtModelo.Enabled = false;
                    txtMarca.Enabled = false;
                    txtColor.Enabled = false;
                    txtSerie.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            switch (Frm.UserVM.Pantalla)
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
                RequestVM vm = new RequestVM();
                vm.Name = txtNombre.Text;
                vm.LastName = txtApellido.Text;
                vm.Phone = txtTelefono.Text;
                vm.Address = txtDireccion.Text;
                vm.DateSolution = DateTime.Parse(txtFechaRegreso.Text);
                vm.EquipmentID = int.Parse(txtEquipo.Text); //Borrar!!!!!!!!!!!!!!
                vm.Model = txtModelo.Text;
                vm.Color = txtColor.Text;
                vm.S_N = txtSerie.Text;
                vm.ErrorDescription = txtDescripcion.Text;

                if (controller.ValidationEmptyTextNewRequest(vm))
                {
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

        private void ReglasCancelarSolicitud()
        {
            try
            {
                SolicitudController controller = new SolicitudController();
                RequestVM vm = new RequestVM();
                vm.CancelDescription = txtMotivoCancelacion.Text;

                if (controller.ValidationEmptyTextCancelRequest(vm))
                {
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

        private void ReglasModificarSolicitud()
        {
            try
            {
                SolicitudController controller = new SolicitudController();
                RequestVM vm = new RequestVM();
                //vm.Name = txtNombre.Text;
                //vm.LastName = txtApellido.Text;
                vm.Phone = txtTelefono.Text;
                //vm.Address = txtDireccion.Text;
                vm.DateSolution = DateTime.Parse(txtFechaRegreso.Text);
                //vm.EquipmentID = int.Parse(txtEquipo.Text); //Borrar!!!!!!!!!!!!!!
                //vm.Model = txtModelo.Text;
                //vm.Color = txtColor.Text;
                //vm.S_N = txtSerie.Text;
                vm.ErrorDescription = txtDescripcion.Text;

                if (controller.ValidationEmptyTextChangeRequest(vm))
                {
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

        
       
    }
}
