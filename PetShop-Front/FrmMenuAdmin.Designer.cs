
namespace PetShop_Front
{
    partial class FrmMenuAdmin
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
            this.btnEmpleadosInfo = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // btnEmpleadosInfo
            // 
            this.btnEmpleadosInfo.Location = new System.Drawing.Point(101, 185);
            this.btnEmpleadosInfo.Name = "btnEmpleadosInfo";
            this.btnEmpleadosInfo.Size = new System.Drawing.Size(208, 80);
            this.btnEmpleadosInfo.TabIndex = 2;
            this.btnEmpleadosInfo.Text = "Información de los empleados";
            this.btnEmpleadosInfo.UseVisualStyleBackColor = true;
            this.btnEmpleadosInfo.Click += new System.EventHandler(this.btnEmpleadosInfo_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Location = new System.Drawing.Point(498, 185);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(208, 80);
            this.btnFacturacion.TabIndex = 3;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // FrmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.btnEmpleadosInfo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmMenuAdmin";
            this.Text = "FrmMenuAdmin";
            this.Load += new System.EventHandler(this.FrmMenuAdmin_Load);
            this.Controls.SetChildIndex(this.btnEmpleadosInfo, 0);
            this.Controls.SetChildIndex(this.btnFacturacion, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleadosInfo;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
    }
}