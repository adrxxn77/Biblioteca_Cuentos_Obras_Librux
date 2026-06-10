namespace diseño
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.lbBusquedaRapida = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.btnRecomendados = new System.Windows.Forms.Button();
            this.btnEspera = new System.Windows.Forms.Button();
            this.btnSolicitud = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(115, 72);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(224, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(756, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 105);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(49, 78);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(60, 16);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Usuario: ";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(258, 290);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(559, 276);
            this.listBox1.TabIndex = 3;
            // 
            // btnRegistar
            // 
            this.btnRegistar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistar.Location = new System.Drawing.Point(395, 61);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(139, 51);
            this.btnRegistar.TabIndex = 4;
            this.btnRegistar.Text = "Registrar";
            this.btnRegistar.UseVisualStyleBackColor = false;
            // 
            // lbBusquedaRapida
            // 
            this.lbBusquedaRapida.AutoSize = true;
            this.lbBusquedaRapida.Location = new System.Drawing.Point(49, 161);
            this.lbBusquedaRapida.Name = "lbBusquedaRapida";
            this.lbBusquedaRapida.Size = new System.Drawing.Size(117, 16);
            this.lbBusquedaRapida.TabIndex = 5;
            this.lbBusquedaRapida.Text = "Busqueda Rapida";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 22);
            this.textBox2.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.Location = new System.Drawing.Point(426, 138);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 49);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHistorial.Location = new System.Drawing.Point(888, 308);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(146, 49);
            this.btnHistorial.TabIndex = 8;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDevolver.Location = new System.Drawing.Point(52, 517);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(147, 49);
            this.btnDevolver.TabIndex = 9;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrestamo.Location = new System.Drawing.Point(52, 409);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(147, 49);
            this.btnPrestamo.TabIndex = 10;
            this.btnPrestamo.Text = "Pedir Prestamo";
            this.btnPrestamo.UseVisualStyleBackColor = false;
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCatalogo.Location = new System.Drawing.Point(52, 308);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(147, 49);
            this.btnCatalogo.TabIndex = 11;
            this.btnCatalogo.Text = " Catalogo";
            this.btnCatalogo.UseVisualStyleBackColor = false;
            // 
            // btnRecomendados
            // 
            this.btnRecomendados.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRecomendados.Location = new System.Drawing.Point(459, 225);
            this.btnRecomendados.Name = "btnRecomendados";
            this.btnRecomendados.Size = new System.Drawing.Size(154, 49);
            this.btnRecomendados.TabIndex = 12;
            this.btnRecomendados.Text = "Recomendados";
            this.btnRecomendados.UseVisualStyleBackColor = false;
            // 
            // btnEspera
            // 
            this.btnEspera.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEspera.Location = new System.Drawing.Point(888, 517);
            this.btnEspera.Name = "btnEspera";
            this.btnEspera.Size = new System.Drawing.Size(146, 49);
            this.btnEspera.TabIndex = 13;
            this.btnEspera.Text = "List. Espera";
            this.btnEspera.UseVisualStyleBackColor = false;
            // 
            // btnSolicitud
            // 
            this.btnSolicitud.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSolicitud.Location = new System.Drawing.Point(888, 409);
            this.btnSolicitud.Name = "btnSolicitud";
            this.btnSolicitud.Size = new System.Drawing.Size(146, 49);
            this.btnSolicitud.TabIndex = 14;
            this.btnSolicitud.Text = "Solicitar Prestamo";
            this.btnSolicitud.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSalir.Location = new System.Drawing.Point(459, 582);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(154, 38);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1092, 642);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSolicitud);
            this.Controls.Add(this.btnEspera);
            this.Controls.Add(this.btnRecomendados);
            this.Controls.Add(this.btnCatalogo);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbBusquedaRapida);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Form1";
            this.Text = "Biblioteca_Obras_Cuentos_Librux";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Label lbBusquedaRapida;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Button btnRecomendados;
        private System.Windows.Forms.Button btnEspera;
        private System.Windows.Forms.Button btnSolicitud;
        private System.Windows.Forms.Button btnSalir;
    }
}

