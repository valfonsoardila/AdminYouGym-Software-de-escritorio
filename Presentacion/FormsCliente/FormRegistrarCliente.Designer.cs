
namespace Presentacion
{
    partial class FormRegistrarCliente
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
            this.menuTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.labelNombres = new System.Windows.Forms.Label();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.labelIdentificacion = new System.Windows.Forms.Label();
            this.labelTipoId = new System.Windows.Forms.Label();
            this.comboTipoId = new System.Windows.Forms.ComboBox();
            this.labelFechaDeNacimiento = new System.Windows.Forms.Label();
            this.dateTimeFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textNombres = new System.Windows.Forms.TextBox();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.labelTitleCliente = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textPeso = new System.Windows.Forms.TextBox();
            this.labelPeso = new System.Windows.Forms.Label();
            this.textEstatura = new System.Windows.Forms.TextBox();
            this.llabelEstatura = new System.Windows.Forms.Label();
            this.btnInscribirCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.menuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTop
            // 
            this.menuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.menuTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuTop.Controls.Add(this.btnCerrar);
            this.menuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(554, 26);
            this.menuTop.TabIndex = 3;
            this.menuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuTop_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 28;
            this.btnCerrar.Location = new System.Drawing.Point(526, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Location = new System.Drawing.Point(78, 120);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(52, 13);
            this.labelNombres.TabIndex = 4;
            this.labelNombres.Text = "Nombres:";
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(154, 139);
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(189, 20);
            this.textApellidos.TabIndex = 7;
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(78, 146);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(52, 13);
            this.labelApellidos.TabIndex = 6;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(154, 89);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(189, 20);
            this.textIdentificacion.TabIndex = 9;
            // 
            // labelIdentificacion
            // 
            this.labelIdentificacion.AutoSize = true;
            this.labelIdentificacion.Location = new System.Drawing.Point(78, 94);
            this.labelIdentificacion.Name = "labelIdentificacion";
            this.labelIdentificacion.Size = new System.Drawing.Size(73, 13);
            this.labelIdentificacion.TabIndex = 8;
            this.labelIdentificacion.Text = "Identificacion:";
            // 
            // labelTipoId
            // 
            this.labelTipoId.AutoSize = true;
            this.labelTipoId.Location = new System.Drawing.Point(348, 93);
            this.labelTipoId.Name = "labelTipoId";
            this.labelTipoId.Size = new System.Drawing.Size(31, 13);
            this.labelTipoId.TabIndex = 10;
            this.labelTipoId.Text = "Tipo:";
            // 
            // comboTipoId
            // 
            this.comboTipoId.FormattingEnabled = true;
            this.comboTipoId.Items.AddRange(new object[] {
            "CC",
            "TI"});
            this.comboTipoId.Location = new System.Drawing.Point(385, 89);
            this.comboTipoId.Name = "comboTipoId";
            this.comboTipoId.Size = new System.Drawing.Size(49, 21);
            this.comboTipoId.TabIndex = 11;
            // 
            // labelFechaDeNacimiento
            // 
            this.labelFechaDeNacimiento.AutoSize = true;
            this.labelFechaDeNacimiento.Location = new System.Drawing.Point(78, 168);
            this.labelFechaDeNacimiento.Name = "labelFechaDeNacimiento";
            this.labelFechaDeNacimiento.Size = new System.Drawing.Size(103, 13);
            this.labelFechaDeNacimiento.TabIndex = 12;
            this.labelFechaDeNacimiento.Text = "Fecha de naciminto:";
            // 
            // dateTimeFechaDeNacimiento
            // 
            this.dateTimeFechaDeNacimiento.Location = new System.Drawing.Point(179, 165);
            this.dateTimeFechaDeNacimiento.Name = "dateTimeFechaDeNacimiento";
            this.dateTimeFechaDeNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaDeNacimiento.TabIndex = 13;
            this.dateTimeFechaDeNacimiento.Validated += new System.EventHandler(this.dateTimeFechaDeNacimiento_Validated);
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(271, 191);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(163, 20);
            this.textDireccion.TabIndex = 15;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(218, 194);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(55, 13);
            this.labelDireccion.TabIndex = 14;
            this.labelDireccion.Text = "Direccion:";
            // 
            // textNombres
            // 
            this.textNombres.Location = new System.Drawing.Point(154, 114);
            this.textNombres.Name = "textNombres";
            this.textNombres.Size = new System.Drawing.Size(189, 20);
            this.textNombres.TabIndex = 5;
            // 
            // comboSexo
            // 
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboSexo.Location = new System.Drawing.Point(154, 191);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(58, 21);
            this.comboSexo.TabIndex = 17;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(78, 194);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(70, 13);
            this.labelSexo.TabIndex = 16;
            this.labelSexo.Text = "Sexo genero:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(78, 221);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 18;
            this.labelTelefono.Text = "Telefono:";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(154, 218);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(111, 20);
            this.textTelefono.TabIndex = 19;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(271, 221);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(41, 13);
            this.labelCorreo.TabIndex = 20;
            this.labelCorreo.Text = "Correo:";
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(309, 218);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(125, 20);
            this.textCorreo.TabIndex = 21;
            // 
            // labelTitleCliente
            // 
            this.labelTitleCliente.AutoSize = true;
            this.labelTitleCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleCliente.ForeColor = System.Drawing.Color.Black;
            this.labelTitleCliente.Location = new System.Drawing.Point(149, 39);
            this.labelTitleCliente.Name = "labelTitleCliente";
            this.labelTitleCliente.Size = new System.Drawing.Size(276, 29);
            this.labelTitleCliente.TabIndex = 22;
            this.labelTitleCliente.Text = "REGISTRAR CLIENTE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(78, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(382, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "REGISTRAR DATOS DE INDICES POR PRIMERA VEZ";
            // 
            // textPeso
            // 
            this.textPeso.Location = new System.Drawing.Point(118, 286);
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(111, 20);
            this.textPeso.TabIndex = 25;
            this.textPeso.Text = "0";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(79, 290);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(34, 13);
            this.labelPeso.TabIndex = 24;
            this.labelPeso.Text = "Peso:";
            // 
            // textEstatura
            // 
            this.textEstatura.Location = new System.Drawing.Point(279, 285);
            this.textEstatura.Name = "textEstatura";
            this.textEstatura.Size = new System.Drawing.Size(111, 20);
            this.textEstatura.TabIndex = 27;
            this.textEstatura.Text = "0";
            // 
            // llabelEstatura
            // 
            this.llabelEstatura.AutoSize = true;
            this.llabelEstatura.Location = new System.Drawing.Point(231, 289);
            this.llabelEstatura.Name = "llabelEstatura";
            this.llabelEstatura.Size = new System.Drawing.Size(49, 13);
            this.llabelEstatura.TabIndex = 26;
            this.llabelEstatura.Text = "Estatura:";
            // 
            // btnInscribirCliente
            // 
            this.btnInscribirCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnInscribirCliente.FlatAppearance.BorderSize = 0;
            this.btnInscribirCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInscribirCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnInscribirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribirCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInscribirCliente.Location = new System.Drawing.Point(101, 327);
            this.btnInscribirCliente.Name = "btnInscribirCliente";
            this.btnInscribirCliente.Size = new System.Drawing.Size(172, 23);
            this.btnInscribirCliente.TabIndex = 45;
            this.btnInscribirCliente.Text = "Inscribir $";
            this.btnInscribirCliente.UseVisualStyleBackColor = false;
            this.btnInscribirCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnModificarCliente.Enabled = false;
            this.btnModificarCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarCliente.Location = new System.Drawing.Point(288, 327);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(172, 23);
            this.btnModificarCliente.TabIndex = 46;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Edad:";
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(414, 165);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(46, 20);
            this.textEdad.TabIndex = 48;
            this.textEdad.Text = "0";
            // 
            // FormRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(554, 361);
            this.Controls.Add(this.labelTitleCliente);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnInscribirCliente);
            this.Controls.Add(this.textEstatura);
            this.Controls.Add(this.llabelEstatura);
            this.Controls.Add(this.textPeso);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.comboSexo);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.dateTimeFechaDeNacimiento);
            this.Controls.Add(this.labelFechaDeNacimiento);
            this.Controls.Add(this.comboTipoId);
            this.Controls.Add(this.labelTipoId);
            this.Controls.Add(this.textIdentificacion);
            this.Controls.Add(this.labelIdentificacion);
            this.Controls.Add(this.textApellidos);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.textNombres);
            this.Controls.Add(this.labelNombres);
            this.Controls.Add(this.menuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrarCliente";
            this.Opacity = 0.9D;
            this.Text = "Registrar Cliente";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRegistrarCliente_MouseDown);
            this.menuTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.TextBox textIdentificacion;
        private System.Windows.Forms.Label labelIdentificacion;
        private System.Windows.Forms.Label labelTipoId;
        private System.Windows.Forms.ComboBox comboTipoId;
        private System.Windows.Forms.Label labelFechaDeNacimiento;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDeNacimiento;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textNombres;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label labelTitleCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textPeso;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.TextBox textEstatura;
        private System.Windows.Forms.Label llabelEstatura;
        private System.Windows.Forms.Button btnInscribirCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEdad;
    }
}