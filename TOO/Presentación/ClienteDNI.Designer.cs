namespace Presentación
{
    partial class ClienteDNI
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
            this.dnitb = new System.Windows.Forms.TextBox();
            this.dnilb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(238, 175);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(99, 37);
            this.botonCancelar.TabIndex = 44;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(91, 175);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(99, 37);
            this.botonAceptar.TabIndex = 43;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            // 
            // dnitb
            // 
            this.dnitb.Location = new System.Drawing.Point(196, 63);
            this.dnitb.Name = "dnitb";
            this.dnitb.Size = new System.Drawing.Size(125, 26);
            this.dnitb.TabIndex = 42;
            // 
            // dnilb
            // 
            this.dnilb.AutoSize = true;
            this.dnilb.Location = new System.Drawing.Point(97, 66);
            this.dnilb.Name = "dnilb";
            this.dnilb.Size = new System.Drawing.Size(41, 20);
            this.dnilb.TabIndex = 41;
            this.dnilb.Text = "DNI:";
            // 
            // ClienteDNI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 277);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.dnitb);
            this.Controls.Add(this.dnilb);
            this.Name = "ClienteDNI";
            this.Text = "Introducir DNI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.TextBox dnitb;
        private System.Windows.Forms.Label dnilb;
    }
}