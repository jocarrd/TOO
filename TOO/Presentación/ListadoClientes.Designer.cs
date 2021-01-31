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
            this.botonDNI.Location = new System.Drawing.Point(75, 69);
            this.botonDNI.Name = "botonDNI";
            this.botonDNI.Size = new System.Drawing.Size(122, 37);
            this.botonDNI.TabIndex = 0;
            this.botonDNI.Text = "DNI";
            this.botonDNI.UseVisualStyleBackColor = true;
            // 
            // botonNombre
            // 
            this.botonNombre.Location = new System.Drawing.Point(268, 69);
            this.botonNombre.Name = "botonNombre";
            this.botonNombre.Size = new System.Drawing.Size(122, 37);
            this.botonNombre.TabIndex = 1;
            this.botonNombre.Text = "Nombre";
            this.botonNombre.UseVisualStyleBackColor = true;
            // 
            // botonImporte
            // 
            this.botonImporte.Location = new System.Drawing.Point(468, 69);
            this.botonImporte.Name = "botonImporte";
            this.botonImporte.Size = new System.Drawing.Size(122, 37);
            this.botonImporte.TabIndex = 2;
            this.botonImporte.Text = "Importe";
            this.botonImporte.UseVisualStyleBackColor = true;
            this.botonImporte.Click += new System.EventHandler(this.botonImporte_Click);
            // 
            // dniListB
            // 
            this.dniListB.FormattingEnabled = true;
            this.dniListB.ItemHeight = 20;
            this.dniListB.Location = new System.Drawing.Point(75, 134);
            this.dniListB.Name = "dniListB";
            this.dniListB.Size = new System.Drawing.Size(120, 164);
            this.dniListB.TabIndex = 3;
            // 
            // nombreListB
            // 
            this.nombreListB.FormattingEnabled = true;
            this.nombreListB.ItemHeight = 20;
            this.nombreListB.Location = new System.Drawing.Point(270, 134);
            this.nombreListB.Name = "nombreListB";
            this.nombreListB.Size = new System.Drawing.Size(120, 164);
            this.nombreListB.TabIndex = 4;
            // 
            // importeListB
            // 
            this.importeListB.FormattingEnabled = true;
            this.importeListB.ItemHeight = 20;
            this.importeListB.Location = new System.Drawing.Point(470, 134);
            this.importeListB.Name = "importeListB";
            this.importeListB.Size = new System.Drawing.Size(120, 164);
            this.importeListB.TabIndex = 5;
            // 
            // botonCerrar
            // 
            this.botonCerrar.Location = new System.Drawing.Point(255, 358);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(150, 32);
            this.botonCerrar.TabIndex = 6;
            this.botonCerrar.Text = "Cerrar";
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // ListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 449);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.importeListB);
            this.Controls.Add(this.nombreListB);
            this.Controls.Add(this.dniListB);
            this.Controls.Add(this.botonImporte);
            this.Controls.Add(this.botonNombre);
            this.Controls.Add(this.botonDNI);
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