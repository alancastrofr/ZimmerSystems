namespace ZimmerSystems
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteSemanalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogosToolStripMenuItem,
            this.calendarioToolStripMenuItem,
            this.almacemToolStripMenuItem,
            this.historialToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaSolicitudToolStripMenuItem,
            this.modificarSolicitudToolStripMenuItem,
            this.cancelarSolicitudToolStripMenuItem});
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.calendarioToolStripMenuItem.Text = "Solicitudes";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.CalendarioToolStripMenuItem_Click);
            // 
            // nuevaSolicitudToolStripMenuItem
            // 
            this.nuevaSolicitudToolStripMenuItem.Name = "nuevaSolicitudToolStripMenuItem";
            this.nuevaSolicitudToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.nuevaSolicitudToolStripMenuItem.Text = "Nueva Solicitud";
            this.nuevaSolicitudToolStripMenuItem.Click += new System.EventHandler(this.NuevaSolicitudToolStripMenuItem_Click);
            // 
            // modificarSolicitudToolStripMenuItem
            // 
            this.modificarSolicitudToolStripMenuItem.Name = "modificarSolicitudToolStripMenuItem";
            this.modificarSolicitudToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.modificarSolicitudToolStripMenuItem.Text = "Modificar Solicitud";
            this.modificarSolicitudToolStripMenuItem.Click += new System.EventHandler(this.modificarSolicitudToolStripMenuItem_Click);
            // 
            // cancelarSolicitudToolStripMenuItem
            // 
            this.cancelarSolicitudToolStripMenuItem.Name = "cancelarSolicitudToolStripMenuItem";
            this.cancelarSolicitudToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.cancelarSolicitudToolStripMenuItem.Text = "Cancelar Solicitud";
            this.cancelarSolicitudToolStripMenuItem.Click += new System.EventHandler(this.cancelarSolicitudToolStripMenuItem_Click);
            // 
            // almacemToolStripMenuItem
            // 
            this.almacemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReporteSemanalToolStripMenuItem,
            this.generarReporteMensualToolStripMenuItem});
            this.almacemToolStripMenuItem.Name = "almacemToolStripMenuItem";
            this.almacemToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.almacemToolStripMenuItem.Text = "Almacen";
            this.almacemToolStripMenuItem.Click += new System.EventHandler(this.AlmacemToolStripMenuItem_Click);
            // 
            // generarReporteSemanalToolStripMenuItem
            // 
            this.generarReporteSemanalToolStripMenuItem.Name = "generarReporteSemanalToolStripMenuItem";
            this.generarReporteSemanalToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.generarReporteSemanalToolStripMenuItem.Text = "Generar Reporte Semanal";
            // 
            // generarReporteMensualToolStripMenuItem
            // 
            this.generarReporteMensualToolStripMenuItem.Name = "generarReporteMensualToolStripMenuItem";
            this.generarReporteMensualToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.generarReporteMensualToolStripMenuItem.Text = "Generar Reporte Mensual";
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.HistorialToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accercaDeToolStripMenuItem,
            this.versionToolStripMenuItem,
            this.contactoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // accercaDeToolStripMenuItem
            // 
            this.accercaDeToolStripMenuItem.Name = "accercaDeToolStripMenuItem";
            this.accercaDeToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.accercaDeToolStripMenuItem.Text = "Soporte";
            this.accercaDeToolStripMenuItem.Click += new System.EventHandler(this.AccercaDeToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.VersionToolStripMenuItem_Click);
            // 
            // contactoToolStripMenuItem
            // 
            this.contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            this.contactoToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.contactoToolStripMenuItem.Text = "Contacto";
            this.contactoToolStripMenuItem.Click += new System.EventHandler(this.ContactoToolStripMenuItem_Click);
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equiposToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.tiposToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.rolesToolStripMenuItem});
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.bajaToolStripMenuItem});
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.equiposToolStripMenuItem.Text = "Equipos";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.bajaToolStripMenuItem.Text = "Baja";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem1,
            this.bajaToolStripMenuItem1});
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.MarcasToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.nuevoToolStripMenuItem1.Text = "Nueva";
            this.nuevoToolStripMenuItem1.Click += new System.EventHandler(this.NuevoToolStripMenuItem1_Click);
            // 
            // bajaToolStripMenuItem1
            // 
            this.bajaToolStripMenuItem1.Name = "bajaToolStripMenuItem1";
            this.bajaToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.bajaToolStripMenuItem1.Text = "Baja";
            // 
            // tiposToolStripMenuItem
            // 
            this.tiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem2,
            this.bajaToolStripMenuItem2});
            this.tiposToolStripMenuItem.Name = "tiposToolStripMenuItem";
            this.tiposToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.tiposToolStripMenuItem.Text = "Tipos";
            // 
            // nuevoToolStripMenuItem2
            // 
            this.nuevoToolStripMenuItem2.Name = "nuevoToolStripMenuItem2";
            this.nuevoToolStripMenuItem2.Size = new System.Drawing.Size(180, 26);
            this.nuevoToolStripMenuItem2.Text = "Nuevo";
            // 
            // bajaToolStripMenuItem2
            // 
            this.bajaToolStripMenuItem2.Name = "bajaToolStripMenuItem2";
            this.bajaToolStripMenuItem2.Size = new System.Drawing.Size(180, 26);
            this.bajaToolStripMenuItem2.Text = "Baja";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem3,
            this.modificarToolStripMenuItem,
            this.bajaToolStripMenuItem3});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // nuevoToolStripMenuItem3
            // 
            this.nuevoToolStripMenuItem3.Name = "nuevoToolStripMenuItem3";
            this.nuevoToolStripMenuItem3.Size = new System.Drawing.Size(180, 26);
            this.nuevoToolStripMenuItem3.Text = "Nuevo";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // bajaToolStripMenuItem3
            // 
            this.bajaToolStripMenuItem3.Name = "bajaToolStripMenuItem3";
            this.bajaToolStripMenuItem3.Size = new System.Drawing.Size(180, 26);
            this.bajaToolStripMenuItem3.Text = "Baja";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem4,
            this.bajaToolStripMenuItem4});
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // nuevoToolStripMenuItem4
            // 
            this.nuevoToolStripMenuItem4.Name = "nuevoToolStripMenuItem4";
            this.nuevoToolStripMenuItem4.Size = new System.Drawing.Size(180, 26);
            this.nuevoToolStripMenuItem4.Text = "Nuevo";
            // 
            // bajaToolStripMenuItem4
            // 
            this.bajaToolStripMenuItem4.Name = "bajaToolStripMenuItem4";
            this.bajaToolStripMenuItem4.Size = new System.Drawing.Size(180, 26);
            this.bajaToolStripMenuItem4.Text = "Baja";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaSolicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarSolicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarSolicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteSemanalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteMensualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem4;
    }
}