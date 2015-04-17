using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControladorFresaCNC
{
    public partial class frmDatos : Form
    {
        public frmDatos(ref int ancho,ref int alto,ref bool borde)
        {
            InitializeComponent();
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
