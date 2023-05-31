
namespace UI
{
    partial class FormInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioSesion));
            panel1 = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            labelInicioSesion = new Label();
            pictureLogo = new PictureBox();
            pictureBox1 = new PictureBox();
            labelUser = new Label();
            labelPasword = new Label();
            textBoxUser = new TextBox();
            textBoxPasword = new TextBox();
            btnIngresar = new Button();
            labelAdvertencia = new Label();
            iconAdvertencia = new FontAwesome.Sharp.IconPictureBox();
            iconSeePasword = new FontAwesome.Sharp.IconPictureBox();
            iconNoSeePasword = new FontAwesome.Sharp.IconPictureBox();
            iconPassword = new FontAwesome.Sharp.IconPictureBox();
            iconUser = new FontAwesome.Sharp.IconPictureBox();
            btnAjustarServidor = new FontAwesome.Sharp.IconButton();
            linkLabelRegistrarUsuario = new LinkLabel();
            linkLabelRestaurarContraseña = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconAdvertencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconSeePasword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconNoSeePasword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconUser).BeginInit();
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
            panel1.Size = new Size(438, 31);
            panel1.TabIndex = 0;
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
            btnCerrar.Location = new Point(404, 5);
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
            btnMinimizar.Location = new Point(376, 3);
            btnMinimizar.Margin = new Padding(4, 3, 4, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(23, 23);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelInicioSesion);
            panel2.Controls.Add(pictureLogo);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 31);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(438, 153);
            panel2.TabIndex = 1;
            // 
            // labelInicioSesion
            // 
            labelInicioSesion.AutoSize = true;
            labelInicioSesion.BackColor = Color.Transparent;
            labelInicioSesion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelInicioSesion.ForeColor = SystemColors.ActiveCaptionText;
            labelInicioSesion.Location = new Point(165, 128);
            labelInicioSesion.Margin = new Padding(4, 0, 4, 0);
            labelInicioSesion.Name = "labelInicioSesion";
            labelInicioSesion.Size = new Size(115, 20);
            labelInicioSesion.TabIndex = 1;
            labelInicioSesion.Text = "Iniciar sesion";
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.Transparent;
            pictureLogo.BackgroundImageLayout = ImageLayout.Center;
            pictureLogo.Image = Properties.Resources.Logo;
            pictureLogo.Location = new Point(153, 15);
            pictureLogo.Margin = new Padding(4, 3, 4, 3);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(132, 120);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUser.Location = new Point(68, 227);
            labelUser.Margin = new Padding(4, 0, 4, 0);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(65, 16);
            labelUser.TabIndex = 2;
            labelUser.Text = "Usuario:";
            // 
            // labelPasword
            // 
            labelPasword.AutoSize = true;
            labelPasword.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPasword.Location = new Point(68, 259);
            labelPasword.Margin = new Padding(4, 0, 4, 0);
            labelPasword.Name = "labelPasword";
            labelPasword.Size = new Size(90, 16);
            labelPasword.TabIndex = 3;
            labelPasword.Text = "Contraseña:";
            // 
            // textBoxUser
            // 
            textBoxUser.ForeColor = SystemColors.WindowFrame;
            textBoxUser.Location = new Point(175, 221);
            textBoxUser.Margin = new Padding(4, 3, 4, 3);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(186, 23);
            textBoxUser.TabIndex = 4;
            textBoxUser.Text = "@Usuario";
            textBoxUser.TextChanged += textBoxUser_TextChanged;
            textBoxUser.Enter += textBoxUser_Enter;
            textBoxUser.Leave += textBoxUser_Leave;
            // 
            // textBoxPasword
            // 
            textBoxPasword.ForeColor = SystemColors.WindowFrame;
            textBoxPasword.Location = new Point(175, 259);
            textBoxPasword.Margin = new Padding(4, 3, 4, 3);
            textBoxPasword.Name = "textBoxPasword";
            textBoxPasword.Size = new Size(186, 23);
            textBoxPasword.TabIndex = 5;
            textBoxPasword.Text = "Contraseña";
            textBoxPasword.TextChanged += textBoxPasword_TextChanged;
            textBoxPasword.Enter += textBoxPasword_Enter;
            textBoxPasword.Leave += textBoxPasword_Leave;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Black;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.White;
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(153, 361);
            btnIngresar.Margin = new Padding(4, 3, 4, 3);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(128, 32);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // labelAdvertencia
            // 
            labelAdvertencia.AutoSize = true;
            labelAdvertencia.ForeColor = Color.Maroon;
            labelAdvertencia.Location = new Point(202, 290);
            labelAdvertencia.Margin = new Padding(4, 0, 4, 0);
            labelAdvertencia.Name = "labelAdvertencia";
            labelAdvertencia.Size = new Size(70, 15);
            labelAdvertencia.TabIndex = 14;
            labelAdvertencia.Text = "Advertencia";
            labelAdvertencia.Visible = false;
            // 
            // iconAdvertencia
            // 
            iconAdvertencia.BackColor = SystemColors.Control;
            iconAdvertencia.ForeColor = Color.Maroon;
            iconAdvertencia.IconChar = FontAwesome.Sharp.IconChar.Warning;
            iconAdvertencia.IconColor = Color.Maroon;
            iconAdvertencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAdvertencia.IconSize = 23;
            iconAdvertencia.Location = new Point(175, 286);
            iconAdvertencia.Margin = new Padding(4, 3, 4, 3);
            iconAdvertencia.Name = "iconAdvertencia";
            iconAdvertencia.Size = new Size(23, 23);
            iconAdvertencia.TabIndex = 13;
            iconAdvertencia.TabStop = false;
            iconAdvertencia.Visible = false;
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
            iconSeePasword.Location = new Point(369, 257);
            iconSeePasword.Margin = new Padding(4, 3, 4, 3);
            iconSeePasword.Name = "iconSeePasword";
            iconSeePasword.Size = new Size(24, 25);
            iconSeePasword.TabIndex = 10;
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
            iconNoSeePasword.Location = new Point(369, 257);
            iconNoSeePasword.Margin = new Padding(4, 3, 4, 3);
            iconNoSeePasword.Name = "iconNoSeePasword";
            iconNoSeePasword.Size = new Size(24, 25);
            iconNoSeePasword.TabIndex = 9;
            iconNoSeePasword.TabStop = false;
            iconNoSeePasword.Click += iconNoSeePasword_Click;
            // 
            // iconPassword
            // 
            iconPassword.BackColor = SystemColors.Control;
            iconPassword.ForeColor = SystemColors.ControlText;
            iconPassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconPassword.IconColor = SystemColors.ControlText;
            iconPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPassword.IconSize = 24;
            iconPassword.Location = new Point(42, 257);
            iconPassword.Margin = new Padding(4, 3, 4, 3);
            iconPassword.Name = "iconPassword";
            iconPassword.Size = new Size(24, 25);
            iconPassword.TabIndex = 8;
            iconPassword.TabStop = false;
            // 
            // iconUser
            // 
            iconUser.BackColor = SystemColors.Control;
            iconUser.ForeColor = SystemColors.ControlText;
            iconUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconUser.IconColor = SystemColors.ControlText;
            iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUser.IconSize = 24;
            iconUser.Location = new Point(42, 225);
            iconUser.Margin = new Padding(4, 3, 4, 3);
            iconUser.Name = "iconUser";
            iconUser.Size = new Size(24, 25);
            iconUser.TabIndex = 7;
            iconUser.TabStop = false;
            // 
            // btnAjustarServidor
            // 
            btnAjustarServidor.IconChar = FontAwesome.Sharp.IconChar.Gear;
            btnAjustarServidor.IconColor = Color.Black;
            btnAjustarServidor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAjustarServidor.IconSize = 20;
            btnAjustarServidor.Location = new Point(399, 186);
            btnAjustarServidor.Margin = new Padding(4, 3, 4, 3);
            btnAjustarServidor.Name = "btnAjustarServidor";
            btnAjustarServidor.Size = new Size(35, 25);
            btnAjustarServidor.TabIndex = 15;
            btnAjustarServidor.UseVisualStyleBackColor = true;
            btnAjustarServidor.Visible = false;
            btnAjustarServidor.Click += btnAjustarServidor_Click;
            // 
            // linkLabelRegistrarUsuario
            // 
            linkLabelRegistrarUsuario.AutoSize = true;
            linkLabelRegistrarUsuario.Cursor = Cursors.Hand;
            linkLabelRegistrarUsuario.Location = new Point(139, 337);
            linkLabelRegistrarUsuario.Margin = new Padding(4, 0, 4, 0);
            linkLabelRegistrarUsuario.Name = "linkLabelRegistrarUsuario";
            linkLabelRegistrarUsuario.Size = new Size(161, 15);
            linkLabelRegistrarUsuario.TabIndex = 17;
            linkLabelRegistrarUsuario.TabStop = true;
            linkLabelRegistrarUsuario.Text = "¿No tienes cuenta? Registrate";
            linkLabelRegistrarUsuario.LinkClicked += linkLabelRegistrarUsuario_LinkClicked;
            // 
            // linkLabelRestaurarContraseña
            // 
            linkLabelRestaurarContraseña.AutoSize = true;
            linkLabelRestaurarContraseña.Cursor = Cursors.Hand;
            linkLabelRestaurarContraseña.Location = new Point(176, 317);
            linkLabelRestaurarContraseña.Margin = new Padding(4, 0, 4, 0);
            linkLabelRestaurarContraseña.Name = "linkLabelRestaurarContraseña";
            linkLabelRestaurarContraseña.Size = new Size(141, 15);
            linkLabelRestaurarContraseña.TabIndex = 16;
            linkLabelRestaurarContraseña.TabStop = true;
            linkLabelRestaurarContraseña.Text = "¿Olvidaste tu contraseña?";
            linkLabelRestaurarContraseña.LinkClicked += linkLabelRestaurarContraseña_LinkClicked_1;
            // 
            // FormInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 433);
            Controls.Add(linkLabelRegistrarUsuario);
            Controls.Add(linkLabelRestaurarContraseña);
            Controls.Add(btnAjustarServidor);
            Controls.Add(labelAdvertencia);
            Controls.Add(iconAdvertencia);
            Controls.Add(iconSeePasword);
            Controls.Add(iconNoSeePasword);
            Controls.Add(iconPassword);
            Controls.Add(iconUser);
            Controls.Add(btnIngresar);
            Controls.Add(textBoxPasword);
            Controls.Add(textBoxUser);
            Controls.Add(labelPasword);
            Controls.Add(labelUser);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormInicioSesion";
            Opacity = 0.88D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            MouseDown += FormInicioSesion_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconAdvertencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconSeePasword).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconNoSeePasword).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label labelInicioSesion;
        private PictureBox pictureLogo;
        private Label labelUser;
        private Label labelPasword;
        private TextBox textBoxUser;
        private TextBox textBoxPasword;
        private Button btnIngresar;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private FontAwesome.Sharp.IconPictureBox iconPassword;
        private FontAwesome.Sharp.IconPictureBox iconNoSeePasword;
        private FontAwesome.Sharp.IconPictureBox iconSeePasword;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconAdvertencia;
        private Label labelAdvertencia;
        private FontAwesome.Sharp.IconButton btnAjustarServidor;
        private LinkLabel linkLabelRegistrarUsuario;
        private LinkLabel linkLabelRestaurarContraseña;
    }
}