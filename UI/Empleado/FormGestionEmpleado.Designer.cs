namespace UI
{
    partial class FormGestionEmpleado
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
            pictureAlerta = new PictureBox();
            labelAlerta = new Label();
            label5 = new Label();
            btnVolver = new FontAwesome.Sharp.IconButton();
            tabControlAdmins = new TabControl();
            tabGeneral = new TabPage();
            panelEmpleado = new Panel();
            panel1 = new Panel();
            btnProgreso = new FontAwesome.Sharp.IconButton();
            btnAddAdmin = new FontAwesome.Sharp.IconButton();
            btnUpdateAdmin = new FontAwesome.Sharp.IconButton();
            panelContenedorClient = new Panel();
            dataGridEmpleados = new DataGridView();
            Eliminar = new DataGridViewImageColumn();
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
            btnCargarFoto = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            picturePerfil = new PictureBox();
            comboSexo = new ComboBox();
            label26 = new Label();
            textCorreo = new TextBox();
            label25 = new Label();
            textTelefono = new TextBox();
            label24 = new Label();
            textDireccion = new TextBox();
            label23 = new Label();
            dateTimeFechaNacimiento = new DateTimePicker();
            label22 = new Label();
            comboTipoID = new ComboBox();
            label21 = new Label();
            textApellidos = new TextBox();
            label20 = new Label();
            textNombres = new TextBox();
            label19 = new Label();
            textID = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureAlerta).BeginInit();
            tabControlAdmins.SuspendLayout();
            tabGeneral.SuspendLayout();
            panelEmpleado.SuspendLayout();
            panel1.SuspendLayout();
            panelContenedorClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleados).BeginInit();
            panelDownDataGrid.SuspendLayout();
            panelTopDataGrid.SuspendLayout();
            tabRegistro.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePerfil).BeginInit();
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
            panel3.Controls.Add(pictureAlerta);
            panel3.Controls.Add(labelAlerta);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(380, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(447, 57);
            panel3.TabIndex = 6;
            // 
            // pictureAlerta
            // 
            pictureAlerta.Image = Properties.Resources.Alert;
            pictureAlerta.Location = new Point(12, 12);
            pictureAlerta.Name = "pictureAlerta";
            pictureAlerta.Size = new Size(30, 30);
            pictureAlerta.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAlerta.TabIndex = 16;
            pictureAlerta.TabStop = false;
            pictureAlerta.Visible = false;
            // 
            // labelAlerta
            // 
            labelAlerta.AutoSize = true;
            labelAlerta.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAlerta.ForeColor = Color.Orange;
            labelAlerta.Location = new Point(39, 17);
            labelAlerta.Name = "labelAlerta";
            labelAlerta.Size = new Size(117, 20);
            labelAlerta.TabIndex = 17;
            labelAlerta.Text = "Mensaje de alerta";
            labelAlerta.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(83, 12);
            label5.Name = "label5";
            label5.Size = new Size(303, 32);
            label5.TabIndex = 2;
            label5.Text = "GESTION DE EMPLEADOS";
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
            tabGeneral.Controls.Add(panelEmpleado);
            tabGeneral.Location = new Point(4, 24);
            tabGeneral.Name = "tabGeneral";
            tabGeneral.Padding = new Padding(3);
            tabGeneral.Size = new Size(819, 442);
            tabGeneral.TabIndex = 0;
            tabGeneral.Text = "General";
            tabGeneral.UseVisualStyleBackColor = true;
            // 
            // panelEmpleado
            // 
            panelEmpleado.Controls.Add(panel1);
            panelEmpleado.Controls.Add(panelContenedorClient);
            panelEmpleado.Dock = DockStyle.Fill;
            panelEmpleado.Location = new Point(3, 3);
            panelEmpleado.Name = "panelEmpleado";
            panelEmpleado.Size = new Size(813, 436);
            panelEmpleado.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnProgreso);
            panel1.Controls.Add(btnAddAdmin);
            panel1.Controls.Add(btnUpdateAdmin);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 398);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 38);
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
            panelContenedorClient.Controls.Add(dataGridEmpleados);
            panelContenedorClient.Controls.Add(panelDownDataGrid);
            panelContenedorClient.Controls.Add(panelTopDataGrid);
            panelContenedorClient.Dock = DockStyle.Top;
            panelContenedorClient.Location = new Point(0, 0);
            panelContenedorClient.Name = "panelContenedorClient";
            panelContenedorClient.Size = new Size(813, 368);
            panelContenedorClient.TabIndex = 0;
            // 
            // dataGridEmpleados
            // 
            dataGridEmpleados.AllowUserToAddRows = false;
            dataGridEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmpleados.Columns.AddRange(new DataGridViewColumn[] { Eliminar });
            dataGridEmpleados.Dock = DockStyle.Fill;
            dataGridEmpleados.Location = new Point(0, 26);
            dataGridEmpleados.Name = "dataGridEmpleados";
            dataGridEmpleados.RowHeadersVisible = false;
            dataGridEmpleados.RowTemplate.Height = 25;
            dataGridEmpleados.Size = new Size(813, 312);
            dataGridEmpleados.TabIndex = 2;
            dataGridEmpleados.CellClick += dataGridEmpleados_CellClick;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.deleRojBlack;
            Eliminar.Name = "Eliminar";
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
            panelDownDataGrid.Size = new Size(813, 30);
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
            panelTopDataGrid.Size = new Size(813, 26);
            panelTopDataGrid.TabIndex = 0;
            // 
            // comboFiltroSexo
            // 
            comboFiltroSexo.FormattingEnabled = true;
            comboFiltroSexo.Items.AddRange(new object[] { "Todos", "M", "F", "Otro" });
            comboFiltroSexo.Location = new Point(295, 2);
            comboFiltroSexo.Name = "comboFiltroSexo";
            comboFiltroSexo.Size = new Size(121, 23);
            comboFiltroSexo.TabIndex = 1;
            comboFiltroSexo.Text = "Filtro sexo";
            comboFiltroSexo.SelectedIndexChanged += comboFiltroSexo_SelectedIndexChanged;
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
            panel7.Controls.Add(btnCargarFoto);
            panel7.Controls.Add(btnModificar);
            panel7.Controls.Add(btnRegistrar);
            panel7.Controls.Add(picturePerfil);
            panel7.Controls.Add(comboSexo);
            panel7.Controls.Add(label26);
            panel7.Controls.Add(textCorreo);
            panel7.Controls.Add(label25);
            panel7.Controls.Add(textTelefono);
            panel7.Controls.Add(label24);
            panel7.Controls.Add(textDireccion);
            panel7.Controls.Add(label23);
            panel7.Controls.Add(dateTimeFechaNacimiento);
            panel7.Controls.Add(label22);
            panel7.Controls.Add(comboTipoID);
            panel7.Controls.Add(label21);
            panel7.Controls.Add(textApellidos);
            panel7.Controls.Add(label20);
            panel7.Controls.Add(textNombres);
            panel7.Controls.Add(label19);
            panel7.Controls.Add(textID);
            panel7.Controls.Add(label18);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(3, 52);
            panel7.Name = "panel7";
            panel7.Size = new Size(813, 384);
            panel7.TabIndex = 7;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCargarFoto.IconColor = Color.Black;
            btnCargarFoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCargarFoto.Location = new Point(643, 166);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(92, 23);
            btnCargarFoto.TabIndex = 26;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = true;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Black;
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnModificar.IconColor = Color.White;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnModificar.IconSize = 25;
            btnModificar.Location = new Point(393, 247);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(107, 33);
            btnModificar.TabIndex = 25;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Black;
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnRegistrar.IconColor = Color.White;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnRegistrar.IconSize = 28;
            btnRegistrar.Location = new Point(280, 247);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(107, 33);
            btnRegistrar.TabIndex = 24;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // picturePerfil
            // 
            picturePerfil.Image = Properties.Resources.User;
            picturePerfil.Location = new Point(607, 14);
            picturePerfil.Name = "picturePerfil";
            picturePerfil.Size = new Size(158, 146);
            picturePerfil.SizeMode = PictureBoxSizeMode.Zoom;
            picturePerfil.TabIndex = 18;
            picturePerfil.TabStop = false;
            // 
            // comboSexo
            // 
            comboSexo.FormattingEnabled = true;
            comboSexo.Items.AddRange(new object[] { "M", "F", "Otro" });
            comboSexo.Location = new Point(448, 97);
            comboSexo.Name = "comboSexo";
            comboSexo.Size = new Size(59, 23);
            comboSexo.TabIndex = 17;
            comboSexo.Text = "M";
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
            // textCorreo
            // 
            textCorreo.BorderStyle = BorderStyle.FixedSingle;
            textCorreo.Location = new Point(100, 158);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(133, 23);
            textCorreo.TabIndex = 15;
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
            // textTelefono
            // 
            textTelefono.BorderStyle = BorderStyle.FixedSingle;
            textTelefono.Location = new Point(346, 129);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(151, 23);
            textTelefono.TabIndex = 13;
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
            // textDireccion
            // 
            textDireccion.BorderStyle = BorderStyle.FixedSingle;
            textDireccion.Location = new Point(118, 128);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(151, 23);
            textDireccion.TabIndex = 11;
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
            // dateTimeFechaNacimiento
            // 
            dateTimeFechaNacimiento.Location = new Point(195, 96);
            dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            dateTimeFechaNacimiento.Size = new Size(200, 23);
            dateTimeFechaNacimiento.TabIndex = 9;
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
            // comboTipoID
            // 
            comboTipoID.FormattingEnabled = true;
            comboTipoID.Items.AddRange(new object[] { "CC", "TI", "Otro" });
            comboTipoID.Location = new Point(441, 34);
            comboTipoID.Name = "comboTipoID";
            comboTipoID.Size = new Size(59, 23);
            comboTipoID.TabIndex = 7;
            comboTipoID.Text = "CC";
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
            // textApellidos
            // 
            textApellidos.BorderStyle = BorderStyle.FixedSingle;
            textApellidos.Location = new Point(340, 62);
            textApellidos.Name = "textApellidos";
            textApellidos.Size = new Size(151, 23);
            textApellidos.TabIndex = 5;
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
            // textNombres
            // 
            textNombres.BorderStyle = BorderStyle.FixedSingle;
            textNombres.Location = new Point(109, 62);
            textNombres.Name = "textNombres";
            textNombres.Size = new Size(151, 23);
            textNombres.TabIndex = 3;
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
            // textID
            // 
            textID.BorderStyle = BorderStyle.FixedSingle;
            textID.Location = new Point(142, 32);
            textID.Name = "textID";
            textID.Size = new Size(133, 23);
            textID.TabIndex = 1;
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
            btnSearch.Click += btnSearch_Click;
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
            textSearch.TextChanged += textSearch_TextChanged;
            textSearch.Enter += textSearch_Enter;
            textSearch.Leave += textSearch_Leave;
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
            btnCloseTextSearch.Click += btnCloseTextSearch_Click;
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
            // FormGestionEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 542);
            Controls.Add(tabControlAdmins);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionEmpleado";
            Text = "FormGestionEmpleado";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAlerta).EndInit();
            tabControlAdmins.ResumeLayout(false);
            tabGeneral.ResumeLayout(false);
            panelEmpleado.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelContenedorClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleados).EndInit();
            panelDownDataGrid.ResumeLayout(false);
            panelDownDataGrid.PerformLayout();
            panelTopDataGrid.ResumeLayout(false);
            panelTopDataGrid.PerformLayout();
            tabRegistro.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturePerfil).EndInit();
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
        private Label label5;
        private FontAwesome.Sharp.IconButton btnVolver;
        private TabControl tabControlAdmins;
        private TabPage tabGeneral;
        private Panel panelEmpleado;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnProgreso;
        private FontAwesome.Sharp.IconButton btnAddAdmin;
        private FontAwesome.Sharp.IconButton btnUpdateAdmin;
        private Panel panelContenedorClient;
        private DataGridView dataGridEmpleados;
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
        private PictureBox picturePerfil;
        private ComboBox comboSexo;
        private Label label26;
        private TextBox textCorreo;
        private Label label25;
        private TextBox textTelefono;
        private Label label24;
        private TextBox textDireccion;
        private Label label23;
        private DateTimePicker dateTimeFechaNacimiento;
        private Label label22;
        private ComboBox comboTipoID;
        private Label label21;
        private TextBox textApellidos;
        private Label label20;
        private TextBox textNombres;
        private Label label19;
        private TextBox textID;
        private Label label18;
        private Panel panel6;
        private Label label9;
        private Panel panel4;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private FontAwesome.Sharp.IconButton btnCargarFoto;
        private FontAwesome.Sharp.IconPictureBox btnSearch;
        private TextBox textSearch;
        private FontAwesome.Sharp.IconPictureBox btnCloseTextSearch;
        private PictureBox pictureAlerta;
        private Label labelAlerta;
        private DataGridViewImageColumn Eliminar;
    }
}