namespace UI
{
    partial class FormPlanEjercicio
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
            tabControlMembership = new TabControl();
            tabGeneral = new TabPage();
            panelPlanEjercicio = new Panel();
            panel1 = new Panel();
            btnProgreso = new FontAwesome.Sharp.IconButton();
            btnAddMembership = new FontAwesome.Sharp.IconButton();
            btnUpdateMembership = new FontAwesome.Sharp.IconButton();
            panelContenedorClient = new Panel();
            dataGridClient = new DataGridView();
            panelDownDataGrid = new Panel();
            textHombres = new TextBox();
            label3 = new Label();
            textTotal = new TextBox();
            textMujeres = new TextBox();
            label4 = new Label();
            label2 = new Label();
            panelTopDataGrid = new Panel();
            comboFiltroSexo = new ComboBox();
            label1 = new Label();
            tabRegistro = new TabPage();
            panel7 = new Panel();
            panel20 = new Panel();
            textBox10 = new TextBox();
            label26 = new Label();
            comboBox4 = new ComboBox();
            label27 = new Label();
            comboBox3 = new ComboBox();
            label25 = new Label();
            textBox9 = new TextBox();
            label24 = new Label();
            label23 = new Label();
            textBox8 = new TextBox();
            panel19 = new Panel();
            label22 = new Label();
            panel18 = new Panel();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label21 = new Label();
            textBox7 = new TextBox();
            label20 = new Label();
            comboBox1 = new ComboBox();
            label19 = new Label();
            panel9 = new Panel();
            label18 = new Label();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            panel8 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            btnSearch = new FontAwesome.Sharp.IconPictureBox();
            textSearch = new TextBox();
            btnCloseTextSearch = new FontAwesome.Sharp.IconPictureBox();
            label9 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            btnVolver = new FontAwesome.Sharp.IconButton();
            tabControlMembership.SuspendLayout();
            tabGeneral.SuspendLayout();
            panelPlanEjercicio.SuspendLayout();
            panel1.SuspendLayout();
            panelContenedorClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClient).BeginInit();
            panelDownDataGrid.SuspendLayout();
            panelTopDataGrid.SuspendLayout();
            tabRegistro.SuspendLayout();
            panel7.SuspendLayout();
            panel20.SuspendLayout();
            panel19.SuspendLayout();
            panel18.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCloseTextSearch).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControlMembership
            // 
            tabControlMembership.Controls.Add(tabGeneral);
            tabControlMembership.Controls.Add(tabRegistro);
            tabControlMembership.Location = new Point(0, 66);
            tabControlMembership.Name = "tabControlMembership";
            tabControlMembership.SelectedIndex = 0;
            tabControlMembership.Size = new Size(827, 474);
            tabControlMembership.TabIndex = 6;
            // 
            // tabGeneral
            // 
            tabGeneral.Controls.Add(panelPlanEjercicio);
            tabGeneral.Location = new Point(4, 24);
            tabGeneral.Name = "tabGeneral";
            tabGeneral.Padding = new Padding(3);
            tabGeneral.Size = new Size(819, 446);
            tabGeneral.TabIndex = 0;
            tabGeneral.Text = "General";
            tabGeneral.UseVisualStyleBackColor = true;
            // 
            // panelPlanEjercicio
            // 
            panelPlanEjercicio.Controls.Add(panel1);
            panelPlanEjercicio.Controls.Add(panelContenedorClient);
            panelPlanEjercicio.Dock = DockStyle.Fill;
            panelPlanEjercicio.Location = new Point(3, 3);
            panelPlanEjercicio.Name = "panelPlanEjercicio";
            panelPlanEjercicio.Size = new Size(813, 440);
            panelPlanEjercicio.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnProgreso);
            panel1.Controls.Add(btnAddMembership);
            panel1.Controls.Add(btnUpdateMembership);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 402);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 38);
            panel1.TabIndex = 1;
            // 
            // btnProgreso
            // 
            btnProgreso.BackColor = Color.MediumSpringGreen;
            btnProgreso.Enabled = false;
            btnProgreso.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            btnProgreso.IconColor = Color.Black;
            btnProgreso.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnProgreso.IconSize = 32;
            btnProgreso.Location = new Point(427, 3);
            btnProgreso.Name = "btnProgreso";
            btnProgreso.Size = new Size(69, 33);
            btnProgreso.TabIndex = 4;
            btnProgreso.UseVisualStyleBackColor = false;
            // 
            // btnAddMembership
            // 
            btnAddMembership.BackColor = Color.LimeGreen;
            btnAddMembership.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnAddMembership.IconColor = Color.Black;
            btnAddMembership.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnAddMembership.IconSize = 32;
            btnAddMembership.Location = new Point(236, 3);
            btnAddMembership.Name = "btnAddMembership";
            btnAddMembership.Size = new Size(69, 33);
            btnAddMembership.TabIndex = 1;
            btnAddMembership.UseVisualStyleBackColor = false;
            // 
            // btnUpdateMembership
            // 
            btnUpdateMembership.BackColor = Color.Gold;
            btnUpdateMembership.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnUpdateMembership.IconColor = Color.Black;
            btnUpdateMembership.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnUpdateMembership.IconSize = 32;
            btnUpdateMembership.Location = new Point(311, 3);
            btnUpdateMembership.Name = "btnUpdateMembership";
            btnUpdateMembership.Size = new Size(69, 33);
            btnUpdateMembership.TabIndex = 2;
            btnUpdateMembership.UseVisualStyleBackColor = false;
            // 
            // panelContenedorClient
            // 
            panelContenedorClient.Controls.Add(dataGridClient);
            panelContenedorClient.Controls.Add(panelDownDataGrid);
            panelContenedorClient.Controls.Add(panelTopDataGrid);
            panelContenedorClient.Dock = DockStyle.Top;
            panelContenedorClient.Location = new Point(0, 0);
            panelContenedorClient.Name = "panelContenedorClient";
            panelContenedorClient.Size = new Size(813, 368);
            panelContenedorClient.TabIndex = 0;
            // 
            // dataGridClient
            // 
            dataGridClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClient.Dock = DockStyle.Fill;
            dataGridClient.Location = new Point(0, 26);
            dataGridClient.Name = "dataGridClient";
            dataGridClient.RowTemplate.Height = 25;
            dataGridClient.Size = new Size(813, 312);
            dataGridClient.TabIndex = 2;
            // 
            // panelDownDataGrid
            // 
            panelDownDataGrid.BackColor = Color.Gainsboro;
            panelDownDataGrid.Controls.Add(textHombres);
            panelDownDataGrid.Controls.Add(label3);
            panelDownDataGrid.Controls.Add(textTotal);
            panelDownDataGrid.Controls.Add(textMujeres);
            panelDownDataGrid.Controls.Add(label4);
            panelDownDataGrid.Controls.Add(label2);
            panelDownDataGrid.Dock = DockStyle.Bottom;
            panelDownDataGrid.Location = new Point(0, 338);
            panelDownDataGrid.Name = "panelDownDataGrid";
            panelDownDataGrid.Size = new Size(813, 30);
            panelDownDataGrid.TabIndex = 1;
            // 
            // textHombres
            // 
            textHombres.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textHombres.Location = new Point(666, 4);
            textHombres.Name = "textHombres";
            textHombres.Size = new Size(52, 23);
            textHombres.TabIndex = 13;
            textHombres.Text = "0";
            textHombres.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(490, 7);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 11;
            label3.Text = "Mujeres:";
            // 
            // textTotal
            // 
            textTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textTotal.Location = new Point(433, 4);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(52, 23);
            textTotal.TabIndex = 10;
            textTotal.Text = "0";
            textTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // textMujeres
            // 
            textMujeres.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textMujeres.Location = new Point(548, 4);
            textMujeres.Name = "textMujeres";
            textMujeres.Size = new Size(52, 23);
            textMujeres.TabIndex = 14;
            textMujeres.Text = "0";
            textMujeres.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(602, 7);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 12;
            label4.Text = "Hombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(351, 8);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 9;
            label2.Text = "Registrados:";
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
            comboFiltroSexo.BackColor = SystemColors.Window;
            comboFiltroSexo.FormattingEnabled = true;
            comboFiltroSexo.Items.AddRange(new object[] { "M", "F", "Otro" });
            comboFiltroSexo.Location = new Point(295, 2);
            comboFiltroSexo.Name = "comboFiltroSexo";
            comboFiltroSexo.Size = new Size(121, 23);
            comboFiltroSexo.TabIndex = 1;
            comboFiltroSexo.Text = "Filtro jornada";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(214, 21);
            label1.TabIndex = 0;
            label1.Text = "Lista de planes de ejercicio";
            // 
            // tabRegistro
            // 
            tabRegistro.Controls.Add(panel7);
            tabRegistro.Controls.Add(panel6);
            tabRegistro.Controls.Add(panel4);
            tabRegistro.Location = new Point(4, 24);
            tabRegistro.Name = "tabRegistro";
            tabRegistro.Padding = new Padding(3);
            tabRegistro.Size = new Size(819, 446);
            tabRegistro.TabIndex = 1;
            tabRegistro.Text = "Registro";
            tabRegistro.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel20);
            panel7.Controls.Add(panel19);
            panel7.Controls.Add(panel18);
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(3, 53);
            panel7.Name = "panel7";
            panel7.Size = new Size(813, 393);
            panel7.TabIndex = 2;
            // 
            // panel20
            // 
            panel20.Controls.Add(textBox10);
            panel20.Controls.Add(label26);
            panel20.Controls.Add(comboBox4);
            panel20.Controls.Add(label27);
            panel20.Controls.Add(comboBox3);
            panel20.Controls.Add(label25);
            panel20.Controls.Add(textBox9);
            panel20.Controls.Add(label24);
            panel20.Controls.Add(label23);
            panel20.Controls.Add(textBox8);
            panel20.Dock = DockStyle.Fill;
            panel20.Enabled = false;
            panel20.Location = new Point(0, 132);
            panel20.Name = "panel20";
            panel20.Size = new Size(523, 217);
            panel20.TabIndex = 35;
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.FixedSingle;
            textBox10.Location = new Point(73, 184);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(85, 23);
            textBox10.TabIndex = 47;
            textBox10.Text = "0";
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(14, 185);
            label26.Name = "label26";
            label26.Size = new Size(53, 20);
            label26.TabIndex = 46;
            label26.Text = "Precio:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Fase inicial", "Fase avanzada", "Fase final" });
            comboBox4.Location = new Point(65, 154);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(136, 23);
            comboBox4.TabIndex = 45;
            comboBox4.Text = "Seleccione un ciclo";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(14, 155);
            label27.Name = "label27";
            label27.Size = new Size(45, 20);
            label27.TabIndex = 44;
            label27.Text = "Ciclo:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboBox3.Location = new Point(71, 119);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(136, 23);
            comboBox3.TabIndex = 42;
            comboBox3.Text = "Seleccione un estado";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(14, 120);
            label25.Name = "label25";
            label25.Size = new Size(57, 20);
            label25.TabIndex = 41;
            label25.Text = "Estado:";
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.FixedSingle;
            textBox9.Location = new Point(168, 54);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(275, 56);
            textBox9.TabIndex = 40;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(14, 74);
            label24.Name = "label24";
            label24.Size = new Size(148, 20);
            label24.TabIndex = 39;
            label24.Text = "Descripcion del plan:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(14, 20);
            label23.Name = "label23";
            label23.Size = new Size(69, 20);
            label23.TabIndex = 38;
            label23.Text = "Objetivo:";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(89, 6);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(275, 42);
            textBox8.TabIndex = 0;
            // 
            // panel19
            // 
            panel19.Controls.Add(label22);
            panel19.Dock = DockStyle.Top;
            panel19.Location = new Point(0, 108);
            panel19.Name = "panel19";
            panel19.Size = new Size(523, 24);
            panel19.TabIndex = 34;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(5, 2);
            label22.Name = "label22";
            label22.Size = new Size(138, 21);
            label22.TabIndex = 2;
            label22.Text = "Detalles del plan";
            // 
            // panel18
            // 
            panel18.Controls.Add(comboBox2);
            panel18.Controls.Add(dateTimePicker1);
            panel18.Controls.Add(label21);
            panel18.Controls.Add(textBox7);
            panel18.Controls.Add(label20);
            panel18.Controls.Add(comboBox1);
            panel18.Controls.Add(label19);
            panel18.Dock = DockStyle.Top;
            panel18.Location = new Point(0, 0);
            panel18.Name = "panel18";
            panel18.Size = new Size(523, 108);
            panel18.TabIndex = 33;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Mes/Meses", "Dia/Dias" });
            comboBox2.Location = new Point(278, 41);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(69, 23);
            comboBox2.TabIndex = 37;
            comboBox2.Text = "Dia/Dias";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(130, 72);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 23);
            dateTimePicker1.TabIndex = 36;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(13, 73);
            label21.Name = "label21";
            label21.Size = new Size(111, 20);
            label21.TabIndex = 35;
            label21.Text = "Fecha de inicio:";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(188, 41);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(85, 23);
            textBox7.TabIndex = 34;
            textBox7.Text = "0";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(13, 42);
            label20.Name = "label20";
            label20.Size = new Size(173, 20);
            label20.TabIndex = 33;
            label20.Text = "Cantidad de Dias/Meses:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Matutina", "Vespertina", "Nocturna" });
            comboBox1.Location = new Point(83, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 23);
            comboBox1.TabIndex = 32;
            comboBox1.Text = "Seleccione una jornada";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(13, 8);
            label19.Name = "label19";
            label19.Size = new Size(64, 20);
            label19.TabIndex = 31;
            label19.Text = "Jornada:";
            // 
            // panel9
            // 
            panel9.Controls.Add(label18);
            panel9.Controls.Add(label10);
            panel9.Controls.Add(pictureBox3);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(523, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(290, 349);
            panel9.TabIndex = 32;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(55, 11);
            label18.Name = "label18";
            label18.Size = new Size(130, 21);
            label18.TabIndex = 26;
            label18.Text = "Codigo de plan:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(184, 10);
            label10.Name = "label10";
            label10.Size = new Size(113, 21);
            label10.TabIndex = 24;
            label10.Text = "*                        ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Plan_de_ejercicio;
            pictureBox3.Location = new Point(55, 86);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(172, 176);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(iconButton2);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 349);
            panel8.Name = "panel8";
            panel8.Size = new Size(813, 44);
            panel8.TabIndex = 31;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Black;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 28;
            iconButton2.Location = new Point(365, 6);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(107, 33);
            iconButton2.TabIndex = 21;
            iconButton2.UseVisualStyleBackColor = false;
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
            panel6.Size = new Size(813, 24);
            panel6.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.ForeColor = Color.Black;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Brands;
            btnSearch.IconSize = 24;
            btnSearch.Location = new Point(787, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(24, 24);
            btnSearch.TabIndex = 12;
            btnSearch.TabStop = false;
            // 
            // textSearch
            // 
            textSearch.BorderStyle = BorderStyle.FixedSingle;
            textSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textSearch.Location = new Point(642, -1);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(146, 25);
            textSearch.TabIndex = 11;
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
            btnCloseTextSearch.Location = new Point(787, 0);
            btnCloseTextSearch.Name = "btnCloseTextSearch";
            btnCloseTextSearch.Size = new Size(24, 24);
            btnCloseTextSearch.TabIndex = 10;
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
            panel4.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(4, 2);
            label7.Name = "label7";
            label7.Size = new Size(242, 21);
            label7.TabIndex = 0;
            label7.Text = "Registro de planes de ejercicio";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnVolver);
            panel2.Location = new Point(0, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(827, 57);
            panel2.TabIndex = 5;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.VoteYea;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(50, 13);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 8;
            iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(372, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(455, 57);
            panel3.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(76, 16);
            label6.Name = "label6";
            label6.Size = new Size(168, 25);
            label6.TabIndex = 9;
            label6.Text = "Mensaje de alerta";
            label6.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Alert;
            pictureBox1.Location = new Point(28, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(83, 12);
            label5.Name = "label5";
            label5.Size = new Size(251, 32);
            label5.TabIndex = 2;
            label5.Text = "GESTION DE PLANES";
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
            // FormPlanEjercicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 542);
            Controls.Add(tabControlMembership);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPlanEjercicio";
            Text = "FormPlanEjercicio";
            tabControlMembership.ResumeLayout(false);
            tabGeneral.ResumeLayout(false);
            panelPlanEjercicio.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelContenedorClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridClient).EndInit();
            panelDownDataGrid.ResumeLayout(false);
            panelDownDataGrid.PerformLayout();
            panelTopDataGrid.ResumeLayout(false);
            panelTopDataGrid.PerformLayout();
            tabRegistro.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCloseTextSearch).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMembership;
        private TabPage tabGeneral;
        private Panel panelPlanEjercicio;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnProgreso;
        private FontAwesome.Sharp.IconButton btnAddMembership;
        private FontAwesome.Sharp.IconButton btnUpdateMembership;
        private Panel panelContenedorClient;
        private DataGridView dataGridClient;
        private Panel panelDownDataGrid;
        private TextBox textHombres;
        private Label label3;
        private TextBox textTotal;
        private TextBox textMujeres;
        private Label label4;
        private Label label2;
        private Panel panelTopDataGrid;
        private ComboBox comboFiltroSexo;
        private Label label1;
        private TabPage tabRegistro;
        private Panel panel6;
        private FontAwesome.Sharp.IconPictureBox btnSearch;
        private TextBox textSearch;
        private FontAwesome.Sharp.IconPictureBox btnCloseTextSearch;
        private Label label9;
        private Panel panel4;
        private Label label7;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel3;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnVolver;
        private Panel panel7;
        private Panel panel18;
        private Panel panel9;
        private Label label18;
        private Label label10;
        private PictureBox pictureBox3;
        private Panel panel8;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel20;
        private Panel panel19;
        private Label label22;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private Label label21;
        private TextBox textBox7;
        private Label label20;
        private ComboBox comboBox1;
        private Label label19;
        private TextBox textBox8;
        private Label label23;
        private TextBox textBox9;
        private Label label24;
        private ComboBox comboBox3;
        private Label label25;
        private ComboBox comboBox4;
        private Label label27;
        private TextBox textBox10;
        private Label label26;
    }
}