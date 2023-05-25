namespace UI
{
    partial class FormGestionAdministrador
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
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            labelAlert = new Label();
            pictureAlert = new PictureBox();
            label5 = new Label();
            btnVolver = new FontAwesome.Sharp.IconButton();
            tabControlAdmins = new TabControl();
            tabGeneral = new TabPage();
            panelClient = new Panel();
            panel1 = new Panel();
            btnProgreso = new FontAwesome.Sharp.IconButton();
            btnAddAdmin = new FontAwesome.Sharp.IconButton();
            btnUpdateAdmin = new FontAwesome.Sharp.IconButton();
            panelContenedorClient = new Panel();
            dataGridClient = new DataGridView();
            panelDownDataGrid = new Panel();
            textHombres = new TextBox();
            label3 = new Label();
            textMujeres = new TextBox();
            label2 = new Label();
            label4 = new Label();
            textTotal = new TextBox();
            panelTopDataGrid = new Panel();
            comboFiltroSexo = new ComboBox();
            label1 = new Label();
            tabRegistro = new TabPage();
            panel7 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            pictureBox3 = new PictureBox();
            comboBox2 = new ComboBox();
            label26 = new Label();
            textBox12 = new TextBox();
            label25 = new Label();
            textBox11 = new TextBox();
            label24 = new Label();
            textBox10 = new TextBox();
            label23 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label22 = new Label();
            comboBox1 = new ComboBox();
            label21 = new Label();
            textBox9 = new TextBox();
            label20 = new Label();
            textBox8 = new TextBox();
            label19 = new Label();
            textBox7 = new TextBox();
            label18 = new Label();
            panel6 = new Panel();
            btnSearch = new FontAwesome.Sharp.IconPictureBox();
            textSearch = new TextBox();
            btnCloseTextSearch = new FontAwesome.Sharp.IconPictureBox();
            label9 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAlert).BeginInit();
            tabControlAdmins.SuspendLayout();
            tabGeneral.SuspendLayout();
            panelClient.SuspendLayout();
            panel1.SuspendLayout();
            panelContenedorClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClient).BeginInit();
            panelDownDataGrid.SuspendLayout();
            panelTopDataGrid.SuspendLayout();
            tabRegistro.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCloseTextSearch).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnVolver);
            panel2.Location = new Point(0, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(827, 57);
            panel2.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(50, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 8;
            iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(labelAlert);
            panel3.Controls.Add(pictureAlert);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(353, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(474, 57);
            panel3.TabIndex = 6;
            // 
            // labelAlert
            // 
            labelAlert.AutoSize = true;
            labelAlert.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAlert.ForeColor = Color.Orange;
            labelAlert.Location = new Point(76, 16);
            labelAlert.Name = "labelAlert";
            labelAlert.Size = new Size(168, 25);
            labelAlert.TabIndex = 9;
            labelAlert.Text = "Mensaje de alerta";
            labelAlert.Visible = false;
            // 
            // pictureAlert
            // 
            pictureAlert.Image = Properties.Resources.Alert;
            pictureAlert.Location = new Point(28, 8);
            pictureAlert.Name = "pictureAlert";
            pictureAlert.Size = new Size(42, 41);
            pictureAlert.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAlert.TabIndex = 0;
            pictureAlert.TabStop = false;
            pictureAlert.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(83, 12);
            label5.Name = "label5";
            label5.Size = new Size(259, 32);
            label5.TabIndex = 2;
            label5.Text = "GESTION DE ADMINS";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Silver;
            btnVolver.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            btnVolver.IconColor = Color.Black;
            btnVolver.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnVolver.IconSize = 32;
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(34, 33);
            btnVolver.TabIndex = 5;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // tabControlAdmins
            // 
            tabControlAdmins.Controls.Add(tabGeneral);
            tabControlAdmins.Controls.Add(tabRegistro);
            tabControlAdmins.Location = new Point(0, 76);
            tabControlAdmins.Name = "tabControlAdmins";
            tabControlAdmins.SelectedIndex = 0;
            tabControlAdmins.Size = new Size(827, 470);
            tabControlAdmins.TabIndex = 4;
            // 
            // tabGeneral
            // 
            tabGeneral.Controls.Add(panelClient);
            tabGeneral.Location = new Point(4, 24);
            tabGeneral.Name = "tabGeneral";
            tabGeneral.Padding = new Padding(3);
            tabGeneral.Size = new Size(819, 442);
            tabGeneral.TabIndex = 0;
            tabGeneral.Text = "General";
            tabGeneral.UseVisualStyleBackColor = true;
            // 
            // panelClient
            // 
            panelClient.Controls.Add(panel1);
            panelClient.Controls.Add(panelContenedorClient);
            panelClient.Location = new Point(42, 21);
            panelClient.Name = "panelClient";
            panelClient.Size = new Size(734, 405);
            panelClient.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnProgreso);
            panel1.Controls.Add(btnAddAdmin);
            panel1.Controls.Add(btnUpdateAdmin);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 367);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 38);
            panel1.TabIndex = 1;
            // 
            // btnProgreso
            // 
            btnProgreso.BackColor = Color.MediumSpringGreen;
            btnProgreso.Enabled = false;
            btnProgreso.IconChar = FontAwesome.Sharp.IconChar._0;
            btnProgreso.IconColor = Color.Black;
            btnProgreso.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnProgreso.IconSize = 32;
            btnProgreso.Location = new Point(427, 3);
            btnProgreso.Name = "btnProgreso";
            btnProgreso.Size = new Size(69, 33);
            btnProgreso.TabIndex = 4;
            btnProgreso.UseVisualStyleBackColor = false;
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.BackColor = Color.LimeGreen;
            btnAddAdmin.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnAddAdmin.IconColor = Color.Black;
            btnAddAdmin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnAddAdmin.IconSize = 32;
            btnAddAdmin.Location = new Point(236, 3);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(69, 33);
            btnAddAdmin.TabIndex = 1;
            btnAddAdmin.UseVisualStyleBackColor = false;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // btnUpdateAdmin
            // 
            btnUpdateAdmin.BackColor = Color.Gold;
            btnUpdateAdmin.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnUpdateAdmin.IconColor = Color.Black;
            btnUpdateAdmin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnUpdateAdmin.IconSize = 32;
            btnUpdateAdmin.Location = new Point(311, 3);
            btnUpdateAdmin.Name = "btnUpdateAdmin";
            btnUpdateAdmin.Size = new Size(69, 33);
            btnUpdateAdmin.TabIndex = 2;
            btnUpdateAdmin.UseVisualStyleBackColor = false;
            btnUpdateAdmin.Click += btnUpdateAdmin_Click;
            // 
            // panelContenedorClient
            // 
            panelContenedorClient.Controls.Add(dataGridClient);
            panelContenedorClient.Controls.Add(panelDownDataGrid);
            panelContenedorClient.Controls.Add(panelTopDataGrid);
            panelContenedorClient.Dock = DockStyle.Top;
            panelContenedorClient.Location = new Point(0, 0);
            panelContenedorClient.Name = "panelContenedorClient";
            panelContenedorClient.Size = new Size(734, 368);
            panelContenedorClient.TabIndex = 0;
            // 
            // dataGridClient
            // 
            dataGridClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClient.Dock = DockStyle.Fill;
            dataGridClient.Location = new Point(0, 26);
            dataGridClient.Name = "dataGridClient";
            dataGridClient.RowTemplate.Height = 25;
            dataGridClient.Size = new Size(734, 312);
            dataGridClient.TabIndex = 2;
            // 
            // panelDownDataGrid
            // 
            panelDownDataGrid.BackColor = Color.Gainsboro;
            panelDownDataGrid.Controls.Add(textHombres);
            panelDownDataGrid.Controls.Add(label3);
            panelDownDataGrid.Controls.Add(textMujeres);
            panelDownDataGrid.Controls.Add(label2);
            panelDownDataGrid.Controls.Add(label4);
            panelDownDataGrid.Controls.Add(textTotal);
            panelDownDataGrid.Dock = DockStyle.Bottom;
            panelDownDataGrid.Location = new Point(0, 338);
            panelDownDataGrid.Name = "panelDownDataGrid";
            panelDownDataGrid.Size = new Size(734, 30);
            panelDownDataGrid.TabIndex = 1;
            // 
            // textHombres
            // 
            textHombres.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textHombres.Location = new Point(669, 3);
            textHombres.Name = "textHombres";
            textHombres.Size = new Size(52, 23);
            textHombres.TabIndex = 8;
            textHombres.Text = "0";
            textHombres.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(493, 6);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 7;
            label3.Text = "Mujeres:";
            // 
            // textMujeres
            // 
            textMujeres.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textMujeres.Location = new Point(551, 3);
            textMujeres.Name = "textMujeres";
            textMujeres.Size = new Size(52, 23);
            textMujeres.TabIndex = 8;
            textMujeres.Text = "0";
            textMujeres.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(354, 7);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 5;
            label2.Text = "Registrados:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(605, 6);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 7;
            label4.Text = "Hombres:";
            // 
            // textTotal
            // 
            textTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textTotal.Location = new Point(436, 3);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(52, 23);
            textTotal.TabIndex = 6;
            textTotal.Text = "0";
            textTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // panelTopDataGrid
            // 
            panelTopDataGrid.BackColor = Color.Gainsboro;
            panelTopDataGrid.Controls.Add(comboFiltroSexo);
            panelTopDataGrid.Controls.Add(label1);
            panelTopDataGrid.Dock = DockStyle.Top;
            panelTopDataGrid.Location = new Point(0, 0);
            panelTopDataGrid.Name = "panelTopDataGrid";
            panelTopDataGrid.Size = new Size(734, 26);
            panelTopDataGrid.TabIndex = 0;
            // 
            // comboFiltroSexo
            // 
            comboFiltroSexo.FormattingEnabled = true;
            comboFiltroSexo.Items.AddRange(new object[] { "M", "F", "Otro" });
            comboFiltroSexo.Location = new Point(295, 2);
            comboFiltroSexo.Name = "comboFiltroSexo";
            comboFiltroSexo.Size = new Size(121, 23);
            comboFiltroSexo.TabIndex = 1;
            comboFiltroSexo.Text = "Filtro sexo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(196, 21);
            label1.TabIndex = 0;
            label1.Text = "Lista de administradores";
            // 
            // tabRegistro
            // 
            tabRegistro.Controls.Add(panel7);
            tabRegistro.Controls.Add(panel6);
            tabRegistro.Controls.Add(panel4);
            tabRegistro.Location = new Point(4, 24);
            tabRegistro.Name = "tabRegistro";
            tabRegistro.Padding = new Padding(3);
            tabRegistro.Size = new Size(819, 442);
            tabRegistro.TabIndex = 1;
            tabRegistro.Text = "Registro";
            tabRegistro.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(iconButton3);
            panel7.Controls.Add(iconButton5);
            panel7.Controls.Add(iconButton2);
            panel7.Controls.Add(pictureBox3);
            panel7.Controls.Add(comboBox2);
            panel7.Controls.Add(label26);
            panel7.Controls.Add(textBox12);
            panel7.Controls.Add(label25);
            panel7.Controls.Add(textBox11);
            panel7.Controls.Add(label24);
            panel7.Controls.Add(textBox10);
            panel7.Controls.Add(label23);
            panel7.Controls.Add(dateTimePicker1);
            panel7.Controls.Add(label22);
            panel7.Controls.Add(comboBox1);
            panel7.Controls.Add(label21);
            panel7.Controls.Add(textBox9);
            panel7.Controls.Add(label20);
            panel7.Controls.Add(textBox8);
            panel7.Controls.Add(label19);
            panel7.Controls.Add(textBox7);
            panel7.Controls.Add(label18);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(3, 52);
            panel7.Name = "panel7";
            panel7.Size = new Size(813, 384);
            panel7.TabIndex = 7;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(643, 166);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(92, 23);
            iconButton3.TabIndex = 26;
            iconButton3.Text = "Cargar Foto";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.Black;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton5.IconSize = 25;
            iconButton5.Location = new Point(393, 247);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(107, 33);
            iconButton5.TabIndex = 25;
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Black;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 28;
            iconButton2.Location = new Point(280, 247);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(107, 33);
            iconButton2.TabIndex = 24;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.User;
            pictureBox3.Location = new Point(607, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(158, 146);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "M", "F", "Otro" });
            comboBox2.Location = new Point(448, 97);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(59, 23);
            comboBox2.TabIndex = 17;
            comboBox2.Text = "M";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(401, 97);
            label26.Name = "label26";
            label26.Size = new Size(44, 20);
            label26.TabIndex = 16;
            label26.Text = "Sexo:";
            // 
            // textBox12
            // 
            textBox12.BorderStyle = BorderStyle.FixedSingle;
            textBox12.Location = new Point(100, 158);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(133, 23);
            textBox12.TabIndex = 15;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(43, 160);
            label25.Name = "label25";
            label25.Size = new Size(57, 20);
            label25.TabIndex = 14;
            label25.Text = "Correo:";
            // 
            // textBox11
            // 
            textBox11.BorderStyle = BorderStyle.FixedSingle;
            textBox11.Location = new Point(346, 129);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(151, 23);
            textBox11.TabIndex = 13;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(274, 130);
            label24.Name = "label24";
            label24.Size = new Size(70, 20);
            label24.TabIndex = 12;
            label24.Text = "Telefono:";
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.FixedSingle;
            textBox10.Location = new Point(118, 128);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(151, 23);
            textBox10.TabIndex = 11;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(42, 129);
            label23.Name = "label23";
            label23.Size = new Size(75, 20);
            label23.TabIndex = 10;
            label23.Text = "Direccion:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(195, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(43, 97);
            label22.Name = "label22";
            label22.Size = new Size(149, 20);
            label22.TabIndex = 8;
            label22.Text = "Fecha de nacimiento:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "CC", "TI", "Otro" });
            comboBox1.Location = new Point(441, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(59, 23);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "CC";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(281, 33);
            label21.Name = "label21";
            label21.Size = new Size(157, 20);
            label21.TabIndex = 6;
            label21.Text = "Tipo de identificacion:";
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.FixedSingle;
            textBox9.Location = new Point(340, 62);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(151, 23);
            textBox9.TabIndex = 5;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(264, 63);
            label20.Name = "label20";
            label20.Size = new Size(75, 20);
            label20.TabIndex = 4;
            label20.Text = "Apellidos:";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(109, 62);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(151, 23);
            textBox8.TabIndex = 3;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(41, 63);
            label19.Name = "label19";
            label19.Size = new Size(67, 20);
            label19.TabIndex = 2;
            label19.Text = "Nombre:";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(142, 32);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(133, 23);
            textBox7.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(40, 33);
            label18.Name = "label18";
            label18.Size = new Size(102, 20);
            label18.TabIndex = 0;
            label18.Text = "Identificacion:";
            // 
            // panel6
            // 
            panel6.Controls.Add(btnSearch);
            panel6.Controls.Add(textSearch);
            panel6.Controls.Add(btnCloseTextSearch);
            panel6.Controls.Add(label9);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(3, 29);
            panel6.Name = "panel6";
            panel6.Size = new Size(813, 23);
            panel6.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.ForeColor = Color.Black;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Brands;
            btnSearch.IconSize = 24;
            btnSearch.Location = new Point(788, -2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(24, 24);
            btnSearch.TabIndex = 15;
            btnSearch.TabStop = false;
            // 
            // textSearch
            // 
            textSearch.BorderStyle = BorderStyle.FixedSingle;
            textSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textSearch.Location = new Point(643, -3);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(146, 25);
            textSearch.TabIndex = 14;
            textSearch.Text = "Buscar";
            // 
            // btnCloseTextSearch
            // 
            btnCloseTextSearch.BackColor = Color.Transparent;
            btnCloseTextSearch.ForeColor = Color.Red;
            btnCloseTextSearch.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnCloseTextSearch.IconColor = Color.Red;
            btnCloseTextSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCloseTextSearch.IconSize = 24;
            btnCloseTextSearch.Location = new Point(788, -2);
            btnCloseTextSearch.Name = "btnCloseTextSearch";
            btnCloseTextSearch.Size = new Size(24, 24);
            btnCloseTextSearch.TabIndex = 13;
            btnCloseTextSearch.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(5, 1);
            label9.Name = "label9";
            label9.Size = new Size(114, 21);
            label9.TabIndex = 1;
            label9.Text = "Datos Basicos";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(813, 26);
            panel4.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(4, 2);
            label7.Name = "label7";
            label7.Size = new Size(208, 21);
            label7.TabIndex = 0;
            label7.Text = "Registro de administrador";
            // 
            // FormGestionAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 542);
            Controls.Add(tabControlAdmins);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionAdministrador";
            Text = "FormGestionAdministrador";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAlert).EndInit();
            tabControlAdmins.ResumeLayout(false);
            tabGeneral.ResumeLayout(false);
            panelClient.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelContenedorClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridClient).EndInit();
            panelDownDataGrid.ResumeLayout(false);
            panelDownDataGrid.PerformLayout();
            panelTopDataGrid.ResumeLayout(false);
            panelTopDataGrid.PerformLayout();
            tabRegistro.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCloseTextSearch).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel3;
        private Label labelAlert;
        private PictureBox pictureAlert;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnVolver;
        private TabControl tabControlAdmins;
        private TabPage tabGeneral;
        private Panel panelClient;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnProgreso;
        private FontAwesome.Sharp.IconButton btnAddAdmin;
        private FontAwesome.Sharp.IconButton btnUpdateAdmin;
        private Panel panelContenedorClient;
        private DataGridView dataGridClient;
        private Panel panelDownDataGrid;
        private TextBox textHombres;
        private Label label3;
        private TextBox textMujeres;
        private Label label2;
        private Label label4;
        private TextBox textTotal;
        private Panel panelTopDataGrid;
        private ComboBox comboFiltroSexo;
        private Label label1;
        private TabPage tabRegistro;
        private Panel panel7;
        private PictureBox pictureBox3;
        private ComboBox comboBox2;
        private Label label26;
        private TextBox textBox12;
        private Label label25;
        private TextBox textBox11;
        private Label label24;
        private TextBox textBox10;
        private Label label23;
        private DateTimePicker dateTimePicker1;
        private Label label22;
        private ComboBox comboBox1;
        private Label label21;
        private TextBox textBox9;
        private Label label20;
        private TextBox textBox8;
        private Label label19;
        private TextBox textBox7;
        private Label label18;
        private Panel panel6;
        private Label label9;
        private Panel panel4;
        private Label label7;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconPictureBox btnSearch;
        private TextBox textSearch;
        private FontAwesome.Sharp.IconPictureBox btnCloseTextSearch;
    }
}