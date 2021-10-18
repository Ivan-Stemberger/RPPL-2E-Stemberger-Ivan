
namespace PetShop_Front
{
    partial class frmVerVentas
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
            this.dtgvVentas = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvVentas
            // 
            this.dtgvVentas.AllowUserToAddRows = false;
            this.dtgvVentas.AllowUserToDeleteRows = false;
            this.dtgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVentas.Location = new System.Drawing.Point(50, 62);
            this.dtgvVentas.Name = "dtgvVentas";
            this.dtgvVentas.ReadOnly = true;
            this.dtgvVentas.RowTemplate.Height = 25;
            this.dtgvVentas.Size = new System.Drawing.Size(688, 269);
            this.dtgvVentas.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(663, 337);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 39);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Exportar a CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmVerVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtgvVentas);
            this.Name = "frmVerVentas";
            this.Text = "frmVerVentas";
            this.Load += new System.EventHandler(this.frmVerVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvVentas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnExport;
    }
}