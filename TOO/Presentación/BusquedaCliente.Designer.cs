namespace Presentación
{
    partial class BusquedaCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.dnicb = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.apellidostb = new System.Windows.Forms.TextBox();
            this.nombretb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombrelb = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // dnicb
            // 
            this.dnicb.FormattingEnabled = true;
            this.dnicb.Location = new System.Drawing.Point(223, 68);
            this.dnicb.Name = "dnicb";
            this.dnicb.Size = new System.Drawing.Size(152, 28);
            this.dnicb.TabIndex = 1;
            this.dnicb.SelectedIndexChanged += new System.EventHandler(this.dnicb_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.apellidostb);
            this.panel1.Controls.Add(this.nombretb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nombrelb);
            this.panel1.Location = new System.Drawing.Point(44, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 233);
            this.panel1.TabIndex = 2;
            // 
            // apellidostb
            // 
            this.apellidostb.Location = new System.Drawing.Point(179, 146);
            this.apellidostb.Name = "apellidostb";
            this.apellidostb.Size = new System.Drawing.Size(152, 26);
            this.apellidostb.TabIndex = 4;
            // 
            // nombretb
            // 
            this.nombretb.Location = new System.Drawing.Point(179, 59);
            this.nombretb.Name = "nombretb";
            this.nombretb.Size = new System.Drawing.Size(152, 26);
            this.nombretb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos";
            // 
            // nombrelb
            // 
            this.nombrelb.AutoSize = true;
            this.nombrelb.Location = new System.Drawing.Point(67, 59);
            this.nombrelb.Name = "nombrelb";
            this.nombrelb.Size = new System.Drawing.Size(65, 20);
            this.nombrelb.TabIndex = 1;
            this.nombrelb.Text = "Nombre";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(192, 421);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(89, 33);
            this.botonCancelar.TabIndex = 3;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // BusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 492);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dnicb);
            this.Controls.Add(this.label1);
            this.Name = "BusquedaCliente";
            this.Text = "Datos de un cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dnicb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox apellidostb;
        private System.Windows.Forms.TextBox nombretb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nombrelb;
        private System.Windows.Forms.Button botonCancelar;
    }
}