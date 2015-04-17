using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge;

namespace ControladorFresaCNC
{
    public partial class frmPrincipal : Form
    {
        BaseUsingCopyPartialFilter filtro;
        int Ancho, Alto;
        bool Borde;
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            filtro = new CannyEdgeDetector();

            
        }

        private void menuAbrirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Archivos de Imagen (*.jpg;*.bmp;*.png;*.pbm;*.tiff)|*.jpg;*.bmp;*.png;*.pbm;*.tiff";
            if (dialogo.ShowDialog() == DialogResult.Cancel) return;

            pbImagen.Image = Bitmap.FromFile(dialogo.FileName);

            frmDatos ventana = new frmDatos();
            ventana.Show();

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            
        }

        
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.png";
            dialogo.Title = "Guardar Imagen";
            dialogo.ShowDialog();

            if (dialogo.FileName != "")
            {
                System.IO.FileStream stream =
                    (System.IO.FileStream)dialogo.OpenFile();

                switch (dialogo.FilterIndex)
                { 
                    case 1 :
                        pbImagen.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        pbImagen.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        pbImagen.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
            }
        }


        private void menuEnlazarFresa_Click(object sender, EventArgs e)
        {
            if (menuEnlazarFresa.ForeColor == Color.Red)
            {
                frmConexionSerial ventana = new frmConexionSerial(this);
                ventana.Show();
            }
            else
            {
                DialogResult resultado=MessageBox.Show("Desea terminar la conexion?", "Mensage", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    serialPort.Close();
                    menuEnlazarFresa.ForeColor = Color.Red;
                    menuEnlazarFresa.Image = Properties.Resources.linkOff;
                }
            }
        }

        private void btnEjemplo1_Click(object sender, EventArgs e)
        {   
            Ancho = 5;
            Alto = 5;
            Borde = true;
            pbImagen.Image = Properties.Resources.Sencillo;
            lblTamaño.Text = "Tamaño: " + Ancho + " x " + Alto + " cm";
        }

        private void btnEjemplo2_Click(object sender, EventArgs e)
        {   
            Ancho = 10;
            Alto = 10;
            Borde = false;
            pbImagen.Image = Properties.Resources.kk;
            lblTamaño.Text = "Tamaño: " + Ancho + " x " + Alto + " cm";
        }

        

        
    }
}
