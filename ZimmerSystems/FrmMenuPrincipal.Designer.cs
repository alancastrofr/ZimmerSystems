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
            this.almacemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteSemanalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
            // 
            // almacemToolStripMenuItem
            // 
            this.almacemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReporteSemanalToolStripMenuItem,
            this.generarReporteMensualToolStripMenuItem});
            this.almacemToolStripMenuItem.Name = "almacemToolStripMenuItem";
            this.almacemToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.almacemToolStripMenuItem.Text = "Almacen";
            this.almacemToolStripMenuItem.Click += new System.EventHandler(this.almacemToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
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
            // nuevaSolicitudToolStripMenuItem
            // 
            this.nuevaSolicitudToolStripMenuItem.Name = "nuevaSolicitudToolStripMenuItem";
            this.nuevaSolicitudToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.nuevaSolicitudToolStripMenuItem.Text = "Nueva Solicitud";
            // 
            // modificarSolicitudToolStripMenuItem
            // 
            this.modificarSolicitudToolStripMenuItem.Name = "modificarSolicitudToolStripMenuItem";
            this.modificarSolicitudToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.modificarSolicitudToolStripMenuItem.Text = "Modificar Solicitud";
            // 
            // cancelarSolicitudToolStripMenuItem
            // 
            this.cancelarSolicitudToolStripMenuItem.Name = "cancelarSolicitudToolStripMenuItem";
            this.cancelarSolicitudToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.cancelarSolicitudToolStripMenuItem.Text = "Cancelar Solicitud";
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
            // accercaDeToolStripMenuItem
            // 
            this.accercaDeToolStripMenuItem.Name = "accercaDeToolStripMenuItem";
            this.accercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.accercaDeToolStripMenuItem.Text = "Soporte";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // contactoToolStripMenuItem
            // 
            this.contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            this.contactoToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.contactoToolStripMenuItem.Text = "Contacto";
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
    }
}