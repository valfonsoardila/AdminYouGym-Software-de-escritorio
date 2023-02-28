
namespace Presentacion
{
    partial class FormRegistrarEntrenador
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
            this.panelRegistrarCliente = new System.Windows.Forms.Panel();
            this.labelTitleCliente = new System.Windows.Forms.Label();
            this.comboTipoId = new System.Windows.Forms.ComboBox();
            this.labelTipoId = new System.Windows.Forms.Label();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.labelIdentificacion = new System.Windows.Forms.Label();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelFechaDeNacimiento = new System.Windows.Forms.Label();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.textNombres = new System.Windows.Forms.TextBox();
            this.labelNombres = new System.Windows.Forms.Label();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.btnModificarEntrenador = new System.Windows.Forms.Button();
            this.btnRegistrarEntrenador = new System.Windows.Forms.Button();
            this.menuTop.SuspendLayout();
            this.panelRegistrarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTop
            // 
            this.menuTop.BackColor = System.Drawing.Color.White;
            this.menuTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuTop.Controls.Add(this.btnCerrar);
            this.menuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(554, 26);
            this.menuTop.TabIndex = 4;
            this.menuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuTop_MouseDown_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 28;
            this.btnCerrar.Location = new System.Drawing.Point(526, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelRegistrarCliente
            // 
            this.panelRegistrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panelRegistrarCliente.Controls.Add(this.labelTitleCliente);
            this.panelRegistrarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegistrarCliente.ForeColor = System.Drawing.Color.Coral;
            this.panelRegistrarCliente.Location = new System.Drawing.Point(0, 26);
            this.panelRegistrarCliente.Name = "panelRegistrarCliente";
            this.panelRegistrarCliente.Size = new System.Drawing.Size(554, 139);
            this.panelRegistrarCliente.TabIndex = 29;
            this.panelRegistrarCliente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRegistrarCliente_MouseDown);
            // 
            // labelTitleCliente
            // 
            this.labelTitleCliente.AutoSize = true;
            this.labelTitleCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleCliente.ForeColor = System.Drawing.Color.Salmon;
            this.labelTitleCliente.Location = new System.Drawing.Point(103, 10);
            this.labelTitleCliente.Name = "labelTitleCliente";
            this.labelTitleCliente.Size = new System.Drawing.Size(346, 29);
            this.labelTitleCliente.TabIndex = 22;
            this.labelTitleCliente.Text = "REGISTRAR ENTRENADOR";
            // 
            // comboTipoId
            // 
            this.comboTipoId.FormattingEnabled = true;
            this.comboTipoId.Items.AddRange(new object[] {
            "CC",
            "TI"});
            this.comboTipoId.Location = new System.Drawing.Point(375, 181);
            this.comboTipoId.Name = "comboTipoId";
            this.comboTipoId.Size = new System.Drawing.Size(49, 21);
            this.comboTipoId.TabIndex = 33;
            // 
            // labelTipoId
            // 
            this.labelTipoId.AutoSize = true;
            this.labelTipoId.Location = new System.Drawing.Point(338, 185);
            this.labelTipoId.Name = "labelTipoId";
            this.labelTipoId.Size = new System.Drawing.Size(31, 13);
            this.labelTipoId.TabIndex = 32;
            this.labelTipoId.Text = "Tipo:";
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(144, 181);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(189, 20);
            this.textIdentificacion.TabIndex = 31;
            // 
            // labelIdentificacion
            // 
            this.labelIdentificacion.AutoSize = true;
            this.labelIdentificacion.Location = new System.Drawing.Point(68, 186);
            this.labelIdentificacion.Name = "labelIdentificacion";
            this.labelIdentificacion.Size = new System.Drawing.Size(73, 13);
            this.labelIdentificacion.TabIndex = 30;
            this.labelIdentificacion.Text = "Identificacion:";
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(404, 258);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(46, 20);
            this.textEdad.TabIndex = 56;
            this.textEdad.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Edad:";
            // 
            // dateTimeFechaDeNacimiento
            // 
            this.dateTimeFechaDeNacimiento.Location = new System.Drawing.Point(169, 258);
            this.dateTimeFechaDeNacimiento.Name = "dateTimeFechaDeNacimiento";
            this.dateTimeFechaDeNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaDeNacimiento.TabIndex = 54;
            this.dateTimeFechaDeNacimiento.Validated += new System.EventHandler(this.dateTimeFechaDeNacimiento_Validated);
            // 
            // labelFechaDeNacimiento
            // 
            this.labelFechaDeNacimiento.AutoSize = true;
            this.labelFechaDeNacimiento.Location = new System.Drawing.Point(68, 261);
            this.labelFechaDeNacimiento.Name = "labelFechaDeNacimiento";
            this.labelFechaDeNacimiento.Size = new System.Drawing.Size(103, 13);
            this.labelFechaDeNacimiento.TabIndex = 53;
            this.labelFechaDeNacimiento.Text = "Fecha de naciminto:";
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(144, 232);
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(189, 20);
            this.textApellidos.TabIndex = 52;
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(68, 239);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(52, 13);
            this.labelApellidos.TabIndex = 51;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // textNombres
            // 
            this.textNombres.Location = new System.Drawing.Point(144, 207);
            this.textNombres.Name = "textNombres";
            this.textNombres.Size = new System.Drawing.Size(189, 20);
            this.textNombres.TabIndex = 50;
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Location = new System.Drawing.Point(68, 213);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(52, 13);
            this.labelNombres.TabIndex = 49;
            this.labelNombres.Text = "Nombres:";
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(144, 311);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(189, 20);
            this.textCorreo.TabIndex = 64;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(70, 314);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(41, 13);
            this.labelCorreo.TabIndex = 63;
            this.labelCorreo.Text = "Correo:";
            // 
            // comboSexo
            // 
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboSexo.Location = new System.Drawing.Point(144, 284);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(58, 21);
            this.comboSexo.TabIndex = 60;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(68, 287);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(70, 13);
            this.labelSexo.TabIndex = 59;
            this.labelSexo.Text = "Sexo genero:";
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(261, 284);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(163, 20);
            this.textDireccion.TabIndex = 58;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(208, 287);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(55, 13);
            this.labelDireccion.TabIndex = 57;
            this.labelDireccion.Text = "Direccion:";
            // 
            // btnModificarEntrenador
            // 
            this.btnModificarEntrenador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnModificarEntrenador.Enabled = false;
            this.btnModificarEntrenador.FlatAppearance.BorderSize = 0;
            this.btnModificarEntrenador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnModificarEntrenador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnModificarEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEntrenador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarEntrenador.Location = new System.Drawing.Point(288, 344);
            this.btnModificarEntrenador.Name = "btnModificarEntrenador";
            this.btnModificarEntrenador.Size = new System.Drawing.Size(172, 23);
            this.btnModificarEntrenador.TabIndex = 66;
            this.btnModificarEntrenador.Text = "Modificar";
            this.btnModificarEntrenador.UseVisualStyleBackColor = false;
            this.btnModificarEntrenador.Click += new System.EventHandler(this.btnModificarEntrenador_Click);
            // 
            // btnRegistrarEntrenador
            // 
            this.btnRegistrarEntrenador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnRegistrarEntrenador.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEntrenador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegistrarEntrenador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRegistrarEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEntrenador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarEntrenador.Location = new System.Drawing.Point(101, 344);
            this.btnRegistrarEntrenador.Name = "btnRegistrarEntrenador";
            this.btnRegistrarEntrenador.Size = new System.Drawing.Size(172, 23);
            this.btnRegistrarEntrenador.TabIndex = 65;
            this.btnRegistrarEntrenador.Text = "Registrar";
            this.btnRegistrarEntrenador.UseVisualStyleBackColor = false;
            this.btnRegistrarEntrenador.Click += new System.EventHandler(this.btnRegistrarEntrenador_Click);
            // 
            // FormRegistrarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 379);
            this.Controls.Add(this.btnModificarEntrenador);
            this.Controls.Add(this.btnRegistrarEntrenador);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.comboSexo);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeFechaDeNacimiento);
            this.Controls.Add(this.labelFechaDeNacimiento);
            this.Controls.Add(this.textApellidos);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.textNombres);
            this.Controls.Add(this.labelNombres);
            this.Controls.Add(this.comboTipoId);
            this.Controls.Add(this.labelTipoId);
            this.Controls.Add(this.textIdentificacion);
            this.Controls.Add(this.labelIdentificacion);
            this.Controls.Add(this.panelRegistrarCliente);
            this.Controls.Add(this.menuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrarEntrenador";
            this.Text = "FormRegistrarEntrenador";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRegistrarEntrenador_MouseDown);
            this.menuTop.ResumeLayout(false);
            this.panelRegistrarCliente.ResumeLayout(false);
            this.panelRegistrarCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel panelRegistrarCliente;
        private System.Windows.Forms.Label labelTitleCliente;
        private System.Windows.Forms.ComboBox comboTipoId;
        private System.Windows.Forms.Label labelTipoId;
        private System.Windows.Forms.TextBox textIdentificacion;
        private System.Windows.Forms.Label labelIdentificacion;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDeNacimiento;
        private System.Windows.Forms.Label labelFechaDeNacimiento;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.TextBox textNombres;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Button btnModificarEntrenador;
        private System.Windows.Forms.Button btnRegistrarEntrenador;
    }
}