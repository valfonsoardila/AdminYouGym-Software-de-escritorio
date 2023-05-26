namespace UI
{
    partial class FormGestionPoducto
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
            tabControlCliente = new TabControl();
            tabGeneral = new TabPage();
            panelClient = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnProgreso = new FontAwesome.Sharp.IconButton();
            btnAddClient = new FontAwesome.Sharp.IconButton();
            btnUpdateClient = new FontAwesome.Sharp.IconButton();
            panelContenedorClient = new Panel();
            dataGridProductos = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            Eliminar = new DataGridViewImageColumn();
            Cash = new DataGridViewImageColumn();
            Vencido = new DataGridViewImageColumn();
            CantidadVenta = new DataGridViewTextBoxColumn();
            panelDownDataGrid = new Panel();
            textVencido = new TextBox();
            labelTotalVencido = new Label();
            textCuarentena = new TextBox();
            labelCuarentena = new Label();
            textVigentes = new TextBox();
            labelVigentes = new Label();
            textTotal = new TextBox();
            labelTotalFarmacos = new Label();
            labelExportar = new Label();
            btnRespaldarInventario = new FontAwesome.Sharp.IconButton();
            textNumeroPagina = new TextBox();
            labelTitlePagina = new Label();
            btnPaginaAnterior = new FontAwesome.Sharp.IconPictureBox();
            btnSiguientePagina = new FontAwesome.Sharp.IconPictureBox();
            panelTopDataGrid = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconCloseSearch = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            comboFiltroEstado = new ComboBox();
            comboFiltroUbicacion = new ComboBox();
            label1 = new Label();
            tabNuevoProducto = new TabPage();
            tabVencido = new TabPage();
            tabVendidos = new TabPage();
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            label29 = new Label();
            labelBase = new Label();
            label30 = new Label();
            label31 = new Label();
            iconBase = new FontAwesome.Sharp.IconPictureBox();
            labelCash = new Label();
            labelTextFondo = new Label();
            iconCash = new FontAwesome.Sharp.IconPictureBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            btnVolver = new FontAwesome.Sharp.IconButton();
            tabControlCliente.SuspendLayout();
            tabGeneral.SuspendLayout();
            panelClient.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panelContenedorClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            panelDownDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnPaginaAnterior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSiguientePagina).BeginInit();
            panelTopDataGrid.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconBase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControlCliente
            // 
            tabControlCliente.Controls.Add(tabGeneral);
            tabControlCliente.Controls.Add(tabNuevoProducto);
            tabControlCliente.Controls.Add(tabVencido);
            tabControlCliente.Controls.Add(tabVendidos);
            tabControlCliente.Location = new Point(0, 62);
            tabControlCliente.Name = "tabControlCliente";
            tabControlCliente.SelectedIndex = 0;
            tabControlCliente.Size = new Size(847, 474);
            tabControlCliente.TabIndex = 4;
            // 
            // tabGeneral
            // 
            tabGeneral.Controls.Add(panelClient);
            tabGeneral.Location = new Point(4, 24);
            tabGeneral.Name = "tabGeneral";
            tabGeneral.Padding = new Padding(3);
            tabGeneral.Size = new Size(839, 446);
            tabGeneral.TabIndex = 0;
            tabGeneral.Text = "General";
            tabGeneral.UseVisualStyleBackColor = true;
            // 
            // panelClient
            // 
            panelClient.Controls.Add(panel4);
            panelClient.Controls.Add(panel1);
            panelClient.Controls.Add(panelContenedorClient);
            panelClient.Dock = DockStyle.Fill;
            panelClient.Location = new Point(3, 3);
            panelClient.Name = "panelClient";
            panelClient.Size = new Size(833, 440);
            panelClient.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 368);
            panel4.Name = "panel4";
            panel4.Size = new Size(833, 27);
            panel4.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(419, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(414, 27);
            panel6.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(176, 3);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 65;
            label3.Text = "Venta";
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(420, 27);
            panel5.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(127, 2);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 64;
            label2.Text = "Menu productos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(btnProgreso);
            panel1.Controls.Add(btnAddClient);
            panel1.Controls.Add(btnUpdateClient);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 395);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 45);
            panel1.TabIndex = 1;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Gold;
            iconButton2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Warning;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 32;
            iconButton2.Location = new Point(258, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(115, 40);
            iconButton2.TabIndex = 6;
            iconButton2.Text = "Vencidos";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Gold;
            iconButton1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(141, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(115, 40);
            iconButton1.TabIndex = 5;
            iconButton1.Text = "Modificar";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnProgreso
            // 
            btnProgreso.BackColor = Color.Firebrick;
            btnProgreso.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnProgreso.ForeColor = SystemColors.ControlLightLight;
            btnProgreso.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            btnProgreso.IconColor = Color.White;
            btnProgreso.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnProgreso.IconSize = 32;
            btnProgreso.Location = new Point(516, 3);
            btnProgreso.Name = "btnProgreso";
            btnProgreso.Size = new Size(112, 40);
            btnProgreso.TabIndex = 4;
            btnProgreso.Text = "Vendidos";
            btnProgreso.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProgreso.UseVisualStyleBackColor = false;
            // 
            // btnAddClient
            // 
            btnAddClient.BackColor = Color.LimeGreen;
            btnAddClient.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddClient.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            btnAddClient.IconColor = Color.Black;
            btnAddClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddClient.IconSize = 32;
            btnAddClient.Location = new Point(627, 3);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(106, 40);
            btnAddClient.TabIndex = 1;
            btnAddClient.Text = "Vender";
            btnAddClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddClient.UseVisualStyleBackColor = false;
            // 
            // btnUpdateClient
            // 
            btnUpdateClient.BackColor = Color.Gold;
            btnUpdateClient.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateClient.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnUpdateClient.IconColor = Color.Black;
            btnUpdateClient.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnUpdateClient.IconSize = 32;
            btnUpdateClient.Location = new Point(25, 3);
            btnUpdateClient.Name = "btnUpdateClient";
            btnUpdateClient.Size = new Size(115, 40);
            btnUpdateClient.TabIndex = 2;
            btnUpdateClient.Text = "Agregar";
            btnUpdateClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateClient.UseVisualStyleBackColor = false;
            // 
            // panelContenedorClient
            // 
            panelContenedorClient.Controls.Add(dataGridProductos);
            panelContenedorClient.Controls.Add(panelDownDataGrid);
            panelContenedorClient.Controls.Add(panelTopDataGrid);
            panelContenedorClient.Dock = DockStyle.Top;
            panelContenedorClient.Location = new Point(0, 0);
            panelContenedorClient.Name = "panelContenedorClient";
            panelContenedorClient.Size = new Size(833, 368);
            panelContenedorClient.TabIndex = 0;
            // 
            // dataGridProductos
            // 
            dataGridProductos.AllowUserToAddRows = false;
            dataGridProductos.AllowUserToResizeColumns = false;
            dataGridProductos.AllowUserToResizeRows = false;
            dataGridProductos.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductos.Columns.AddRange(new DataGridViewColumn[] { Column1, Eliminar, Cash, Vencido, CantidadVenta });
            dataGridProductos.Cursor = Cursors.Hand;
            dataGridProductos.Dock = DockStyle.Fill;
            dataGridProductos.GridColor = Color.WhiteSmoke;
            dataGridProductos.Location = new Point(0, 29);
            dataGridProductos.Margin = new Padding(4, 3, 4, 3);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.RightToLeft = RightToLeft.No;
            dataGridProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridProductos.RowHeadersVisible = false;
            dataGridProductos.Size = new Size(833, 309);
            dataGridProductos.TabIndex = 78;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "Seleccionar";
            Column1.Name = "Column1";
            Column1.Width = 30;
            // 
            // Eliminar
            // 
            Eliminar.Description = "Seleccionar";
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.deleRojBlack;
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 30;
            // 
            // Cash
            // 
            Cash.HeaderText = "Vender";
            Cash.Image = Properties.Resources.cash;
            Cash.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Cash.Name = "Cash";
            Cash.Width = 30;
            // 
            // Vencido
            // 
            Vencido.HeaderText = "Vencido";
            Vencido.Image = Properties.Resources.SacarDeInventario;
            Vencido.Name = "Vencido";
            Vencido.Width = 30;
            // 
            // CantidadVenta
            // 
            CantidadVenta.HeaderText = "CantidadVenta";
            CantidadVenta.Name = "CantidadVenta";
            CantidadVenta.Width = 80;
            // 
            // panelDownDataGrid
            // 
            panelDownDataGrid.BackColor = Color.Gainsboro;
            panelDownDataGrid.Controls.Add(textVencido);
            panelDownDataGrid.Controls.Add(labelTotalVencido);
            panelDownDataGrid.Controls.Add(textCuarentena);
            panelDownDataGrid.Controls.Add(labelCuarentena);
            panelDownDataGrid.Controls.Add(textVigentes);
            panelDownDataGrid.Controls.Add(labelVigentes);
            panelDownDataGrid.Controls.Add(textTotal);
            panelDownDataGrid.Controls.Add(labelTotalFarmacos);
            panelDownDataGrid.Controls.Add(labelExportar);
            panelDownDataGrid.Controls.Add(btnRespaldarInventario);
            panelDownDataGrid.Controls.Add(textNumeroPagina);
            panelDownDataGrid.Controls.Add(labelTitlePagina);
            panelDownDataGrid.Controls.Add(btnPaginaAnterior);
            panelDownDataGrid.Controls.Add(btnSiguientePagina);
            panelDownDataGrid.Dock = DockStyle.Bottom;
            panelDownDataGrid.Location = new Point(0, 338);
            panelDownDataGrid.Name = "panelDownDataGrid";
            panelDownDataGrid.Size = new Size(833, 30);
            panelDownDataGrid.TabIndex = 1;
            // 
            // textVencido
            // 
            textVencido.BorderStyle = BorderStyle.FixedSingle;
            textVencido.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textVencido.Location = new Point(560, 3);
            textVencido.Margin = new Padding(4, 3, 4, 3);
            textVencido.Name = "textVencido";
            textVencido.Size = new Size(46, 25);
            textVencido.TabIndex = 77;
            textVencido.Text = "0";
            textVencido.TextAlign = HorizontalAlignment.Center;
            // 
            // labelTotalVencido
            // 
            labelTotalVencido.AutoSize = true;
            labelTotalVencido.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalVencido.Location = new Point(470, 9);
            labelTotalVencido.Margin = new Padding(4, 0, 4, 0);
            labelTotalVencido.Name = "labelTotalVencido";
            labelTotalVencido.Size = new Size(90, 13);
            labelTotalVencido.TabIndex = 76;
            labelTotalVencido.Text = "Total Vencido:";
            // 
            // textCuarentena
            // 
            textCuarentena.BorderStyle = BorderStyle.FixedSingle;
            textCuarentena.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textCuarentena.Location = new Point(419, 3);
            textCuarentena.Margin = new Padding(4, 3, 4, 3);
            textCuarentena.Name = "textCuarentena";
            textCuarentena.Size = new Size(49, 25);
            textCuarentena.TabIndex = 75;
            textCuarentena.Text = "0";
            textCuarentena.TextAlign = HorizontalAlignment.Center;
            // 
            // labelCuarentena
            // 
            labelCuarentena.AutoSize = true;
            labelCuarentena.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCuarentena.Location = new Point(311, 9);
            labelCuarentena.Margin = new Padding(4, 0, 4, 0);
            labelCuarentena.Name = "labelCuarentena";
            labelCuarentena.Size = new Size(109, 13);
            labelCuarentena.TabIndex = 74;
            labelCuarentena.Text = "Total Cuarentena:";
            // 
            // textVigentes
            // 
            textVigentes.BorderStyle = BorderStyle.FixedSingle;
            textVigentes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textVigentes.Location = new Point(261, 3);
            textVigentes.Margin = new Padding(4, 3, 4, 3);
            textVigentes.Name = "textVigentes";
            textVigentes.Size = new Size(48, 25);
            textVigentes.TabIndex = 72;
            textVigentes.Text = "0";
            textVigentes.TextAlign = HorizontalAlignment.Center;
            // 
            // labelVigentes
            // 
            labelVigentes.AutoSize = true;
            labelVigentes.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelVigentes.Location = new Point(168, 9);
            labelVigentes.Margin = new Padding(4, 0, 4, 0);
            labelVigentes.Name = "labelVigentes";
            labelVigentes.Size = new Size(93, 13);
            labelVigentes.TabIndex = 73;
            labelVigentes.Text = "Total Vigentes:";
            // 
            // textTotal
            // 
            textTotal.BorderStyle = BorderStyle.FixedSingle;
            textTotal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textTotal.Location = new Point(118, 3);
            textTotal.Margin = new Padding(4, 3, 4, 3);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(48, 25);
            textTotal.TabIndex = 70;
            textTotal.Text = "0";
            textTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // labelTotalFarmacos
            // 
            labelTotalFarmacos.AutoSize = true;
            labelTotalFarmacos.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalFarmacos.Location = new Point(6, 9);
            labelTotalFarmacos.Margin = new Padding(4, 0, 4, 0);
            labelTotalFarmacos.Name = "labelTotalFarmacos";
            labelTotalFarmacos.Size = new Size(111, 13);
            labelTotalFarmacos.TabIndex = 71;
            labelTotalFarmacos.Text = "Total Registrados:";
            // 
            // labelExportar
            // 
            labelExportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelExportar.AutoSize = true;
            labelExportar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelExportar.Location = new Point(624, 6);
            labelExportar.Margin = new Padding(4, 0, 4, 0);
            labelExportar.Name = "labelExportar";
            labelExportar.Size = new Size(64, 17);
            labelExportar.TabIndex = 64;
            labelExportar.Text = "Exportar:";
            labelExportar.Visible = false;
            // 
            // btnRespaldarInventario
            // 
            btnRespaldarInventario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRespaldarInventario.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            btnRespaldarInventario.IconColor = Color.DarkGreen;
            btnRespaldarInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRespaldarInventario.IconSize = 18;
            btnRespaldarInventario.Location = new Point(687, 2);
            btnRespaldarInventario.Margin = new Padding(4, 3, 4, 3);
            btnRespaldarInventario.Name = "btnRespaldarInventario";
            btnRespaldarInventario.Size = new Size(26, 27);
            btnRespaldarInventario.TabIndex = 69;
            btnRespaldarInventario.UseVisualStyleBackColor = true;
            btnRespaldarInventario.Visible = false;
            // 
            // textNumeroPagina
            // 
            textNumeroPagina.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textNumeroPagina.BackColor = SystemColors.Control;
            textNumeroPagina.BorderStyle = BorderStyle.None;
            textNumeroPagina.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textNumeroPagina.Location = new Point(788, 6);
            textNumeroPagina.Margin = new Padding(4, 3, 4, 3);
            textNumeroPagina.Name = "textNumeroPagina";
            textNumeroPagina.Size = new Size(15, 18);
            textNumeroPagina.TabIndex = 68;
            textNumeroPagina.Text = "0";
            textNumeroPagina.TextAlign = HorizontalAlignment.Center;
            // 
            // labelTitlePagina
            // 
            labelTitlePagina.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTitlePagina.AutoSize = true;
            labelTitlePagina.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitlePagina.Location = new Point(737, 8);
            labelTitlePagina.Margin = new Padding(4, 0, 4, 0);
            labelTitlePagina.Name = "labelTitlePagina";
            labelTitlePagina.Size = new Size(46, 13);
            labelTitlePagina.TabIndex = 67;
            labelTitlePagina.Text = "Pàgina";
            // 
            // btnPaginaAnterior
            // 
            btnPaginaAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPaginaAnterior.BackColor = Color.Gainsboro;
            btnPaginaAnterior.Cursor = Cursors.Hand;
            btnPaginaAnterior.ForeColor = SystemColors.ControlText;
            btnPaginaAnterior.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            btnPaginaAnterior.IconColor = SystemColors.ControlText;
            btnPaginaAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPaginaAnterior.IconSize = 23;
            btnPaginaAnterior.Location = new Point(714, 4);
            btnPaginaAnterior.Margin = new Padding(4, 3, 4, 3);
            btnPaginaAnterior.Name = "btnPaginaAnterior";
            btnPaginaAnterior.Size = new Size(23, 23);
            btnPaginaAnterior.TabIndex = 66;
            btnPaginaAnterior.TabStop = false;
            // 
            // btnSiguientePagina
            // 
            btnSiguientePagina.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSiguientePagina.BackColor = Color.Gainsboro;
            btnSiguientePagina.Cursor = Cursors.Hand;
            btnSiguientePagina.ForeColor = SystemColors.ControlText;
            btnSiguientePagina.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            btnSiguientePagina.IconColor = SystemColors.ControlText;
            btnSiguientePagina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSiguientePagina.IconSize = 23;
            btnSiguientePagina.Location = new Point(806, 4);
            btnSiguientePagina.Margin = new Padding(4, 3, 4, 3);
            btnSiguientePagina.Name = "btnSiguientePagina";
            btnSiguientePagina.Size = new Size(23, 23);
            btnSiguientePagina.TabIndex = 65;
            btnSiguientePagina.TabStop = false;
            // 
            // panelTopDataGrid
            // 
            panelTopDataGrid.BackColor = Color.Gainsboro;
            panelTopDataGrid.Controls.Add(iconButton4);
            panelTopDataGrid.Controls.Add(iconCloseSearch);
            panelTopDataGrid.Controls.Add(textBox1);
            panelTopDataGrid.Controls.Add(btnRefresh);
            panelTopDataGrid.Controls.Add(comboFiltroEstado);
            panelTopDataGrid.Controls.Add(comboFiltroUbicacion);
            panelTopDataGrid.Controls.Add(label1);
            panelTopDataGrid.Dock = DockStyle.Top;
            panelTopDataGrid.Location = new Point(0, 0);
            panelTopDataGrid.Name = "panelTopDataGrid";
            panelTopDataGrid.Size = new Size(833, 29);
            panelTopDataGrid.TabIndex = 0;
            // 
            // iconButton4
            // 
            iconButton4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton4.Cursor = Cursors.Hand;
            iconButton4.FlatAppearance.BorderColor = Color.FromArgb(170, 170, 173);
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            iconButton4.FlatAppearance.MouseOverBackColor = Color.DimGray;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = SystemColors.ControlDark;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton4.IconSize = 20;
            iconButton4.Location = new Point(805, 3);
            iconButton4.Margin = new Padding(4, 3, 4, 3);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(24, 24);
            iconButton4.TabIndex = 81;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconCloseSearch
            // 
            iconCloseSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconCloseSearch.Cursor = Cursors.Hand;
            iconCloseSearch.FlatAppearance.BorderColor = Color.FromArgb(170, 170, 173);
            iconCloseSearch.FlatAppearance.BorderSize = 0;
            iconCloseSearch.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            iconCloseSearch.FlatAppearance.MouseOverBackColor = Color.DimGray;
            iconCloseSearch.FlatStyle = FlatStyle.Flat;
            iconCloseSearch.ForeColor = SystemColors.ControlDark;
            iconCloseSearch.IconChar = FontAwesome.Sharp.IconChar.X;
            iconCloseSearch.IconColor = Color.Red;
            iconCloseSearch.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconCloseSearch.IconSize = 20;
            iconCloseSearch.Location = new Point(804, 3);
            iconCloseSearch.Margin = new Padding(4, 3, 4, 3);
            iconCloseSearch.Name = "iconCloseSearch";
            iconCloseSearch.Size = new Size(24, 24);
            iconCloseSearch.TabIndex = 80;
            iconCloseSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(650, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 27);
            textBox1.TabIndex = 79;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(170, 170, 173);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = SystemColors.ControlDark;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btnRefresh.IconColor = SystemColors.ActiveCaptionText;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnRefresh.IconSize = 24;
            btnRefresh.Location = new Point(517, 3);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(24, 24);
            btnRefresh.TabIndex = 63;
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // comboFiltroEstado
            // 
            comboFiltroEstado.BackColor = SystemColors.Window;
            comboFiltroEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboFiltroEstado.FormattingEnabled = true;
            comboFiltroEstado.Items.AddRange(new object[] { "Vigente", "Cuarentena", "Vencido" });
            comboFiltroEstado.Location = new Point(389, 0);
            comboFiltroEstado.Name = "comboFiltroEstado";
            comboFiltroEstado.Size = new Size(121, 28);
            comboFiltroEstado.TabIndex = 3;
            comboFiltroEstado.Text = "Filtro estado";
            // 
            // comboFiltroUbicacion
            // 
            comboFiltroUbicacion.BackColor = SystemColors.Window;
            comboFiltroUbicacion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboFiltroUbicacion.FormattingEnabled = true;
            comboFiltroUbicacion.Items.AddRange(new object[] { "M", "F", "Otro" });
            comboFiltroUbicacion.Location = new Point(256, 0);
            comboFiltroUbicacion.Name = "comboFiltroUbicacion";
            comboFiltroUbicacion.Size = new Size(129, 28);
            comboFiltroUbicacion.TabIndex = 2;
            comboFiltroUbicacion.Text = "Filtro ubicacion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 0;
            label1.Text = "Lista de productos";
            // 
            // tabNuevoProducto
            // 
            tabNuevoProducto.Location = new Point(4, 24);
            tabNuevoProducto.Name = "tabNuevoProducto";
            tabNuevoProducto.Size = new Size(839, 446);
            tabNuevoProducto.TabIndex = 1;
            tabNuevoProducto.Text = "Nuevo producto";
            tabNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // tabVencido
            // 
            tabVencido.Location = new Point(4, 24);
            tabVencido.Name = "tabVencido";
            tabVencido.Size = new Size(839, 446);
            tabVencido.TabIndex = 2;
            tabVencido.Text = "Vencidos";
            tabVencido.UseVisualStyleBackColor = true;
            // 
            // tabVendidos
            // 
            tabVendidos.Location = new Point(4, 24);
            tabVendidos.Name = "tabVendidos";
            tabVendidos.Size = new Size(839, 446);
            tabVendidos.TabIndex = 3;
            tabVendidos.Text = "Vendidos";
            tabVendidos.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnVolver);
            panel2.Location = new Point(0, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 57);
            panel2.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BottleWater;
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
            panel3.Controls.Add(label29);
            panel3.Controls.Add(labelBase);
            panel3.Controls.Add(label30);
            panel3.Controls.Add(label31);
            panel3.Controls.Add(iconBase);
            panel3.Controls.Add(labelCash);
            panel3.Controls.Add(labelTextFondo);
            panel3.Controls.Add(iconCash);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(382, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(468, 57);
            panel3.TabIndex = 6;
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label29.AutoSize = true;
            label29.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label29.ForeColor = Color.White;
            label29.Location = new Point(397, 27);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(15, 16);
            label29.TabIndex = 88;
            label29.Text = "$";
            // 
            // labelBase
            // 
            labelBase.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelBase.AutoSize = true;
            labelBase.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBase.ForeColor = Color.White;
            labelBase.Location = new Point(299, 28);
            labelBase.Margin = new Padding(4, 0, 4, 0);
            labelBase.Name = "labelBase";
            labelBase.Size = new Size(13, 15);
            labelBase.TabIndex = 87;
            labelBase.Text = "*";
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label30.AutoSize = true;
            label30.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label30.ForeColor = Color.White;
            label30.Location = new Point(278, 25);
            label30.Margin = new Padding(4, 0, 4, 0);
            label30.Name = "label30";
            label30.Size = new Size(15, 16);
            label30.TabIndex = 86;
            label30.Text = "$";
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label31.AutoSize = true;
            label31.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label31.ForeColor = Color.White;
            label31.Location = new Point(279, 9);
            label31.Margin = new Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new Size(38, 12);
            label31.TabIndex = 85;
            label31.Text = "-BASE";
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
            iconBase.Location = new Point(237, 10);
            iconBase.Margin = new Padding(4, 3, 4, 3);
            iconBase.Name = "iconBase";
            iconBase.Size = new Size(37, 37);
            iconBase.TabIndex = 84;
            iconBase.TabStop = false;
            // 
            // labelCash
            // 
            labelCash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCash.AutoSize = true;
            labelCash.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCash.ForeColor = Color.White;
            labelCash.Location = new Point(417, 28);
            labelCash.Margin = new Padding(4, 0, 4, 0);
            labelCash.Name = "labelCash";
            labelCash.Size = new Size(13, 16);
            labelCash.TabIndex = 82;
            labelCash.Text = "*";
            // 
            // labelTextFondo
            // 
            labelTextFondo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTextFondo.AutoSize = true;
            labelTextFondo.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTextFondo.ForeColor = Color.White;
            labelTextFondo.Location = new Point(396, 13);
            labelTextFondo.Margin = new Padding(4, 0, 4, 0);
            labelTextFondo.Name = "labelTextFondo";
            labelTextFondo.Size = new Size(42, 12);
            labelTextFondo.TabIndex = 83;
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
            iconCash.Location = new Point(356, 10);
            iconCash.Margin = new Padding(4, 3, 4, 3);
            iconCash.Name = "iconCash";
            iconCash.Size = new Size(37, 37);
            iconCash.TabIndex = 81;
            iconCash.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(58, 16);
            label6.Name = "label6";
            label6.Size = new Size(168, 25);
            label6.TabIndex = 9;
            label6.Text = "Mensaje de alerta";
            label6.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Alert;
            pictureBox1.Location = new Point(14, 8);
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
            label5.Location = new Point(77, 12);
            label5.Name = "label5";
            label5.Size = new Size(304, 32);
            label5.TabIndex = 2;
            label5.Text = "GESTION DE PRODUCTOS";
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
            // FormGestionPoducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 542);
            Controls.Add(tabControlCliente);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionPoducto";
            Text = "FormGestionPoducto";
            tabControlCliente.ResumeLayout(false);
            tabGeneral.ResumeLayout(false);
            panelClient.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panelContenedorClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            panelDownDataGrid.ResumeLayout(false);
            panelDownDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnPaginaAnterior).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSiguientePagina).EndInit();
            panelTopDataGrid.ResumeLayout(false);
            panelTopDataGrid.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconBase).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCash).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlCliente;
        private TabPage tabGeneral;
        private Panel panelClient;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnProgreso;
        private FontAwesome.Sharp.IconButton btnAddClient;
        private FontAwesome.Sharp.IconButton btnUpdateClient;
        private Panel panelContenedorClient;
        private Panel panelDownDataGrid;
        private Panel panelTopDataGrid;
        private Label label1;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel3;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnVolver;
        private Label label29;
        private Label labelBase;
        private Label label30;
        private Label label31;
        private FontAwesome.Sharp.IconPictureBox iconBase;
        private Label labelCash;
        private Label labelTextFondo;
        private FontAwesome.Sharp.IconPictureBox iconCash;
        private TabPage tabNuevoProducto;
        private TabPage tabVencido;
        private TabPage tabVendidos;
        private Label labelExportar;
        private FontAwesome.Sharp.IconButton btnRespaldarInventario;
        private TextBox textNumeroPagina;
        private Label labelTitlePagina;
        private FontAwesome.Sharp.IconPictureBox btnPaginaAnterior;
        private FontAwesome.Sharp.IconPictureBox btnSiguientePagina;
        private TextBox textVencido;
        private Label labelTotalVencido;
        private TextBox textCuarentena;
        private Label labelCuarentena;
        private TextBox textVigentes;
        private Label labelVigentes;
        private TextBox textTotal;
        private Label labelTotalFarmacos;
        private DataGridView dataGridProductos;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewImageColumn Cash;
        private DataGridViewImageColumn Vencido;
        private DataGridViewTextBoxColumn CantidadVenta;
        private ComboBox comboFiltroEstado;
        private ComboBox comboFiltroUbicacion;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private Panel panel4;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel6;
        private Label label3;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconCloseSearch;
    }
}