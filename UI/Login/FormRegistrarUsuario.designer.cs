
namespace UI
{
    partial class FormRegistrarUsuario
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
            panel1 = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            labelCorreo = new Label();
            textCorreo = new TextBox();
            textUsuario = new TextBox();
            labelUsuario = new Label();
            textContraseña = new TextBox();
            labelContraseña = new Label();
            panelBarraVolver = new Panel();
            label1 = new Label();
            textIdentificacion = new TextBox();
            labelIdentificacion = new Label();
            comboTipoDeId = new ComboBox();
            label3 = new Label();
            textNombre = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textApellido = new TextBox();
            label6 = new Label();
            dateTimeFechaDeNacimiento = new DateTimePicker();
            label7 = new Label();
            comboSexo = new ComboBox();
            textDireccion = new TextBox();
            label8 = new Label();
            textTelefono = new TextBox();
            label9 = new Label();
            btnRegistrar = new Button();
            comboRol = new ComboBox();
            label2 = new Label();
            labelAdvertencia = new Label();
            iconSeePasword = new FontAwesome.Sharp.IconPictureBox();
            iconNoSeePasword = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            btnCargarFoto = new FontAwesome.Sharp.IconButton();
            picturePerfil = new PictureBox();
            btnVolver = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconSeePasword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconNoSeePasword).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePerfil).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(89, 2, 2);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnMinimizar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(536, 31);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.FromArgb(89, 2, 2);
            btnCerrar.ForeColor = SystemColors.ControlLightLight;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            btnCerrar.IconColor = SystemColors.ControlLightLight;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.IconSize = 23;
            btnCerrar.Location = new Point(502, 5);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 23);
            btnCerrar.TabIndex = 3;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.FromArgb(89, 2, 2);
            btnMinimizar.ForeColor = SystemColors.ControlLightLight;
            btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizar.IconColor = SystemColors.ControlLightLight;
            btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizar.IconSize = 23;
            btnMinimizar.Location = new Point(474, 3);
            btnMinimizar.Margin = new Padding(4, 3, 4, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(23, 23);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(11, 237);
            labelCorreo.Margin = new Padding(4, 0, 4, 0);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(108, 15);
            labelCorreo.TabIndex = 3;
            labelCorreo.Text = "Correo electronico:";
            // 
            // textCorreo
            // 
            textCorreo.ForeColor = SystemColors.WindowFrame;
            textCorreo.Location = new Point(120, 233);
            textCorreo.Margin = new Padding(4, 3, 4, 3);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(188, 23);
            textCorreo.TabIndex = 4;
            textCorreo.Text = "@gmail.com";
            textCorreo.Enter += textCorreo_Enter;
            textCorreo.Leave += textCorreo_Leave;
            // 
            // textUsuario
            // 
            textUsuario.ForeColor = SystemColors.WindowFrame;
            textUsuario.Location = new Point(72, 263);
            textUsuario.Margin = new Padding(4, 3, 4, 3);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(166, 23);
            textUsuario.TabIndex = 6;
            textUsuario.Text = "@Bryan10";
            textUsuario.Enter += textUsuario_Enter;
            textUsuario.Leave += textUsuario_Leave;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(11, 267);
            labelUsuario.Margin = new Padding(4, 0, 4, 0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(50, 15);
            labelUsuario.TabIndex = 5;
            labelUsuario.Text = "Usuario:";
            // 
            // textContraseña
            // 
            textContraseña.ForeColor = SystemColors.WindowFrame;
            textContraseña.Location = new Point(315, 263);
            textContraseña.Margin = new Padding(4, 3, 4, 3);
            textContraseña.Name = "textContraseña";
            textContraseña.Size = new Size(177, 23);
            textContraseña.TabIndex = 8;
            textContraseña.Text = "Mayor a 6 caracteres";
            textContraseña.Enter += textContraseña_Enter;
            textContraseña.Leave += textContraseña_Leave;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(241, 268);
            labelContraseña.Margin = new Padding(4, 0, 4, 0);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(70, 15);
            labelContraseña.TabIndex = 7;
            labelContraseña.Text = "Contraseña:";
            // 
            // panelBarraVolver
            // 
            panelBarraVolver.BackColor = Color.FromArgb(89, 2, 2);
            panelBarraVolver.Location = new Point(1, 35);
            panelBarraVolver.Margin = new Padding(4, 3, 4, 3);
            panelBarraVolver.Name = "panelBarraVolver";
            panelBarraVolver.Size = new Size(8, 29);
            panelBarraVolver.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(46, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 24);
            label1.TabIndex = 32;
            label1.Text = "Registro de usuario";
            // 
            // textIdentificacion
            // 
            textIdentificacion.ForeColor = Color.Black;
            textIdentificacion.Location = new Point(92, 294);
            textIdentificacion.Margin = new Padding(4, 3, 4, 3);
            textIdentificacion.Name = "textIdentificacion";
            textIdentificacion.Size = new Size(131, 23);
            textIdentificacion.TabIndex = 36;
            // 
            // labelIdentificacion
            // 
            labelIdentificacion.AutoSize = true;
            labelIdentificacion.Location = new Point(11, 299);
            labelIdentificacion.Margin = new Padding(4, 0, 4, 0);
            labelIdentificacion.Name = "labelIdentificacion";
            labelIdentificacion.Size = new Size(82, 15);
            labelIdentificacion.TabIndex = 35;
            labelIdentificacion.Text = "Identificacion:";
            // 
            // comboTipoDeId
            // 
            comboTipoDeId.FormattingEnabled = true;
            comboTipoDeId.Items.AddRange(new object[] { "CC", "TI" });
            comboTipoDeId.Location = new Point(291, 294);
            comboTipoDeId.Margin = new Padding(4, 3, 4, 3);
            comboTipoDeId.Name = "comboTipoDeId";
            comboTipoDeId.Size = new Size(72, 23);
            comboTipoDeId.TabIndex = 37;
            comboTipoDeId.Text = "CC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 300);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 38;
            label3.Text = "Tipo de id:";
            // 
            // textNombre
            // 
            textNombre.ForeColor = Color.Black;
            textNombre.Location = new Point(69, 323);
            textNombre.Margin = new Padding(4, 3, 4, 3);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(140, 23);
            textNombre.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 328);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 39;
            label4.Text = "Nombres:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 328);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 41;
            label5.Text = "Apellidos:";
            // 
            // textApellido
            // 
            textApellido.ForeColor = Color.Black;
            textApellido.Location = new Point(269, 324);
            textApellido.Margin = new Padding(4, 3, 4, 3);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(140, 23);
            textApellido.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 357);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 15);
            label6.TabIndex = 43;
            label6.Text = "Fecha de nacimiento:";
            // 
            // dateTimeFechaDeNacimiento
            // 
            dateTimeFechaDeNacimiento.Location = new Point(136, 352);
            dateTimeFechaDeNacimiento.Margin = new Padding(4, 3, 4, 3);
            dateTimeFechaDeNacimiento.Name = "dateTimeFechaDeNacimiento";
            dateTimeFechaDeNacimiento.Size = new Size(233, 23);
            dateTimeFechaDeNacimiento.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(372, 357);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 45;
            label7.Text = "Sexo:";
            // 
            // comboSexo
            // 
            comboSexo.FormattingEnabled = true;
            comboSexo.Items.AddRange(new object[] { "M", "F" });
            comboSexo.Location = new Point(409, 353);
            comboSexo.Margin = new Padding(4, 3, 4, 3);
            comboSexo.Name = "comboSexo";
            comboSexo.Size = new Size(72, 23);
            comboSexo.TabIndex = 46;
            comboSexo.Text = "M";
            // 
            // textDireccion
            // 
            textDireccion.ForeColor = Color.Black;
            textDireccion.Location = new Point(77, 381);
            textDireccion.Margin = new Padding(4, 3, 4, 3);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(140, 23);
            textDireccion.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 386);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 47;
            label8.Text = "Direccion:";
            // 
            // textTelefono
            // 
            textTelefono.ForeColor = Color.Black;
            textTelefono.Location = new Point(285, 382);
            textTelefono.Margin = new Padding(4, 3, 4, 3);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(140, 23);
            textTelefono.TabIndex = 50;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(225, 386);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 49;
            label9.Text = "Telefono:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Black;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.White;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(203, 426);
            btnRegistrar.Margin = new Padding(4, 3, 4, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(128, 32);
            btnRegistrar.TabIndex = 51;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // comboRol
            // 
            comboRol.ForeColor = Color.Maroon;
            comboRol.FormattingEnabled = true;
            comboRol.Items.AddRange(new object[] { "Administrador", "Empleado" });
            comboRol.Location = new Point(407, 297);
            comboRol.Margin = new Padding(4, 3, 4, 3);
            comboRol.Name = "comboRol";
            comboRol.Size = new Size(109, 23);
            comboRol.TabIndex = 53;
            comboRol.Text = "Administrador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 300);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 54;
            label2.Text = "Rol:";
            // 
            // labelAdvertencia
            // 
            labelAdvertencia.AutoSize = true;
            labelAdvertencia.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAdvertencia.ForeColor = Color.Maroon;
            labelAdvertencia.Location = new Point(273, 45);
            labelAdvertencia.Margin = new Padding(4, 0, 4, 0);
            labelAdvertencia.Name = "labelAdvertencia";
            labelAdvertencia.Size = new Size(90, 16);
            labelAdvertencia.TabIndex = 57;
            labelAdvertencia.Text = "Advertencia";
            labelAdvertencia.Visible = false;
            // 
            // iconSeePasword
            // 
            iconSeePasword.BackColor = SystemColors.Control;
            iconSeePasword.Cursor = Cursors.Hand;
            iconSeePasword.ForeColor = SystemColors.ControlText;
            iconSeePasword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            iconSeePasword.IconColor = SystemColors.ControlText;
            iconSeePasword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSeePasword.IconSize = 24;
            iconSeePasword.Location = new Point(493, 263);
            iconSeePasword.Margin = new Padding(4, 3, 4, 3);
            iconSeePasword.Name = "iconSeePasword";
            iconSeePasword.Size = new Size(24, 25);
            iconSeePasword.TabIndex = 55;
            iconSeePasword.TabStop = false;
            iconSeePasword.Visible = false;
            iconSeePasword.Click += iconSeePasword_Click;
            // 
            // iconNoSeePasword
            // 
            iconNoSeePasword.BackColor = SystemColors.Control;
            iconNoSeePasword.ForeColor = SystemColors.ControlText;
            iconNoSeePasword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            iconNoSeePasword.IconColor = SystemColors.ControlText;
            iconNoSeePasword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconNoSeePasword.IconSize = 24;
            iconNoSeePasword.Location = new Point(493, 263);
            iconNoSeePasword.Margin = new Padding(4, 3, 4, 3);
            iconNoSeePasword.Name = "iconNoSeePasword";
            iconNoSeePasword.Size = new Size(24, 25);
            iconNoSeePasword.TabIndex = 56;
            iconNoSeePasword.TabStop = false;
            iconNoSeePasword.Click += iconNoSeePasword_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCargarFoto);
            panel2.Controls.Add(picturePerfil);
            panel2.Location = new Point(0, 67);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(536, 160);
            panel2.TabIndex = 52;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCargarFoto.IconColor = Color.Black;
            btnCargarFoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCargarFoto.Location = new Point(223, 127);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(92, 23);
            btnCargarFoto.TabIndex = 20;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = true;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // picturePerfil
            // 
            picturePerfil.Image = Properties.Resources.User;
            picturePerfil.Location = new Point(210, 3);
            picturePerfil.Margin = new Padding(4, 3, 4, 3);
            picturePerfil.Name = "picturePerfil";
            picturePerfil.Size = new Size(121, 121);
            picturePerfil.SizeMode = PictureBoxSizeMode.Zoom;
            picturePerfil.TabIndex = 0;
            picturePerfil.TabStop = false;
            picturePerfil.Paint += picturePerfil_Paint;
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderColor = Color.FromArgb(89, 2, 2);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ActiveCaptionText;
            btnVolver.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            btnVolver.IconColor = SystemColors.WindowText;
            btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVolver.IconSize = 28;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(12, 35);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(29, 29);
            btnVolver.TabIndex = 34;
            btnVolver.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormRegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 462);
            Controls.Add(labelAdvertencia);
            Controls.Add(iconSeePasword);
            Controls.Add(iconNoSeePasword);
            Controls.Add(label2);
            Controls.Add(comboRol);
            Controls.Add(panel2);
            Controls.Add(btnRegistrar);
            Controls.Add(textTelefono);
            Controls.Add(label9);
            Controls.Add(textDireccion);
            Controls.Add(label8);
            Controls.Add(comboSexo);
            Controls.Add(label7);
            Controls.Add(dateTimeFechaDeNacimiento);
            Controls.Add(label6);
            Controls.Add(textApellido);
            Controls.Add(label5);
            Controls.Add(textNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboTipoDeId);
            Controls.Add(textIdentificacion);
            Controls.Add(labelIdentificacion);
            Controls.Add(btnVolver);
            Controls.Add(panelBarraVolver);
            Controls.Add(label1);
            Controls.Add(textContraseña);
            Controls.Add(labelContraseña);
            Controls.Add(textUsuario);
            Controls.Add(labelUsuario);
            Controls.Add(textCorreo);
            Controls.Add(labelCorreo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormRegistrarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrarUsuario";
            MouseDown += FormRegistrarUsuario_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconSeePasword).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconNoSeePasword).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picturePerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private Label labelCorreo;
        private TextBox textCorreo;
        private TextBox textUsuario;
        private Label labelUsuario;
        private TextBox textContraseña;
        private Label labelContraseña;
        private FontAwesome.Sharp.IconButton btnVolver;
        private Panel panelBarraVolver;
        private Label label1;
        private TextBox textIdentificacion;
        private Label labelIdentificacion;
        private ComboBox comboTipoDeId;
        private Label label3;
        private TextBox textNombre;
        private Label label4;
        private Label label5;
        private TextBox textApellido;
        private Label label6;
        private DateTimePicker dateTimeFechaDeNacimiento;
        private Label label7;
        private ComboBox comboSexo;
        private TextBox textDireccion;
        private Label label8;
        private TextBox textTelefono;
        private Label label9;
        private Button btnRegistrar;
        private Panel panel2;
        private PictureBox picturePerfil;
        private ComboBox comboRol;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconSeePasword;
        private FontAwesome.Sharp.IconPictureBox iconNoSeePasword;
        private Label labelAdvertencia;
        private FontAwesome.Sharp.IconButton btnCargarFoto;
    }
}