using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_Front
{
    public partial class FrmMenuAdmin : frmMenuEmpleado
    {
        public FrmMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnEmpleadosInfo_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            frmEmpleados.Show();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            frmVerVentas frmVerVentas = new frmVerVentas();
            frmVerVentas.Show();
        }

        private void FrmMenuAdmin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
