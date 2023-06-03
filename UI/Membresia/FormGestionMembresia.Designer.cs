namespace UI
{
    partial class FormMembresia
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
            panelMembresia = new Panel();
            panel1 = new Panel();
            btnProgreso = new FontAwesome.Sharp.IconButton();
            btnAddMembership = new FontAwesome.Sharp.IconButton();
            btnUpdateMembership = new FontAwesome.Sharp.IconButton();
            panelContenedorClient = new Panel();
            dataGridMiembro = new DataGridView();
            panelDownDataGrid = new Panel();
            textHombres = new TextBox();
            label3 = new Label();
            textTotal = new TextBox();
            textMujeres = new TextBox();
            label4 = new Label();
            label2 = new Label();
            panelTopDataGrid = new Panel();
            comboFiltroCategoria = new ComboBox();
            label1 = new Label();
            tabRegistro = new TabPage();
            panelDatosMembresia = new Panel();
            textSaldo = new TextBox();
            textAbono = new TextBox();
            textValorMensual = new TextBox();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            panelReporte = new Panel();
            btnEnviarReporte = new FontAwesome.Sharp.IconButton();
            labelTotalAPagar = new Label();
            label31 = new Label();
            labelCantidadCreditos = new Label();
            label29 = new Label();
            labelValorMensualidad = new Label();
            label27 = new Label();
            labelValorInscripcion = new Label();
            label25 = new Label();
            panel18 = new Panel();
            btnModificarCliente = new FontAwesome.Sharp.IconButton();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            textCodigoMiembro = new TextBox();
            comboCategoria = new ComboBox();
            label18 = new Label();
            label19 = new Label();
            panel8 = new Panel();
            label10 = new Label();
            panel7 = new Panel();
            comboEstado = new ComboBox();
            comboPlan = new ComboBox();
            label13 = new Label();
            panel5 = new Panel();
            btnSearch = new FontAwesome.Sharp.IconPictureBox();
            textSearch = new TextBox();
            btnCloseSearch = new FontAwesome.Sharp.IconPictureBox();
            label14 = new Label();
            textApellidos = new TextBox();
            label21 = new Label();
            textNombres = new TextBox();
            label20 = new Label();
            pictureBox7 = new PictureBox();
            pictureCategoria = new PictureBox();
            picturePerfil = new PictureBox();
            panel4 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            pictureAlerta = new PictureBox();
            labelAlerta = new Label();
            label8 = new Label();
            labelBase = new Label();
            label11 = new Label();
            label12 = new Label();
            iconBase = new FontAwesome.Sharp.IconPictureBox();
            labelCash = new Label();
            labelTextFondo = new Label();
            iconCash = new FontAwesome.Sharp.IconPictureBox();
            label5 = new Label();
            btnVolver = new FontAwesome.Sharp.IconButton();
            Eliminar = new DataGridViewImageColumn();
            Deshacer = new DataGridViewImageColumn();
            tabControlMembership.SuspendLayout();
            tabGeneral.SuspendLayout();
            panelMembresia.SuspendLayout();
            panel1.SuspendLayout();
            panelContenedorClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMiembro).BeginInit();
            panelDownDataGrid.SuspendLayout();
            panelTopDataGrid.SuspendLayout();
            tabRegistro.SuspendLayout();
            panelDatosMembresia.SuspendLayout();
            panelReporte.SuspendLayout();
            panel18.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCloseSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePerfil).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAlerta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconBase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCash).BeginInit();
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
            tabControlMembership.TabIndex = 4;
            // 
            // tabGeneral
            // 
            tabGeneral.Controls.Add(panelMembresia);
            tabGeneral.Location = new Point(4, 24);
            tabGeneral.Name = "tabGeneral";
            tabGeneral.Padding = new Padding(3);
            tabGeneral.Size = new Size(819, 446);
            tabGeneral.TabIndex = 0;
            tabGeneral.Text = "General";
            tabGeneral.UseVisualStyleBackColor = true;
            // 
            // panelMembresia
            // 
            panelMembresia.Controls.Add(panel1);
            panelMembresia.Controls.Add(panelContenedorClient);
            panelMembresia.Dock = DockStyle.Fill;
            panelMembresia.Location = new Point(3, 3);
            panelMembresia.Name = "panelMembresia";
            panelMembresia.Size = new Size(813, 440);
            panelMembresia.TabIndex = 1;
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
            btnAddMembership.Click += btnAddMembership_Click;
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
            btnUpdateMembership.Click += btnUpdateMembership_Click;
            // 
            // panelContenedorClient
            // 
            panelContenedorClient.Controls.Add(dataGridMiembro);
            panelContenedorClient.Controls.Add(panelDownDataGrid);
            panelContenedorClient.Controls.Add(panelTopDataGrid);
            panelContenedorClient.Dock = DockStyle.Top;
            panelContenedorClient.Location = new Point(0, 0);
            panelContenedorClient.Name = "panelContenedorClient";
            panelContenedorClient.Size = new Size(813, 368);
            panelContenedorClient.TabIndex = 0;
            // 
            // dataGridMiembro
            // 
            dataGridMiembro.AllowUserToAddRows = false;
            dataGridMiembro.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dataGridMiembro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMiembro.Columns.AddRange(new DataGridViewColumn[] { Eliminar, Deshacer });
            dataGridMiembro.Cursor = Cursors.Hand;
            dataGridMiembro.Dock = DockStyle.Fill;
            dataGridMiembro.Location = new Point(0, 26);
            dataGridMiembro.Name = "dataGridMiembro";
            dataGridMiembro.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridMiembro.RowHeadersVisible = false;
            dataGridMiembro.RowTemplate.Height = 25;
            dataGridMiembro.Size = new Size(813, 312);
            dataGridMiembro.TabIndex = 2;
            dataGridMiembro.CellClick += dataGridMiembro_CellClick;
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
            panelTopDataGrid.Controls.Add(comboFiltroCategoria);
            panelTopDataGrid.Controls.Add(label1);
            panelTopDataGrid.Dock = DockStyle.Top;
            panelTopDataGrid.Location = new Point(0, 0);
            panelTopDataGrid.Name = "panelTopDataGrid";
            panelTopDataGrid.Size = new Size(813, 26);
            panelTopDataGrid.TabIndex = 0;
            // 
            // comboFiltroCategoria
            // 
            comboFiltroCategoria.BackColor = SystemColors.Window;
            comboFiltroCategoria.FormattingEnabled = true;
            comboFiltroCategoria.Items.AddRange(new object[] { "Todos", "Principiante", "Elite", "Profesional" });
            comboFiltroCategoria.Location = new Point(295, 2);
            comboFiltroCategoria.Name = "comboFiltroCategoria";
            comboFiltroCategoria.Size = new Size(121, 23);
            comboFiltroCategoria.TabIndex = 1;
            comboFiltroCategoria.Text = "Filtro categoria";
            comboFiltroCategoria.SelectedIndexChanged += comboFiltroCategoria_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 0;
            label1.Text = "Lista de miembros";
            // 
            // tabRegistro
            // 
            tabRegistro.Controls.Add(panelDatosMembresia);
            tabRegistro.Controls.Add(panel8);
            tabRegistro.Controls.Add(panel7);
            tabRegistro.Controls.Add(panel4);
            tabRegistro.Location = new Point(4, 24);
            tabRegistro.Name = "tabRegistro";
            tabRegistro.Padding = new Padding(3);
            tabRegistro.Size = new Size(819, 446);
            tabRegistro.TabIndex = 1;
            tabRegistro.Text = "Registro";
            tabRegistro.UseVisualStyleBackColor = true;
            // 
            // panelDatosMembresia
            // 
            panelDatosMembresia.Controls.Add(textSaldo);
            panelDatosMembresia.Controls.Add(textAbono);
            panelDatosMembresia.Controls.Add(textValorMensual);
            panelDatosMembresia.Controls.Add(label24);
            panelDatosMembresia.Controls.Add(label23);
            panelDatosMembresia.Controls.Add(label22);
            panelDatosMembresia.Controls.Add(panelReporte);
            panelDatosMembresia.Controls.Add(panel18);
            panelDatosMembresia.Controls.Add(textCodigoMiembro);
            panelDatosMembresia.Controls.Add(comboCategoria);
            panelDatosMembresia.Controls.Add(label18);
            panelDatosMembresia.Controls.Add(label19);
            panelDatosMembresia.Dock = DockStyle.Top;
            panelDatosMembresia.Enabled = false;
            panelDatosMembresia.Location = new Point(3, 231);
            panelDatosMembresia.Name = "panelDatosMembresia";
            panelDatosMembresia.Size = new Size(813, 208);
            panelDatosMembresia.TabIndex = 4;
            // 
            // textSaldo
            // 
            textSaldo.BorderStyle = BorderStyle.None;
            textSaldo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textSaldo.ForeColor = Color.Green;
            textSaldo.Location = new Point(67, 120);
            textSaldo.Name = "textSaldo";
            textSaldo.Size = new Size(133, 18);
            textSaldo.TabIndex = 30;
            textSaldo.Text = "0";
            textSaldo.TextAlign = HorizontalAlignment.Center;
            // 
            // textAbono
            // 
            textAbono.BorderStyle = BorderStyle.FixedSingle;
            textAbono.Location = new Point(73, 91);
            textAbono.Name = "textAbono";
            textAbono.Size = new Size(149, 23);
            textAbono.TabIndex = 29;
            textAbono.Text = "0";
            textAbono.TextAlign = HorizontalAlignment.Center;
            textAbono.TextChanged += textAbono_TextChanged;
            textAbono.Enter += textAbono_Enter;
            textAbono.Leave += textAbono_Leave;
            // 
            // textValorMensual
            // 
            textValorMensual.BorderStyle = BorderStyle.None;
            textValorMensual.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textValorMensual.ForeColor = Color.Green;
            textValorMensual.Location = new Point(115, 66);
            textValorMensual.Name = "textValorMensual";
            textValorMensual.Size = new Size(149, 18);
            textValorMensual.TabIndex = 28;
            textValorMensual.Text = "0";
            textValorMensual.TextAlign = HorizontalAlignment.Center;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(11, 118);
            label24.Name = "label24";
            label24.Size = new Size(50, 20);
            label24.TabIndex = 27;
            label24.Text = "Saldo:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(10, 91);
            label23.Name = "label23";
            label23.Size = new Size(57, 20);
            label23.TabIndex = 26;
            label23.Text = "Abono:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(7, 65);
            label22.Name = "label22";
            label22.Size = new Size(105, 20);
            label22.TabIndex = 25;
            label22.Text = "Valor Mensual:";
            // 
            // panelReporte
            // 
            panelReporte.BackColor = Color.Black;
            panelReporte.Controls.Add(btnEnviarReporte);
            panelReporte.Controls.Add(labelTotalAPagar);
            panelReporte.Controls.Add(label31);
            panelReporte.Controls.Add(labelCantidadCreditos);
            panelReporte.Controls.Add(label29);
            panelReporte.Controls.Add(labelValorMensualidad);
            panelReporte.Controls.Add(label27);
            panelReporte.Controls.Add(labelValorInscripcion);
            panelReporte.Controls.Add(label25);
            panelReporte.Dock = DockStyle.Right;
            panelReporte.Location = new Point(418, 0);
            panelReporte.Name = "panelReporte";
            panelReporte.Size = new Size(395, 148);
            panelReporte.TabIndex = 24;
            // 
            // btnEnviarReporte
            // 
            btnEnviarReporte.BackColor = Color.DarkGreen;
            btnEnviarReporte.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            btnEnviarReporte.IconColor = Color.White;
            btnEnviarReporte.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnEnviarReporte.IconSize = 25;
            btnEnviarReporte.Location = new Point(285, 113);
            btnEnviarReporte.Name = "btnEnviarReporte";
            btnEnviarReporte.Size = new Size(107, 33);
            btnEnviarReporte.TabIndex = 24;
            btnEnviarReporte.UseVisualStyleBackColor = false;
            btnEnviarReporte.Visible = false;
            // 
            // labelTotalAPagar
            // 
            labelTotalAPagar.AutoSize = true;
            labelTotalAPagar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalAPagar.ForeColor = Color.Lime;
            labelTotalAPagar.Location = new Point(95, 103);
            labelTotalAPagar.Name = "labelTotalAPagar";
            labelTotalAPagar.Size = new Size(126, 21);
            labelTotalAPagar.TabIndex = 8;
            labelTotalAPagar.Text = "$*                         ";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label31.ForeColor = Color.Lime;
            label31.Location = new Point(40, 103);
            label31.Name = "label31";
            label31.Size = new Size(49, 21);
            label31.TabIndex = 7;
            label31.Text = "Total:";
            // 
            // labelCantidadCreditos
            // 
            labelCantidadCreditos.AutoSize = true;
            labelCantidadCreditos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCantidadCreditos.ForeColor = Color.Lime;
            labelCantidadCreditos.Location = new Point(212, 76);
            labelCantidadCreditos.Name = "labelCantidadCreditos";
            labelCantidadCreditos.Size = new Size(125, 21);
            labelCantidadCreditos.TabIndex = 6;
            labelCantidadCreditos.Text = "*                           ";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label29.ForeColor = Color.Lime;
            label29.Location = new Point(40, 76);
            label29.Name = "label29";
            label29.Size = new Size(166, 21);
            label29.TabIndex = 5;
            label29.Text = "Cantidad de creditos:";
            // 
            // labelValorMensualidad
            // 
            labelValorMensualidad.AutoSize = true;
            labelValorMensualidad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelValorMensualidad.ForeColor = Color.Lime;
            labelValorMensualidad.Location = new Point(216, 49);
            labelValorMensualidad.Name = "labelValorMensualidad";
            labelValorMensualidad.Size = new Size(126, 21);
            labelValorMensualidad.TabIndex = 4;
            labelValorMensualidad.Text = "$*                         ";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label27.ForeColor = Color.Lime;
            label27.Location = new Point(40, 49);
            label27.Name = "label27";
            label27.Size = new Size(170, 21);
            label27.TabIndex = 3;
            label27.Text = "Valor de mensualidad:";
            // 
            // labelValorInscripcion
            // 
            labelValorInscripcion.AutoSize = true;
            labelValorInscripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelValorInscripcion.ForeColor = Color.Lime;
            labelValorInscripcion.Location = new Point(202, 22);
            labelValorInscripcion.Name = "labelValorInscripcion";
            labelValorInscripcion.Size = new Size(126, 21);
            labelValorInscripcion.TabIndex = 2;
            labelValorInscripcion.Text = "$*                         ";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.Lime;
            label25.Location = new Point(40, 22);
            label25.Name = "label25";
            label25.Size = new Size(157, 21);
            label25.TabIndex = 1;
            label25.Text = "Valor de inscripcion:";
            // 
            // panel18
            // 
            panel18.Controls.Add(btnModificarCliente);
            panel18.Controls.Add(btnRegistrar);
            panel18.Dock = DockStyle.Bottom;
            panel18.Location = new Point(0, 148);
            panel18.Name = "panel18";
            panel18.Size = new Size(813, 60);
            panel18.TabIndex = 23;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.BackColor = Color.Black;
            btnModificarCliente.Enabled = false;
            btnModificarCliente.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnModificarCliente.IconColor = Color.White;
            btnModificarCliente.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnModificarCliente.IconSize = 28;
            btnModificarCliente.Location = new Point(396, 15);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(107, 33);
            btnModificarCliente.TabIndex = 23;
            btnModificarCliente.UseVisualStyleBackColor = false;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Black;
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnRegistrar.IconColor = Color.White;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnRegistrar.IconSize = 28;
            btnRegistrar.Location = new Point(283, 15);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(107, 33);
            btnRegistrar.TabIndex = 21;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // textCodigoMiembro
            // 
            textCodigoMiembro.BorderStyle = BorderStyle.None;
            textCodigoMiembro.ForeColor = Color.Green;
            textCodigoMiembro.Location = new Point(131, 11);
            textCodigoMiembro.Name = "textCodigoMiembro";
            textCodigoMiembro.Size = new Size(133, 16);
            textCodigoMiembro.TabIndex = 1;
            // 
            // comboCategoria
            // 
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Items.AddRange(new object[] { "Principiante", "Elite", "Profesional" });
            comboCategoria.Location = new Point(183, 36);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(173, 23);
            comboCategoria.TabIndex = 22;
            comboCategoria.Text = "Principiante";
            comboCategoria.SelectedIndexChanged += comboCategoria_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(7, 8);
            label18.Name = "label18";
            label18.Size = new Size(126, 20);
            label18.TabIndex = 0;
            label18.Text = "Codigo miembro:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(7, 37);
            label19.Name = "label19";
            label19.Size = new Size(176, 20);
            label19.TabIndex = 21;
            label19.Text = "Categoria de membresia:";
            // 
            // panel8
            // 
            panel8.Controls.Add(label10);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(3, 208);
            panel8.Name = "panel8";
            panel8.Size = new Size(813, 23);
            panel8.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(5, 1);
            label10.Name = "label10";
            label10.Size = new Size(166, 21);
            label10.TabIndex = 1;
            label10.Text = "Datos de membresia";
            // 
            // panel7
            // 
            panel7.Controls.Add(comboEstado);
            panel7.Controls.Add(comboPlan);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(panel5);
            panel7.Controls.Add(textApellidos);
            panel7.Controls.Add(label21);
            panel7.Controls.Add(textNombres);
            panel7.Controls.Add(label20);
            panel7.Controls.Add(pictureBox7);
            panel7.Controls.Add(pictureCategoria);
            panel7.Controls.Add(picturePerfil);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(3, 29);
            panel7.Name = "panel7";
            panel7.Size = new Size(813, 179);
            panel7.TabIndex = 2;
            // 
            // comboEstado
            // 
            comboEstado.Enabled = false;
            comboEstado.FormattingEnabled = true;
            comboEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboEstado.Location = new Point(11, 149);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(142, 23);
            comboEstado.TabIndex = 31;
            comboEstado.Text = "Selecione estado";
            // 
            // comboPlan
            // 
            comboPlan.Enabled = false;
            comboPlan.FormattingEnabled = true;
            comboPlan.Items.AddRange(new object[] { "Principiante", "Elite", "Profesional" });
            comboPlan.Location = new Point(11, 120);
            comboPlan.Name = "comboPlan";
            comboPlan.Size = new Size(189, 23);
            comboPlan.TabIndex = 31;
            comboPlan.Text = "Seleccione el plan";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(11, 95);
            label13.Name = "label13";
            label13.Size = new Size(134, 20);
            label13.TabIndex = 30;
            label13.Text = "Planes disponibles:";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnSearch);
            panel5.Controls.Add(textSearch);
            panel5.Controls.Add(btnCloseSearch);
            panel5.Controls.Add(label14);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(813, 24);
            panel5.TabIndex = 29;
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
            // btnCloseSearch
            // 
            btnCloseSearch.BackColor = Color.Transparent;
            btnCloseSearch.ForeColor = Color.Red;
            btnCloseSearch.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnCloseSearch.IconColor = Color.Red;
            btnCloseSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCloseSearch.IconSize = 24;
            btnCloseSearch.Location = new Point(787, 0);
            btnCloseSearch.Name = "btnCloseSearch";
            btnCloseSearch.Size = new Size(24, 24);
            btnCloseSearch.TabIndex = 10;
            btnCloseSearch.TabStop = false;
            btnCloseSearch.Click += btnCloseSearch_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(5, 1);
            label14.Name = "label14";
            label14.Size = new Size(114, 21);
            label14.TabIndex = 1;
            label14.Text = "Datos Basicos";
            // 
            // textApellidos
            // 
            textApellidos.BorderStyle = BorderStyle.FixedSingle;
            textApellidos.Enabled = false;
            textApellidos.Location = new Point(89, 59);
            textApellidos.Name = "textApellidos";
            textApellidos.Size = new Size(133, 23);
            textApellidos.TabIndex = 28;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(10, 61);
            label21.Name = "label21";
            label21.Size = new Size(75, 20);
            label21.TabIndex = 27;
            label21.Text = "Apellidos:";
            // 
            // textNombres
            // 
            textNombres.BorderStyle = BorderStyle.FixedSingle;
            textNombres.Enabled = false;
            textNombres.Location = new Point(89, 30);
            textNombres.Name = "textNombres";
            textNombres.Size = new Size(133, 23);
            textNombres.TabIndex = 26;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(10, 31);
            label20.Name = "label20";
            label20.Size = new Size(73, 20);
            label20.TabIndex = 25;
            label20.Text = "Nombres:";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Red_dot;
            pictureBox7.Location = new Point(735, 6);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(12, 12);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 24;
            pictureBox7.TabStop = false;
            pictureBox7.Visible = false;
            // 
            // pictureCategoria
            // 
            pictureCategoria.Image = Properties.Resources.Gold_;
            pictureCategoria.Location = new Point(586, 129);
            pictureCategoria.Name = "pictureCategoria";
            pictureCategoria.Size = new Size(53, 50);
            pictureCategoria.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCategoria.TabIndex = 23;
            pictureCategoria.TabStop = false;
            pictureCategoria.Visible = false;
            // 
            // picturePerfil
            // 
            picturePerfil.Image = Properties.Resources.User;
            picturePerfil.Location = new Point(607, 28);
            picturePerfil.Name = "picturePerfil";
            picturePerfil.Size = new Size(140, 146);
            picturePerfil.SizeMode = PictureBoxSizeMode.Zoom;
            picturePerfil.TabIndex = 18;
            picturePerfil.TabStop = false;
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
            label7.Size = new Size(185, 21);
            label7.TabIndex = 0;
            label7.Text = "Registro de membresia";
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
            panel2.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Wpforms;
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
            panel3.Controls.Add(label8);
            panel3.Controls.Add(labelBase);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(iconBase);
            panel3.Controls.Add(labelCash);
            panel3.Controls.Add(labelTextFondo);
            panel3.Controls.Add(iconCash);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(397, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(430, 57);
            panel3.TabIndex = 6;
            // 
            // pictureAlerta
            // 
            pictureAlerta.Image = Properties.Resources.Alert;
            pictureAlerta.Location = new Point(5, 12);
            pictureAlerta.Name = "pictureAlerta";
            pictureAlerta.Size = new Size(30, 30);
            pictureAlerta.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAlerta.TabIndex = 97;
            pictureAlerta.TabStop = false;
            pictureAlerta.Visible = false;
            // 
            // labelAlerta
            // 
            labelAlerta.AutoSize = true;
            labelAlerta.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAlerta.ForeColor = Color.Orange;
            labelAlerta.Location = new Point(32, 17);
            labelAlerta.Name = "labelAlerta";
            labelAlerta.Size = new Size(117, 20);
            labelAlerta.TabIndex = 98;
            labelAlerta.Text = "Mensaje de alerta";
            labelAlerta.Visible = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(371, 29);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(15, 16);
            label8.TabIndex = 96;
            label8.Text = "$";
            // 
            // labelBase
            // 
            labelBase.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelBase.AutoSize = true;
            labelBase.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBase.ForeColor = Color.White;
            labelBase.Location = new Point(281, 30);
            labelBase.Margin = new Padding(4, 0, 4, 0);
            labelBase.Name = "labelBase";
            labelBase.Size = new Size(13, 15);
            labelBase.TabIndex = 95;
            labelBase.Text = "*";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(260, 27);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(15, 16);
            label11.TabIndex = 94;
            label11.Text = "$";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(261, 11);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(38, 12);
            label12.TabIndex = 93;
            label12.Text = "-BASE";
            // 
            // iconBase
            // 
            iconBase.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconBase.BackColor = SystemColors.MenuText;
            iconBase.ForeColor = Color.FromArgb(192, 64, 0);
            iconBase.IconChar = FontAwesome.Sharp.IconChar.Coins;
            iconBase.IconColor = Color.FromArgb(192, 64, 0);
            iconBase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBase.IconSize = 37;
            iconBase.Location = new Point(219, 12);
            iconBase.Margin = new Padding(4, 3, 4, 3);
            iconBase.Name = "iconBase";
            iconBase.Size = new Size(37, 37);
            iconBase.TabIndex = 92;
            iconBase.TabStop = false;
            // 
            // labelCash
            // 
            labelCash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCash.AutoSize = true;
            labelCash.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCash.ForeColor = Color.White;
            labelCash.Location = new Point(386, 30);
            labelCash.Margin = new Padding(4, 0, 4, 0);
            labelCash.Name = "labelCash";
            labelCash.Size = new Size(13, 16);
            labelCash.TabIndex = 90;
            labelCash.Text = "*";
            // 
            // labelTextFondo
            // 
            labelTextFondo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTextFondo.AutoSize = true;
            labelTextFondo.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTextFondo.ForeColor = Color.White;
            labelTextFondo.Location = new Point(370, 15);
            labelTextFondo.Margin = new Padding(4, 0, 4, 0);
            labelTextFondo.Name = "labelTextFondo";
            labelTextFondo.Size = new Size(42, 12);
            labelTextFondo.TabIndex = 91;
            labelTextFondo.Text = "VENTA";
            // 
            // iconCash
            // 
            iconCash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconCash.BackColor = SystemColors.MenuText;
            iconCash.ForeColor = Color.Gold;
            iconCash.IconChar = FontAwesome.Sharp.IconChar.Coins;
            iconCash.IconColor = Color.Gold;
            iconCash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCash.IconSize = 37;
            iconCash.Location = new Point(330, 12);
            iconCash.Margin = new Padding(4, 3, 4, 3);
            iconCash.Name = "iconCash";
            iconCash.Size = new Size(37, 37);
            iconCash.TabIndex = 89;
            iconCash.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(83, 12);
            label5.Name = "label5";
            label5.Size = new Size(315, 32);
            label5.TabIndex = 2;
            label5.Text = "GESTION DE MEMBRESIAS";
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
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.deleRojBlack;
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.False;
            // 
            // Deshacer
            // 
            Deshacer.HeaderText = "Deshacer";
            Deshacer.Image = Properties.Resources.Regresar;
            Deshacer.Name = "Deshacer";
            // 
            // FormMembresia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 542);
            Controls.Add(tabControlMembership);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMembresia";
            Text = "FormMembresia";
            tabControlMembership.ResumeLayout(false);
            tabGeneral.ResumeLayout(false);
            panelMembresia.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelContenedorClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridMiembro).EndInit();
            panelDownDataGrid.ResumeLayout(false);
            panelDownDataGrid.PerformLayout();
            panelTopDataGrid.ResumeLayout(false);
            panelTopDataGrid.PerformLayout();
            tabRegistro.ResumeLayout(false);
            panelDatosMembresia.ResumeLayout(false);
            panelDatosMembresia.PerformLayout();
            panelReporte.ResumeLayout(false);
            panelReporte.PerformLayout();
            panel18.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCloseSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePerfil).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAlerta).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconBase).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCash).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMembership;
        private TabPage tabGeneral;
        private Panel panelMembresia;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnProgreso;
        private FontAwesome.Sharp.IconButton btnAddMembership;
        private FontAwesome.Sharp.IconButton btnUpdateMembership;
        private Panel panelContenedorClient;
        private DataGridView dataGridMiembro;
        private Panel panelDownDataGrid;
        private TextBox textHombres;
        private Label label3;
        private TextBox textTotal;
        private TextBox textMujeres;
        private Label label4;
        private Label label2;
        private Panel panelTopDataGrid;
        private ComboBox comboFiltroCategoria;
        private Label label1;
        private TabPage tabRegistro;
        private Panel panelDatosMembresia;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private Panel panel8;
        private Label label10;
        private Panel panel7;
        private PictureBox picturePerfil;
        private TextBox textCodigoMiembro;
        private Label label18;
        private Panel panel4;
        private Label label7;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel3;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnVolver;
        private ComboBox comboCategoria;
        private Label label19;
        private PictureBox pictureCategoria;
        private PictureBox pictureBox7;
        private TextBox textApellidos;
        private Label label21;
        private TextBox textNombres;
        private Label label20;
        private Panel panelReporte;
        private Panel panel18;
        private Label label22;
        private Label label23;
        private TextBox textSaldo;
        private TextBox textAbono;
        private TextBox textValorMensual;
        private Label label24;
        private Label label25;
        private Label labelValorMensualidad;
        private Label label27;
        private Label labelValorInscripcion;
        private Label labelTotalAPagar;
        private Label label31;
        private Label label8;
        private Label labelBase;
        private Label label11;
        private Label label12;
        private FontAwesome.Sharp.IconPictureBox iconBase;
        private Label labelCash;
        private Label labelTextFondo;
        private FontAwesome.Sharp.IconPictureBox iconCash;
        private ComboBox comboPlan;
        private Label label13;
        private Panel panel5;
        private FontAwesome.Sharp.IconPictureBox btnSearch;
        private TextBox textSearch;
        private FontAwesome.Sharp.IconPictureBox btnCloseSearch;
        private Label label14;
        private PictureBox pictureAlerta;
        private Label labelAlerta;
        private FontAwesome.Sharp.IconButton btnModificarCliente;
        private Label labelCantidadCreditos;
        private Label label29;
        private ComboBox comboEstado;
        private FontAwesome.Sharp.IconButton btnEnviarReporte;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewImageColumn Deshacer;
    }
}