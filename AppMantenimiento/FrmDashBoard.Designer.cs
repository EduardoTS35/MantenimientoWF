﻿namespace AppMantenimiento
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
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteGeneralToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteTabajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteCorrectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refaccionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comrpasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarRefacciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacénToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maquinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoDeMaquinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.historialDeActividadesRealizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(815, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bttHome
            // 
            this.bttHome.Image = ((System.Drawing.Image)(resources.GetObject("bttHome.Image")));
            this.bttHome.Name = "bttHome";
            this.bttHome.Size = new System.Drawing.Size(72, 24);
            this.bttHome.Text = "Home";
            this.bttHome.Click += new System.EventHandler(this.bttHome_Click);
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cátalogoActividadesToolStripMenuItem,
            this.asignaciónDeActividadesToolStripMenuItem,
            this.revisiónDeActividadesToolStripMenuItem,
            this.historialDeActividadesRealizadasToolStripMenuItem});
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.actividadesToolStripMenuItem.Text = "Mantenimiento Preventivo";
            // 
            // cátalogoActividadesToolStripMenuItem
            // 
            this.cátalogoActividadesToolStripMenuItem.Name = "cátalogoActividadesToolStripMenuItem";
            this.cátalogoActividadesToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.cátalogoActividadesToolStripMenuItem.Text = "Cátalogo Actividades";
            this.cátalogoActividadesToolStripMenuItem.Click += new System.EventHandler(this.cátalogoActividadesToolStripMenuItem_Click);
            // 
            // asignaciónDeActividadesToolStripMenuItem
            // 
            this.asignaciónDeActividadesToolStripMenuItem.Name = "asignaciónDeActividadesToolStripMenuItem";
            this.asignaciónDeActividadesToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.asignaciónDeActividadesToolStripMenuItem.Text = "Asignación de Actividades";
            this.asignaciónDeActividadesToolStripMenuItem.Click += new System.EventHandler(this.asignaciónDeActividadesToolStripMenuItem_Click);
            // 
            // revisiónDeActividadesToolStripMenuItem
            // 
            this.revisiónDeActividadesToolStripMenuItem.Name = "revisiónDeActividadesToolStripMenuItem";
            this.revisiónDeActividadesToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.revisiónDeActividadesToolStripMenuItem.Text = "Revisión de Actividades";
            this.revisiónDeActividadesToolStripMenuItem.Click += new System.EventHandler(this.revisiónDeActividadesToolStripMenuItem_Click);
            // 
            // mantenimientoCorrectivoToolStripMenuItem
            // 
            this.mantenimientoCorrectivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarActividadCorrectivaToolStripMenuItem});
            this.mantenimientoCorrectivoToolStripMenuItem.Name = "mantenimientoCorrectivoToolStripMenuItem";
            this.mantenimientoCorrectivoToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.mantenimientoCorrectivoToolStripMenuItem.Text = "Mantenimiento Correctivo";
            // 
            // agregarActividadCorrectivaToolStripMenuItem
            // 
            this.agregarActividadCorrectivaToolStripMenuItem.Name = "agregarActividadCorrectivaToolStripMenuItem";
            this.agregarActividadCorrectivaToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.agregarActividadCorrectivaToolStripMenuItem.Text = "Agregar Actividad Correctiva";
            this.agregarActividadCorrectivaToolStripMenuItem.Click += new System.EventHandler(this.agregarActividadCorrectivaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.refaccionesToolStripMenuItem1,
            this.comrpasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteGeneralToolStripMenuItem1,
            this.reporteTabajadoresToolStripMenuItem,
            this.reporteCorrectivoToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // reporteGeneralToolStripMenuItem1
            // 
            this.reporteGeneralToolStripMenuItem1.Name = "reporteGeneralToolStripMenuItem1";
            this.reporteGeneralToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.reporteGeneralToolStripMenuItem1.Text = "Reporte General";
            this.reporteGeneralToolStripMenuItem1.Click += new System.EventHandler(this.reporteGeneralToolStripMenuItem1_Click);
            // 
            // reporteTabajadoresToolStripMenuItem
            // 
            this.reporteTabajadoresToolStripMenuItem.Name = "reporteTabajadoresToolStripMenuItem";
            this.reporteTabajadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteTabajadoresToolStripMenuItem.Text = "Reporte Tabajadores";
            this.reporteTabajadoresToolStripMenuItem.Click += new System.EventHandler(this.reporteTabajadoresToolStripMenuItem_Click);
            // 
            // reporteCorrectivoToolStripMenuItem
            // 
            this.reporteCorrectivoToolStripMenuItem.Name = "reporteCorrectivoToolStripMenuItem";
            this.reporteCorrectivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteCorrectivoToolStripMenuItem.Text = "Reporte Correctivo";
            this.reporteCorrectivoToolStripMenuItem.Click += new System.EventHandler(this.reporteCorrectivoToolStripMenuItem_Click);
            // 
            // refaccionesToolStripMenuItem1
            // 
            this.refaccionesToolStripMenuItem1.Name = "refaccionesToolStripMenuItem1";
            this.refaccionesToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.refaccionesToolStripMenuItem1.Text = "Refacciones";
            // 
            // comrpasToolStripMenuItem
            // 
            this.comrpasToolStripMenuItem.Name = "comrpasToolStripMenuItem";
            this.comrpasToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.comrpasToolStripMenuItem.Text = "Compras";
            // 
            // refaccionesToolStripMenuItem
            // 
            this.refaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.solicitarRefacciónToolStripMenuItem,
            this.almacénToolStripMenuItem,
            this.catálogoToolStripMenuItem,
            this.reportesToolStripMenuItem1,
            this.comprasToolStripMenuItem});
            this.refaccionesToolStripMenuItem.Name = "refaccionesToolStripMenuItem";
            this.refaccionesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.refaccionesToolStripMenuItem.Text = "Refacciones";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // solicitarRefacciónToolStripMenuItem
            // 
            this.solicitarRefacciónToolStripMenuItem.Name = "solicitarRefacciónToolStripMenuItem";
            this.solicitarRefacciónToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.solicitarRefacciónToolStripMenuItem.Text = "Solicitar Refacción";
            this.solicitarRefacciónToolStripMenuItem.Click += new System.EventHandler(this.solicitarRefacciónToolStripMenuItem_Click);
            // 
            // almacénToolStripMenuItem
            // 
            this.almacénToolStripMenuItem.Name = "almacénToolStripMenuItem";
            this.almacénToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.almacénToolStripMenuItem.Text = "Almacén";
            this.almacénToolStripMenuItem.Click += new System.EventHandler(this.almacénToolStripMenuItem_Click);
            // 
            // catálogoToolStripMenuItem
            // 
            this.catálogoToolStripMenuItem.Name = "catálogoToolStripMenuItem";
            this.catálogoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.catálogoToolStripMenuItem.Text = "Catálogo";
            this.catálogoToolStripMenuItem.Click += new System.EventHandler(this.catálogoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem1
            // 
            this.reportesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem1});
            this.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            this.reportesToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.reportesToolStripMenuItem1.Text = "Reportes";
            // 
            // comprasToolStripMenuItem1
            // 
            this.comprasToolStripMenuItem1.Name = "comprasToolStripMenuItem1";
            this.comprasToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.comprasToolStripMenuItem1.Text = "General";
            this.comprasToolStripMenuItem1.Click += new System.EventHandler(this.comprasToolStripMenuItem1_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorizarCompraToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // autorizarCompraToolStripMenuItem
            // 
            this.autorizarCompraToolStripMenuItem.Name = "autorizarCompraToolStripMenuItem";
            this.autorizarCompraToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.autorizarCompraToolStripMenuItem.Text = "Autorizar Compra";
            this.autorizarCompraToolStripMenuItem.Click += new System.EventHandler(this.autorizarCompraToolStripMenuItem_Click);
            // 
            // maquinariaToolStripMenuItem
            // 
            this.maquinariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogoDeMaquinariaToolStripMenuItem});
            this.maquinariaToolStripMenuItem.Name = "maquinariaToolStripMenuItem";
            this.maquinariaToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.maquinariaToolStripMenuItem.Text = "Maquinaria";
            // 
            // catálogoDeMaquinariaToolStripMenuItem
            // 
            this.catálogoDeMaquinariaToolStripMenuItem.Name = "catálogoDeMaquinariaToolStripMenuItem";
            this.catálogoDeMaquinariaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.catálogoDeMaquinariaToolStripMenuItem.Text = "Catálogo de Maquinaria";
            this.catálogoDeMaquinariaToolStripMenuItem.Click += new System.EventHandler(this.catálogoDeMaquinariaToolStripMenuItem_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 26);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(815, 550);
            this.pnlContenedor.TabIndex = 1;
            // 
            // historialDeActividadesRealizadasToolStripMenuItem
            // 
            this.historialDeActividadesRealizadasToolStripMenuItem.Name = "historialDeActividadesRealizadasToolStripMenuItem";
            this.historialDeActividadesRealizadasToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.historialDeActividadesRealizadasToolStripMenuItem.Text = "Historial de Actividades Realizadas";
            this.historialDeActividadesRealizadasToolStripMenuItem.Click += new System.EventHandler(this.historialDeActividadesRealizadasToolStripMenuItem_Click);
            // 
            // FrmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 576);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
        private System.Windows.Forms.ToolStripMenuItem refaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacénToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maquinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoDeMaquinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarRefacciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteGeneralToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reporteTabajadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorizarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refaccionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comrpasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteCorrectivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeActividadesRealizadasToolStripMenuItem;
    }
}

