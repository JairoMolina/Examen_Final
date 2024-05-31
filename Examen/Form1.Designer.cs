namespace Examen
{
    partial class FormEnsamblador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnsamblador));
            this.btnPrueba = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.txtboxPlacas = new System.Windows.Forms.TextBox();
            this.txtboxPropietario = new System.Windows.Forms.TextBox();
            this.txtboxColor = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPlacas = new System.Windows.Forms.Label();
            this.lblTIPO = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.comboxTipo = new System.Windows.Forms.ComboBox();
            this.comboxMarca = new System.Windows.Forms.ComboBox();
            this.comboxModelo = new System.Windows.Forms.ComboBox();
            this.lblCaja = new System.Windows.Forms.Label();
            this.lblTraccion = new System.Windows.Forms.Label();
            this.comboxCaja = new System.Windows.Forms.ComboBox();
            this.checkbox4x4 = new System.Windows.Forms.CheckBox();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtagridwTabla = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtagridwTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrueba.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrueba.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrueba.Location = new System.Drawing.Point(1349, 9);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(71, 37);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "PRUEBA CONEXION";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCrear.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnCrear.Location = new System.Drawing.Point(779, 75);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(108, 39);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtboxID
            // 
            this.txtboxID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxID.Location = new System.Drawing.Point(16, 111);
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.Size = new System.Drawing.Size(142, 31);
            this.txtboxID.TabIndex = 2;
            // 
            // txtboxPlacas
            // 
            this.txtboxPlacas.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtboxPlacas.Location = new System.Drawing.Point(179, 111);
            this.txtboxPlacas.Name = "txtboxPlacas";
            this.txtboxPlacas.Size = new System.Drawing.Size(142, 31);
            this.txtboxPlacas.TabIndex = 3;
            // 
            // txtboxPropietario
            // 
            this.txtboxPropietario.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtboxPropietario.Location = new System.Drawing.Point(16, 462);
            this.txtboxPropietario.Name = "txtboxPropietario";
            this.txtboxPropietario.Size = new System.Drawing.Size(305, 31);
            this.txtboxPropietario.TabIndex = 5;
            // 
            // txtboxColor
            // 
            this.txtboxColor.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtboxColor.Location = new System.Drawing.Point(179, 282);
            this.txtboxColor.Name = "txtboxColor";
            this.txtboxColor.Size = new System.Drawing.Size(142, 31);
            this.txtboxColor.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblID.Location = new System.Drawing.Point(12, 83);
            this.lblID.Name = "lblID";
            this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblID.Size = new System.Drawing.Size(30, 22);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlacas
            // 
            this.lblPlacas.AutoSize = true;
            this.lblPlacas.BackColor = System.Drawing.Color.Transparent;
            this.lblPlacas.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblPlacas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPlacas.Location = new System.Drawing.Point(175, 83);
            this.lblPlacas.Name = "lblPlacas";
            this.lblPlacas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPlacas.Size = new System.Drawing.Size(63, 20);
            this.lblPlacas.TabIndex = 10;
            this.lblPlacas.Text = "PLACAS";
            this.lblPlacas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTIPO
            // 
            this.lblTIPO.AutoSize = true;
            this.lblTIPO.BackColor = System.Drawing.Color.Transparent;
            this.lblTIPO.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblTIPO.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTIPO.Location = new System.Drawing.Point(12, 170);
            this.lblTIPO.Name = "lblTIPO";
            this.lblTIPO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTIPO.Size = new System.Drawing.Size(45, 20);
            this.lblTIPO.TabIndex = 11;
            this.lblTIPO.Text = "TIPO";
            this.lblTIPO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblMarca.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMarca.Location = new System.Drawing.Point(175, 170);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMarca.Size = new System.Drawing.Size(54, 20);
            this.lblMarca.TabIndex = 12;
            this.lblMarca.Text = "MARCA";
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblModelo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblModelo.Location = new System.Drawing.Point(12, 256);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblModelo.Size = new System.Drawing.Size(63, 20);
            this.lblModelo.TabIndex = 13;
            this.lblModelo.Text = "MODELO";
            this.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblColor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblColor.Location = new System.Drawing.Point(175, 256);
            this.lblColor.Name = "lblColor";
            this.lblColor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblColor.Size = new System.Drawing.Size(54, 20);
            this.lblColor.TabIndex = 15;
            this.lblColor.Text = "COLOR";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboxTipo
            // 
            this.comboxTipo.Font = new System.Drawing.Font("Consolas", 12F);
            this.comboxTipo.FormattingEnabled = true;
            this.comboxTipo.Location = new System.Drawing.Point(16, 195);
            this.comboxTipo.Name = "comboxTipo";
            this.comboxTipo.Size = new System.Drawing.Size(142, 31);
            this.comboxTipo.TabIndex = 17;
            this.comboxTipo.SelectedIndexChanged += new System.EventHandler(this.comboxTipo_SelectedIndexChanged);
            // 
            // comboxMarca
            // 
            this.comboxMarca.Font = new System.Drawing.Font("Consolas", 12F);
            this.comboxMarca.FormattingEnabled = true;
            this.comboxMarca.Location = new System.Drawing.Point(179, 195);
            this.comboxMarca.Name = "comboxMarca";
            this.comboxMarca.Size = new System.Drawing.Size(142, 31);
            this.comboxMarca.TabIndex = 18;
            this.comboxMarca.SelectedIndexChanged += new System.EventHandler(this.comboxMarca_SelectedIndexChanged);
            // 
            // comboxModelo
            // 
            this.comboxModelo.Font = new System.Drawing.Font("Consolas", 12F);
            this.comboxModelo.FormattingEnabled = true;
            this.comboxModelo.Location = new System.Drawing.Point(16, 282);
            this.comboxModelo.Name = "comboxModelo";
            this.comboxModelo.Size = new System.Drawing.Size(142, 31);
            this.comboxModelo.TabIndex = 19;
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.BackColor = System.Drawing.Color.Transparent;
            this.lblCaja.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblCaja.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCaja.Location = new System.Drawing.Point(12, 344);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCaja.Size = new System.Drawing.Size(45, 20);
            this.lblCaja.TabIndex = 20;
            this.lblCaja.Text = "CAJA";
            this.lblCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTraccion
            // 
            this.lblTraccion.AutoSize = true;
            this.lblTraccion.BackColor = System.Drawing.Color.Transparent;
            this.lblTraccion.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblTraccion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTraccion.Location = new System.Drawing.Point(175, 344);
            this.lblTraccion.Name = "lblTraccion";
            this.lblTraccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTraccion.Size = new System.Drawing.Size(81, 20);
            this.lblTraccion.TabIndex = 21;
            this.lblTraccion.Text = "TRACCION";
            this.lblTraccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboxCaja
            // 
            this.comboxCaja.Font = new System.Drawing.Font("Consolas", 12F);
            this.comboxCaja.FormattingEnabled = true;
            this.comboxCaja.Location = new System.Drawing.Point(16, 369);
            this.comboxCaja.Name = "comboxCaja";
            this.comboxCaja.Size = new System.Drawing.Size(142, 31);
            this.comboxCaja.TabIndex = 22;
            // 
            // checkbox4x4
            // 
            this.checkbox4x4.AutoSize = true;
            this.checkbox4x4.BackColor = System.Drawing.Color.Transparent;
            this.checkbox4x4.Font = new System.Drawing.Font("Consolas", 14F);
            this.checkbox4x4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkbox4x4.Location = new System.Drawing.Point(179, 369);
            this.checkbox4x4.Name = "checkbox4x4";
            this.checkbox4x4.Size = new System.Drawing.Size(73, 32);
            this.checkbox4x4.TabIndex = 23;
            this.checkbox4x4.Text = "4X4";
            this.checkbox4x4.UseVisualStyleBackColor = false;
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.BackColor = System.Drawing.Color.Transparent;
            this.lblPropietario.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblPropietario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPropietario.Location = new System.Drawing.Point(12, 433);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPropietario.Size = new System.Drawing.Size(108, 20);
            this.lblPropietario.TabIndex = 24;
            this.lblPropietario.Text = "PROPIETARIO";
            this.lblPropietario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 515);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "FECHA CREACION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Consolas", 9.2F);
            this.dtpFecha.Location = new System.Drawing.Point(16, 547);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(305, 25);
            this.dtpFecha.TabIndex = 26;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMostrar.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnMostrar.Location = new System.Drawing.Point(655, 74);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(108, 39);
            this.btnMostrar.TabIndex = 27;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnActualizar.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnActualizar.Location = new System.Drawing.Point(897, 75);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(118, 39);
            this.btnActualizar.TabIndex = 28;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnEliminar.Location = new System.Drawing.Point(1027, 75);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 39);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtagridwTabla
            // 
            this.dtagridwTabla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtagridwTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagridwTabla.Location = new System.Drawing.Point(356, 154);
            this.dtagridwTabla.Name = "dtagridwTabla";
            this.dtagridwTabla.RowHeadersWidth = 51;
            this.dtagridwTabla.RowTemplate.Height = 24;
            this.dtagridwTabla.Size = new System.Drawing.Size(1045, 418);
            this.dtagridwTabla.TabIndex = 30;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscar.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnBuscar.Location = new System.Drawing.Point(1151, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 39);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAtras.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(391, 75);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(38, 37);
            this.btnAtras.TabIndex = 32;
            this.btnAtras.Text = "<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAdelante
            // 
            this.btnAdelante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdelante.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdelante.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdelante.Location = new System.Drawing.Point(435, 75);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(38, 37);
            this.btnAdelante.TabIndex = 33;
            this.btnAdelante.Text = ">";
            this.btnAdelante.UseVisualStyleBackColor = true;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevo.Font = new System.Drawing.Font("Consolas", 11F);
            this.btnNuevo.Location = new System.Drawing.Point(531, 74);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 38);
            this.btnNuevo.TabIndex = 34;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitulo.Location = new System.Drawing.Point(407, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitulo.Size = new System.Drawing.Size(647, 38);
            this.lblTitulo.TabIndex = 38;
            this.lblTitulo.Text = "ENSAMBLADOR Y REGISTRO DE VEHICULOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNombre.Location = new System.Drawing.Point(12, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombre.Size = new System.Drawing.Size(329, 46);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "JAIRO LEONEL MOLINA HERNANDEZ\r\n0905-23-4651";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormEnsamblador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1432, 603);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAdelante);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dtagridwTabla);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.checkbox4x4);
            this.Controls.Add(this.comboxCaja);
            this.Controls.Add(this.lblTraccion);
            this.Controls.Add(this.lblCaja);
            this.Controls.Add(this.comboxModelo);
            this.Controls.Add(this.comboxMarca);
            this.Controls.Add(this.comboxTipo);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblTIPO);
            this.Controls.Add(this.lblPlacas);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtboxColor);
            this.Controls.Add(this.txtboxPropietario);
            this.Controls.Add(this.txtboxPlacas);
            this.Controls.Add(this.txtboxID);
            this.Controls.Add(this.btnPrueba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEnsamblador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENSAMBLADOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtagridwTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtboxID;
        private System.Windows.Forms.TextBox txtboxPlacas;
        private System.Windows.Forms.TextBox txtboxPropietario;
        private System.Windows.Forms.TextBox txtboxColor;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPlacas;
        private System.Windows.Forms.Label lblTIPO;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox comboxTipo;
        private System.Windows.Forms.ComboBox comboxMarca;
        private System.Windows.Forms.ComboBox comboxModelo;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.Label lblTraccion;
        private System.Windows.Forms.ComboBox comboxCaja;
        private System.Windows.Forms.CheckBox checkbox4x4;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dtagridwTabla;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
    }
}

