
namespace Presentacion
{
    partial class FormServicioDeEntrenador
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
            this.labelTitleCliente = new System.Windows.Forms.Label();
            this.btnBuscarIdentificacion = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.panelDatosDeContrato = new System.Windows.Forms.Panel();
            this.labelCodigoEntrenadorAsignado = new System.Windows.Forms.Label();
            this.labelCodigoEntrenador = new System.Windows.Forms.Label();
            this.comboTipoContrato = new System.Windows.Forms.ComboBox();
            this.labelTipoContrato = new System.Windows.Forms.Label();
            this.textCantidadMesesContrato = new System.Windows.Forms.TextBox();
            this.labelCantidadMesesContrato = new System.Windows.Forms.Label();
            this.textCantidadDiasTrabajo = new System.Windows.Forms.TextBox();
            this.labelCantidadDiasTrabajo = new System.Windows.Forms.Label();
            this.textCantidadHorasExtras = new System.Windows.Forms.TextBox();
            this.labelCantidadHorasExtras = new System.Windows.Forms.Label();
            this.textSueldo = new System.Windows.Forms.TextBox();
            this.labelSueldo = new System.Windows.Forms.Label();
            this.panelDatosDeEntrenador = new System.Windows.Forms.Panel();
            this.textSexo = new System.Windows.Forms.TextBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.labelIdentificacion = new System.Windows.Forms.Label();
            this.btnContratar = new System.Windows.Forms.Button();
            this.btnGenerarContrato = new System.Windows.Forms.Button();
            this.menuTop.SuspendLayout();
            this.panelDatosDeContrato.SuspendLayout();
            this.panelDatosDeEntrenador.SuspendLayout();
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
            this.menuTop.Size = new System.Drawing.Size(636, 26);
            this.menuTop.TabIndex = 5;
            this.menuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuTop_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 28;
            this.btnCerrar.Location = new System.Drawing.Point(608, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // labelTitleCliente
            // 
            this.labelTitleCliente.AutoSize = true;
            this.labelTitleCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleCliente.ForeColor = System.Drawing.Color.Black;
            this.labelTitleCliente.Location = new System.Drawing.Point(129, 29);
            this.labelTitleCliente.Name = "labelTitleCliente";
            this.labelTitleCliente.Size = new System.Drawing.Size(386, 29);
            this.labelTitleCliente.TabIndex = 90;
            this.labelTitleCliente.Text = "CONTRATO DE ENTRENADOR";
            // 
            // btnBuscarIdentificacion
            // 
            this.btnBuscarIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnBuscarIdentificacion.FlatAppearance.BorderSize = 0;
            this.btnBuscarIdentificacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscarIdentificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnBuscarIdentificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarIdentificacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarIdentificacion.Location = new System.Drawing.Point(343, 70);
            this.btnBuscarIdentificacion.Name = "btnBuscarIdentificacion";
            this.btnBuscarIdentificacion.Size = new System.Drawing.Size(172, 23);
            this.btnBuscarIdentificacion.TabIndex = 87;
            this.btnBuscarIdentificacion.Text = "Buscar";
            this.btnBuscarIdentificacion.UseVisualStyleBackColor = false;
            this.btnBuscarIdentificacion.Click += new System.EventHandler(this.btnBuscarIdentificacion_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(205, 72);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(135, 20);
            this.textBuscar.TabIndex = 89;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.Color.Black;
            this.labelBuscar.Location = new System.Drawing.Point(116, 76);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(88, 13);
            this.labelBuscar.TabIndex = 88;
            this.labelBuscar.Text = "Identificacion:";
            // 
            // panelDatosDeContrato
            // 
            this.panelDatosDeContrato.Controls.Add(this.labelCodigoEntrenadorAsignado);
            this.panelDatosDeContrato.Controls.Add(this.labelCodigoEntrenador);
            this.panelDatosDeContrato.Controls.Add(this.comboTipoContrato);
            this.panelDatosDeContrato.Controls.Add(this.labelTipoContrato);
            this.panelDatosDeContrato.Controls.Add(this.textCantidadMesesContrato);
            this.panelDatosDeContrato.Controls.Add(this.labelCantidadMesesContrato);
            this.panelDatosDeContrato.Controls.Add(this.textCantidadDiasTrabajo);
            this.panelDatosDeContrato.Controls.Add(this.labelCantidadDiasTrabajo);
            this.panelDatosDeContrato.Controls.Add(this.textCantidadHorasExtras);
            this.panelDatosDeContrato.Controls.Add(this.labelCantidadHorasExtras);
            this.panelDatosDeContrato.Controls.Add(this.textSueldo);
            this.panelDatosDeContrato.Controls.Add(this.labelSueldo);
            this.panelDatosDeContrato.Enabled = false;
            this.panelDatosDeContrato.Location = new System.Drawing.Point(47, 121);
            this.panelDatosDeContrato.Name = "panelDatosDeContrato";
            this.panelDatosDeContrato.Size = new System.Drawing.Size(398, 267);
            this.panelDatosDeContrato.TabIndex = 91;
            // 
            // labelCodigoEntrenadorAsignado
            // 
            this.labelCodigoEntrenadorAsignado.AutoSize = true;
            this.labelCodigoEntrenadorAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoEntrenadorAsignado.ForeColor = System.Drawing.Color.Black;
            this.labelCodigoEntrenadorAsignado.Location = new System.Drawing.Point(154, 20);
            this.labelCodigoEntrenadorAsignado.Name = "labelCodigoEntrenadorAsignado";
            this.labelCodigoEntrenadorAsignado.Size = new System.Drawing.Size(76, 13);
            this.labelCodigoEntrenadorAsignado.TabIndex = 101;
            this.labelCodigoEntrenadorAsignado.Text = "*                ";
            // 
            // labelCodigoEntrenador
            // 
            this.labelCodigoEntrenador.AutoSize = true;
            this.labelCodigoEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoEntrenador.ForeColor = System.Drawing.Color.Black;
            this.labelCodigoEntrenador.Location = new System.Drawing.Point(14, 20);
            this.labelCodigoEntrenador.Name = "labelCodigoEntrenador";
            this.labelCodigoEntrenador.Size = new System.Drawing.Size(134, 13);
            this.labelCodigoEntrenador.TabIndex = 100;
            this.labelCodigoEntrenador.Text = "Codigo de Entrenador:";
            // 
            // comboTipoContrato
            // 
            this.comboTipoContrato.FormattingEnabled = true;
            this.comboTipoContrato.Items.AddRange(new object[] {
            "Ps(Prestacion-de-servicios)",
            "Cf(Contrato-a-termino-fijo)"});
            this.comboTipoContrato.Location = new System.Drawing.Point(120, 41);
            this.comboTipoContrato.Name = "comboTipoContrato";
            this.comboTipoContrato.Size = new System.Drawing.Size(152, 21);
            this.comboTipoContrato.TabIndex = 99;
            // 
            // labelTipoContrato
            // 
            this.labelTipoContrato.AutoSize = true;
            this.labelTipoContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoContrato.ForeColor = System.Drawing.Color.Black;
            this.labelTipoContrato.Location = new System.Drawing.Point(14, 45);
            this.labelTipoContrato.Name = "labelTipoContrato";
            this.labelTipoContrato.Size = new System.Drawing.Size(105, 13);
            this.labelTipoContrato.TabIndex = 98;
            this.labelTipoContrato.Text = "Tipo de contrato:";
            // 
            // textCantidadMesesContrato
            // 
            this.textCantidadMesesContrato.Location = new System.Drawing.Point(199, 125);
            this.textCantidadMesesContrato.Name = "textCantidadMesesContrato";
            this.textCantidadMesesContrato.Size = new System.Drawing.Size(135, 20);
            this.textCantidadMesesContrato.TabIndex = 97;
            // 
            // labelCantidadMesesContrato
            // 
            this.labelCantidadMesesContrato.AutoSize = true;
            this.labelCantidadMesesContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadMesesContrato.ForeColor = System.Drawing.Color.Black;
            this.labelCantidadMesesContrato.Location = new System.Drawing.Point(14, 128);
            this.labelCantidadMesesContrato.Name = "labelCantidadMesesContrato";
            this.labelCantidadMesesContrato.Size = new System.Drawing.Size(187, 13);
            this.labelCantidadMesesContrato.TabIndex = 96;
            this.labelCantidadMesesContrato.Text = "Cantidad de meses de contrato:";
            // 
            // textCantidadDiasTrabajo
            // 
            this.textCantidadDiasTrabajo.Location = new System.Drawing.Point(178, 96);
            this.textCantidadDiasTrabajo.Name = "textCantidadDiasTrabajo";
            this.textCantidadDiasTrabajo.Size = new System.Drawing.Size(135, 20);
            this.textCantidadDiasTrabajo.TabIndex = 95;
            // 
            // labelCantidadDiasTrabajo
            // 
            this.labelCantidadDiasTrabajo.AutoSize = true;
            this.labelCantidadDiasTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadDiasTrabajo.ForeColor = System.Drawing.Color.Black;
            this.labelCantidadDiasTrabajo.Location = new System.Drawing.Point(14, 99);
            this.labelCantidadDiasTrabajo.Name = "labelCantidadDiasTrabajo";
            this.labelCantidadDiasTrabajo.Size = new System.Drawing.Size(167, 13);
            this.labelCantidadDiasTrabajo.TabIndex = 94;
            this.labelCantidadDiasTrabajo.Text = "Cantidad de dias de trabajo:";
            // 
            // textCantidadHorasExtras
            // 
            this.textCantidadHorasExtras.Location = new System.Drawing.Point(163, 67);
            this.textCantidadHorasExtras.Name = "textCantidadHorasExtras";
            this.textCantidadHorasExtras.Size = new System.Drawing.Size(135, 20);
            this.textCantidadHorasExtras.TabIndex = 93;
            // 
            // labelCantidadHorasExtras
            // 
            this.labelCantidadHorasExtras.AutoSize = true;
            this.labelCantidadHorasExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadHorasExtras.ForeColor = System.Drawing.Color.Black;
            this.labelCantidadHorasExtras.Location = new System.Drawing.Point(14, 70);
            this.labelCantidadHorasExtras.Name = "labelCantidadHorasExtras";
            this.labelCantidadHorasExtras.Size = new System.Drawing.Size(152, 13);
            this.labelCantidadHorasExtras.TabIndex = 92;
            this.labelCantidadHorasExtras.Text = "Cantidad de horas extras:";
            // 
            // textSueldo
            // 
            this.textSueldo.Location = new System.Drawing.Point(72, 157);
            this.textSueldo.Name = "textSueldo";
            this.textSueldo.Size = new System.Drawing.Size(135, 20);
            this.textSueldo.TabIndex = 91;
            // 
            // labelSueldo
            // 
            this.labelSueldo.AutoSize = true;
            this.labelSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSueldo.ForeColor = System.Drawing.Color.Black;
            this.labelSueldo.Location = new System.Drawing.Point(14, 161);
            this.labelSueldo.Name = "labelSueldo";
            this.labelSueldo.Size = new System.Drawing.Size(61, 13);
            this.labelSueldo.TabIndex = 90;
            this.labelSueldo.Text = "Sueldo: $";
            // 
            // panelDatosDeEntrenador
            // 
            this.panelDatosDeEntrenador.Controls.Add(this.textSexo);
            this.panelDatosDeEntrenador.Controls.Add(this.labelSexo);
            this.panelDatosDeEntrenador.Controls.Add(this.textEdad);
            this.panelDatosDeEntrenador.Controls.Add(this.labelEdad);
            this.panelDatosDeEntrenador.Controls.Add(this.textNombre);
            this.panelDatosDeEntrenador.Controls.Add(this.labelNombre);
            this.panelDatosDeEntrenador.Controls.Add(this.textIdentificacion);
            this.panelDatosDeEntrenador.Controls.Add(this.labelIdentificacion);
            this.panelDatosDeEntrenador.Enabled = false;
            this.panelDatosDeEntrenador.Location = new System.Drawing.Point(450, 121);
            this.panelDatosDeEntrenador.Name = "panelDatosDeEntrenador";
            this.panelDatosDeEntrenador.Size = new System.Drawing.Size(147, 267);
            this.panelDatosDeEntrenador.TabIndex = 92;
            // 
            // textSexo
            // 
            this.textSexo.Location = new System.Drawing.Point(2, 152);
            this.textSexo.Name = "textSexo";
            this.textSexo.Size = new System.Drawing.Size(135, 20);
            this.textSexo.TabIndex = 97;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.ForeColor = System.Drawing.Color.Black;
            this.labelSexo.Location = new System.Drawing.Point(3, 136);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(39, 13);
            this.labelSexo.TabIndex = 96;
            this.labelSexo.Text = "Sexo:";
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(3, 107);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(135, 20);
            this.textEdad.TabIndex = 95;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.ForeColor = System.Drawing.Color.Black;
            this.labelEdad.Location = new System.Drawing.Point(4, 91);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(40, 13);
            this.labelEdad.TabIndex = 94;
            this.labelEdad.Text = "Edad:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(3, 63);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(135, 20);
            this.textNombre.TabIndex = 93;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.Black;
            this.labelNombre.Location = new System.Drawing.Point(4, 47);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(54, 13);
            this.labelNombre.TabIndex = 92;
            this.labelNombre.Text = "Nombre:";
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(3, 20);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(135, 20);
            this.textIdentificacion.TabIndex = 91;
            // 
            // labelIdentificacion
            // 
            this.labelIdentificacion.AutoSize = true;
            this.labelIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentificacion.ForeColor = System.Drawing.Color.Black;
            this.labelIdentificacion.Location = new System.Drawing.Point(4, 4);
            this.labelIdentificacion.Name = "labelIdentificacion";
            this.labelIdentificacion.Size = new System.Drawing.Size(88, 13);
            this.labelIdentificacion.TabIndex = 90;
            this.labelIdentificacion.Text = "Identificacion:";
            // 
            // btnContratar
            // 
            this.btnContratar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnContratar.Enabled = false;
            this.btnContratar.FlatAppearance.BorderSize = 0;
            this.btnContratar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContratar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnContratar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContratar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContratar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContratar.Location = new System.Drawing.Point(144, 394);
            this.btnContratar.Name = "btnContratar";
            this.btnContratar.Size = new System.Drawing.Size(172, 23);
            this.btnContratar.TabIndex = 93;
            this.btnContratar.Text = "Contratar";
            this.btnContratar.UseVisualStyleBackColor = false;
            this.btnContratar.Click += new System.EventHandler(this.btnContratar_Click);
            // 
            // btnGenerarContrato
            // 
            this.btnGenerarContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnGenerarContrato.Enabled = false;
            this.btnGenerarContrato.FlatAppearance.BorderSize = 0;
            this.btnGenerarContrato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerarContrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnGenerarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarContrato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerarContrato.Location = new System.Drawing.Point(322, 394);
            this.btnGenerarContrato.Name = "btnGenerarContrato";
            this.btnGenerarContrato.Size = new System.Drawing.Size(172, 23);
            this.btnGenerarContrato.TabIndex = 94;
            this.btnGenerarContrato.Text = "Generar Contrato";
            this.btnGenerarContrato.UseVisualStyleBackColor = false;
            // 
            // FormServicioDeEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(636, 430);
            this.Controls.Add(this.btnGenerarContrato);
            this.Controls.Add(this.btnContratar);
            this.Controls.Add(this.panelDatosDeEntrenador);
            this.Controls.Add(this.panelDatosDeContrato);
            this.Controls.Add(this.labelTitleCliente);
            this.Controls.Add(this.btnBuscarIdentificacion);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.menuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormServicioDeEntrenador";
            this.Text = "FormServicioDeEntrenador";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormServicioDeEntrenador_MouseDown);
            this.menuTop.ResumeLayout(false);
            this.panelDatosDeContrato.ResumeLayout(false);
            this.panelDatosDeContrato.PerformLayout();
            this.panelDatosDeEntrenador.ResumeLayout(false);
            this.panelDatosDeEntrenador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label labelTitleCliente;
        private System.Windows.Forms.Button btnBuscarIdentificacion;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.Panel panelDatosDeContrato;
        private System.Windows.Forms.Panel panelDatosDeEntrenador;
        private System.Windows.Forms.TextBox textSueldo;
        private System.Windows.Forms.Label labelSueldo;
        private System.Windows.Forms.TextBox textIdentificacion;
        private System.Windows.Forms.Label labelIdentificacion;
        private System.Windows.Forms.TextBox textCantidadHorasExtras;
        private System.Windows.Forms.Label labelCantidadHorasExtras;
        private System.Windows.Forms.TextBox textCantidadDiasTrabajo;
        private System.Windows.Forms.Label labelCantidadDiasTrabajo;
        private System.Windows.Forms.Label labelTipoContrato;
        private System.Windows.Forms.TextBox textCantidadMesesContrato;
        private System.Windows.Forms.Label labelCantidadMesesContrato;
        private System.Windows.Forms.ComboBox comboTipoContrato;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button btnContratar;
        private System.Windows.Forms.Button btnGenerarContrato;
        private System.Windows.Forms.TextBox textSexo;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelCodigoEntrenadorAsignado;
        private System.Windows.Forms.Label labelCodigoEntrenador;
    }
}