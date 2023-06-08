
namespace UI
{
    partial class FormAjustarServidor
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
            panelAvanzado = new Panel();
            labelConnectionString = new Label();
            pictureCadenaConexion = new PictureBox();
            btnBuscarCadenaConexion = new Button();
            panelTituloAvanzado = new Panel();
            labelInstruccionAvanzado = new Label();
            labelTituloAvanzado = new Label();
            textCadenaConexion = new TextBox();
            labelCadenaConexion = new Label();
            btnModificarConexion = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            panelAvanzado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCadenaConexion).BeginInit();
            panelTituloAvanzado.SuspendLayout();
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
            panel1.Size = new Size(556, 31);
            panel1.TabIndex = 1;
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
            btnCerrar.Location = new Point(523, 5);
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
            btnMinimizar.Location = new Point(495, 3);
            btnMinimizar.Margin = new Padding(4, 3, 4, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(23, 23);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // panelAvanzado
            // 
            panelAvanzado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelAvanzado.Controls.Add(labelConnectionString);
            panelAvanzado.Controls.Add(pictureCadenaConexion);
            panelAvanzado.Controls.Add(btnBuscarCadenaConexion);
            panelAvanzado.Controls.Add(panelTituloAvanzado);
            panelAvanzado.Controls.Add(textCadenaConexion);
            panelAvanzado.Controls.Add(labelCadenaConexion);
            panelAvanzado.Location = new Point(12, 38);
            panelAvanzado.Margin = new Padding(4, 3, 4, 3);
            panelAvanzado.Name = "panelAvanzado";
            panelAvanzado.Size = new Size(533, 95);
            panelAvanzado.TabIndex = 95;
            // 
            // labelConnectionString
            // 
            labelConnectionString.AutoSize = true;
            labelConnectionString.Location = new Point(195, 38);
            labelConnectionString.Margin = new Padding(4, 0, 4, 0);
            labelConnectionString.Name = "labelConnectionString";
            labelConnectionString.Size = new Size(12, 15);
            labelConnectionString.TabIndex = 87;
            labelConnectionString.Text = "*";
            // 
            // pictureCadenaConexion
            // 
            pictureCadenaConexion.Image = Properties.Resources.conexion;
            pictureCadenaConexion.Location = new Point(20, 30);
            pictureCadenaConexion.Margin = new Padding(4, 3, 4, 3);
            pictureCadenaConexion.Name = "pictureCadenaConexion";
            pictureCadenaConexion.Size = new Size(27, 30);
            pictureCadenaConexion.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCadenaConexion.TabIndex = 86;
            pictureCadenaConexion.TabStop = false;
            // 
            // btnBuscarCadenaConexion
            // 
            btnBuscarCadenaConexion.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            btnBuscarCadenaConexion.FlatStyle = FlatStyle.Popup;
            btnBuscarCadenaConexion.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarCadenaConexion.Location = new Point(421, 59);
            btnBuscarCadenaConexion.Margin = new Padding(4, 3, 4, 3);
            btnBuscarCadenaConexion.Name = "btnBuscarCadenaConexion";
            btnBuscarCadenaConexion.Size = new Size(43, 25);
            btnBuscarCadenaConexion.TabIndex = 82;
            btnBuscarCadenaConexion.Text = "...";
            btnBuscarCadenaConexion.UseVisualStyleBackColor = true;
            // 
            // panelTituloAvanzado
            // 
            panelTituloAvanzado.Controls.Add(labelInstruccionAvanzado);
            panelTituloAvanzado.Controls.Add(labelTituloAvanzado);
            panelTituloAvanzado.Dock = DockStyle.Top;
            panelTituloAvanzado.Location = new Point(0, 0);
            panelTituloAvanzado.Margin = new Padding(4, 3, 4, 3);
            panelTituloAvanzado.Name = "panelTituloAvanzado";
            panelTituloAvanzado.Size = new Size(533, 29);
            panelTituloAvanzado.TabIndex = 0;
            // 
            // labelInstruccionAvanzado
            // 
            labelInstruccionAvanzado.AutoSize = true;
            labelInstruccionAvanzado.Location = new Point(97, 7);
            labelInstruccionAvanzado.Margin = new Padding(4, 0, 4, 0);
            labelInstruccionAvanzado.Name = "labelInstruccionAvanzado";
            labelInstruccionAvanzado.Size = new Size(148, 15);
            labelInstruccionAvanzado.TabIndex = 87;
            labelInstruccionAvanzado.Text = "(Solo para programadores)";
            // 
            // labelTituloAvanzado
            // 
            labelTituloAvanzado.AutoSize = true;
            labelTituloAvanzado.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTituloAvanzado.Location = new Point(6, 5);
            labelTituloAvanzado.Margin = new Padding(4, 0, 4, 0);
            labelTituloAvanzado.Name = "labelTituloAvanzado";
            labelTituloAvanzado.Size = new Size(76, 16);
            labelTituloAvanzado.TabIndex = 84;
            labelTituloAvanzado.Text = "Avanzado";
            // 
            // textCadenaConexion
            // 
            textCadenaConexion.Location = new Point(14, 59);
            textCadenaConexion.Margin = new Padding(4, 3, 4, 3);
            textCadenaConexion.Name = "textCadenaConexion";
            textCadenaConexion.Size = new Size(401, 23);
            textCadenaConexion.TabIndex = 61;
            textCadenaConexion.TextChanged += textCadenaConexion_TextChanged;
            // 
            // labelCadenaConexion
            // 
            labelCadenaConexion.AutoSize = true;
            labelCadenaConexion.Location = new Point(50, 38);
            labelCadenaConexion.Margin = new Padding(4, 0, 4, 0);
            labelCadenaConexion.Name = "labelCadenaConexion";
            labelCadenaConexion.Size = new Size(133, 15);
            labelCadenaConexion.TabIndex = 60;
            labelCadenaConexion.Text = "Modificar Conexion BD:";
            // 
            // btnModificarConexion
            // 
            btnModificarConexion.BackColor = Color.Black;
            btnModificarConexion.FlatAppearance.BorderSize = 0;
            btnModificarConexion.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btnModificarConexion.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            btnModificarConexion.FlatStyle = FlatStyle.Popup;
            btnModificarConexion.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificarConexion.ForeColor = SystemColors.ControlLightLight;
            btnModificarConexion.IconChar = FontAwesome.Sharp.IconChar.PooBolt;
            btnModificarConexion.IconColor = Color.White;
            btnModificarConexion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificarConexion.IconSize = 30;
            btnModificarConexion.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificarConexion.Location = new Point(192, 151);
            btnModificarConexion.Margin = new Padding(4, 3, 4, 3);
            btnModificarConexion.Name = "btnModificarConexion";
            btnModificarConexion.Size = new Size(144, 40);
            btnModificarConexion.TabIndex = 96;
            btnModificarConexion.Text = "Modificar Conexion";
            btnModificarConexion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificarConexion.UseVisualStyleBackColor = false;
            btnModificarConexion.Click += btnModificarConexion_Click;
            // 
            // FormAjustarServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 205);
            Controls.Add(btnModificarConexion);
            Controls.Add(panelAvanzado);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAjustarServidor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAjustarServidor";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            panelAvanzado.ResumeLayout(false);
            panelAvanzado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCadenaConexion).EndInit();
            panelTituloAvanzado.ResumeLayout(false);
            panelTituloAvanzado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private Panel panelAvanzado;
        private Label labelConnectionString;
        private PictureBox pictureCadenaConexion;
        private Button btnBuscarCadenaConexion;
        private Panel panelTituloAvanzado;
        private Label labelInstruccionAvanzado;
        private Label labelTituloAvanzado;
        private TextBox textCadenaConexion;
        private Label labelCadenaConexion;
        private FontAwesome.Sharp.IconButton btnModificarConexion;
    }
}