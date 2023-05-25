
namespace UI
{
    partial class FormRestaurarContraseña
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
            panelBarraVolver = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnVolver = new FontAwesome.Sharp.IconButton();
            textIdentificacion = new TextBox();
            labelIdentificacion = new Label();
            textUsuario = new TextBox();
            labelUsuario = new Label();
            btnBuscar = new Button();
            textContraseña = new TextBox();
            labelContraseña = new Label();
            label5 = new Label();
            btnRestaurar = new Button();
            labelAdvertencia = new Label();
            iconNoSeePasword = new FontAwesome.Sharp.IconPictureBox();
            iconSeePasword = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconNoSeePasword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconSeePasword).BeginInit();
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
            panel1.Size = new Size(415, 31);
            panel1.TabIndex = 1;
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
            btnCerrar.Location = new Point(382, 5);
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
            btnMinimizar.Location = new Point(354, 3);
            btnMinimizar.Margin = new Padding(4, 3, 4, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(23, 23);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // panelBarraVolver
            // 
            panelBarraVolver.BackColor = Color.FromArgb(89, 2, 2);
            panelBarraVolver.Location = new Point(4, 33);
            panelBarraVolver.Margin = new Padding(4, 3, 4, 3);
            panelBarraVolver.Name = "panelBarraVolver";
            panelBarraVolver.Size = new Size(8, 29);
            panelBarraVolver.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(50, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 24);
            label1.TabIndex = 35;
            label1.Text = "Restaurar Contraseña";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 66);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 132);
            panel2.TabIndex = 53;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = UI.Properties.Resources.Reset;
            pictureBox1.Location = new Point(128, 5);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            btnVolver.Location = new Point(14, 33);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(29, 29);
            btnVolver.TabIndex = 37;
            btnVolver.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // textIdentificacion
            // 
            textIdentificacion.ForeColor = Color.Black;
            textIdentificacion.Location = new Point(112, 253);
            textIdentificacion.Margin = new Padding(4, 3, 4, 3);
            textIdentificacion.Name = "textIdentificacion";
            textIdentificacion.Size = new Size(153, 23);
            textIdentificacion.TabIndex = 55;
            // 
            // labelIdentificacion
            // 
            labelIdentificacion.AutoSize = true;
            labelIdentificacion.Location = new Point(26, 257);
            labelIdentificacion.Margin = new Padding(4, 0, 4, 0);
            labelIdentificacion.Name = "labelIdentificacion";
            labelIdentificacion.Size = new Size(82, 15);
            labelIdentificacion.TabIndex = 54;
            labelIdentificacion.Text = "Identificacion:";
            // 
            // textUsuario
            // 
            textUsuario.ForeColor = Color.Black;
            textUsuario.Location = new Point(112, 224);
            textUsuario.Margin = new Padding(4, 3, 4, 3);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(153, 23);
            textUsuario.TabIndex = 57;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(26, 228);
            labelUsuario.Margin = new Padding(4, 0, 4, 0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(50, 15);
            labelUsuario.TabIndex = 56;
            labelUsuario.Text = "Usuario:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(62, 178, 191);
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.White;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(141, 365);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(128, 32);
            btnBuscar.TabIndex = 58;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // textContraseña
            // 
            textContraseña.Enabled = false;
            textContraseña.ForeColor = Color.Gray;
            textContraseña.Location = new Point(107, 324);
            textContraseña.Margin = new Padding(4, 3, 4, 3);
            textContraseña.Name = "textContraseña";
            textContraseña.Size = new Size(158, 23);
            textContraseña.TabIndex = 60;
            textContraseña.Text = "Contraseña";
            textContraseña.Enter += textContraseña_Enter;
            textContraseña.Leave += textContraseña_Leave;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Enabled = false;
            labelContraseña.Location = new Point(26, 328);
            labelContraseña.Margin = new Padding(4, 0, 4, 0);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(70, 15);
            labelContraseña.TabIndex = 59;
            labelContraseña.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(2, 56, 89);
            label5.Location = new Point(21, 291);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 18);
            label5.TabIndex = 61;
            label5.Text = "Nueva Contraseña";
            // 
            // btnRestaurar
            // 
            btnRestaurar.BackColor = Color.Black;
            btnRestaurar.FlatAppearance.MouseDownBackColor = Color.White;
            btnRestaurar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestaurar.ForeColor = Color.White;
            btnRestaurar.Location = new Point(141, 365);
            btnRestaurar.Margin = new Padding(4, 3, 4, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(128, 32);
            btnRestaurar.TabIndex = 62;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // labelAdvertencia
            // 
            labelAdvertencia.AutoSize = true;
            labelAdvertencia.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAdvertencia.ForeColor = Color.Maroon;
            labelAdvertencia.Location = new Point(110, 200);
            labelAdvertencia.Margin = new Padding(4, 0, 4, 0);
            labelAdvertencia.Name = "labelAdvertencia";
            labelAdvertencia.Size = new Size(95, 18);
            labelAdvertencia.TabIndex = 63;
            labelAdvertencia.Text = "Advertencia";
            labelAdvertencia.Visible = false;
            // 
            // iconNoSeePasword
            // 
            iconNoSeePasword.BackColor = SystemColors.Control;
            iconNoSeePasword.ForeColor = SystemColors.ControlText;
            iconNoSeePasword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            iconNoSeePasword.IconColor = SystemColors.ControlText;
            iconNoSeePasword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconNoSeePasword.IconSize = 24;
            iconNoSeePasword.Location = new Point(267, 325);
            iconNoSeePasword.Margin = new Padding(4, 3, 4, 3);
            iconNoSeePasword.Name = "iconNoSeePasword";
            iconNoSeePasword.Size = new Size(24, 25);
            iconNoSeePasword.TabIndex = 64;
            iconNoSeePasword.TabStop = false;
            iconNoSeePasword.Click += iconNoSeePasword_Click;
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
            iconSeePasword.Location = new Point(267, 325);
            iconSeePasword.Margin = new Padding(4, 3, 4, 3);
            iconSeePasword.Name = "iconSeePasword";
            iconSeePasword.Size = new Size(24, 25);
            iconSeePasword.TabIndex = 65;
            iconSeePasword.TabStop = false;
            iconSeePasword.Visible = false;
            iconSeePasword.Click += iconSeePasword_Click;
            // 
            // FormRestaurarContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 411);
            Controls.Add(iconSeePasword);
            Controls.Add(iconNoSeePasword);
            Controls.Add(labelAdvertencia);
            Controls.Add(btnRestaurar);
            Controls.Add(label5);
            Controls.Add(textContraseña);
            Controls.Add(labelContraseña);
            Controls.Add(btnBuscar);
            Controls.Add(textUsuario);
            Controls.Add(labelUsuario);
            Controls.Add(textIdentificacion);
            Controls.Add(labelIdentificacion);
            Controls.Add(panel2);
            Controls.Add(btnVolver);
            Controls.Add(panelBarraVolver);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormRestaurarContraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRestaurarContraseña";
            MouseDown += FormRestaurarContraseña_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconNoSeePasword).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconSeePasword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private FontAwesome.Sharp.IconButton btnVolver;
        private Panel panelBarraVolver;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox textIdentificacion;
        private Label labelIdentificacion;
        private TextBox textUsuario;
        private Label labelUsuario;
        private Button btnBuscar;
        private TextBox textContraseña;
        private Label labelContraseña;
        private Label label5;
        private Button btnRestaurar;
        private Label labelAdvertencia;
        private FontAwesome.Sharp.IconPictureBox iconNoSeePasword;
        private FontAwesome.Sharp.IconPictureBox iconSeePasword;
    }
}