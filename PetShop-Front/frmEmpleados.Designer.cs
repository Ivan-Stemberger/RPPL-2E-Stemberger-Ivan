
namespace PetShop_Front
{
    partial class frmEmpleados
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
            this.btnVerEmpleados = new System.Windows.Forms.Button();
            this.btnAgregarEmpleados = new System.Windows.Forms.Button();
            this.btnEditarEmpleado = new System.Windows.Forms.Button();
            this.btnBorrarEmpleado = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerEmpleados
            // 
            this.btnVerEmpleados.Location = new System.Drawing.Point(310, 54);
            this.btnVerEmpleados.Name = "btnVerEmpleados";
            this.btnVerEmpleados.Size = new System.Drawing.Size(155, 54);
            this.btnVerEmpleados.TabIndex = 0;
            this.btnVerEmpleados.Text = "Ver Empleados";
            this.btnVerEmpleados.UseVisualStyleBackColor = true;
            this.btnVerEmpleados.Click += new System.EventHandler(this.btnVerEmpleados_Click);
            // 
            // btnAgregarEmpleados
            // 
            this.btnAgregarEmpleados.Location = new System.Drawing.Point(310, 134);
            this.btnAgregarEmpleados.Name = "btnAgregarEmpleados";
            this.btnAgregarEmpleados.Size = new System.Drawing.Size(155, 50);
            this.btnAgregarEmpleados.TabIndex = 1;
            this.btnAgregarEmpleados.Text = "Agregar Empleado";
            this.btnAgregarEmpleados.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleados.Click += new System.EventHandler(this.btnAgregarEmpleados_Click);
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.Location = new System.Drawing.Point(310, 206);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Size = new System.Drawing.Size(155, 51);
            this.btnEditarEmpleado.TabIndex = 2;
            this.btnEditarEmpleado.Text = "Editar Empleado";
            this.btnEditarEmpleado.UseVisualStyleBackColor = true;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.btnEditarEmpleado_Click);
            // 
            // btnBorrarEmpleado
            // 
            this.btnBorrarEmpleado.Location = new System.Drawing.Point(310, 283);
            this.btnBorrarEmpleado.Name = "btnBorrarEmpleado";
            this.btnBorrarEmpleado.Size = new System.Drawing.Size(155, 51);
            this.btnBorrarEmpleado.TabIndex = 3;
            this.btnBorrarEmpleado.Text = "Borrar Empleado";
            this.btnBorrarEmpleado.UseVisualStyleBackColor = true;
            this.btnBorrarEmpleado.Click += new System.EventHandler(this.btnBorrarEmpleado_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(23, 21);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 36);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseMnemonic = false;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBorrarEmpleado);
            this.Controls.Add(this.btnEditarEmpleado);
            this.Controls.Add(this.btnAgregarEmpleados);
            this.Controls.Add(this.btnVerEmpleados);
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerEmpleados;
        private System.Windows.Forms.Button btnAgregarEmpleados;
        private System.Windows.Forms.Button btnEditarEmpleado;
        private System.Windows.Forms.Button btnBorrarEmpleado;
        private System.Windows.Forms.Button btnVolver;
    }
}