
namespace PetShop_Front
{
    partial class frmFinalizarVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.lblTipoEnvio = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvVentas
            // 
            this.dtgvVentas.AllowUserToAddRows = false;
            this.dtgvVentas.AllowUserToDeleteRows = false;
            this.dtgvVentas.AllowUserToOrderColumns = true;
            this.dtgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVentas.Location = new System.Drawing.Point(0, 0);
            this.dtgvVentas.Name = "dtgvVentas";
            this.dtgvVentas.ReadOnly = true;
            this.dtgvVentas.RowTemplate.Height = 25;
            this.dtgvVentas.Size = new System.Drawing.Size(511, 193);
            this.dtgvVentas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto a pagar";
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.Location = new System.Drawing.Point(647, 304);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(138, 53);
            this.btnConfirmarVenta.TabIndex = 3;
            this.btnConfirmarVenta.Text = "Finalizar Venta";
            this.btnConfirmarVenta.UseVisualStyleBackColor = true;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(39, 304);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 53);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(663, 20);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(125, 23);
            this.txtDniCliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Introducir DNI del cliente";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Location = new System.Drawing.Point(457, 196);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(0, 15);
            this.lblPrecioFinal.TabIndex = 7;
            // 
            // lblTipoEnvio
            // 
            this.lblTipoEnvio.AutoSize = true;
            this.lblTipoEnvio.Location = new System.Drawing.Point(567, 57);
            this.lblTipoEnvio.Name = "lblTipoEnvio";
            this.lblTipoEnvio.Size = new System.Drawing.Size(38, 15);
            this.lblTipoEnvio.TabIndex = 8;
            this.lblTipoEnvio.Text = "label3";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(567, 101);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(38, 15);
            this.lblDistancia.TabIndex = 9;
            this.lblDistancia.Text = "label3";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(567, 143);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(38, 15);
            this.lblMonto.TabIndex = 10;
            this.lblMonto.Text = "label3";
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(660, 259);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(125, 23);
            this.txtPago.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pago realizado";
            // 
            // frmFinalizarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblTipoEnvio);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvVentas);
            this.Name = "frmFinalizarVenta";
            this.Text = "frmFinalizarVenta";
            this.Load += new System.EventHandler(this.frmFinalizarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Label lblTipoEnvio;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label3;
    }
}