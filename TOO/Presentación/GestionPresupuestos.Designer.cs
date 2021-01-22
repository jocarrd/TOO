namespace Presentación
{
    partial class GestionPresupuestos
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
            this.idePrestb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidadlb = new System.Windows.Forms.Label();
            this.cantidadtb = new System.Windows.Forms.TextBox();
            this.clientetb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.estadotb = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listVehilb = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.botonAñadir = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idePrestb
            // 
            this.idePrestb.Location = new System.Drawing.Point(276, 89);
            this.idePrestb.Name = "idePrestb";
            this.idePrestb.Size = new System.Drawing.Size(109, 26);
            this.idePrestb.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Identificador de Presupuesto:";
            // 
            // cantidadlb
            // 
            this.cantidadlb.AutoSize = true;
            this.cantidadlb.Location = new System.Drawing.Point(53, 158);
            this.cantidadlb.Name = "cantidadlb";
            this.cantidadlb.Size = new System.Drawing.Size(77, 20);
            this.cantidadlb.TabIndex = 43;
            this.cantidadlb.Text = "Cantidad:";
            // 
            // cantidadtb
            // 
            this.cantidadtb.Location = new System.Drawing.Point(276, 158);
            this.cantidadtb.Name = "cantidadtb";
            this.cantidadtb.Size = new System.Drawing.Size(109, 26);
            this.cantidadtb.TabIndex = 44;
            // 
            // clientetb
            // 
            this.clientetb.Location = new System.Drawing.Point(276, 300);
            this.clientetb.Name = "clientetb";
            this.clientetb.Size = new System.Drawing.Size(109, 26);
            this.clientetb.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Estado:";
            // 
            // estadotb
            // 
            this.estadotb.Location = new System.Drawing.Point(276, 231);
            this.estadotb.Name = "estadotb";
            this.estadotb.Size = new System.Drawing.Size(109, 26);
            this.estadotb.TabIndex = 45;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(235, 379);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Fecha Realización:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(534, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 164);
            this.listBox1.TabIndex = 51;
            // 
            // listVehilb
            // 
            this.listVehilb.AutoSize = true;
            this.listVehilb.Location = new System.Drawing.Point(530, 88);
            this.listVehilb.Name = "listVehilb";
            this.listVehilb.Size = new System.Drawing.Size(160, 20);
            this.listVehilb.TabIndex = 52;
            this.listVehilb.Text = "Listado de Vehiculos:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(534, 302);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 26);
            this.textBox1.TabIndex = 53;
            this.textBox1.Text = "--Numero de bastidor--";
            // 
            // botonAñadir
            // 
            this.botonAñadir.Location = new System.Drawing.Point(534, 344);
            this.botonAñadir.Name = "botonAñadir";
            this.botonAñadir.Size = new System.Drawing.Size(79, 27);
            this.botonAñadir.TabIndex = 54;
            this.botonAñadir.Text = "Añadir";
            this.botonAñadir.UseVisualStyleBackColor = true;
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(644, 344);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(79, 27);
            this.botonEliminar.TabIndex = 55;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(431, 464);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(99, 37);
            this.botonCancelar.TabIndex = 57;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(284, 464);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(99, 37);
            this.botonAceptar.TabIndex = 56;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            // 
            // GestionPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonAñadir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listVehilb);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.clientetb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.estadotb);
            this.Controls.Add(this.cantidadtb);
            this.Controls.Add(this.cantidadlb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idePrestb);
            this.Name = "GestionPresupuestos";
            this.Text = "Gestión de Presupuestos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idePrestb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cantidadlb;
        private System.Windows.Forms.TextBox cantidadtb;
        private System.Windows.Forms.TextBox clientetb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox estadotb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label listVehilb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botonAñadir;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAceptar;
    }
}