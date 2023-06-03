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
            tabControlPlanes = new TabControl();
            tabGeneral = new TabPage();
            panelPlanEjercicio = new Panel();
            panel1 = new Panel();
            btnProgreso = new FontAwesome.Sharp.IconButton();
            btnAddPlan = new FontAwesome.Sharp.IconButton();
            btnUpdatePlan = new FontAwesome.Sharp.IconButton();
            panelContenedorClient = new Panel();
            dataGridPlanEjercicio = new DataGridView();
            Eliminar = new DataGridViewImageColumn();
            panelDownDataGrid = new Panel();
            textNocturna = new TextBox();
            label8 = new Label();
            textVespertina = new TextBox();
            label3 = new Label();
            textTotal = new TextBox();
            textMatutina = new TextBox();
            label4 = new Label();
            label2 = new Label();
            panelTopDataGrid = new Panel();
            comboFiltroJornada = new ComboBox();
            label1 = new Label();
            tabRegistro = new TabPage();
            panel7 = new Panel();
            panelDetallesPlanes = new Panel();
            textPrecio = new TextBox();
            label26 = new Label();
            comboCiclo = new ComboBox();
            label27 = new Label();
            comboEstado = new ComboBox();
            label25 = new Label();
            textDescripcion = new TextBox();
            label24 = new Label();
            label23 = new Label();
            textObjetivo = new TextBox();
            panel19 = new Panel();
            label22 = new Label();
            panelDatosBasicosPlan = new Panel();
            comboDiasMeses = new ComboBox();
            dateTimeFechaInicio = new DateTimePicker();
            label21 = new Label();
            textCatidadDiasMeses = new TextBox();
            label20 = new Label();
            comboJornada = new ComboBox();
            label19 = new Label();
            panel9 = new Panel();
            label18 = new Label();
            labelCodigoPlan = new Label();
            pictureBox3 = new PictureBox();
            panel8 = new Panel();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
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
            pictureAlerta = new PictureBox();
            labelAlerta = new Label();
            label5 = new Label();
            btnVolver = new FontAwesome.Sharp.IconButton();
            tabControlPlanes.SuspendLayout();
            tabGeneral.SuspendLayout();
            panelPlanEjercicio.SuspendLayout();
            panel1.SuspendLayout();
            panelContenedorClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPlanEjercicio).BeginInit();
            panelDownDataGrid.SuspendLayout();
            panelTopDataGrid.SuspendLayout();
            tabRegistro.SuspendLayout();
            panel7.SuspendLayout();
            panelDetallesPlanes.SuspendLayout();
            panel19.SuspendLayout();
            panelDatosBasicosPlan.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)pictureAlerta).BeginInit();
            SuspendLayout();
            // 
            // tabControlPlanes
            // 
            tabControlPlanes.Controls.Add(tabGeneral);
            tabControlPlanes.Controls.Add(tabRegistro);
            tabControlPlanes.Location = new Point(0, 66);
            tabControlPlanes.Name = "tabControlPlanes";
            tabControlPlanes.SelectedIndex = 0;
            tabControlPlanes.Size = new Size(827, 474);
            tabControlPlanes.TabIndex = 6;
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
            panel1.Controls.Add(btnAddPlan);
            panel1.Controls.Add(btnUpdatePlan);
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
            // btnAddPlan
            // 
            btnAddPlan.BackColor = Color.LimeGreen;
            btnAddPlan.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAddPlan.IconColor = Color.Black;
            btnAddPlan.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnAddPlan.IconSize = 32;
            btnAddPlan.Location = new Point(236, 3);
            btnAddPlan.Name = "btnAddPlan";
            btnAddPlan.Size = new Size(69, 33);
            btnAddPlan.TabIndex = 1;
            btnAddPlan.UseVisualStyleBackColor = false;
            btnAddPlan.Click += btnAddPlan_Click;
            // 
            // btnUpdatePlan
            // 
            btnUpdatePlan.BackColor = Color.Gold;
            btnUpdatePlan.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            btnUpdatePlan.IconColor = Color.Black;
            btnUpdatePlan.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnUpdatePlan.IconSize = 32;
            btnUpdatePlan.Location = new Point(311, 3);
            btnUpdatePlan.Name = "btnUpdatePlan";
            btnUpdatePlan.Size = new Size(69, 33);
            btnUpdatePlan.TabIndex = 2;
            btnUpdatePlan.UseVisualStyleBackColor = false;
            btnUpdatePlan.Click += btnUpdatePlan_Click;
            // 
            // panelContenedorClient
            // 
            panelContenedorClient.Controls.Add(dataGridPlanEjercicio);
            panelContenedorClient.Controls.Add(panelDownDataGrid);
            panelContenedorClient.Controls.Add(panelTopDataGrid);
            panelContenedorClient.Dock = DockStyle.Top;
            panelContenedorClient.Location = new Point(0, 0);
            panelContenedorClient.Name = "panelContenedorClient";
            panelContenedorClient.Size = new Size(813, 368);
            panelContenedorClient.TabIndex = 0;
            // 
            // dataGridPlanEjercicio
            // 
            dataGridPlanEjercicio.AllowUserToAddRows = false;
            dataGridPlanEjercicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPlanEjercicio.Columns.AddRange(new DataGridViewColumn[] { Eliminar });
            dataGridPlanEjercicio.Dock = DockStyle.Fill;
            dataGridPlanEjercicio.Location = new Point(0, 26);
            dataGridPlanEjercicio.Name = "dataGridPlanEjercicio";
            dataGridPlanEjercicio.RowHeadersVisible = false;
            dataGridPlanEjercicio.RowTemplate.Height = 25;
            dataGridPlanEjercicio.Size = new Size(813, 312);
            dataGridPlanEjercicio.TabIndex = 2;
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
            panelDownDataGrid.Controls.Add(textNocturna);
            panelDownDataGrid.Controls.Add(label8);
            panelDownDataGrid.Controls.Add(textVespertina);
            panelDownDataGrid.Controls.Add(label3);
            panelDownDataGrid.Controls.Add(textTotal);
            panelDownDataGrid.Controls.Add(textMatutina);
            panelDownDataGrid.Controls.Add(label4);
            panelDownDataGrid.Controls.Add(label2);
            panelDownDataGrid.Dock = DockStyle.Bottom;
            panelDownDataGrid.Location = new Point(0, 338);
            panelDownDataGrid.Name = "panelDownDataGrid";
            panelDownDataGrid.Size = new Size(813, 30);
            panelDownDataGrid.TabIndex = 1;
            // 
            // textNocturna
            // 
            textNocturna.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textNocturna.Location = new Point(742, 3);
            textNocturna.Name = "textNocturna";
            textNocturna.Size = new Size(52, 23);
            textNocturna.TabIndex = 16;
            textNocturna.Text = "0";
            textNocturna.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(678, 6);
            label8.Name = "label8";
            label8.Size = new Size(69, 17);
            label8.TabIndex = 15;
            label8.Text = "Nocturna:";
            // 
            // textVespertina
            // 
            textVespertina.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textVespertina.Location = new Point(620, 4);
            textVespertina.Name = "textVespertina";
            textVespertina.Size = new Size(52, 23);
            textVespertina.TabIndex = 13;
            textVespertina.Text = "0";
            textVespertina.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(429, 7);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 11;
            label3.Text = "Matutina:";
            // 
            // textTotal
            // 
            textTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textTotal.Location = new Point(372, 4);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(52, 23);
            textTotal.TabIndex = 10;
            textTotal.Text = "0";
            textTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // textMatutina
            // 
            textMatutina.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textMatutina.Location = new Point(487, 4);
            textMatutina.Name = "textMatutina";
            textMatutina.Size = new Size(52, 23);
            textMatutina.TabIndex = 14;
            textMatutina.Text = "0";
            textMatutina.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(543, 7);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 12;
            label4.Text = "Vespertina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(290, 8);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 9;
            label2.Text = "Registrados:";
            // 
            // panelTopDataGrid
            // 
            panelTopDataGrid.BackColor = Color.Gainsboro;
            panelTopDataGrid.Controls.Add(comboFiltroJornada);
            panelTopDataGrid.Controls.Add(label1);
            panelTopDataGrid.Dock = DockStyle.Top;
            panelTopDataGrid.Location = new Point(0, 0);
            panelTopDataGrid.Name = "panelTopDataGrid";
            panelTopDataGrid.Size = new Size(813, 26);
            panelTopDataGrid.TabIndex = 0;
            // 
            // comboFiltroJornada
            // 
            comboFiltroJornada.BackColor = SystemColors.Window;
            comboFiltroJornada.FormattingEnabled = true;
            comboFiltroJornada.Items.AddRange(new object[] { "Todos", "Matutina", "Vespertina", "Nocturna" });
            comboFiltroJornada.Location = new Point(295, 2);
            comboFiltroJornada.Name = "comboFiltroJornada";
            comboFiltroJornada.Size = new Size(121, 23);
            comboFiltroJornada.TabIndex = 1;
            comboFiltroJornada.Text = "Filtro jornada";
            comboFiltroJornada.SelectedIndexChanged += comboFiltroJornada_SelectedIndexChanged;
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
            panel7.Controls.Add(panelDetallesPlanes);
            panel7.Controls.Add(panel19);
            panel7.Controls.Add(panelDatosBasicosPlan);
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(3, 53);
            panel7.Name = "panel7";
            panel7.Size = new Size(813, 393);
            panel7.TabIndex = 2;
            // 
            // panelDetallesPlanes
            // 
            panelDetallesPlanes.Controls.Add(textPrecio);
            panelDetallesPlanes.Controls.Add(label26);
            panelDetallesPlanes.Controls.Add(comboCiclo);
            panelDetallesPlanes.Controls.Add(label27);
            panelDetallesPlanes.Controls.Add(comboEstado);
            panelDetallesPlanes.Controls.Add(label25);
            panelDetallesPlanes.Controls.Add(textDescripcion);
            panelDetallesPlanes.Controls.Add(label24);
            panelDetallesPlanes.Controls.Add(label23);
            panelDetallesPlanes.Controls.Add(textObjetivo);
            panelDetallesPlanes.Dock = DockStyle.Fill;
            panelDetallesPlanes.Location = new Point(0, 132);
            panelDetallesPlanes.Name = "panelDetallesPlanes";
            panelDetallesPlanes.Size = new Size(523, 217);
            panelDetallesPlanes.TabIndex = 35;
            // 
            // textPrecio
            // 
            textPrecio.BorderStyle = BorderStyle.FixedSingle;
            textPrecio.Location = new Point(73, 184);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(85, 23);
            textPrecio.TabIndex = 47;
            textPrecio.Text = "0";
            textPrecio.TextAlign = HorizontalAlignment.Center;
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
            // comboCiclo
            // 
            comboCiclo.FormattingEnabled = true;
            comboCiclo.Items.AddRange(new object[] { "Fase inicial", "Fase avanzada", "Fase final" });
            comboCiclo.Location = new Point(65, 154);
            comboCiclo.Name = "comboCiclo";
            comboCiclo.Size = new Size(136, 23);
            comboCiclo.TabIndex = 45;
            comboCiclo.Text = "Seleccione un ciclo";
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
            // comboEstado
            // 
            comboEstado.FormattingEnabled = true;
            comboEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboEstado.Location = new Point(71, 119);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(136, 23);
            comboEstado.TabIndex = 42;
            comboEstado.Text = "Seleccione un estado";
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
            // textDescripcion
            // 
            textDescripcion.BorderStyle = BorderStyle.FixedSingle;
            textDescripcion.Location = new Point(168, 54);
            textDescripcion.Multiline = true;
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(275, 56);
            textDescripcion.TabIndex = 40;
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
            // textObjetivo
            // 
            textObjetivo.BorderStyle = BorderStyle.FixedSingle;
            textObjetivo.Location = new Point(89, 6);
            textObjetivo.Multiline = true;
            textObjetivo.Name = "textObjetivo";
            textObjetivo.Size = new Size(275, 42);
            textObjetivo.TabIndex = 0;
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
            // panelDatosBasicosPlan
            // 
            panelDatosBasicosPlan.Controls.Add(comboDiasMeses);
            panelDatosBasicosPlan.Controls.Add(dateTimeFechaInicio);
            panelDatosBasicosPlan.Controls.Add(label21);
            panelDatosBasicosPlan.Controls.Add(textCatidadDiasMeses);
            panelDatosBasicosPlan.Controls.Add(label20);
            panelDatosBasicosPlan.Controls.Add(comboJornada);
            panelDatosBasicosPlan.Controls.Add(label19);
            panelDatosBasicosPlan.Dock = DockStyle.Top;
            panelDatosBasicosPlan.Location = new Point(0, 0);
            panelDatosBasicosPlan.Name = "panelDatosBasicosPlan";
            panelDatosBasicosPlan.Size = new Size(523, 108);
            panelDatosBasicosPlan.TabIndex = 33;
            // 
            // comboDiasMeses
            // 
            comboDiasMeses.FormattingEnabled = true;
            comboDiasMeses.Items.AddRange(new object[] { "Mes/Meses", "Dia/Dias" });
            comboDiasMeses.Location = new Point(278, 41);
            comboDiasMeses.Name = "comboDiasMeses";
            comboDiasMeses.Size = new Size(69, 23);
            comboDiasMeses.TabIndex = 37;
            comboDiasMeses.Text = "Dia/Dias";
            // 
            // dateTimeFechaInicio
            // 
            dateTimeFechaInicio.Location = new Point(130, 72);
            dateTimeFechaInicio.Name = "dateTimeFechaInicio";
            dateTimeFechaInicio.Size = new Size(217, 23);
            dateTimeFechaInicio.TabIndex = 36;
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
            // textCatidadDiasMeses
            // 
            textCatidadDiasMeses.BorderStyle = BorderStyle.FixedSingle;
            textCatidadDiasMeses.Location = new Point(188, 41);
            textCatidadDiasMeses.Name = "textCatidadDiasMeses";
            textCatidadDiasMeses.Size = new Size(85, 23);
            textCatidadDiasMeses.TabIndex = 34;
            textCatidadDiasMeses.Text = "0";
            textCatidadDiasMeses.TextAlign = HorizontalAlignment.Center;
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
            // comboJornada
            // 
            comboJornada.FormattingEnabled = true;
            comboJornada.Items.AddRange(new object[] { "Matutina", "Vespertina", "Nocturna" });
            comboJornada.Location = new Point(83, 8);
            comboJornada.Name = "comboJornada";
            comboJornada.Size = new Size(146, 23);
            comboJornada.TabIndex = 32;
            comboJornada.Text = "Seleccione una jornada";
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
            panel9.Controls.Add(labelCodigoPlan);
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
            // labelCodigoPlan
            // 
            labelCodigoPlan.AutoSize = true;
            labelCodigoPlan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodigoPlan.ForeColor = Color.Black;
            labelCodigoPlan.Location = new Point(184, 10);
            labelCodigoPlan.Name = "labelCodigoPlan";
            labelCodigoPlan.Size = new Size(113, 21);
            labelCodigoPlan.TabIndex = 24;
            labelCodigoPlan.Text = "*                        ";
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
            panel8.Controls.Add(btnModificar);
            panel8.Controls.Add(btnRegistrar);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 349);
            panel8.Name = "panel8";
            panel8.Size = new Size(813, 44);
            panel8.TabIndex = 31;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Black;
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnModificar.IconColor = Color.White;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnModificar.IconSize = 28;
            btnModificar.Location = new Point(416, 8);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(107, 33);
            btnModificar.TabIndex = 22;
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
            btnRegistrar.Location = new Point(303, 8);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(107, 33);
            btnRegistrar.TabIndex = 21;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
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
            btnSearch.Click += btnSearch_Click;
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
            textSearch.Visible = false;
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
            btnCloseTextSearch.Location = new Point(787, 0);
            btnCloseTextSearch.Name = "btnCloseTextSearch";
            btnCloseTextSearch.Size = new Size(24, 24);
            btnCloseTextSearch.TabIndex = 10;
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
            panel3.Controls.Add(pictureAlerta);
            panel3.Controls.Add(labelAlerta);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(372, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(455, 57);
            panel3.TabIndex = 6;
            // 
            // pictureAlerta
            // 
            pictureAlerta.Image = Properties.Resources.Alert;
            pictureAlerta.Location = new Point(14, 12);
            pictureAlerta.Name = "pictureAlerta";
            pictureAlerta.Size = new Size(30, 30);
            pictureAlerta.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAlerta.TabIndex = 12;
            pictureAlerta.TabStop = false;
            pictureAlerta.Visible = false;
            // 
            // labelAlerta
            // 
            labelAlerta.AutoSize = true;
            labelAlerta.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAlerta.ForeColor = Color.Orange;
            labelAlerta.Location = new Point(41, 17);
            labelAlerta.Name = "labelAlerta";
            labelAlerta.Size = new Size(117, 20);
            labelAlerta.TabIndex = 13;
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
            Controls.Add(tabControlPlanes);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPlanEjercicio";
            Text = "FormPlanEjercicio";
            tabControlPlanes.ResumeLayout(false);
            tabGeneral.ResumeLayout(false);
            panelPlanEjercicio.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelContenedorClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPlanEjercicio).EndInit();
            panelDownDataGrid.ResumeLayout(false);
            panelDownDataGrid.PerformLayout();
            panelTopDataGrid.ResumeLayout(false);
            panelTopDataGrid.PerformLayout();
            tabRegistro.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panelDetallesPlanes.ResumeLayout(false);
            panelDetallesPlanes.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panelDatosBasicosPlan.ResumeLayout(false);
            panelDatosBasicosPlan.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)pictureAlerta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPlanes;
        private TabPage tabGeneral;
        private Panel panelPlanEjercicio;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnProgreso;
        private FontAwesome.Sharp.IconButton btnAddPlan;
        private FontAwesome.Sharp.IconButton btnUpdatePlan;
        private Panel panelContenedorClient;
        private DataGridView dataGridPlanEjercicio;
        private Panel panelDownDataGrid;
        private TextBox textVespertina;
        private Label label3;
        private TextBox textTotal;
        private TextBox textMatutina;
        private Label label4;
        private Label label2;
        private Panel panelTopDataGrid;
        private ComboBox comboFiltroJornada;
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
        private Label label5;
        private FontAwesome.Sharp.IconButton btnVolver;
        private Panel panel7;
        private Panel panelDatosBasicosPlan;
        private Panel panel9;
        private Label label18;
        private PictureBox pictureBox3;
        private Panel panel8;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private Panel panelDetallesPlanes;
        private Panel panel19;
        private Label label22;
        private ComboBox comboDiasMeses;
        private DateTimePicker dateTimeFechaInicio;
        private Label label21;
        private TextBox textCatidadDiasMeses;
        private Label label20;
        private ComboBox comboJornada;
        private Label label19;
        private TextBox textObjetivo;
        private Label label23;
        private TextBox textDescripcion;
        private Label label24;
        private ComboBox comboEstado;
        private Label label25;
        private ComboBox comboCiclo;
        private Label label27;
        private TextBox textPrecio;
        private Label label26;
        private DataGridViewImageColumn Eliminar;
        private TextBox textNocturna;
        private Label label8;
        private Label labelCodigoPlan;
        private PictureBox pictureAlerta;
        private Label labelAlerta;
        private FontAwesome.Sharp.IconButton btnModificar;
    }
}