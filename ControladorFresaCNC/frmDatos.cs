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
        frmPrincipal Padre;
        public frmDatos(frmPrincipal _Padre)
        {
            InitializeComponent();
            Padre = _Padre;
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            cmbAltoMedidaEn.SelectedItem = "cm";
            cmbAnchoMedidaEn.SelectedItem = "cm";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Establecer las propiedades fisicas del PCB y mostrarlo
            Padre.Ancho =(float) neAncho.Value;
            Padre.Alto = (float)neAlto.Value;            
            Padre.lblTamaño.Text = "Tamaño: " + Padre.Ancho + " x " + Padre.Alto + " cm";

            //Esta variable es para buscar o no el borde en la imagen, esto ayudará a facilitar en procesamiento de la imagen
            Padre.Borde = rdSi.Checked; 

            this.Close();
        }
    }
}
