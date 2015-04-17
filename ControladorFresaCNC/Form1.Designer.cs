namespace ControladorFresaCNC
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbrirImagen = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEnlazarFresa = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoAvanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupElementos = new System.Windows.Forms.GroupBox();
            this.lblProcesando = new System.Windows.Forms.Label();
            this.lblMostrando = new System.Windows.Forms.Label();
            this.lblElementos = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupEjemplos = new System.Windows.Forms.GroupBox();
            this.btnEjemplo5 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnEjemplo4 = new System.Windows.Forms.Button();
            this.btnEjemplo3 = new System.Windows.Forms.Button();
            this.btnEjemplo2 = new System.Windows.Forms.Button();
            this.btnEjemplo1 = new System.Windows.Forms.Button();
            this.pbarProcesado = new System.Windows.Forms.ProgressBar();
            this.lblPbar = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblTamaño = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.groupElementos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupEjemplos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuEnlazarFresa,
            this.herramientasToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1018, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbrirImagen,
            this.guardarToolStripMenuItem});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "Archivo";
            // 
            // menuAbrirImagen
            // 
            this.menuAbrirImagen.Name = "menuAbrirImagen";
            this.menuAbrirImagen.Size = new System.Drawing.Size(143, 22);
            this.menuAbrirImagen.Text = "Abrir Imagen";
            this.menuAbrirImagen.Click += new System.EventHandler(this.menuAbrirImagen_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // menuEnlazarFresa
            // 
            this.menuEnlazarFresa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuEnlazarFresa.Checked = true;
            this.menuEnlazarFresa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuEnlazarFresa.ForeColor = System.Drawing.Color.Red;
            this.menuEnlazarFresa.Image = global::ControladorFresaCNC.Properties.Resources.linkOff;
            this.menuEnlazarFresa.Name = "menuEnlazarFresa";
            this.menuEnlazarFresa.Size = new System.Drawing.Size(135, 20);
            this.menuEnlazarFresa.Text = "Enlazar a Fresadora";
            this.menuEnlazarFresa.Click += new System.EventHandler(this.menuEnlazarFresa_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesoAvanzadoToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // procesoAvanzadoToolStripMenuItem
            // 
            this.procesoAvanzadoToolStripMenuItem.Name = "procesoAvanzadoToolStripMenuItem";
            this.procesoAvanzadoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.procesoAvanzadoToolStripMenuItem.Text = "Proceso Avanzado";
            // 
            // serialPort
            // 
            this.serialPort.Parity = System.IO.Ports.Parity.Even;
            // 
            // groupElementos
            // 
            this.groupElementos.Controls.Add(this.lblProcesando);
            this.groupElementos.Controls.Add(this.lblMostrando);
            this.groupElementos.Controls.Add(this.lblElementos);
            this.groupElementos.Controls.Add(this.pictureBox5);
            this.groupElementos.Controls.Add(this.pictureBox6);
            this.groupElementos.Controls.Add(this.pictureBox3);
            this.groupElementos.Controls.Add(this.pictureBox4);
            this.groupElementos.Controls.Add(this.pictureBox2);
            this.groupElementos.Controls.Add(this.pictureBox1);
            this.groupElementos.Location = new System.Drawing.Point(743, 163);
            this.groupElementos.Name = "groupElementos";
            this.groupElementos.Size = new System.Drawing.Size(248, 386);
            this.groupElementos.TabIndex = 5;
            this.groupElementos.TabStop = false;
            this.groupElementos.Text = "Elementos Independientes";
            // 
            // lblProcesando
            // 
            this.lblProcesando.AutoSize = true;
            this.lblProcesando.Location = new System.Drawing.Point(21, 365);
            this.lblProcesando.Name = "lblProcesando";
            this.lblProcesando.Size = new System.Drawing.Size(130, 13);
            this.lblProcesando.TabIndex = 7;
            this.lblProcesando.Text = "Procesando: Sin Procesar";
            // 
            // lblMostrando
            // 
            this.lblMostrando.AutoSize = true;
            this.lblMostrando.Location = new System.Drawing.Point(21, 48);
            this.lblMostrando.Name = "lblMostrando";
            this.lblMostrando.Size = new System.Drawing.Size(123, 13);
            this.lblMostrando.TabIndex = 7;
            this.lblMostrando.Text = "Mostrando: Sin Procesar";
            // 
            // lblElementos
            // 
            this.lblElementos.AutoSize = true;
            this.lblElementos.Location = new System.Drawing.Point(21, 29);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(185, 13);
            this.lblElementos.TabIndex = 6;
            this.lblElementos.Text = "Elementos Encontrados: Sin Procesar";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(132, 272);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 85);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(16, 272);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 85);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(132, 177);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(16, 177);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 85);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(131, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupEjemplos
            // 
            this.groupEjemplos.Controls.Add(this.btnEjemplo5);
            this.groupEjemplos.Controls.Add(this.btnEjemplo4);
            this.groupEjemplos.Controls.Add(this.btnEjemplo3);
            this.groupEjemplos.Controls.Add(this.btnEjemplo2);
            this.groupEjemplos.Controls.Add(this.btnEjemplo1);
            this.groupEjemplos.Location = new System.Drawing.Point(12, 38);
            this.groupEjemplos.Name = "groupEjemplos";
            this.groupEjemplos.Size = new System.Drawing.Size(133, 511);
            this.groupEjemplos.TabIndex = 6;
            this.groupEjemplos.TabStop = false;
            this.groupEjemplos.Text = "Ejemplos";
            // 
            // btnEjemplo5
            // 
            this.btnEjemplo5.ImageIndex = 0;
            this.btnEjemplo5.ImageList = this.imageList1;
            this.btnEjemplo5.Location = new System.Drawing.Point(6, 403);
            this.btnEjemplo5.Name = "btnEjemplo5";
            this.btnEjemplo5.Size = new System.Drawing.Size(120, 90);
            this.btnEjemplo5.TabIndex = 11;
            this.btnEjemplo5.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Sencillo.PNG");
            this.imageList1.Images.SetKeyName(1, "kk.png");
            // 
            // btnEjemplo4
            // 
            this.btnEjemplo4.ImageIndex = 0;
            this.btnEjemplo4.ImageList = this.imageList1;
            this.btnEjemplo4.Location = new System.Drawing.Point(6, 307);
            this.btnEjemplo4.Name = "btnEjemplo4";
            this.btnEjemplo4.Size = new System.Drawing.Size(120, 90);
            this.btnEjemplo4.TabIndex = 10;
            this.btnEjemplo4.UseVisualStyleBackColor = true;
            // 
            // btnEjemplo3
            // 
            this.btnEjemplo3.ImageIndex = 0;
            this.btnEjemplo3.ImageList = this.imageList1;
            this.btnEjemplo3.Location = new System.Drawing.Point(6, 211);
            this.btnEjemplo3.Name = "btnEjemplo3";
            this.btnEjemplo3.Size = new System.Drawing.Size(120, 90);
            this.btnEjemplo3.TabIndex = 9;
            this.btnEjemplo3.UseVisualStyleBackColor = true;
            // 
            // btnEjemplo2
            // 
            this.btnEjemplo2.ImageIndex = 1;
            this.btnEjemplo2.ImageList = this.imageList1;
            this.btnEjemplo2.Location = new System.Drawing.Point(6, 115);
            this.btnEjemplo2.Name = "btnEjemplo2";
            this.btnEjemplo2.Size = new System.Drawing.Size(120, 90);
            this.btnEjemplo2.TabIndex = 8;
            this.btnEjemplo2.UseVisualStyleBackColor = true;
            this.btnEjemplo2.Click += new System.EventHandler(this.btnEjemplo2_Click);
            // 
            // btnEjemplo1
            // 
            this.btnEjemplo1.ImageIndex = 0;
            this.btnEjemplo1.ImageList = this.imageList1;
            this.btnEjemplo1.Location = new System.Drawing.Point(6, 19);
            this.btnEjemplo1.Name = "btnEjemplo1";
            this.btnEjemplo1.Size = new System.Drawing.Size(120, 90);
            this.btnEjemplo1.TabIndex = 7;
            this.btnEjemplo1.UseVisualStyleBackColor = true;
            this.btnEjemplo1.Click += new System.EventHandler(this.btnEjemplo1_Click);
            // 
            // pbarProcesado
            // 
            this.pbarProcesado.Location = new System.Drawing.Point(172, 526);
            this.pbarProcesado.Name = "pbarProcesado";
            this.pbarProcesado.Size = new System.Drawing.Size(550, 23);
            this.pbarProcesado.TabIndex = 7;
            // 
            // lblPbar
            // 
            this.lblPbar.AutoSize = true;
            this.lblPbar.Location = new System.Drawing.Point(441, 531);
            this.lblPbar.Name = "lblPbar";
            this.lblPbar.Size = new System.Drawing.Size(21, 13);
            this.lblPbar.TabIndex = 8;
            this.lblPbar.Text = "0%";
            this.lblPbar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::ControladorFresaCNC.Properties.Resources.button_cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(743, 95);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 51);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pbImagen
            // 
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Location = new System.Drawing.Point(172, 67);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(550, 450);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 3;
            this.pbImagen.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::ControladorFresaCNC.Properties.Resources.taladro;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(870, 38);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(121, 51);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Image = global::ControladorFresaCNC.Properties.Resources.procesar;
            this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesar.Location = new System.Drawing.Point(743, 38);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(121, 51);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblTamaño
            // 
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Location = new System.Drawing.Point(206, 51);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(49, 13);
            this.lblTamaño.TabIndex = 9;
            this.lblTamaño.Text = "Tamaño:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 561);
            this.Controls.Add(this.lblTamaño);
            this.Controls.Add(this.lblPbar);
            this.Controls.Add(this.pbarProcesado);
            this.Controls.Add(this.groupEjemplos);
            this.Controls.Add(this.groupElementos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximumSize = new System.Drawing.Size(1034, 600);
            this.MinimumSize = new System.Drawing.Size(1034, 600);
            this.Name = "frmPrincipal";
            this.Text = "Control Fresadora";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.groupElementos.ResumeLayout(false);
            this.groupElementos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupEjemplos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem menuAbrirImagen;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menuEnlazarFresa;
        public System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStripMenuItem procesoAvanzadoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupElementos;
        private System.Windows.Forms.GroupBox groupEjemplos;
        private System.Windows.Forms.Button btnEjemplo1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnEjemplo5;
        private System.Windows.Forms.Button btnEjemplo4;
        private System.Windows.Forms.Button btnEjemplo3;
        private System.Windows.Forms.Button btnEjemplo2;
        private System.Windows.Forms.Label lblProcesando;
        private System.Windows.Forms.Label lblMostrando;
        private System.Windows.Forms.Label lblElementos;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar pbarProcesado;
        private System.Windows.Forms.Label lblPbar;
        private System.Windows.Forms.PictureBox pbImagen;
        public System.Windows.Forms.Label lblTamaño;
    }
}

