namespace DiscosDb
{
    partial class FrmAltaDiscos
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
            this.Titulo = new System.Windows.Forms.Label();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCanciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstilos = new System.Windows.Forms.ComboBox();
            this.cboTipoEdicion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(7, 81);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(29, 13);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "titulo";
            // 
            // picImg
            // 
            this.picImg.BackColor = System.Drawing.Color.AliceBlue;
            this.picImg.Location = new System.Drawing.Point(464, 26);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(302, 292);
            this.picImg.TabIndex = 1;
            this.picImg.TabStop = false;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(99, 78);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(92, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtCanciones
            // 
            this.txtCanciones.Location = new System.Drawing.Point(99, 142);
            this.txtCanciones.Name = "txtCanciones";
            this.txtCanciones.Size = new System.Drawing.Size(92, 20);
            this.txtCanciones.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cant. Canciones";
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(313, 211);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(92, 20);
            this.txtImagen.TabIndex = 2;
            this.txtImagen.Leave += new System.EventHandler(this.txtImagen_Leave);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(208, 218);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(42, 13);
            this.lblImagen.TabIndex = 5;
            this.lblImagen.Text = "Imagen";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(218, 81);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(32, 13);
            this.lblEstilo.TabIndex = 7;
            this.lblEstilo.Text = "Estilo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = " Lanzamiento";
            // 
            // dataFecha
            // 
            this.dataFecha.Location = new System.Drawing.Point(99, 211);
            this.dataFecha.Name = "dataFecha";
            this.dataFecha.Size = new System.Drawing.Size(92, 20);
            this.dataFecha.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(363, 348);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 27);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(191, 349);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(74, 26);
            this.BtnReset.TabIndex = 5;
            this.BtnReset.Text = "Reiniciar ";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "TipoEdicion";
            // 
            // cboEstilos
            // 
            this.cboEstilos.FormattingEnabled = true;
            this.cboEstilos.Location = new System.Drawing.Point(313, 73);
            this.cboEstilos.Name = "cboEstilos";
            this.cboEstilos.Size = new System.Drawing.Size(92, 21);
            this.cboEstilos.TabIndex = 12;
            // 
            // cboTipoEdicion
            // 
            this.cboTipoEdicion.FormattingEnabled = true;
            this.cboTipoEdicion.Location = new System.Drawing.Point(313, 142);
            this.cboTipoEdicion.Name = "cboTipoEdicion";
            this.cboTipoEdicion.Size = new System.Drawing.Size(92, 21);
            this.cboTipoEdicion.TabIndex = 13;
            // 
            // FrmAltaDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboTipoEdicion);
            this.Controls.Add(this.cboEstilos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.txtCanciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.picImg);
            this.Controls.Add(this.Titulo);
            this.Name = "FrmAltaDiscos";
            this.Text = "FrmAltaDiscos";
            this.Load += new System.EventHandler(this.FrmAltaDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCanciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dataFecha;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEstilos;
        private System.Windows.Forms.ComboBox cboTipoEdicion;
    }
}