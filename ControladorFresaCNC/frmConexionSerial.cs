using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ControladorFresaCNC
{
    public partial class frmConexionSerial : Form
    {
        frmPrincipal Padre;
        public frmConexionSerial(frmPrincipal padre)
        {   
            InitializeComponent();
            Padre = padre;
        }

        private void frmConexionSerial_Load(object sender, EventArgs e)
        {
            foreach (string Puerto in SerialPort.GetPortNames())
            {
                cmbPuertos.Items.Add(Puerto);
            }
            if(cmbPuertos.Items.Count>0)
            cmbPuertos.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {            
                try
                {
                    Padre.serialPort.PortName = cmbPuertos.SelectedItem.ToString();
                    Padre.serialPort.Open();
            
                    MessageBox.Show("Conexion Exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Padre.menuEnlazarFresa.ForeColor = Color.Green;
                    Padre.menuEnlazarFresa.Image = Properties.Resources.linkOn;
                    this.Close();
                }
                catch { MessageBox.Show("Error de Conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void cmbPuertos_Click(object sender, EventArgs e)
        {
            cmbPuertos.Items.Clear();
            foreach (string Puerto in SerialPort.GetPortNames())
            {
                cmbPuertos.Items.Add(Puerto);
            }
        }
    }
}
