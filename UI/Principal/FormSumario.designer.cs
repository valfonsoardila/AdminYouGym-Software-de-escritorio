namespace UI
{
    partial class FormSumario
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            labelCaja = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            labelTitleEntrenadores = new Label();
            lblFecha = new Label();
            lblhora = new Label();
            panel13 = new Panel();
            pictureBox5 = new PictureBox();
            labelProductos = new FontAwesome.Sharp.IconButton();
            panel14 = new Panel();
            labelTitleAcerca = new Label();
            label15 = new Label();
            panel11 = new Panel();
            pictureBox3 = new PictureBox();
            labelPlanes = new FontAwesome.Sharp.IconButton();
            panel12 = new Panel();
            labelTitleServicios = new Label();
            panel9 = new Panel();
            pictureBox1 = new PictureBox();
            labelMiembros = new FontAwesome.Sharp.IconButton();
            panel10 = new Panel();
            label3 = new Label();
            label4 = new Label();
            labelTitleClientes = new Label();
            panel7 = new Panel();
            pictureBox4 = new PictureBox();
            labelEntrenadores = new FontAwesome.Sharp.IconButton();
            panel8 = new Panel();
            labelTitleCash = new Label();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            labelRefresh = new Label();
            panel4 = new Panel();
            iconPapelera = new FontAwesome.Sharp.IconButton();
            labelPapelera = new Label();
            panel3 = new Panel();
            panel15 = new Panel();
            Reloj = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel14.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel12.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel10.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel15.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(labelCaja);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = Color.SeaGreen;
            panel1.Location = new Point(272, 39);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(128, 173);
            panel1.TabIndex = 30;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Caja_Registradora;
            pictureBox2.Location = new Point(15, 39);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(96, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // labelCaja
            // 
            labelCaja.FlatAppearance.BorderSize = 0;
            labelCaja.FlatAppearance.MouseDownBackColor = Color.Transparent;
            labelCaja.FlatAppearance.MouseOverBackColor = Color.Transparent;
            labelCaja.FlatStyle = FlatStyle.Flat;
            labelCaja.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCaja.ForeColor = Color.RoyalBlue;
            labelCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            labelCaja.IconColor = Color.Black;
            labelCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            labelCaja.Location = new Point(4, 133);
            labelCaja.Margin = new Padding(4, 3, 4, 3);
            labelCaja.Name = "labelCaja";
            labelCaja.Size = new Size(127, 35);
            labelCaja.TabIndex = 31;
            labelCaja.Text = "lbl1";
            labelCaja.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(labelTitleEntrenadores);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.SeaShell;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(126, 35);
            panel2.TabIndex = 0;
            // 
            // labelTitleEntrenadores
            // 
            labelTitleEntrenadores.AutoSize = true;
            labelTitleEntrenadores.BackColor = Color.Black;
            labelTitleEntrenadores.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitleEntrenadores.ForeColor = Color.White;
            labelTitleEntrenadores.Location = new Point(28, 8);
            labelTitleEntrenadores.Margin = new Padding(4, 0, 4, 0);
            labelTitleEntrenadores.Name = "labelTitleEntrenadores";
            labelTitleEntrenadores.Size = new Size(64, 18);
            labelTitleEntrenadores.TabIndex = 15;
            labelTitleEntrenadores.Text = "Dinero $";
            // 
            // lblFecha
            // 
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Dock = DockStyle.Bottom;
            lblFecha.FlatStyle = FlatStyle.Flat;
            lblFecha.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.Black;
            lblFecha.Location = new Point(0, 150);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.RightToLeft = RightToLeft.Yes;
            lblFecha.Size = new Size(1009, 45);
            lblFecha.TabIndex = 29;
            lblFecha.Text = "Miercoles, 10  noviembre  2017";
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblhora
            // 
            lblhora.BackColor = Color.Transparent;
            lblhora.Dock = DockStyle.Top;
            lblhora.FlatStyle = FlatStyle.Flat;
            lblhora.Font = new Font("Microsoft Sans Serif", 80F, FontStyle.Regular, GraphicsUnit.Point);
            lblhora.ForeColor = Color.FromArgb(140, 3, 3);
            lblhora.Location = new Point(0, 0);
            lblhora.Margin = new Padding(4, 0, 4, 0);
            lblhora.Name = "lblhora";
            lblhora.RightToLeft = RightToLeft.No;
            lblhora.Size = new Size(1009, 138);
            lblhora.TabIndex = 28;
            lblhora.Text = "10:59:58";
            lblhora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.Top;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(pictureBox5);
            panel13.Controls.Add(labelProductos);
            panel13.Controls.Add(panel14);
            panel13.Location = new Point(772, 42);
            panel13.Margin = new Padding(4, 3, 4, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(128, 173);
            panel13.TabIndex = 34;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Products;
            pictureBox5.Location = new Point(15, 39);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(96, 92);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            // 
            // labelProductos
            // 
            labelProductos.FlatAppearance.BorderSize = 0;
            labelProductos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            labelProductos.FlatAppearance.MouseOverBackColor = Color.Transparent;
            labelProductos.FlatStyle = FlatStyle.Flat;
            labelProductos.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductos.ForeColor = Color.Orange;
            labelProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            labelProductos.IconColor = Color.Black;
            labelProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            labelProductos.Location = new Point(0, 133);
            labelProductos.Margin = new Padding(4, 3, 4, 3);
            labelProductos.Name = "labelProductos";
            labelProductos.Size = new Size(127, 35);
            labelProductos.TabIndex = 30;
            labelProductos.Text = "lbl1";
            labelProductos.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Black;
            panel14.Controls.Add(labelTitleAcerca);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 0);
            panel14.Margin = new Padding(4, 3, 4, 3);
            panel14.Name = "panel14";
            panel14.Size = new Size(126, 35);
            panel14.TabIndex = 0;
            // 
            // labelTitleAcerca
            // 
            labelTitleAcerca.AutoSize = true;
            labelTitleAcerca.BackColor = Color.Black;
            labelTitleAcerca.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitleAcerca.ForeColor = Color.White;
            labelTitleAcerca.Location = new Point(24, 8);
            labelTitleAcerca.Margin = new Padding(4, 0, 4, 0);
            labelTitleAcerca.Name = "labelTitleAcerca";
            labelTitleAcerca.Size = new Size(77, 18);
            labelTitleAcerca.TabIndex = 15;
            labelTitleAcerca.Text = "Productos";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(9, 6);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(176, 20);
            label15.TabIndex = 37;
            label15.Text = "Sumario del sistema:";
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top;
            panel11.BackColor = Color.Transparent;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(pictureBox3);
            panel11.Controls.Add(labelPlanes);
            panel11.Controls.Add(panel12);
            panel11.Location = new Point(441, 40);
            panel11.Margin = new Padding(4, 3, 4, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(128, 173);
            panel11.TabIndex = 35;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Planes_de_ejercicio;
            pictureBox3.Location = new Point(15, 39);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(96, 92);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // labelPlanes
            // 
            labelPlanes.FlatAppearance.BorderSize = 0;
            labelPlanes.FlatAppearance.MouseDownBackColor = Color.Transparent;
            labelPlanes.FlatAppearance.MouseOverBackColor = Color.Transparent;
            labelPlanes.FlatStyle = FlatStyle.Flat;
            labelPlanes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlanes.ForeColor = Color.Crimson;
            labelPlanes.IconChar = FontAwesome.Sharp.IconChar.None;
            labelPlanes.IconColor = Color.Black;
            labelPlanes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            labelPlanes.Location = new Point(0, 133);
            labelPlanes.Margin = new Padding(4, 3, 4, 3);
            labelPlanes.Name = "labelPlanes";
            labelPlanes.Size = new Size(127, 35);
            labelPlanes.TabIndex = 32;
            labelPlanes.Text = "lbl1";
            labelPlanes.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Black;
            panel12.Controls.Add(labelTitleServicios);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 0);
            panel12.Margin = new Padding(4, 3, 4, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(126, 35);
            panel12.TabIndex = 0;
            // 
            // labelTitleServicios
            // 
            labelTitleServicios.AutoSize = true;
            labelTitleServicios.BackColor = Color.Black;
            labelTitleServicios.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitleServicios.ForeColor = Color.White;
            labelTitleServicios.Location = new Point(-2, 8);
            labelTitleServicios.Margin = new Padding(4, 0, 4, 0);
            labelTitleServicios.Name = "labelTitleServicios";
            labelTitleServicios.Size = new Size(132, 18);
            labelTitleServicios.TabIndex = 15;
            labelTitleServicios.Text = "Planes de ejercicio";
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top;
            panel9.BackColor = Color.Transparent;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(pictureBox1);
            panel9.Controls.Add(labelMiembros);
            panel9.Controls.Add(panel10);
            panel9.Location = new Point(104, 38);
            panel9.Margin = new Padding(4, 3, 4, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(128, 173);
            panel9.TabIndex = 36;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Miembros;
            pictureBox1.Location = new Point(14, 40);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // labelMiembros
            // 
            labelMiembros.FlatAppearance.BorderSize = 0;
            labelMiembros.FlatAppearance.MouseDownBackColor = Color.Transparent;
            labelMiembros.FlatAppearance.MouseOverBackColor = Color.Transparent;
            labelMiembros.FlatStyle = FlatStyle.Flat;
            labelMiembros.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelMiembros.ForeColor = Color.SeaGreen;
            labelMiembros.IconChar = FontAwesome.Sharp.IconChar.None;
            labelMiembros.IconColor = Color.Black;
            labelMiembros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            labelMiembros.Location = new Point(0, 134);
            labelMiembros.Margin = new Padding(4, 3, 4, 3);
            labelMiembros.Name = "labelMiembros";
            labelMiembros.Size = new Size(127, 35);
            labelMiembros.TabIndex = 30;
            labelMiembros.Text = "lbl1";
            labelMiembros.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Controls.Add(label3);
            panel10.Controls.Add(label4);
            panel10.Controls.Add(labelTitleClientes);
            panel10.Dock = DockStyle.Top;
            panel10.ForeColor = Color.Coral;
            panel10.Location = new Point(0, 0);
            panel10.Margin = new Padding(4, 3, 4, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(126, 35);
            panel10.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(28, 80);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 3;
            label3.Text = "15, 485";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, -58);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 18);
            label4.TabIndex = 2;
            label4.Text = "Clientes";
            // 
            // labelTitleClientes
            // 
            labelTitleClientes.AutoSize = true;
            labelTitleClientes.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitleClientes.ForeColor = Color.White;
            labelTitleClientes.Location = new Point(25, 8);
            labelTitleClientes.Margin = new Padding(4, 0, 4, 0);
            labelTitleClientes.Name = "labelTitleClientes";
            labelTitleClientes.Size = new Size(75, 18);
            labelTitleClientes.TabIndex = 0;
            labelTitleClientes.Text = "Miembros";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(pictureBox4);
            panel7.Controls.Add(labelEntrenadores);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(606, 42);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(128, 173);
            panel7.TabIndex = 33;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Entrenador;
            pictureBox4.Location = new Point(15, 39);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(96, 92);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // labelEntrenadores
            // 
            labelEntrenadores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEntrenadores.FlatAppearance.BorderSize = 0;
            labelEntrenadores.FlatAppearance.MouseDownBackColor = Color.Transparent;
            labelEntrenadores.FlatAppearance.MouseOverBackColor = Color.Transparent;
            labelEntrenadores.FlatStyle = FlatStyle.Flat;
            labelEntrenadores.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEntrenadores.ForeColor = Color.MidnightBlue;
            labelEntrenadores.IconChar = FontAwesome.Sharp.IconChar.None;
            labelEntrenadores.IconColor = Color.Black;
            labelEntrenadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            labelEntrenadores.Location = new Point(0, 132);
            labelEntrenadores.Margin = new Padding(4, 3, 4, 3);
            labelEntrenadores.Name = "labelEntrenadores";
            labelEntrenadores.Size = new Size(127, 35);
            labelEntrenadores.TabIndex = 29;
            labelEntrenadores.Text = "lbl1";
            labelEntrenadores.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Controls.Add(labelTitleCash);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(126, 35);
            panel8.TabIndex = 0;
            // 
            // labelTitleCash
            // 
            labelTitleCash.AutoSize = true;
            labelTitleCash.BackColor = Color.Black;
            labelTitleCash.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitleCash.ForeColor = Color.White;
            labelTitleCash.Location = new Point(15, 8);
            labelTitleCash.Margin = new Padding(4, 0, 4, 0);
            labelTitleCash.Name = "labelTitleCash";
            labelTitleCash.Size = new Size(97, 18);
            labelTitleCash.TabIndex = 15;
            labelTitleCash.Text = "Entrenadores";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(170, 170, 173);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.Black;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = SystemColors.ControlDark;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btnRefresh.IconColor = SystemColors.ActiveCaptionText;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnRefresh.IconSize = 30;
            btnRefresh.Location = new Point(889, 1);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(31, 32);
            btnRefresh.TabIndex = 40;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // labelRefresh
            // 
            labelRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelRefresh.AutoSize = true;
            labelRefresh.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelRefresh.ForeColor = Color.Black;
            labelRefresh.Location = new Point(844, 36);
            labelRefresh.Margin = new Padding(4, 0, 4, 0);
            labelRefresh.Name = "labelRefresh";
            labelRefresh.Size = new Size(104, 16);
            labelRefresh.TabIndex = 41;
            labelRefresh.Text = "Actualizar Datos";
            labelRefresh.Visible = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(iconPapelera);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(btnRefresh);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1009, 35);
            panel4.TabIndex = 42;
            // 
            // iconPapelera
            // 
            iconPapelera.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPapelera.Cursor = Cursors.Hand;
            iconPapelera.Enabled = false;
            iconPapelera.FlatAppearance.BorderColor = Color.FromArgb(170, 170, 173);
            iconPapelera.FlatAppearance.BorderSize = 0;
            iconPapelera.FlatAppearance.MouseDownBackColor = Color.Black;
            iconPapelera.FlatAppearance.MouseOverBackColor = Color.Gray;
            iconPapelera.FlatStyle = FlatStyle.Flat;
            iconPapelera.ForeColor = SystemColors.ControlDark;
            iconPapelera.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconPapelera.IconColor = SystemColors.ActiveCaptionText;
            iconPapelera.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPapelera.IconSize = 30;
            iconPapelera.Location = new Point(927, 1);
            iconPapelera.Margin = new Padding(4, 3, 4, 3);
            iconPapelera.Name = "iconPapelera";
            iconPapelera.Size = new Size(31, 32);
            iconPapelera.TabIndex = 41;
            iconPapelera.UseVisualStyleBackColor = true;
            // 
            // labelPapelera
            // 
            labelPapelera.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPapelera.AutoSize = true;
            labelPapelera.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPapelera.ForeColor = Color.Black;
            labelPapelera.Location = new Point(908, 36);
            labelPapelera.Margin = new Padding(4, 0, 4, 0);
            labelPapelera.Name = "labelPapelera";
            labelPapelera.Size = new Size(63, 16);
            labelPapelera.TabIndex = 43;
            labelPapelera.Text = "Papelera";
            labelPapelera.Visible = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(panel15);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(panel13);
            panel3.Location = new Point(0, 42);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1009, 437);
            panel3.TabIndex = 44;
            // 
            // panel15
            // 
            panel15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel15.Controls.Add(lblhora);
            panel15.Controls.Add(lblFecha);
            panel15.Location = new Point(0, 228);
            panel15.Margin = new Padding(4, 3, 4, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(1009, 195);
            panel15.TabIndex = 37;
            // 
            // Reloj
            // 
            Reloj.Tick += Reloj_Tick;
            // 
            // FormSumario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1009, 704);
            Controls.Add(labelRefresh);
            Controls.Add(labelPapelera);
            Controls.Add(panel3);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormSumario";
            Text = "FormSumario";
            Load += FormSumario_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel15.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label labelTitleEntrenadores;
        private Panel panel2;
        private Label lblFecha;
        private Label lblhora;
        private Panel panel13;
        private Label labelTitleAcerca;
        private Panel panel14;
        private Label label15;
        private Panel panel11;
        private Label labelTitleServicios;
        private Panel panel12;
        private Panel panel9;
        private Panel panel10;
        private Label label3;
        private Label label4;
        private Label labelTitleClientes;
        private Panel panel7;
        private Label labelTitleCash;
        private Panel panel8;
        private FontAwesome.Sharp.IconButton labelEntrenadores;
        private FontAwesome.Sharp.IconButton labelCaja;
        private FontAwesome.Sharp.IconButton labelProductos;
        private FontAwesome.Sharp.IconButton labelPlanes;
        private FontAwesome.Sharp.IconButton labelMiembros;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private Label labelRefresh;
        private Panel panel4;
        private Label labelPapelera;
        private FontAwesome.Sharp.IconButton iconPapelera;
        private Panel panel3;
        private Panel panel15;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer Reloj;
    }
}