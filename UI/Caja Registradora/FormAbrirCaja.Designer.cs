
namespace UI
{
    partial class FormAbrirCaja
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
            menuTop = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            labelTitleCaja = new Label();
            label1 = new Label();
            btnAbrirCaja = new Button();
            textMonto = new TextBox();
            pictureBox1 = new PictureBox();
            menuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuTop
            // 
            menuTop.BackColor = Color.FromArgb(89, 2, 2);
            menuTop.BorderStyle = BorderStyle.FixedSingle;
            menuTop.Controls.Add(btnCerrar);
            menuTop.Dock = DockStyle.Top;
            menuTop.Location = new Point(0, 0);
            menuTop.Margin = new Padding(4, 3, 4, 3);
            menuTop.Name = "menuTop";
            menuTop.Size = new Size(600, 30);
            menuTop.TabIndex = 2;
            menuTop.MouseDown += menuTop_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            btnCerrar.IconColor = Color.White;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.IconSize = 28;
            btnCerrar.Location = new Point(568, 2);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(28, 27);
            btnCerrar.TabIndex = 3;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // labelTitleCaja
            // 
            labelTitleCaja.AutoSize = true;
            labelTitleCaja.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleCaja.ForeColor = Color.Black;
            labelTitleCaja.Location = new Point(198, 67);
            labelTitleCaja.Margin = new Padding(4, 0, 4, 0);
            labelTitleCaja.Name = "labelTitleCaja";
            labelTitleCaja.Size = new Size(212, 24);
            labelTitleCaja.TabIndex = 15;
            labelTitleCaja.Text = "APERTURA DE CAJA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(107, 144);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 17;
            label1.Text = "Digite el monto:";
            // 
            // btnAbrirCaja
            // 
            btnAbrirCaja.BackColor = Color.Black;
            btnAbrirCaja.FlatAppearance.BorderSize = 0;
            btnAbrirCaja.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnAbrirCaja.FlatAppearance.MouseOverBackColor = Color.Red;
            btnAbrirCaja.FlatStyle = FlatStyle.Flat;
            btnAbrirCaja.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbrirCaja.ForeColor = SystemColors.ControlLightLight;
            btnAbrirCaja.Location = new Point(217, 190);
            btnAbrirCaja.Margin = new Padding(4, 3, 4, 3);
            btnAbrirCaja.Name = "btnAbrirCaja";
            btnAbrirCaja.Size = new Size(201, 27);
            btnAbrirCaja.TabIndex = 44;
            btnAbrirCaja.Text = "Abrir";
            btnAbrirCaja.UseVisualStyleBackColor = false;
            btnAbrirCaja.Click += btnAbrirCaja_Click;
            // 
            // textMonto
            // 
            textMonto.BackColor = SystemColors.Control;
            textMonto.BorderStyle = BorderStyle.FixedSingle;
            textMonto.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textMonto.ForeColor = Color.Black;
            textMonto.Location = new Point(241, 140);
            textMonto.Margin = new Padding(4, 3, 4, 3);
            textMonto.Name = "textMonto";
            textMonto.Size = new Size(262, 24);
            textMonto.TabIndex = 46;
            textMonto.Text = "0";
            textMonto.Enter += textUsuario_Enter;
            textMonto.KeyPress += textMonto_KeyPress;
            textMonto.Leave += textUsuario_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Caja_Registradora;
            pictureBox1.Location = new Point(63, 34);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // FormAbrirCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(600, 241);
            Controls.Add(pictureBox1);
            Controls.Add(textMonto);
            Controls.Add(btnAbrirCaja);
            Controls.Add(label1);
            Controls.Add(labelTitleCaja);
            Controls.Add(menuTop);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAbrirCaja";
            Opacity = 0.97D;
            Text = "Abrir Caja";
            MouseDown += FormAbrirCaja_MouseDown;
            menuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel menuTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private Label labelTitleCaja;
        private Label label1;
        private Button btnAbrirCaja;
        private TextBox textMonto;
        private PictureBox pictureBox1;
    }
}