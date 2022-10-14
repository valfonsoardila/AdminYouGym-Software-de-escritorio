
namespace Presentacion
{
    partial class FormGestionarEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionarEntrenador));
            this.panelDatagridEntrenadores = new System.Windows.Forms.Panel();
            this.DataGridEntrenadores = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelTittleDataGrid = new Bunifu.UI.WinForms.BunifuPanel();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.labelListaDeCajas = new System.Windows.Forms.Label();
            this.panelSubDataGrid = new Bunifu.UI.WinForms.BunifuPanel();
            this.textTotalMujeres = new System.Windows.Forms.TextBox();
            this.labelCajasCerradas = new System.Windows.Forms.Label();
            this.textTotalHombres = new System.Windows.Forms.TextBox();
            this.labelTotalHombres = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelOpcionMenu = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnFirmarContrato = new FontAwesome.Sharp.IconButton();
            this.btnModificarEntrenador = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarEntrenador = new FontAwesome.Sharp.IconButton();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.labelTitleEntrenador = new System.Windows.Forms.Label();
            this.labelTextFondo = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.iconCash = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAviso = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.labelAviso = new FontAwesome.Sharp.IconButton();
            this.panelDatagridEntrenadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEntrenadores)).BeginInit();
            this.panelTittleDataGrid.SuspendLayout();
            this.panelSubDataGrid.SuspendLayout();
            this.panelOpcionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCash)).BeginInit();
            this.panelAviso.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatagridEntrenadores
            // 
            this.panelDatagridEntrenadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatagridEntrenadores.Controls.Add(this.DataGridEntrenadores);
            this.panelDatagridEntrenadores.Controls.Add(this.panelTittleDataGrid);
            this.panelDatagridEntrenadores.Controls.Add(this.panelSubDataGrid);
            this.panelDatagridEntrenadores.Controls.Add(this.panelOpcionMenu);
            this.panelDatagridEntrenadores.Location = new System.Drawing.Point(11, 140);
            this.panelDatagridEntrenadores.Name = "panelDatagridEntrenadores";
            this.panelDatagridEntrenadores.Size = new System.Drawing.Size(766, 369);
            this.panelDatagridEntrenadores.TabIndex = 46;
            // 
            // DataGridEntrenadores
            // 
            this.DataGridEntrenadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridEntrenadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.DataGridEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEntrenadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.DataGridEntrenadores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.DataGridEntrenadores.Location = new System.Drawing.Point(2, 29);
            this.DataGridEntrenadores.Name = "DataGridEntrenadores";
            this.DataGridEntrenadores.Size = new System.Drawing.Size(645, 312);
            this.DataGridEntrenadores.TabIndex = 38;
            this.DataGridEntrenadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEntrenadores_CellClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Presentacion.Properties.Resources.deleRojWhite;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 50;
            // 
            // panelTittleDataGrid
            // 
            this.panelTittleDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTittleDataGrid.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelTittleDataGrid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTittleDataGrid.BackgroundImage")));
            this.panelTittleDataGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTittleDataGrid.BorderColor = System.Drawing.Color.Transparent;
            this.panelTittleDataGrid.BorderRadius = 3;
            this.panelTittleDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTittleDataGrid.BorderThickness = 1;
            this.panelTittleDataGrid.Controls.Add(this.comboSexo);
            this.panelTittleDataGrid.Controls.Add(this.labelFiltro);
            this.panelTittleDataGrid.Controls.Add(this.labelListaDeCajas);
            this.panelTittleDataGrid.Location = new System.Drawing.Point(3, 3);
            this.panelTittleDataGrid.Name = "panelTittleDataGrid";
            this.panelTittleDataGrid.ShowBorders = true;
            this.panelTittleDataGrid.Size = new System.Drawing.Size(764, 26);
            this.panelTittleDataGrid.TabIndex = 31;
            // 
            // comboSexo
            // 
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "Todos",
            "Femenino",
            "Masculino"});
            this.comboSexo.Location = new System.Drawing.Point(246, 1);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(121, 21);
            this.comboSexo.TabIndex = 21;
            this.comboSexo.Text = "Todos";
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFiltro.Location = new System.Drawing.Point(208, 6);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(32, 13);
            this.labelFiltro.TabIndex = 20;
            this.labelFiltro.Text = "Filtro:";
            // 
            // labelListaDeCajas
            // 
            this.labelListaDeCajas.AutoSize = true;
            this.labelListaDeCajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaDeCajas.ForeColor = System.Drawing.Color.DarkGray;
            this.labelListaDeCajas.Location = new System.Drawing.Point(2, 3);
            this.labelListaDeCajas.Name = "labelListaDeCajas";
            this.labelListaDeCajas.Size = new System.Drawing.Size(183, 15);
            this.labelListaDeCajas.TabIndex = 19;
            this.labelListaDeCajas.Text = "LISTA DE ENTRENADORES";
            // 
            // panelSubDataGrid
            // 
            this.panelSubDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSubDataGrid.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelSubDataGrid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSubDataGrid.BackgroundImage")));
            this.panelSubDataGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSubDataGrid.BorderColor = System.Drawing.Color.Transparent;
            this.panelSubDataGrid.BorderRadius = 3;
            this.panelSubDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSubDataGrid.BorderThickness = 1;
            this.panelSubDataGrid.Controls.Add(this.textTotalMujeres);
            this.panelSubDataGrid.Controls.Add(this.labelCajasCerradas);
            this.panelSubDataGrid.Controls.Add(this.textTotalHombres);
            this.panelSubDataGrid.Controls.Add(this.labelTotalHombres);
            this.panelSubDataGrid.Controls.Add(this.textTotal);
            this.panelSubDataGrid.Controls.Add(this.labelTotal);
            this.panelSubDataGrid.Location = new System.Drawing.Point(2, 343);
            this.panelSubDataGrid.Name = "panelSubDataGrid";
            this.panelSubDataGrid.ShowBorders = true;
            this.panelSubDataGrid.Size = new System.Drawing.Size(764, 26);
            this.panelSubDataGrid.TabIndex = 32;
            // 
            // textTotalMujeres
            // 
            this.textTotalMujeres.Location = new System.Drawing.Point(459, 2);
            this.textTotalMujeres.Name = "textTotalMujeres";
            this.textTotalMujeres.Size = new System.Drawing.Size(78, 20);
            this.textTotalMujeres.TabIndex = 25;
            // 
            // labelCajasCerradas
            // 
            this.labelCajasCerradas.AutoSize = true;
            this.labelCajasCerradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCajasCerradas.ForeColor = System.Drawing.Color.DarkGray;
            this.labelCajasCerradas.Location = new System.Drawing.Point(354, 6);
            this.labelCajasCerradas.Name = "labelCajasCerradas";
            this.labelCajasCerradas.Size = new System.Drawing.Size(99, 12);
            this.labelCajasCerradas.TabIndex = 24;
            this.labelCajasCerradas.Text = "TOTAL MUJERES:";
            // 
            // textTotalHombres
            // 
            this.textTotalHombres.Location = new System.Drawing.Point(268, 2);
            this.textTotalHombres.Name = "textTotalHombres";
            this.textTotalHombres.Size = new System.Drawing.Size(78, 20);
            this.textTotalHombres.TabIndex = 23;
            // 
            // labelTotalHombres
            // 
            this.labelTotalHombres.AutoSize = true;
            this.labelTotalHombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalHombres.ForeColor = System.Drawing.Color.DarkGray;
            this.labelTotalHombres.Location = new System.Drawing.Point(162, 7);
            this.labelTotalHombres.Name = "labelTotalHombres";
            this.labelTotalHombres.Size = new System.Drawing.Size(101, 12);
            this.labelTotalHombres.TabIndex = 22;
            this.labelTotalHombres.Text = "TOTAL HOMBRES:";
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(75, 2);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(78, 20);
            this.textTotal.TabIndex = 21;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.DarkGray;
            this.labelTotal.Location = new System.Drawing.Point(26, 7);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(43, 12);
            this.labelTotal.TabIndex = 20;
            this.labelTotal.Text = "TOTAL:";
            // 
            // panelOpcionMenu
            // 
            this.panelOpcionMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOpcionMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelOpcionMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelOpcionMenu.BackgroundImage")));
            this.panelOpcionMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelOpcionMenu.BorderRadius = 1;
            this.panelOpcionMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpcionMenu.Controls.Add(this.btnFirmarContrato);
            this.panelOpcionMenu.Controls.Add(this.btnModificarEntrenador);
            this.panelOpcionMenu.Controls.Add(this.btnRegistrarEntrenador);
            this.panelOpcionMenu.Controls.Add(this.bunifuSeparator2);
            this.panelOpcionMenu.Controls.Add(this.label1);
            this.panelOpcionMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.panelOpcionMenu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelOpcionMenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.panelOpcionMenu.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.panelOpcionMenu.Location = new System.Drawing.Point(646, 21);
            this.panelOpcionMenu.Name = "panelOpcionMenu";
            this.panelOpcionMenu.Quality = 10;
            this.panelOpcionMenu.Size = new System.Drawing.Size(120, 327);
            this.panelOpcionMenu.TabIndex = 37;
            // 
            // btnFirmarContrato
            // 
            this.btnFirmarContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirmarContrato.FlatAppearance.BorderSize = 0;
            this.btnFirmarContrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnFirmarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirmarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirmarContrato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFirmarContrato.IconChar = FontAwesome.Sharp.IconChar.Wpforms;
            this.btnFirmarContrato.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnFirmarContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFirmarContrato.IconSize = 24;
            this.btnFirmarContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirmarContrato.Location = new System.Drawing.Point(0, 141);
            this.btnFirmarContrato.Name = "btnFirmarContrato";
            this.btnFirmarContrato.Size = new System.Drawing.Size(120, 36);
            this.btnFirmarContrato.TabIndex = 31;
            this.btnFirmarContrato.Text = "   FIRMAR   CONTRATO";
            this.btnFirmarContrato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirmarContrato.UseVisualStyleBackColor = true;
            this.btnFirmarContrato.Click += new System.EventHandler(this.btnFirmarContrato_Click);
            // 
            // btnModificarEntrenador
            // 
            this.btnModificarEntrenador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarEntrenador.FlatAppearance.BorderSize = 0;
            this.btnModificarEntrenador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnModificarEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEntrenador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarEntrenador.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnModificarEntrenador.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarEntrenador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarEntrenador.IconSize = 25;
            this.btnModificarEntrenador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarEntrenador.Location = new System.Drawing.Point(-1, 100);
            this.btnModificarEntrenador.Name = "btnModificarEntrenador";
            this.btnModificarEntrenador.Size = new System.Drawing.Size(120, 35);
            this.btnModificarEntrenador.TabIndex = 29;
            this.btnModificarEntrenador.Text = "   MODIFICAR ENTRENADOR";
            this.btnModificarEntrenador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarEntrenador.UseVisualStyleBackColor = true;
            this.btnModificarEntrenador.Click += new System.EventHandler(this.btnModificarEntrenador_Click);
            // 
            // btnRegistrarEntrenador
            // 
            this.btnRegistrarEntrenador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarEntrenador.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEntrenador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegistrarEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEntrenador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarEntrenador.IconChar = FontAwesome.Sharp.IconChar.UserNinja;
            this.btnRegistrarEntrenador.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrarEntrenador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarEntrenador.IconSize = 25;
            this.btnRegistrarEntrenador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarEntrenador.Location = new System.Drawing.Point(1, 59);
            this.btnRegistrarEntrenador.Name = "btnRegistrarEntrenador";
            this.btnRegistrarEntrenador.Size = new System.Drawing.Size(118, 35);
            this.btnRegistrarEntrenador.TabIndex = 28;
            this.btnRegistrarEntrenador.Text = "   REGISTRAR ENTRENADOR";
            this.btnRegistrarEntrenador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarEntrenador.UseVisualStyleBackColor = true;
            this.btnRegistrarEntrenador.Click += new System.EventHandler(this.btnRegistrarEntrenador_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-1, 53);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(111, 10);
            this.bunifuSeparator2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Opciones";
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btnVolver.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver.IconSize = 25;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(21, 15);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnVolver.Size = new System.Drawing.Size(80, 35);
            this.btnVolver.TabIndex = 41;
            this.btnVolver.Text = "   Atras";
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // labelTitleEntrenador
            // 
            this.labelTitleEntrenador.AutoSize = true;
            this.labelTitleEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleEntrenador.ForeColor = System.Drawing.Color.DarkGray;
            this.labelTitleEntrenador.Location = new System.Drawing.Point(81, 58);
            this.labelTitleEntrenador.Name = "labelTitleEntrenador";
            this.labelTitleEntrenador.Size = new System.Drawing.Size(357, 29);
            this.labelTitleEntrenador.TabIndex = 40;
            this.labelTitleEntrenador.Text = "GESTION DE ENTRENADOR";
            // 
            // labelTextFondo
            // 
            this.labelTextFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTextFondo.AutoSize = true;
            this.labelTextFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextFondo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTextFondo.Location = new System.Drawing.Point(735, 9);
            this.labelTextFondo.Name = "labelTextFondo";
            this.labelTextFondo.Size = new System.Drawing.Size(45, 12);
            this.labelTextFondo.TabIndex = 44;
            this.labelTextFondo.Text = "MONTO";
            // 
            // labelCash
            // 
            this.labelCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCash.AutoSize = true;
            this.labelCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCash.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCash.Location = new System.Drawing.Point(739, 25);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(14, 16);
            this.labelCash.TabIndex = 43;
            this.labelCash.Text = "*";
            // 
            // iconCash
            // 
            this.iconCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.iconCash.ForeColor = System.Drawing.Color.Yellow;
            this.iconCash.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.iconCash.IconColor = System.Drawing.Color.Yellow;
            this.iconCash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCash.Location = new System.Drawing.Point(701, 12);
            this.iconCash.Name = "iconCash";
            this.iconCash.Size = new System.Drawing.Size(32, 32);
            this.iconCash.TabIndex = 42;
            this.iconCash.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.panel1.Location = new System.Drawing.Point(11, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 35);
            this.panel1.TabIndex = 39;
            // 
            // panelAviso
            // 
            this.panelAviso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAviso.BackColor = System.Drawing.Color.Transparent;
            this.panelAviso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAviso.BackgroundImage")));
            this.panelAviso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAviso.BorderRadius = 1;
            this.panelAviso.Controls.Add(this.labelAviso);
            this.panelAviso.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.panelAviso.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelAviso.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.panelAviso.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.panelAviso.Location = new System.Drawing.Point(0, 90);
            this.panelAviso.Name = "panelAviso";
            this.panelAviso.Quality = 10;
            this.panelAviso.Size = new System.Drawing.Size(801, 33);
            this.panelAviso.TabIndex = 45;
            // 
            // labelAviso
            // 
            this.labelAviso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAviso.FlatAppearance.BorderSize = 0;
            this.labelAviso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.labelAviso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.labelAviso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAviso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAviso.IconChar = FontAwesome.Sharp.IconChar.None;
            this.labelAviso.IconColor = System.Drawing.Color.Black;
            this.labelAviso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.labelAviso.Location = new System.Drawing.Point(0, 0);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(795, 33);
            this.labelAviso.TabIndex = 37;
            this.labelAviso.Text = "*";
            this.labelAviso.UseVisualStyleBackColor = true;
            // 
            // FormGestionarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.panelDatagridEntrenadores);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panelAviso);
            this.Controls.Add(this.labelTitleEntrenador);
            this.Controls.Add(this.labelTextFondo);
            this.Controls.Add(this.labelCash);
            this.Controls.Add(this.iconCash);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionarEntrenador";
            this.Text = "FormGestionarEntrenador";
            this.panelDatagridEntrenadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEntrenadores)).EndInit();
            this.panelTittleDataGrid.ResumeLayout(false);
            this.panelTittleDataGrid.PerformLayout();
            this.panelSubDataGrid.ResumeLayout(false);
            this.panelSubDataGrid.PerformLayout();
            this.panelOpcionMenu.ResumeLayout(false);
            this.panelOpcionMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCash)).EndInit();
            this.panelAviso.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDatagridEntrenadores;
        private Bunifu.UI.WinForms.BunifuPanel panelTittleDataGrid;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label labelListaDeCajas;
        private Bunifu.UI.WinForms.BunifuPanel panelSubDataGrid;
        private System.Windows.Forms.TextBox textTotalMujeres;
        private System.Windows.Forms.Label labelCajasCerradas;
        private System.Windows.Forms.TextBox textTotalHombres;
        private System.Windows.Forms.Label labelTotalHombres;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label labelTotal;
        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Label labelTitleEntrenador;
        private System.Windows.Forms.Label labelTextFondo;
        private System.Windows.Forms.Label labelCash;
        private FontAwesome.Sharp.IconPictureBox iconCash;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuGradientPanel panelOpcionMenu;
        private FontAwesome.Sharp.IconButton btnFirmarContrato;
        private FontAwesome.Sharp.IconButton btnModificarEntrenador;
        private FontAwesome.Sharp.IconButton btnRegistrarEntrenador;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridEntrenadores;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private Bunifu.UI.WinForms.BunifuGradientPanel panelAviso;
        private FontAwesome.Sharp.IconButton labelAviso;
    }
}