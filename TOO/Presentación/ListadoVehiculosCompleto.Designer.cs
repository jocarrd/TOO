namespace Presentación
{
    partial class ListadoVehiculosCompleto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumBastidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioRecomendado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumBastidor,
            this.marca,
            this.modelo,
            this.potencia,
            this.precioRecomendado,
            this.PVP});
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(967, 316);
            this.dataGridView1.TabIndex = 1;
            // 
            // NumBastidor
            // 
            this.NumBastidor.HeaderText = "Numero de Bastidor";
            this.NumBastidor.MinimumWidth = 8;
            this.NumBastidor.Name = "NumBastidor";
            this.NumBastidor.Width = 150;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.MinimumWidth = 8;
            this.marca.Name = "marca";
            this.marca.Width = 150;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.MinimumWidth = 8;
            this.modelo.Name = "modelo";
            this.modelo.Width = 150;
            // 
            // potencia
            // 
            this.potencia.HeaderText = "Potencia";
            this.potencia.MinimumWidth = 8;
            this.potencia.Name = "potencia";
            this.potencia.Width = 150;
            // 
            // precioRecomendado
            // 
            this.precioRecomendado.HeaderText = "Precio Recomendado";
            this.precioRecomendado.MinimumWidth = 8;
            this.precioRecomendado.Name = "precioRecomendado";
            this.precioRecomendado.Width = 150;
            // 
            // PVP
            // 
            this.PVP.HeaderText = "PVP";
            this.PVP.MinimumWidth = 8;
            this.PVP.Name = "PVP";
            this.PVP.Width = 150;
            // 
            // ListadoVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListadoVehiculos";
            this.Text = "ListadoVehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumBastidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn potencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioRecomendado;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVP;
    }
}