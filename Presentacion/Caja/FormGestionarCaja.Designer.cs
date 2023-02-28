
namespace Presentacion
{
    partial class FormGestionarCaja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionarCaja));
            this.panelBarraVolver = new System.Windows.Forms.Panel();
            this.labelTitleCaja = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.labelTextFondo = new System.Windows.Forms.Label();
            this.DataGridCajas = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.btnHistorial = new FontAwesome.Sharp.IconButton();
            this.panelSubDataGrid = new Bunifu.UI.WinForms.BunifuPanel();
            this.textTotalCajasCerradas = new System.Windows.Forms.TextBox();
            this.labelCajasCerradas = new System.Windows.Forms.Label();
            this.textTotalCajasAbiertas = new System.Windows.Forms.TextBox();
            this.labelCajasAbiertas = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.iconCash = new FontAwesome.Sharp.IconPictureBox();
            this.btnCerrarCaja = new FontAwesome.Sharp.IconButton();
            this.btnAbrirCaja = new FontAwesome.Sharp.IconButton();
            this.panelTittleDataGrid = new Bunifu.UI.WinForms.BunifuPanel();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.labelListaDeCajas = new System.Windows.Forms.Label();
            this.panelAviso = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.labelAviso = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCajas)).BeginInit();
            this.panelSubDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCash)).BeginInit();
            this.panelTittleDataGrid.SuspendLayout();
            this.panelAviso.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraVolver
            // 
            this.panelBarraVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.panelBarraVolver.Location = new System.Drawing.Point(12, 12);
            this.panelBarraVolver.Name = "panelBarraVolver";
            this.panelBarraVolver.Size = new System.Drawing.Size(4, 35);
            this.panelBarraVolver.TabIndex = 13;
            // 
            // labelTitleCaja
            // 
            this.labelTitleCaja.AutoSize = true;
            this.labelTitleCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleCaja.ForeColor = System.Drawing.Color.DarkGray;
            this.labelTitleCaja.Location = new System.Drawing.Point(87, 71);
            this.labelTitleCaja.Name = "labelTitleCaja";
            this.labelTitleCaja.Size = new System.Drawing.Size(441, 29);
            this.labelTitleCaja.TabIndex = 14;
            this.labelTitleCaja.Text = "GESTIONAR CAJA REGISTRADORA";
            // 
            // labelCash
            // 
            this.labelCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCash.AutoSize = true;
            this.labelCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCash.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCash.Location = new System.Drawing.Point(768, 25);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(14, 16);
            this.labelCash.TabIndex = 26;
            this.labelCash.Text = "*";
            // 
            // labelTextFondo
            // 
            this.labelTextFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTextFondo.AutoSize = true;
            this.labelTextFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextFondo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTextFondo.Location = new System.Drawing.Point(764, 9);
            this.labelTextFondo.Name = "labelTextFondo";
            this.labelTextFondo.Size = new System.Drawing.Size(45, 12);
            this.labelTextFondo.TabIndex = 27;
            this.labelTextFondo.Text = "MONTO";
            // 
            // DataGridCajas
            // 
            this.DataGridCajas.AllowCustomTheming = true;
            this.DataGridCajas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DataGridCajas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridCajas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridCajas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridCajas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.DataGridCajas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridCajas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridCajas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCajas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridCajas.ColumnHeadersHeight = 40;
            this.DataGridCajas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.DataGridCajas.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DataGridCajas.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridCajas.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridCajas.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DataGridCajas.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridCajas.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DataGridCajas.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.DataGridCajas.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.DataGridCajas.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DataGridCajas.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridCajas.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.DataGridCajas.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridCajas.CurrentTheme.Name = null;
            this.DataGridCajas.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridCajas.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridCajas.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridCajas.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.DataGridCajas.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridCajas.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridCajas.EnableHeadersVisualStyles = false;
            this.DataGridCajas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.DataGridCajas.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.DataGridCajas.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataGridCajas.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridCajas.Location = new System.Drawing.Point(92, 177);
            this.DataGridCajas.Name = "DataGridCajas";
            this.DataGridCajas.ReadOnly = true;
            this.DataGridCajas.RowHeadersVisible = false;
            this.DataGridCajas.RowTemplate.Height = 40;
            this.DataGridCajas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridCajas.Size = new System.Drawing.Size(571, 345);
            this.DataGridCajas.TabIndex = 17;
            this.DataGridCajas.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.DataGridCajas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCajas_CellClick);
            // 
            // Eliminar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Eliminar.Description = "Eliminar";
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Presentacion.Properties.Resources.deleRojWhite;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::Presentacion.Properties.Resources._1345874;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 571;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            this.btnVolver.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver.IconSize = 30;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(20, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(78, 35);
            this.btnVolver.TabIndex = 29;
            this.btnVolver.Text = "Atras";
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHistorial.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.btnHistorial.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistorial.IconSize = 30;
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(451, 552);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(138, 35);
            this.btnHistorial.TabIndex = 28;
            this.btnHistorial.Text = "LIMPIAR HISTORIAL";
            this.btnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
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
            this.panelSubDataGrid.Controls.Add(this.textTotalCajasCerradas);
            this.panelSubDataGrid.Controls.Add(this.labelCajasCerradas);
            this.panelSubDataGrid.Controls.Add(this.textTotalCajasAbiertas);
            this.panelSubDataGrid.Controls.Add(this.labelCajasAbiertas);
            this.panelSubDataGrid.Controls.Add(this.textTotal);
            this.panelSubDataGrid.Controls.Add(this.labelTotal);
            this.panelSubDataGrid.Location = new System.Drawing.Point(92, 520);
            this.panelSubDataGrid.Name = "panelSubDataGrid";
            this.panelSubDataGrid.ShowBorders = true;
            this.panelSubDataGrid.Size = new System.Drawing.Size(571, 26);
            this.panelSubDataGrid.TabIndex = 22;
            // 
            // textTotalCajasCerradas
            // 
            this.textTotalCajasCerradas.Location = new System.Drawing.Point(459, 2);
            this.textTotalCajasCerradas.Name = "textTotalCajasCerradas";
            this.textTotalCajasCerradas.Size = new System.Drawing.Size(78, 20);
            this.textTotalCajasCerradas.TabIndex = 25;
            // 
            // labelCajasCerradas
            // 
            this.labelCajasCerradas.AutoSize = true;
            this.labelCajasCerradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCajasCerradas.ForeColor = System.Drawing.Color.DarkGray;
            this.labelCajasCerradas.Location = new System.Drawing.Point(351, 7);
            this.labelCajasCerradas.Name = "labelCajasCerradas";
            this.labelCajasCerradas.Size = new System.Drawing.Size(111, 12);
            this.labelCajasCerradas.TabIndex = 24;
            this.labelCajasCerradas.Text = "CAJAS CERRADAS:";
            // 
            // textTotalCajasAbiertas
            // 
            this.textTotalCajasAbiertas.Location = new System.Drawing.Point(268, 2);
            this.textTotalCajasAbiertas.Name = "textTotalCajasAbiertas";
            this.textTotalCajasAbiertas.Size = new System.Drawing.Size(78, 20);
            this.textTotalCajasAbiertas.TabIndex = 23;
            // 
            // labelCajasAbiertas
            // 
            this.labelCajasAbiertas.AutoSize = true;
            this.labelCajasAbiertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCajasAbiertas.ForeColor = System.Drawing.Color.DarkGray;
            this.labelCajasAbiertas.Location = new System.Drawing.Point(162, 7);
            this.labelCajasAbiertas.Name = "labelCajasAbiertas";
            this.labelCajasAbiertas.Size = new System.Drawing.Size(104, 12);
            this.labelCajasAbiertas.TabIndex = 22;
            this.labelCajasAbiertas.Text = "CAJAS ABIERTAS:";
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
            this.iconCash.Location = new System.Drawing.Point(730, 12);
            this.iconCash.Name = "iconCash";
            this.iconCash.Size = new System.Drawing.Size(32, 32);
            this.iconCash.TabIndex = 25;
            this.iconCash.TabStop = false;
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnCerrarCaja.Enabled = false;
            this.btnCerrarCaja.FlatAppearance.BorderSize = 0;
            this.btnCerrarCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCerrarCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCaja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarCaja.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnCerrarCaja.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrarCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarCaja.IconSize = 30;
            this.btnCerrarCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarCaja.Location = new System.Drawing.Point(303, 552);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(142, 35);
            this.btnCerrarCaja.TabIndex = 23;
            this.btnCerrarCaja.Text = " CERRAR CAJA";
            this.btnCerrarCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarCaja.UseVisualStyleBackColor = false;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // btnAbrirCaja
            // 
            this.btnAbrirCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnAbrirCaja.FlatAppearance.BorderSize = 0;
            this.btnAbrirCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAbrirCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAbrirCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbrirCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnAbrirCaja.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbrirCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbrirCaja.IconSize = 30;
            this.btnAbrirCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirCaja.Location = new System.Drawing.Point(161, 552);
            this.btnAbrirCaja.Name = "btnAbrirCaja";
            this.btnAbrirCaja.Size = new System.Drawing.Size(136, 35);
            this.btnAbrirCaja.TabIndex = 22;
            this.btnAbrirCaja.Text = "   ABRIR CAJA";
            this.btnAbrirCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirCaja.UseVisualStyleBackColor = false;
            this.btnAbrirCaja.Click += new System.EventHandler(this.btbAbrirCaja_Click);
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
            this.panelTittleDataGrid.Controls.Add(this.comboEstado);
            this.panelTittleDataGrid.Controls.Add(this.labelFiltro);
            this.panelTittleDataGrid.Controls.Add(this.labelListaDeCajas);
            this.panelTittleDataGrid.Location = new System.Drawing.Point(92, 154);
            this.panelTittleDataGrid.Name = "panelTittleDataGrid";
            this.panelTittleDataGrid.ShowBorders = true;
            this.panelTittleDataGrid.Size = new System.Drawing.Size(571, 26);
            this.panelTittleDataGrid.TabIndex = 18;
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "Todos",
            "Abierta",
            "Cerrada"});
            this.comboEstado.Location = new System.Drawing.Point(217, 1);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(121, 21);
            this.comboEstado.TabIndex = 21;
            this.comboEstado.Text = "Todos";
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.comboEstado_SelectedIndexChanged);
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
            this.labelListaDeCajas.Size = new System.Drawing.Size(146, 15);
            this.labelListaDeCajas.TabIndex = 19;
            this.labelListaDeCajas.Text = "HISTORIAL DE CAJAS";
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
            this.panelAviso.Location = new System.Drawing.Point(0, 115);
            this.panelAviso.Name = "panelAviso";
            this.panelAviso.Quality = 10;
            this.panelAviso.Size = new System.Drawing.Size(834, 33);
            this.panelAviso.TabIndex = 16;
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
            this.labelAviso.Size = new System.Drawing.Size(834, 33);
            this.labelAviso.TabIndex = 28;
            this.labelAviso.Text = "*";
            this.labelAviso.UseVisualStyleBackColor = true;
            // 
            // FormGestionarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(837, 592);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.panelSubDataGrid);
            this.Controls.Add(this.labelTextFondo);
            this.Controls.Add(this.labelCash);
            this.Controls.Add(this.iconCash);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.btnAbrirCaja);
            this.Controls.Add(this.panelTittleDataGrid);
            this.Controls.Add(this.panelAviso);
            this.Controls.Add(this.labelTitleCaja);
            this.Controls.Add(this.panelBarraVolver);
            this.Controls.Add(this.DataGridCajas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionarCaja";
            this.Text = "FormGestionarCaja";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCajas)).EndInit();
            this.panelSubDataGrid.ResumeLayout(false);
            this.panelSubDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCash)).EndInit();
            this.panelTittleDataGrid.ResumeLayout(false);
            this.panelTittleDataGrid.PerformLayout();
            this.panelAviso.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraVolver;
        private System.Windows.Forms.Label labelTitleCaja;
        private Bunifu.UI.WinForms.BunifuGradientPanel panelAviso;
        private Bunifu.UI.WinForms.BunifuPanel panelTittleDataGrid;
        private System.Windows.Forms.Label labelListaDeCajas;
        private System.Windows.Forms.Label labelFiltro;
        private FontAwesome.Sharp.IconButton btnAbrirCaja;
        private FontAwesome.Sharp.IconButton btnCerrarCaja;
        private System.Windows.Forms.Label labelCash;
        private FontAwesome.Sharp.IconPictureBox iconCash;
        private System.Windows.Forms.Label labelTextFondo;
        private System.Windows.Forms.ComboBox comboEstado;
        private Bunifu.UI.WinForms.BunifuPanel panelSubDataGrid;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textTotalCajasCerradas;
        private System.Windows.Forms.Label labelCajasCerradas;
        private System.Windows.Forms.TextBox textTotalCajasAbiertas;
        private System.Windows.Forms.Label labelCajasAbiertas;
        private System.Windows.Forms.TextBox textTotal;
        private FontAwesome.Sharp.IconButton labelAviso;
        private FontAwesome.Sharp.IconButton btnHistorial;
        private FontAwesome.Sharp.IconButton btnVolver;
        private Bunifu.UI.WinForms.BunifuDataGridView DataGridCajas;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}