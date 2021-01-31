namespace Presentación
{
    partial class ListadoClientes
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
            this.botonDNI = new System.Windows.Forms.Button();
            this.botonNombre = new System.Windows.Forms.Button();
            this.botonImporte = new System.Windows.Forms.Button();
            this.dniListB = new System.Windows.Forms.ListBox();
            this.nombreListB = new System.Windows.Forms.ListBox();
            this.importeListB = new System.Windows.Forms.ListBox();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonDNI
            // 
            this.botonDNI.Location = new System.Drawing.Point(50, 45);
            this.botonDNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonDNI.Name = "botonDNI";
            this.botonDNI.Size = new System.Drawing.Size(81, 24);
            this.botonDNI.TabIndex = 0;
            this.botonDNI.Text = "DNI";
            this.botonDNI.UseVisualStyleBackColor = true;
            // 
            // botonNombre
            // 
            this.botonNombre.Location = new System.Drawing.Point(179, 45);
            this.botonNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonNombre.Name = "botonNombre";
            this.botonNombre.Size = new System.Drawing.Size(81, 24);
            this.botonNombre.TabIndex = 1;
            this.botonNombre.Text = "Nombre";
            this.botonNombre.UseVisualStyleBackColor = true;
            // 
            // botonImporte
            // 
            this.botonImporte.Location = new System.Drawing.Point(312, 45);
            this.botonImporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonImporte.Name = "botonImporte";
            this.botonImporte.Size = new System.Drawing.Size(81, 24);
            this.botonImporte.TabIndex = 2;
            this.botonImporte.Text = "Importe";
            this.botonImporte.UseVisualStyleBackColor = true;
            this.botonImporte.Click += new System.EventHandler(this.botonImporte_Click);
            // 
            // dniListB
            // 
            this.dniListB.FormattingEnabled = true;
            this.dniListB.Location = new System.Drawing.Point(50, 87);
            this.dniListB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dniListB.Name = "dniListB";
            this.dniListB.Size = new System.Drawing.Size(81, 108);
            this.dniListB.TabIndex = 3;
            // 
            // nombreListB
            // 
            this.nombreListB.FormattingEnabled = true;
            this.nombreListB.Location = new System.Drawing.Point(180, 87);
            this.nombreListB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombreListB.Name = "nombreListB";
            this.nombreListB.Size = new System.Drawing.Size(81, 108);
            this.nombreListB.TabIndex = 4;
            // 
            // importeListB
            // 
            this.importeListB.FormattingEnabled = true;
            this.importeListB.Location = new System.Drawing.Point(313, 87);
            this.importeListB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.importeListB.Name = "importeListB";
            this.importeListB.Size = new System.Drawing.Size(81, 108);
            this.importeListB.TabIndex = 5;
            // 
            // botonCerrar
            // 
            this.botonCerrar.Location = new System.Drawing.Point(170, 233);
            this.botonCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(100, 21);
            this.botonCerrar.TabIndex = 6;
            this.botonCerrar.Text = "Cerrar";
            this.botonCerrar.UseVisualStyleBackColor = true;
            // 
            // ListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 292);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.importeListB);
            this.Controls.Add(this.nombreListB);
            this.Controls.Add(this.dniListB);
            this.Controls.Add(this.botonImporte);
            this.Controls.Add(this.botonNombre);
            this.Controls.Add(this.botonDNI);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListadoClientes";
            this.Text = "Listado de Clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonDNI;
        private System.Windows.Forms.Button botonNombre;
        private System.Windows.Forms.Button botonImporte;
        private System.Windows.Forms.ListBox dniListB;
        private System.Windows.Forms.ListBox nombreListB;
        private System.Windows.Forms.ListBox importeListB;
        private System.Windows.Forms.Button botonCerrar;
    }
}