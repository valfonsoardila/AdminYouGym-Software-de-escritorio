
namespace Presentacion
{
    partial class FormGestionarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionarCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitleCliente = new System.Windows.Forms.Label();
            this.labelTextFondo = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelAviso = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.labelAviso = new FontAwesome.Sharp.IconButton();
            this.panelSubDataGrid = new Bunifu.UI.WinForms.BunifuPanel();
            this.textTotalMujeres = new System.Windows.Forms.TextBox();
            this.labelCajasCerradas = new System.Windows.Forms.Label();
            this.textTotalHombres = new System.Windows.Forms.TextBox();
            this.labelTotalHombres = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.iconCash = new FontAwesome.Sharp.IconPictureBox();
            this.panelTittleDataGrid = new Bunifu.UI.WinForms.BunifuPanel();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.labelListaDeCajas = new System.Windows.Forms.Label();
            this.panelOpcionMenu = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnObtenerProgreso = new FontAwesome.Sharp.IconButton();
            this.btnModificarCliente = new FontAwesome.Sharp.IconButton();
            this.btnInscribirCliente = new FontAwesome.Sharp.IconButton();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.panelDatagridClientes = new System.Windows.Forms.Panel();
            this.DataGridClientes = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelAviso.SuspendLayout();
            this.panelSubDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCash)).BeginInit();
            this.panelTittleDataGrid.SuspendLayout();
            this.panelOpcionMenu.SuspendLayout();
            this.panelDatagridClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 35);
            this.panel1.TabIndex = 11;
            // 
            // labelTitleCliente
            // 
            this.labelTitleCliente.AutoSize = true;
            this.labelTitleCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleCliente.ForeColor = System.Drawing.Color.DarkGray;
            this.labelTitleCliente.Location = new System.Drawing.Point(82, 55);
            this.labelTitleCliente.Name = "labelTitleCliente";
            this.labelTitleCliente.Size = new System.Drawing.Size(287, 29);
            this.labelTitleCliente.TabIndex = 29;
            this.labelTitleCliente.Text = "GESTION DE CLIENTE";
            // 
            // labelTextFondo
            // 
            this.labelTextFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTextFondo.AutoSize = true;
            this.labelTextFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextFondo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTextFondo.Location = new System.Drawing.Point(736, 6);
            this.labelTextFondo.Name = "labelTextFondo";
            this.labelTextFondo.Size = new System.Drawing.Size(45, 12);
            this.labelTextFondo.TabIndex = 35;
            this.labelTextFondo.Text = "MONTO";
            // 
            // labelCash
            // 
            this.labelCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCash.AutoSize = true;
            this.labelCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCash.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCash.Location = new System.Drawing.Point(740, 22);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(14, 16);
            this.labelCash.TabIndex = 34;
            this.labelCash.Text = "*";
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewImageColumn1.Description = "Eliminar";
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::Presentacion.Properties.Resources.deleRojWhite;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Visible = false;
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
            this.panelAviso.Location = new System.Drawing.Point(1, 87);
            this.panelAviso.Name = "panelAviso";
            this.panelAviso.Quality = 10;
            this.panelAviso.Size = new System.Drawing.Size(801, 33);
            this.panelAviso.TabIndex = 36;
            // 
            // labelAviso
            // 
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
            // iconCash
            // 
            this.iconCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.iconCash.ForeColor = System.Drawing.Color.Yellow;
            this.iconCash.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.iconCash.IconColor = System.Drawing.Color.Yellow;
            this.iconCash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCash.Location = new System.Drawing.Point(702, 9);
            this.iconCash.Name = "iconCash";
            this.iconCash.Size = new System.Drawing.Size(32, 32);
            this.iconCash.TabIndex = 33;
            this.iconCash.TabStop = false;
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
            this.comboSexo.Location = new System.Drawing.Point(217, 1);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(121, 21);
            this.comboSexo.TabIndex = 21;
            this.comboSexo.Text = "Todos";
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFiltro.Location = new System.Drawing.Point(179, 6);
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
            this.labelListaDeCajas.Size = new System.Drawing.Size(137, 15);
            this.labelListaDeCajas.TabIndex = 19;
            this.labelListaDeCajas.Text = "LISTA DE CLIENTES";
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
            this.panelOpcionMenu.Controls.Add(this.btnObtenerProgreso);
            this.panelOpcionMenu.Controls.Add(this.btnModificarCliente);
            this.panelOpcionMenu.Controls.Add(this.btnInscribirCliente);
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
            // btnObtenerProgreso
            // 
            this.btnObtenerProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObtenerProgreso.FlatAppearance.BorderSize = 0;
            this.btnObtenerProgreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnObtenerProgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObtenerProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtenerProgreso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnObtenerProgreso.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.btnObtenerProgreso.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnObtenerProgreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnObtenerProgreso.IconSize = 24;
            this.btnObtenerProgreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObtenerProgreso.Location = new System.Drawing.Point(0, 141);
            this.btnObtenerProgreso.Name = "btnObtenerProgreso";
            this.btnObtenerProgreso.Size = new System.Drawing.Size(120, 36);
            this.btnObtenerProgreso.TabIndex = 31;
            this.btnObtenerProgreso.Text = "   OBTENER PROGRESO";
            this.btnObtenerProgreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObtenerProgreso.UseVisualStyleBackColor = true;
            this.btnObtenerProgreso.Click += new System.EventHandler(this.btnObtenerProgreso_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarCliente.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            this.btnModificarCliente.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarCliente.IconSize = 25;
            this.btnModificarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCliente.Location = new System.Drawing.Point(-1, 100);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(120, 35);
            this.btnModificarCliente.TabIndex = 29;
            this.btnModificarCliente.Text = "   MODIFICAR CLIENTE";
            this.btnModificarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnInscribirCliente
            // 
            this.btnInscribirCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInscribirCliente.FlatAppearance.BorderSize = 0;
            this.btnInscribirCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnInscribirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribirCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInscribirCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnInscribirCliente.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnInscribirCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInscribirCliente.IconSize = 25;
            this.btnInscribirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscribirCliente.Location = new System.Drawing.Point(1, 59);
            this.btnInscribirCliente.Name = "btnInscribirCliente";
            this.btnInscribirCliente.Size = new System.Drawing.Size(118, 35);
            this.btnInscribirCliente.TabIndex = 28;
            this.btnInscribirCliente.Text = "   INSCRIBIR CLIENTE $";
            this.btnInscribirCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInscribirCliente.UseVisualStyleBackColor = true;
            this.btnInscribirCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
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
            this.btnVolver.Location = new System.Drawing.Point(22, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnVolver.Size = new System.Drawing.Size(80, 35);
            this.btnVolver.TabIndex = 32;
            this.btnVolver.Text = "   Atras";
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panelDatagridClientes
            // 
            this.panelDatagridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatagridClientes.Controls.Add(this.DataGridClientes);
            this.panelDatagridClientes.Controls.Add(this.panelTittleDataGrid);
            this.panelDatagridClientes.Controls.Add(this.panelSubDataGrid);
            this.panelDatagridClientes.Controls.Add(this.panelOpcionMenu);
            this.panelDatagridClientes.Location = new System.Drawing.Point(12, 137);
            this.panelDatagridClientes.Name = "panelDatagridClientes";
            this.panelDatagridClientes.Size = new System.Drawing.Size(766, 369);
            this.panelDatagridClientes.TabIndex = 38;
            // 
            // DataGridClientes
            // 
            this.DataGridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.DataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.DataGridClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.DataGridClientes.Location = new System.Drawing.Point(1, 29);
            this.DataGridClientes.Name = "DataGridClientes";
            this.DataGridClientes.Size = new System.Drawing.Size(645, 312);
            this.DataGridClientes.TabIndex = 39;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Presentacion.Properties.Resources.deleRojWhite;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 50;
            // 
            // FormGestionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.panelDatagridClientes);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panelAviso);
            this.Controls.Add(this.labelTitleCliente);
            this.Controls.Add(this.labelTextFondo);
            this.Controls.Add(this.labelCash);
            this.Controls.Add(this.iconCash);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionarCliente";
            this.Text = "Gestionar Cliente";
            this.panelAviso.ResumeLayout(false);
            this.panelSubDataGrid.ResumeLayout(false);
            this.panelSubDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCash)).EndInit();
            this.panelTittleDataGrid.ResumeLayout(false);
            this.panelTittleDataGrid.PerformLayout();
            this.panelOpcionMenu.ResumeLayout(false);
            this.panelOpcionMenu.PerformLayout();
            this.panelDatagridClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitleCliente;
        private Bunifu.UI.WinForms.BunifuPanel panelSubDataGrid;
        private System.Windows.Forms.TextBox textTotalMujeres;
        private System.Windows.Forms.Label labelCajasCerradas;
        private System.Windows.Forms.TextBox textTotalHombres;
        private System.Windows.Forms.Label labelTotalHombres;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTextFondo;
        private System.Windows.Forms.Label labelCash;
        private FontAwesome.Sharp.IconPictureBox iconCash;
        private Bunifu.UI.WinForms.BunifuPanel panelTittleDataGrid;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label labelListaDeCajas;
        private FontAwesome.Sharp.IconButton labelAviso;
        private Bunifu.UI.WinForms.BunifuGradientPanel panelAviso;
        private Bunifu.UI.WinForms.BunifuGradientPanel panelOpcionMenu;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private FontAwesome.Sharp.IconButton btnModificarCliente;
        private FontAwesome.Sharp.IconButton btnInscribirCliente;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private FontAwesome.Sharp.IconButton btnObtenerProgreso;
        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Panel panelDatagridClientes;
        private System.Windows.Forms.DataGridView DataGridClientes;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}