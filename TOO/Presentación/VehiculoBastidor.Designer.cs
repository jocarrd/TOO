namespace Presentación
{
    partial class VehiculoBastidor
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
            this.numBaslb = new System.Windows.Forms.Label();
            this.numBastb = new System.Windows.Forms.TextBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numBaslb
            // 
            this.numBaslb.AutoSize = true;
            this.numBaslb.Location = new System.Drawing.Point(39, 58);
            this.numBaslb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numBaslb.Name = "numBaslb";
            this.numBaslb.Size = new System.Drawing.Size(103, 13);
            this.numBaslb.TabIndex = 0;
            this.numBaslb.Text = "Número de Bastidor:";
            // 
            // numBastb
            // 
            this.numBastb.Location = new System.Drawing.Point(159, 56);
            this.numBastb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numBastb.Name = "numBastb";
            this.numBastb.Size = new System.Drawing.Size(85, 20);
            this.numBastb.TabIndex = 1;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(159, 110);
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(66, 24);
            this.botonCancelar.TabIndex = 40;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(62, 110);
            this.botonAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(66, 24);
            this.botonAceptar.TabIndex = 39;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // VehiculoBastidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 192);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.numBastb);
            this.Controls.Add(this.numBaslb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VehiculoBastidor";
            this.Text = "Introducir número de bastidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numBaslb;
        private System.Windows.Forms.TextBox numBastb;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAceptar;
    }
}