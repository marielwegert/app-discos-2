namespace principal
{
    partial class frmAltaDisco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaDisco));
            this.lblDisco = new System.Windows.Forms.Label();
            this.lblErrorCantCanciones = new System.Windows.Forms.Label();
            this.lblErrorEstilo = new System.Windows.Forms.Label();
            this.lblErrorTipoEdicion = new System.Windows.Forms.Label();
            this.lblErrorFechaLanzamiento = new System.Windows.Forms.Label();
            this.lblErrorTitulo = new System.Windows.Forms.Label();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.pbxDisco = new System.Windows.Forms.PictureBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lblTipoEdicion = new System.Windows.Forms.Label();
            this.cboTipoEdicion = new System.Windows.Forms.ComboBox();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCantCanciones = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblCantCanciones = new System.Windows.Forms.Label();
            this.lblFechaLanzamiento = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.pbxImgDisco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDisco
            // 
            this.lblDisco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDisco.AutoSize = true;
            this.lblDisco.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisco.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDisco.Location = new System.Drawing.Point(382, 29);
            this.lblDisco.Name = "lblDisco";
            this.lblDisco.Size = new System.Drawing.Size(211, 38);
            this.lblDisco.TabIndex = 65;
            this.lblDisco.Text = "Nuevo Disco";
            // 
            // lblErrorCantCanciones
            // 
            this.lblErrorCantCanciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErrorCantCanciones.AutoSize = true;
            this.lblErrorCantCanciones.BackColor = System.Drawing.SystemColors.Window;
            this.lblErrorCantCanciones.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCantCanciones.Location = new System.Drawing.Point(339, 284);
            this.lblErrorCantCanciones.Name = "lblErrorCantCanciones";
            this.lblErrorCantCanciones.Size = new System.Drawing.Size(0, 20);
            this.lblErrorCantCanciones.TabIndex = 64;
            // 
            // lblErrorEstilo
            // 
            this.lblErrorEstilo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErrorEstilo.AutoSize = true;
            this.lblErrorEstilo.BackColor = System.Drawing.SystemColors.Window;
            this.lblErrorEstilo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEstilo.Location = new System.Drawing.Point(339, 420);
            this.lblErrorEstilo.Name = "lblErrorEstilo";
            this.lblErrorEstilo.Size = new System.Drawing.Size(0, 20);
            this.lblErrorEstilo.TabIndex = 63;
            // 
            // lblErrorTipoEdicion
            // 
            this.lblErrorTipoEdicion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErrorTipoEdicion.AutoSize = true;
            this.lblErrorTipoEdicion.BackColor = System.Drawing.SystemColors.Window;
            this.lblErrorTipoEdicion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTipoEdicion.Location = new System.Drawing.Point(339, 494);
            this.lblErrorTipoEdicion.Name = "lblErrorTipoEdicion";
            this.lblErrorTipoEdicion.Size = new System.Drawing.Size(0, 20);
            this.lblErrorTipoEdicion.TabIndex = 62;
            // 
            // lblErrorFechaLanzamiento
            // 
            this.lblErrorFechaLanzamiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErrorFechaLanzamiento.AutoSize = true;
            this.lblErrorFechaLanzamiento.BackColor = System.Drawing.SystemColors.Window;
            this.lblErrorFechaLanzamiento.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaLanzamiento.Location = new System.Drawing.Point(339, 219);
            this.lblErrorFechaLanzamiento.Name = "lblErrorFechaLanzamiento";
            this.lblErrorFechaLanzamiento.Size = new System.Drawing.Size(0, 20);
            this.lblErrorFechaLanzamiento.TabIndex = 61;
            // 
            // lblErrorTitulo
            // 
            this.lblErrorTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErrorTitulo.AutoSize = true;
            this.lblErrorTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.lblErrorTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTitulo.Location = new System.Drawing.Point(339, 142);
            this.lblErrorTitulo.Name = "lblErrorTitulo";
            this.lblErrorTitulo.Size = new System.Drawing.Size(0, 20);
            this.lblErrorTitulo.TabIndex = 60;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImagen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregarImagen.FlatAppearance.BorderSize = 3;
            this.btnAgregarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarImagen.Image")));
            this.btnAgregarImagen.Location = new System.Drawing.Point(599, 313);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(35, 35);
            this.btnAgregarImagen.TabIndex = 4;
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaLanzamiento.Checked = false;
            this.dtpFechaLanzamiento.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaLanzamiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(396, 173);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.ShowCheckBox = true;
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(197, 34);
            this.dtpFechaLanzamiento.TabIndex = 1;
            this.dtpFechaLanzamiento.Value = new System.DateTime(2024, 7, 21, 22, 38, 25, 0);
            // 
            // pbxDisco
            // 
            this.pbxDisco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxDisco.Location = new System.Drawing.Point(665, 151);
            this.pbxDisco.Name = "pbxDisco";
            this.pbxDisco.Size = new System.Drawing.Size(295, 257);
            this.pbxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDisco.TabIndex = 57;
            this.pbxDisco.TabStop = false;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUrlImagen.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUrlImagen.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrlImagen.Location = new System.Drawing.Point(396, 313);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(197, 34);
            this.txtUrlImagen.TabIndex = 3;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImagen.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUrlImagen.Location = new System.Drawing.Point(241, 316);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(137, 25);
            this.lblUrlImagen.TabIndex = 56;
            this.lblUrlImagen.Text = "Url Imagen:";
            // 
            // lblTipoEdicion
            // 
            this.lblTipoEdicion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipoEdicion.AutoSize = true;
            this.lblTipoEdicion.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEdicion.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTipoEdicion.Location = new System.Drawing.Point(197, 452);
            this.lblTipoEdicion.Name = "lblTipoEdicion";
            this.lblTipoEdicion.Size = new System.Drawing.Size(181, 25);
            this.lblTipoEdicion.TabIndex = 55;
            this.lblTipoEdicion.Text = "Tipo de edicion:";
            // 
            // cboTipoEdicion
            // 
            this.cboTipoEdicion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTipoEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEdicion.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoEdicion.FormattingEnabled = true;
            this.cboTipoEdicion.Location = new System.Drawing.Point(396, 452);
            this.cboTipoEdicion.Name = "cboTipoEdicion";
            this.cboTipoEdicion.Size = new System.Drawing.Size(197, 33);
            this.cboTipoEdicion.TabIndex = 6;
            // 
            // cboEstilo
            // 
            this.cboEstilo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(396, 383);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(197, 33);
            this.cboEstilo.TabIndex = 5;
            // 
            // lblEstilo
            // 
            this.lblEstilo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstilo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEstilo.Location = new System.Drawing.Point(307, 386);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(71, 25);
            this.lblEstilo.TabIndex = 54;
            this.lblEstilo.Text = "Estilo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCancelar.FlatAppearance.BorderSize = 3;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.Location = new System.Drawing.Point(459, 526);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 49);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAceptar.FlatAppearance.BorderSize = 3;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAceptar.Location = new System.Drawing.Point(279, 526);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(134, 49);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCantCanciones
            // 
            this.txtCantCanciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCantCanciones.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCantCanciones.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantCanciones.Location = new System.Drawing.Point(396, 243);
            this.txtCantCanciones.Name = "txtCantCanciones";
            this.txtCantCanciones.Size = new System.Drawing.Size(197, 34);
            this.txtCantCanciones.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTitulo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(396, 103);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(197, 34);
            this.txtTitulo.TabIndex = 0;
            // 
            // lblCantCanciones
            // 
            this.lblCantCanciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCantCanciones.AutoSize = true;
            this.lblCantCanciones.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCanciones.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCantCanciones.Location = new System.Drawing.Point(141, 246);
            this.lblCantCanciones.Name = "lblCantCanciones";
            this.lblCantCanciones.Size = new System.Drawing.Size(237, 25);
            this.lblCantCanciones.TabIndex = 47;
            this.lblCantCanciones.Text = "Cantidad canciones:";
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFechaLanzamiento.AutoSize = true;
            this.lblFechaLanzamiento.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaLanzamiento.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(154, 178);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(224, 25);
            this.lblFechaLanzamiento.TabIndex = 46;
            this.lblFechaLanzamiento.Text = "Fecha lanzamiento:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitulo.Location = new System.Drawing.Point(302, 103);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(76, 25);
            this.lblTitulo.TabIndex = 44;
            this.lblTitulo.Text = "Título:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1036, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(64, 49);
            this.btnCerrar.TabIndex = 66;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(958, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(72, 49);
            this.btnMinimizar.TabIndex = 67;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pbxImgDisco
            // 
            this.pbxImgDisco.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxImgDisco.ErrorImage")));
            this.pbxImgDisco.Image = ((System.Drawing.Image)(resources.GetObject("pbxImgDisco.Image")));
            this.pbxImgDisco.Location = new System.Drawing.Point(286, 0);
            this.pbxImgDisco.Name = "pbxImgDisco";
            this.pbxImgDisco.Size = new System.Drawing.Size(90, 90);
            this.pbxImgDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImgDisco.TabIndex = 68;
            this.pbxImgDisco.TabStop = false;
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1100, 605);
            this.Controls.Add(this.pbxImgDisco);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblDisco);
            this.Controls.Add(this.lblErrorCantCanciones);
            this.Controls.Add(this.lblErrorEstilo);
            this.Controls.Add(this.lblErrorTipoEdicion);
            this.Controls.Add(this.lblErrorFechaLanzamiento);
            this.Controls.Add(this.lblErrorTitulo);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.pbxDisco);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblTipoEdicion);
            this.Controls.Add(this.cboTipoEdicion);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantCanciones);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblCantCanciones);
            this.Controls.Add(this.lblFechaLanzamiento);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAltaDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaDisco";
            this.Load += new System.EventHandler(this.frmAltaDisco_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAltaDisco_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisco;
        private System.Windows.Forms.Label lblErrorCantCanciones;
        private System.Windows.Forms.Label lblErrorEstilo;
        private System.Windows.Forms.Label lblErrorTipoEdicion;
        private System.Windows.Forms.Label lblErrorFechaLanzamiento;
        private System.Windows.Forms.Label lblErrorTitulo;
        private System.Windows.Forms.Button btnAgregarImagen;
        public System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.PictureBox pbxDisco;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label lblTipoEdicion;
        private System.Windows.Forms.ComboBox cboTipoEdicion;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCantCanciones;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblCantCanciones;
        private System.Windows.Forms.Label lblFechaLanzamiento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.PictureBox pbxImgDisco;
    }
}