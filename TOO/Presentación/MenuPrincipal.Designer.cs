namespace Presentación
{
    partial class MenuPrincipal
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
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAltaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBajaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBusquedaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListarCompletoClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAltaVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBajaVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBusquedaVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListadoCompletoVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCrearNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBusquedaPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaPorVehículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListadoCmpletoPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.vehiculosToolStripMenuItem,
            this.presupuestosToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAltaCliente,
            this.tsmiBajaCliente,
            this.tsmiBusquedaCliente,
            this.tsmiListarClientes,
            this.tsmiListarCompletoClientes});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.clientesToolStripMenuItem_DropDownItemClicked);
            // 
            // tsmiAltaCliente
            // 
            this.tsmiAltaCliente.Name = "tsmiAltaCliente";
            this.tsmiAltaCliente.Size = new System.Drawing.Size(180, 22);
            this.tsmiAltaCliente.Text = "Alta";
            // 
            // tsmiBajaCliente
            // 
            this.tsmiBajaCliente.Name = "tsmiBajaCliente";
            this.tsmiBajaCliente.Size = new System.Drawing.Size(180, 22);
            this.tsmiBajaCliente.Text = "Baja";
            // 
            // tsmiBusquedaCliente
            // 
            this.tsmiBusquedaCliente.Name = "tsmiBusquedaCliente";
            this.tsmiBusquedaCliente.Size = new System.Drawing.Size(180, 22);
            this.tsmiBusquedaCliente.Text = "Búsqueda";
            // 
            // tsmiListarClientes
            // 
            this.tsmiListarClientes.Name = "tsmiListarClientes";
            this.tsmiListarClientes.Size = new System.Drawing.Size(180, 22);
            this.tsmiListarClientes.Text = "Listar";
            // 
            // tsmiListarCompletoClientes
            // 
            this.tsmiListarCompletoClientes.Name = "tsmiListarCompletoClientes";
            this.tsmiListarCompletoClientes.Size = new System.Drawing.Size(180, 22);
            this.tsmiListarCompletoClientes.Text = "Listado Completo";
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAltaVehiculo,
            this.tsmiBajaVehiculo,
            this.tsmiBusquedaVehiculo,
            this.tsmiListadoCompletoVehiculos});
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.vehiculosToolStripMenuItem.Text = "Vehículos";
            this.vehiculosToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.vehiculosToolStripMenuItem_DropDownItemClicked);
            // 
            // tsmiAltaVehiculo
            // 
            this.tsmiAltaVehiculo.Name = "tsmiAltaVehiculo";
            this.tsmiAltaVehiculo.Size = new System.Drawing.Size(180, 22);
            this.tsmiAltaVehiculo.Text = "Alta";
            // 
            // tsmiBajaVehiculo
            // 
            this.tsmiBajaVehiculo.Name = "tsmiBajaVehiculo";
            this.tsmiBajaVehiculo.Size = new System.Drawing.Size(180, 22);
            this.tsmiBajaVehiculo.Text = "Baja";
            // 
            // tsmiBusquedaVehiculo
            // 
            this.tsmiBusquedaVehiculo.Name = "tsmiBusquedaVehiculo";
            this.tsmiBusquedaVehiculo.Size = new System.Drawing.Size(180, 22);
            this.tsmiBusquedaVehiculo.Text = "Búsqueda";
            // 
            // tsmiListadoCompletoVehiculos
            // 
            this.tsmiListadoCompletoVehiculos.Name = "tsmiListadoCompletoVehiculos";
            this.tsmiListadoCompletoVehiculos.Size = new System.Drawing.Size(180, 22);
            this.tsmiListadoCompletoVehiculos.Text = "Listado Completo";
            this.tsmiListadoCompletoVehiculos.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // presupuestosToolStripMenuItem
            // 
            this.presupuestosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCrearNuevo,
            this.tsmiBusquedaPresupuesto,
            this.búsquedaPorClienteToolStripMenuItem,
            this.búsquedaPorVehículoToolStripMenuItem,
            this.tsmiListadoCmpletoPresupuesto});
            this.presupuestosToolStripMenuItem.Name = "presupuestosToolStripMenuItem";
            this.presupuestosToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.presupuestosToolStripMenuItem.Text = "Presupuestos";
            this.presupuestosToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.presupuestosToolStripMenuItem_DropDownItemClicked);
            // 
            // tsmiCrearNuevo
            // 
            this.tsmiCrearNuevo.Name = "tsmiCrearNuevo";
            this.tsmiCrearNuevo.Size = new System.Drawing.Size(195, 22);
            this.tsmiCrearNuevo.Text = "Crear nuevo";
            // 
            // tsmiBusquedaPresupuesto
            // 
            this.tsmiBusquedaPresupuesto.Name = "tsmiBusquedaPresupuesto";
            this.tsmiBusquedaPresupuesto.Size = new System.Drawing.Size(195, 22);
            this.tsmiBusquedaPresupuesto.Text = "Búsqueda";
            // 
            // búsquedaPorClienteToolStripMenuItem
            // 
            this.búsquedaPorClienteToolStripMenuItem.Name = "búsquedaPorClienteToolStripMenuItem";
            this.búsquedaPorClienteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.búsquedaPorClienteToolStripMenuItem.Text = "Búsqueda por cliente";
            // 
            // búsquedaPorVehículoToolStripMenuItem
            // 
            this.búsquedaPorVehículoToolStripMenuItem.Name = "búsquedaPorVehículoToolStripMenuItem";
            this.búsquedaPorVehículoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.búsquedaPorVehículoToolStripMenuItem.Text = "Búsqueda por vehículo";
            // 
            // tsmiListadoCmpletoPresupuesto
            // 
            this.tsmiListadoCmpletoPresupuesto.Name = "tsmiListadoCmpletoPresupuesto";
            this.tsmiListadoCmpletoPresupuesto.Size = new System.Drawing.Size(195, 22);
            this.tsmiListadoCmpletoPresupuesto.Text = "Listado Completo";
            this.tsmiListadoCmpletoPresupuesto.Click += new System.EventHandler(this.listadoCompletoToolStripMenuItem1_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipal";
            this.Text = "(Se cambia al hacer el login)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAltaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiBajaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiBusquedaCliente;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAltaVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tsmiBajaVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tsmiBusquedaVehiculo;
        private System.Windows.Forms.ToolStripMenuItem presupuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCrearNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsmiBusquedaPresupuesto;
        private System.Windows.Forms.ToolStripMenuItem búsquedaPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem búsquedaPorVehículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiListarClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiListadoCompletoVehiculos;
        private System.Windows.Forms.ToolStripMenuItem tsmiListarCompletoClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiListadoCmpletoPresupuesto;
    }
}