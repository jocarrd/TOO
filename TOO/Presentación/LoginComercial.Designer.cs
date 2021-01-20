namespace Presentación
{
    partial class LoginComercial
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
            this.nombrelb = new System.Windows.Forms.Label();
            this.nombretb = new System.Windows.Forms.TextBox();
            this.contraseñatb = new System.Windows.Forms.TextBox();
            this.contraseñalb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // nombrelb
            // 
            this.nombrelb.AutoSize = true;
            this.nombrelb.Location = new System.Drawing.Point(72, 96);
            this.nombrelb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombrelb.Name = "nombrelb";
            this.nombrelb.Size = new System.Drawing.Size(99, 13);
            this.nombrelb.TabIndex = 1;
            this.nombrelb.Text = "Nombre y apellidos:";
            // 
            // nombretb
            // 
            this.nombretb.Location = new System.Drawing.Point(65, 111);
            this.nombretb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombretb.Name = "nombretb";
            this.nombretb.Size = new System.Drawing.Size(145, 20);
            this.nombretb.TabIndex = 2;
            // 
            // contraseñatb
            // 
            this.contraseñatb.Location = new System.Drawing.Point(65, 170);
            this.contraseñatb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contraseñatb.Name = "contraseñatb";
            this.contraseñatb.Size = new System.Drawing.Size(145, 20);
            this.contraseñatb.TabIndex = 4;
            // 
            // contraseñalb
            // 
            this.contraseñalb.AutoSize = true;
            this.contraseñalb.Location = new System.Drawing.Point(72, 155);
            this.contraseñalb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contraseñalb.Name = "contraseñalb";
            this.contraseñalb.Size = new System.Drawing.Size(64, 13);
            this.contraseñalb.TabIndex = 3;
            this.contraseñalb.Text = "Contraseña:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 225);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 21);
            this.button1.TabIndex = 5;
            this.button1.Text = "Log ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contraseñatb);
            this.Controls.Add(this.contraseñalb);
            this.Controls.Add(this.nombretb);
            this.Controls.Add(this.nombrelb);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginComercial";
            this.Text = "LoginComercial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombrelb;
        private System.Windows.Forms.TextBox nombretb;
        private System.Windows.Forms.TextBox contraseñatb;
        private System.Windows.Forms.Label contraseñalb;
        private System.Windows.Forms.Button button1;
    }
}