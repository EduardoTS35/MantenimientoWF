namespace AppMantenimiento
{
    partial class FrmDashBoard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashBoard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bttHome = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cátalogoActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaciónDeActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisiónDeActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoCorrectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarActividadCorrectivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteTrabajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacénToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.maquinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoDeMaquinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bttHome,
            this.actividadesToolStripMenuItem,
            this.mantenimientoCorrectivoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.refaccionesToolStripMenuItem,
            this.maquinariaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1086, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bttHome
            // 
            this.bttHome.Image = ((System.Drawing.Image)(resources.GetObject("bttHome.Image")));
            this.bttHome.Name = "bttHome";
            this.bttHome.Size = new System.Drawing.Size(84, 24);
            this.bttHome.Text = "Home";
            this.bttHome.Click += new System.EventHandler(this.bttHome_Click);
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cátalogoActividadesToolStripMenuItem,
            this.asignaciónDeActividadesToolStripMenuItem,
            this.revisiónDeActividadesToolStripMenuItem});
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.actividadesToolStripMenuItem.Text = "Mantenimiento Preventivo";
            // 
            // cátalogoActividadesToolStripMenuItem
            // 
            this.cátalogoActividadesToolStripMenuItem.Name = "cátalogoActividadesToolStripMenuItem";
            this.cátalogoActividadesToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.cátalogoActividadesToolStripMenuItem.Text = "Cátalogo Actividades";
            this.cátalogoActividadesToolStripMenuItem.Click += new System.EventHandler(this.cátalogoActividadesToolStripMenuItem_Click);
            // 
            // asignaciónDeActividadesToolStripMenuItem
            // 
            this.asignaciónDeActividadesToolStripMenuItem.Name = "asignaciónDeActividadesToolStripMenuItem";
            this.asignaciónDeActividadesToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.asignaciónDeActividadesToolStripMenuItem.Text = "Asignación de Actividades";
            this.asignaciónDeActividadesToolStripMenuItem.Click += new System.EventHandler(this.asignaciónDeActividadesToolStripMenuItem_Click);
            // 
            // revisiónDeActividadesToolStripMenuItem
            // 
            this.revisiónDeActividadesToolStripMenuItem.Name = "revisiónDeActividadesToolStripMenuItem";
            this.revisiónDeActividadesToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.revisiónDeActividadesToolStripMenuItem.Text = "Revisión de Actividades";
            this.revisiónDeActividadesToolStripMenuItem.Click += new System.EventHandler(this.revisiónDeActividadesToolStripMenuItem_Click);
            // 
            // mantenimientoCorrectivoToolStripMenuItem
            // 
            this.mantenimientoCorrectivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarActividadCorrectivaToolStripMenuItem});
            this.mantenimientoCorrectivoToolStripMenuItem.Name = "mantenimientoCorrectivoToolStripMenuItem";
            this.mantenimientoCorrectivoToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.mantenimientoCorrectivoToolStripMenuItem.Text = "Mantenimiento Correctivo";
            // 
            // agregarActividadCorrectivaToolStripMenuItem
            // 
            this.agregarActividadCorrectivaToolStripMenuItem.Name = "agregarActividadCorrectivaToolStripMenuItem";
            this.agregarActividadCorrectivaToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.agregarActividadCorrectivaToolStripMenuItem.Text = "Agregar Actividad Correctiva";
            this.agregarActividadCorrectivaToolStripMenuItem.Click += new System.EventHandler(this.agregarActividadCorrectivaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteGeneralToolStripMenuItem,
            this.reporteTrabajadoresToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteGeneralToolStripMenuItem
            // 
            this.reporteGeneralToolStripMenuItem.Name = "reporteGeneralToolStripMenuItem";
            this.reporteGeneralToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.reporteGeneralToolStripMenuItem.Text = "Reporte General";
            this.reporteGeneralToolStripMenuItem.Click += new System.EventHandler(this.reporteGeneralToolStripMenuItem_Click);
            // 
            // reporteTrabajadoresToolStripMenuItem
            // 
            this.reporteTrabajadoresToolStripMenuItem.Name = "reporteTrabajadoresToolStripMenuItem";
            this.reporteTrabajadoresToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.reporteTrabajadoresToolStripMenuItem.Text = "Reporte Trabajadores";
            this.reporteTrabajadoresToolStripMenuItem.Click += new System.EventHandler(this.reporteTrabajadoresToolStripMenuItem_Click);
            // 
            // refaccionesToolStripMenuItem
            // 
            this.refaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.almacénToolStripMenuItem,
            this.catálogoToolStripMenuItem,
            this.reportesToolStripMenuItem1});
            this.refaccionesToolStripMenuItem.Name = "refaccionesToolStripMenuItem";
            this.refaccionesToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.refaccionesToolStripMenuItem.Text = "Refacciones";
            // 
            // almacénToolStripMenuItem
            // 
            this.almacénToolStripMenuItem.Name = "almacénToolStripMenuItem";
            this.almacénToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.almacénToolStripMenuItem.Text = "Almacén";
            this.almacénToolStripMenuItem.Click += new System.EventHandler(this.almacénToolStripMenuItem_Click);
            // 
            // catálogoToolStripMenuItem
            // 
            this.catálogoToolStripMenuItem.Name = "catálogoToolStripMenuItem";
            this.catálogoToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.catálogoToolStripMenuItem.Text = "Catálogo";
            this.catálogoToolStripMenuItem.Click += new System.EventHandler(this.catálogoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem1
            // 
            this.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            this.reportesToolStripMenuItem1.Size = new System.Drawing.Size(153, 26);
            this.reportesToolStripMenuItem1.Text = "Reportes";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 28);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1086, 681);
            this.pnlContenedor.TabIndex = 1;
            // 
            // maquinariaToolStripMenuItem
            // 
            this.maquinariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogoDeMaquinariaToolStripMenuItem});
            this.maquinariaToolStripMenuItem.Name = "maquinariaToolStripMenuItem";
            this.maquinariaToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.maquinariaToolStripMenuItem.Text = "Maquinaria";
            // 
            // catálogoDeMaquinariaToolStripMenuItem
            // 
            this.catálogoDeMaquinariaToolStripMenuItem.Name = "catálogoDeMaquinariaToolStripMenuItem";
            this.catálogoDeMaquinariaToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.catálogoDeMaquinariaToolStripMenuItem.Text = "Catálogo de Maquinaria";
            this.catálogoDeMaquinariaToolStripMenuItem.Click += new System.EventHandler(this.catálogoDeMaquinariaToolStripMenuItem_Click);
            // 
            // FrmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 709);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Mantenimiento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cátalogoActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaciónDeActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisiónDeActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoCorrectivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarActividadCorrectivaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.ToolStripMenuItem bttHome;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteTrabajadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacénToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maquinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoDeMaquinariaToolStripMenuItem;
    }
}

