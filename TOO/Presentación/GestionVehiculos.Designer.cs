namespace Presentación
{
    partial class GestionVehiculos
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
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.fechaMatriculatb = new System.Windows.Forms.TextBox();
            this.fechaMatriculalb = new System.Windows.Forms.Label();
            this.matriculalb = new System.Windows.Forms.Label();
            this.botonSegMano = new System.Windows.Forms.RadioButton();
            this.botonNuevo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.matriculatb = new System.Windows.Forms.TextBox();
            this.precioRectb = new System.Windows.Forms.TextBox();
            this.potenciatb = new System.Windows.Forms.TextBox();
            this.modelotb = new System.Windows.Forms.TextBox();
            this.marcatb = new System.Windows.Forms.TextBox();
            this.numBastb = new System.Windows.Forms.TextBox();
            this.precioReclb = new System.Windows.Forms.Label();
            this.potencialb = new System.Windows.Forms.Label();
            this.modelolb = new System.Windows.Forms.Label();
            this.marcalb = new System.Windows.Forms.Label();
            this.numBastlb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(292, 257);
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(66, 24);
            this.botonCancelar.TabIndex = 38;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(167, 257);
            this.botonAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(66, 24);
            this.botonAceptar.TabIndex = 37;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            // 
            // fechaMatriculatb
            // 
            this.fechaMatriculatb.Location = new System.Drawing.Point(397, 184);
            this.fechaMatriculatb.Margin = new System.Windows.Forms.Padding(2);
            this.fechaMatriculatb.Name = "fechaMatriculatb";
            this.fechaMatriculatb.Size = new System.Drawing.Size(68, 20);
            this.fechaMatriculatb.TabIndex = 36;
            // 
            // fechaMatriculalb
            // 
            this.fechaMatriculalb.AutoSize = true;
            this.fechaMatriculalb.Location = new System.Drawing.Point(289, 186);
            this.fechaMatriculalb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fechaMatriculalb.Name = "fechaMatriculalb";
            this.fechaMatriculalb.Size = new System.Drawing.Size(106, 13);
            this.fechaMatriculalb.TabIndex = 35;
            this.fechaMatriculalb.Text = "Fecha Matriculación:";
            // 
            // matriculalb
            // 
            this.matriculalb.AutoSize = true;
            this.matriculalb.Location = new System.Drawing.Point(289, 141);
            this.matriculalb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.matriculalb.Name = "matriculalb";
            this.matriculalb.Size = new System.Drawing.Size(55, 13);
            this.matriculalb.TabIndex = 34;
            this.matriculalb.Text = "Matrícula:";
            // 
            // botonSegMano
            // 
            this.botonSegMano.AutoSize = true;
            this.botonSegMano.Location = new System.Drawing.Point(389, 43);
            this.botonSegMano.Margin = new System.Windows.Forms.Padding(2);
            this.botonSegMano.Name = "botonSegMano";
            this.botonSegMano.Size = new System.Drawing.Size(98, 17);
            this.botonSegMano.TabIndex = 33;
            this.botonSegMano.TabStop = true;
            this.botonSegMano.Text = "Segunda Mano";
            this.botonSegMano.UseVisualStyleBackColor = true;
            this.botonSegMano.Click += new System.EventHandler(this.botonSegMano_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.AutoSize = true;
            this.botonNuevo.Location = new System.Drawing.Point(318, 43);
            this.botonNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(57, 17);
            this.botonNuevo.TabIndex = 20;
            this.botonNuevo.TabStop = true;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.CheckedChanged += new System.EventHandler(this.botonNuevo_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Vehículo";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(292, 18);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(217, 65);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // matriculatb
            // 
            this.matriculatb.Location = new System.Drawing.Point(397, 137);
            this.matriculatb.Margin = new System.Windows.Forms.Padding(2);
            this.matriculatb.Name = "matriculatb";
            this.matriculatb.Size = new System.Drawing.Size(68, 20);
            this.matriculatb.TabIndex = 30;
            // 
            // precioRectb
            // 
            this.precioRectb.Location = new System.Drawing.Point(137, 186);
            this.precioRectb.Margin = new System.Windows.Forms.Padding(2);
            this.precioRectb.Name = "precioRectb";
            this.precioRectb.Size = new System.Drawing.Size(68, 20);
            this.precioRectb.TabIndex = 29;
            // 
            // potenciatb
            // 
            this.potenciatb.Location = new System.Drawing.Point(137, 141);
            this.potenciatb.Margin = new System.Windows.Forms.Padding(2);
            this.potenciatb.Name = "potenciatb";
            this.potenciatb.Size = new System.Drawing.Size(68, 20);
            this.potenciatb.TabIndex = 28;
            // 
            // modelotb
            // 
            this.modelotb.Location = new System.Drawing.Point(137, 101);
            this.modelotb.Margin = new System.Windows.Forms.Padding(2);
            this.modelotb.Name = "modelotb";
            this.modelotb.Size = new System.Drawing.Size(68, 20);
            this.modelotb.TabIndex = 27;
            // 
            // marcatb
            // 
            this.marcatb.Location = new System.Drawing.Point(137, 60);
            this.marcatb.Margin = new System.Windows.Forms.Padding(2);
            this.marcatb.Name = "marcatb";
            this.marcatb.Size = new System.Drawing.Size(68, 20);
            this.marcatb.TabIndex = 26;
            // 
            // numBastb
            // 
            this.numBastb.Location = new System.Drawing.Point(137, 18);
            this.numBastb.Margin = new System.Windows.Forms.Padding(2);
            this.numBastb.Name = "numBastb";
            this.numBastb.Size = new System.Drawing.Size(68, 20);
            this.numBastb.TabIndex = 25;
            // 
            // precioReclb
            // 
            this.precioReclb.AutoSize = true;
            this.precioReclb.Location = new System.Drawing.Point(25, 190);
            this.precioReclb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.precioReclb.Name = "precioReclb";
            this.precioReclb.Size = new System.Drawing.Size(113, 13);
            this.precioReclb.TabIndex = 24;
            this.precioReclb.Text = "Precio Recomendado:";
            // 
            // potencialb
            // 
            this.potencialb.AutoSize = true;
            this.potencialb.Location = new System.Drawing.Point(25, 145);
            this.potencialb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.potencialb.Name = "potencialb";
            this.potencialb.Size = new System.Drawing.Size(52, 13);
            this.potencialb.TabIndex = 23;
            this.potencialb.Text = "Potencia:";
            // 
            // modelolb
            // 
            this.modelolb.AutoSize = true;
            this.modelolb.Location = new System.Drawing.Point(25, 105);
            this.modelolb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modelolb.Name = "modelolb";
            this.modelolb.Size = new System.Drawing.Size(45, 13);
            this.modelolb.TabIndex = 22;
            this.modelolb.Text = "Modelo:";
            // 
            // marcalb
            // 
            this.marcalb.AutoSize = true;
            this.marcalb.Location = new System.Drawing.Point(25, 62);
            this.marcalb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.marcalb.Name = "marcalb";
            this.marcalb.Size = new System.Drawing.Size(40, 13);
            this.marcalb.TabIndex = 21;
            this.marcalb.Text = "Marca:";
            // 
            // numBastlb
            // 
            this.numBastlb.AutoSize = true;
            this.numBastlb.Location = new System.Drawing.Point(25, 19);
            this.numBastlb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numBastlb.Name = "numBastlb";
            this.numBastlb.Size = new System.Drawing.Size(103, 13);
            this.numBastlb.TabIndex = 19;
            this.numBastlb.Text = "Número de Bastidor:";
            // 
            // GestionVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.fechaMatriculatb);
            this.Controls.Add(this.fechaMatriculalb);
            this.Controls.Add(this.matriculalb);
            this.Controls.Add(this.botonSegMano);
            this.Controls.Add(this.botonNuevo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.matriculatb);
            this.Controls.Add(this.precioRectb);
            this.Controls.Add(this.potenciatb);
            this.Controls.Add(this.modelotb);
            this.Controls.Add(this.marcatb);
            this.Controls.Add(this.numBastb);
            this.Controls.Add(this.precioReclb);
            this.Controls.Add(this.potencialb);
            this.Controls.Add(this.modelolb);
            this.Controls.Add(this.marcalb);
            this.Controls.Add(this.numBastlb);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionVehiculos";
            this.Text = "Alta de vehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.TextBox fechaMatriculatb;
        private System.Windows.Forms.Label fechaMatriculalb;
        private System.Windows.Forms.Label matriculalb;
        private System.Windows.Forms.RadioButton botonSegMano;
        private System.Windows.Forms.RadioButton botonNuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox matriculatb;
        private System.Windows.Forms.TextBox precioRectb;
        private System.Windows.Forms.TextBox potenciatb;
        private System.Windows.Forms.TextBox modelotb;
        private System.Windows.Forms.TextBox marcatb;
        private System.Windows.Forms.TextBox numBastb;
        private System.Windows.Forms.Label precioReclb;
        private System.Windows.Forms.Label potencialb;
        private System.Windows.Forms.Label modelolb;
        private System.Windows.Forms.Label marcalb;
        private System.Windows.Forms.Label numBastlb;
    }
}