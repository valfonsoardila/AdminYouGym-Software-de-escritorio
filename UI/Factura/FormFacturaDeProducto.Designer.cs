
namespace UI
{
    partial class FormFacturaDeProducto
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
            menuTop = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            dataGridFacturaProductos = new DataGridView();
            Deshacer = new DataGridViewImageColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ReferenciaP = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            labelTitleFactura = new Label();
            labelPago = new Label();
            labelVueltos = new Label();
            labelVueltosGenerado = new Label();
            labelTotalFactura = new Label();
            label3 = new Label();
            panelTotalesFactura = new Panel();
            textTotalFacturaGenerada = new TextBox();
            label1 = new Label();
            comboFormaDePago = new ComboBox();
            textPago = new TextBox();
            labelCliente = new Label();
            panel4 = new Panel();
            label2 = new Label();
            labelAdvertenciaCliente = new Label();
            btnCloseCliente = new FontAwesome.Sharp.IconPictureBox();
            textSearchCliente = new TextBox();
            btnSearchCliente = new FontAwesome.Sharp.IconPictureBox();
            panel5 = new Panel();
            textIdentificacionEmpleado = new TextBox();
            labelIdentificacionEmpleado = new Label();
            textApellidoEmpleado = new TextBox();
            labelApellidoEmpleado = new Label();
            textNombreEmpleado = new TextBox();
            labelNombreEmpleado = new Label();
            panel6 = new Panel();
            labelAdvertenciaEmpleado = new Label();
            btnCloseEmpleado = new FontAwesome.Sharp.IconPictureBox();
            textSearchEmpleado = new TextBox();
            btnSearchEmpleado = new FontAwesome.Sharp.IconPictureBox();
            labelVendedor = new Label();
            labelIdFactura = new Label();
            labelIdGeneradoDeFactura = new Label();
            textNombreCliente = new TextBox();
            labelNombreCliente = new Label();
            textIdentificacionCliente = new TextBox();
            labelIdentificacionCliente = new Label();
            labelApellidoCliente = new Label();
            textApellidoCliente = new TextBox();
            labelTipoDeId = new Label();
            comboTipoDeId = new ComboBox();
            labelSexo = new Label();
            dateTimeFechaDeNacimiento = new DateTimePicker();
            labelFechaDeNacimiento = new Label();
            comboSexo = new ComboBox();
            labelTelefono = new Label();
            textTelefono = new TextBox();
            labelCorreo = new Label();
            textCorreo = new TextBox();
            panelFactura = new Panel();
            panel3 = new Panel();
            panel8 = new Panel();
            labelDireccion = new Label();
            textDireccion = new TextBox();
            ImprimirDocumento = new System.Drawing.Printing.PrintDocument();
            label5 = new Label();
            labelBase = new Label();
            label4 = new Label();
            label6 = new Label();
            iconBase = new FontAwesome.Sharp.IconPictureBox();
            labelCash = new Label();
            labelTextFondo = new Label();
            iconCash = new FontAwesome.Sharp.IconPictureBox();
            btnSoloVender = new FontAwesome.Sharp.IconButton();
            btnImprimirFactura = new FontAwesome.Sharp.IconButton();
            menuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFacturaProductos).BeginInit();
            panelTotalesFactura.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSearchCliente).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseEmpleado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSearchEmpleado).BeginInit();
            panelFactura.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconBase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCash).BeginInit();
            SuspendLayout();
            // 
            // menuTop
            // 
            menuTop.BackColor = Color.Black;
            menuTop.BorderStyle = BorderStyle.FixedSingle;
            menuTop.Controls.Add(btnCerrar);
            menuTop.Dock = DockStyle.Top;
            menuTop.Location = new Point(0, 0);
            menuTop.Margin = new Padding(4, 3, 4, 3);
            menuTop.Name = "menuTop";
            menuTop.Size = new Size(750, 30);
            menuTop.TabIndex = 5;
            menuTop.MouseDown += menuTop_MouseDown;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            btnCerrar.IconColor = Color.White;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.IconSize = 28;
            btnCerrar.Location = new Point(718, 2);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(28, 27);
            btnCerrar.TabIndex = 3;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dataGridFacturaProductos
            // 
            dataGridFacturaProductos.AllowUserToAddRows = false;
            dataGridFacturaProductos.BorderStyle = BorderStyle.None;
            dataGridFacturaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFacturaProductos.Columns.AddRange(new DataGridViewColumn[] { Deshacer, Cantidad, ReferenciaP, Nombre, Detalle, Precio });
            dataGridFacturaProductos.Location = new Point(2, 267);
            dataGridFacturaProductos.Margin = new Padding(4, 3, 4, 3);
            dataGridFacturaProductos.Name = "dataGridFacturaProductos";
            dataGridFacturaProductos.RowHeadersVisible = false;
            dataGridFacturaProductos.Size = new Size(720, 162);
            dataGridFacturaProductos.TabIndex = 6;
            dataGridFacturaProductos.CellBeginEdit += dataGridFacturaProductos_CellBeginEdit;
            dataGridFacturaProductos.CellClick += dataGridFacturaProductos_CellClick;
            dataGridFacturaProductos.CellEndEdit += dataGridFacturaProductos_CellEndEdit;
            // 
            // Deshacer
            // 
            Deshacer.HeaderText = "Deshacer";
            Deshacer.Image = Properties.Resources.Regresar;
            Deshacer.Name = "Deshacer";
            Deshacer.Width = 48;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 60;
            // 
            // ReferenciaP
            // 
            ReferenciaP.HeaderText = "Referencia";
            ReferenciaP.Name = "ReferenciaP";
            ReferenciaP.Width = 70;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 140;
            // 
            // Detalle
            // 
            Detalle.HeaderText = "Detalle";
            Detalle.Name = "Detalle";
            Detalle.Width = 180;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Width = 118;
            // 
            // labelTitleFactura
            // 
            labelTitleFactura.AutoSize = true;
            labelTitleFactura.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleFactura.ForeColor = Color.Black;
            labelTitleFactura.Location = new Point(7, 39);
            labelTitleFactura.Margin = new Padding(4, 0, 4, 0);
            labelTitleFactura.Name = "labelTitleFactura";
            labelTitleFactura.Size = new Size(260, 29);
            labelTitleFactura.TabIndex = 61;
            labelTitleFactura.Text = "Factura de productos";
            // 
            // labelPago
            // 
            labelPago.AutoSize = true;
            labelPago.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPago.ForeColor = Color.FromArgb(0, 192, 0);
            labelPago.Location = new Point(201, 5);
            labelPago.Margin = new Padding(4, 0, 4, 0);
            labelPago.Name = "labelPago";
            labelPago.Size = new Size(56, 16);
            labelPago.TabIndex = 62;
            labelPago.Text = "Pago $";
            // 
            // labelVueltos
            // 
            labelVueltos.AutoSize = true;
            labelVueltos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelVueltos.ForeColor = Color.Red;
            labelVueltos.Location = new Point(380, 3);
            labelVueltos.Margin = new Padding(4, 0, 4, 0);
            labelVueltos.Name = "labelVueltos";
            labelVueltos.Size = new Size(71, 16);
            labelVueltos.TabIndex = 63;
            labelVueltos.Text = "Vueltos $";
            // 
            // labelVueltosGenerado
            // 
            labelVueltosGenerado.AutoSize = true;
            labelVueltosGenerado.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelVueltosGenerado.ForeColor = Color.Red;
            labelVueltosGenerado.Location = new Point(458, 3);
            labelVueltosGenerado.Margin = new Padding(4, 0, 4, 0);
            labelVueltosGenerado.Name = "labelVueltosGenerado";
            labelVueltosGenerado.Size = new Size(65, 18);
            labelVueltosGenerado.TabIndex = 65;
            labelVueltosGenerado.Text = "0.00     ";
            // 
            // labelTotalFactura
            // 
            labelTotalFactura.AutoSize = true;
            labelTotalFactura.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalFactura.ForeColor = Color.White;
            labelTotalFactura.Location = new Point(-5, 2);
            labelTotalFactura.Margin = new Padding(4, 0, 4, 0);
            labelTotalFactura.Name = "labelTotalFactura";
            labelTotalFactura.Size = new Size(121, 20);
            labelTotalFactura.TabIndex = 66;
            labelTotalFactura.Text = "Total factura$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(4, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 72;
            label3.Text = "Lista de Productos";
            // 
            // panelTotalesFactura
            // 
            panelTotalesFactura.BackColor = SystemColors.ActiveCaptionText;
            panelTotalesFactura.BorderStyle = BorderStyle.FixedSingle;
            panelTotalesFactura.Controls.Add(textTotalFacturaGenerada);
            panelTotalesFactura.Controls.Add(label1);
            panelTotalesFactura.Controls.Add(comboFormaDePago);
            panelTotalesFactura.Controls.Add(textPago);
            panelTotalesFactura.Controls.Add(labelTotalFactura);
            panelTotalesFactura.Controls.Add(labelPago);
            panelTotalesFactura.Controls.Add(labelVueltos);
            panelTotalesFactura.Controls.Add(labelVueltosGenerado);
            panelTotalesFactura.Location = new Point(2, 428);
            panelTotalesFactura.Margin = new Padding(4, 3, 4, 3);
            panelTotalesFactura.Name = "panelTotalesFactura";
            panelTotalesFactura.Size = new Size(720, 29);
            panelTotalesFactura.TabIndex = 73;
            // 
            // textTotalFacturaGenerada
            // 
            textTotalFacturaGenerada.BackColor = SystemColors.InfoText;
            textTotalFacturaGenerada.BorderStyle = BorderStyle.None;
            textTotalFacturaGenerada.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textTotalFacturaGenerada.ForeColor = Color.White;
            textTotalFacturaGenerada.Location = new Point(132, 5);
            textTotalFacturaGenerada.Margin = new Padding(4, 3, 4, 3);
            textTotalFacturaGenerada.Name = "textTotalFacturaGenerada";
            textTotalFacturaGenerada.Size = new Size(69, 15);
            textTotalFacturaGenerada.TabIndex = 97;
            textTotalFacturaGenerada.Text = "0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(524, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 96;
            label1.Text = "Forma de pago;";
            // 
            // comboFormaDePago
            // 
            comboFormaDePago.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboFormaDePago.FormattingEnabled = true;
            comboFormaDePago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            comboFormaDePago.Location = new Point(650, 2);
            comboFormaDePago.Margin = new Padding(4, 3, 4, 3);
            comboFormaDePago.Name = "comboFormaDePago";
            comboFormaDePago.Size = new Size(67, 21);
            comboFormaDePago.TabIndex = 86;
            comboFormaDePago.Text = "Efectivo";
            // 
            // textPago
            // 
            textPago.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textPago.ForeColor = Color.Green;
            textPago.Location = new Point(264, 1);
            textPago.Margin = new Padding(4, 3, 4, 3);
            textPago.Name = "textPago";
            textPago.Size = new Size(116, 22);
            textPago.TabIndex = 74;
            textPago.Text = "0.00";
            textPago.TextChanged += textPago_TextChanged_1;
            textPago.Enter += textPago_Enter;
            textPago.Leave += textPago_Leave;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCliente.Location = new Point(4, 3);
            labelCliente.Margin = new Padding(4, 0, 4, 0);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(55, 16);
            labelCliente.TabIndex = 74;
            labelCliente.Text = "Cliente";
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(labelAdvertenciaCliente);
            panel4.Controls.Add(btnCloseCliente);
            panel4.Controls.Add(textSearchCliente);
            panel4.Controls.Add(btnSearchCliente);
            panel4.Controls.Add(labelCliente);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(722, 24);
            panel4.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(4, 140, 128);
            label2.Location = new Point(76, 2);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 16);
            label2.TabIndex = 80;
            label2.Text = "Opcional";
            // 
            // labelAdvertenciaCliente
            // 
            labelAdvertenciaCliente.AutoSize = true;
            labelAdvertenciaCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAdvertenciaCliente.ForeColor = Color.DarkRed;
            labelAdvertenciaCliente.Location = new Point(281, 2);
            labelAdvertenciaCliente.Margin = new Padding(4, 0, 4, 0);
            labelAdvertenciaCliente.Name = "labelAdvertenciaCliente";
            labelAdvertenciaCliente.Size = new Size(156, 16);
            labelAdvertenciaCliente.TabIndex = 78;
            labelAdvertenciaCliente.Text = "No hay coincidencias";
            labelAdvertenciaCliente.Visible = false;
            // 
            // btnCloseCliente
            // 
            btnCloseCliente.BackColor = SystemColors.Control;
            btnCloseCliente.Cursor = Cursors.Hand;
            btnCloseCliente.ForeColor = Color.DarkRed;
            btnCloseCliente.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCloseCliente.IconColor = Color.DarkRed;
            btnCloseCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCloseCliente.IconSize = 21;
            btnCloseCliente.Location = new Point(630, 1);
            btnCloseCliente.Margin = new Padding(4, 3, 4, 3);
            btnCloseCliente.Name = "btnCloseCliente";
            btnCloseCliente.Size = new Size(21, 21);
            btnCloseCliente.TabIndex = 77;
            btnCloseCliente.TabStop = false;
            btnCloseCliente.Visible = false;
            btnCloseCliente.Click += btnCloseCliente_Click;
            // 
            // textSearchCliente
            // 
            textSearchCliente.Location = new Point(482, 0);
            textSearchCliente.Margin = new Padding(4, 3, 4, 3);
            textSearchCliente.Name = "textSearchCliente";
            textSearchCliente.Size = new Size(148, 23);
            textSearchCliente.TabIndex = 75;
            textSearchCliente.Text = "Buscar identificacion";
            textSearchCliente.Visible = false;
            textSearchCliente.TextChanged += textSearchCliente_TextChanged;
            textSearchCliente.Enter += textSearchCliente_Enter;
            // 
            // btnSearchCliente
            // 
            btnSearchCliente.BackColor = SystemColors.Control;
            btnSearchCliente.Cursor = Cursors.Hand;
            btnSearchCliente.ForeColor = SystemColors.ControlText;
            btnSearchCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearchCliente.IconColor = SystemColors.ControlText;
            btnSearchCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearchCliente.IconSize = 23;
            btnSearchCliente.Location = new Point(652, 0);
            btnSearchCliente.Margin = new Padding(4, 3, 4, 3);
            btnSearchCliente.Name = "btnSearchCliente";
            btnSearchCliente.Size = new Size(23, 23);
            btnSearchCliente.TabIndex = 76;
            btnSearchCliente.TabStop = false;
            btnSearchCliente.Click += btnSearchCliente_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(textIdentificacionEmpleado);
            panel5.Controls.Add(labelIdentificacionEmpleado);
            panel5.Controls.Add(textApellidoEmpleado);
            panel5.Controls.Add(labelApellidoEmpleado);
            panel5.Controls.Add(textNombreEmpleado);
            panel5.Controls.Add(labelNombreEmpleado);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 16);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(722, 84);
            panel5.TabIndex = 76;
            // 
            // textIdentificacionEmpleado
            // 
            textIdentificacionEmpleado.Location = new Point(86, 54);
            textIdentificacionEmpleado.Margin = new Padding(4, 3, 4, 3);
            textIdentificacionEmpleado.Name = "textIdentificacionEmpleado";
            textIdentificacionEmpleado.Size = new Size(166, 23);
            textIdentificacionEmpleado.TabIndex = 91;
            // 
            // labelIdentificacionEmpleado
            // 
            labelIdentificacionEmpleado.AutoSize = true;
            labelIdentificacionEmpleado.Location = new Point(4, 59);
            labelIdentificacionEmpleado.Margin = new Padding(4, 0, 4, 0);
            labelIdentificacionEmpleado.Name = "labelIdentificacionEmpleado";
            labelIdentificacionEmpleado.Size = new Size(82, 15);
            labelIdentificacionEmpleado.TabIndex = 90;
            labelIdentificacionEmpleado.Text = "Identificacion:";
            // 
            // textApellidoEmpleado
            // 
            textApellidoEmpleado.Location = new Point(427, 28);
            textApellidoEmpleado.Margin = new Padding(4, 3, 4, 3);
            textApellidoEmpleado.Name = "textApellidoEmpleado";
            textApellidoEmpleado.Size = new Size(166, 23);
            textApellidoEmpleado.TabIndex = 91;
            // 
            // labelApellidoEmpleado
            // 
            labelApellidoEmpleado.AutoSize = true;
            labelApellidoEmpleado.Location = new Point(299, 32);
            labelApellidoEmpleado.Margin = new Padding(4, 0, 4, 0);
            labelApellidoEmpleado.Name = "labelApellidoEmpleado";
            labelApellidoEmpleado.Size = new Size(123, 15);
            labelApellidoEmpleado.TabIndex = 90;
            labelApellidoEmpleado.Text = "Apellido de vendedor:";
            // 
            // textNombreEmpleado
            // 
            textNombreEmpleado.Location = new Point(130, 28);
            textNombreEmpleado.Margin = new Padding(4, 3, 4, 3);
            textNombreEmpleado.Name = "textNombreEmpleado";
            textNombreEmpleado.Size = new Size(166, 23);
            textNombreEmpleado.TabIndex = 77;
            // 
            // labelNombreEmpleado
            // 
            labelNombreEmpleado.AutoSize = true;
            labelNombreEmpleado.Location = new Point(5, 31);
            labelNombreEmpleado.Margin = new Padding(4, 0, 4, 0);
            labelNombreEmpleado.Name = "labelNombreEmpleado";
            labelNombreEmpleado.Size = new Size(123, 15);
            labelNombreEmpleado.TabIndex = 76;
            labelNombreEmpleado.Text = "Nombre de vendedor:";
            // 
            // panel6
            // 
            panel6.Controls.Add(labelAdvertenciaEmpleado);
            panel6.Controls.Add(btnCloseEmpleado);
            panel6.Controls.Add(textSearchEmpleado);
            panel6.Controls.Add(btnSearchEmpleado);
            panel6.Controls.Add(labelVendedor);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(722, 24);
            panel6.TabIndex = 75;
            // 
            // labelAdvertenciaEmpleado
            // 
            labelAdvertenciaEmpleado.AutoSize = true;
            labelAdvertenciaEmpleado.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAdvertenciaEmpleado.ForeColor = Color.DarkRed;
            labelAdvertenciaEmpleado.Location = new Point(281, 2);
            labelAdvertenciaEmpleado.Margin = new Padding(4, 0, 4, 0);
            labelAdvertenciaEmpleado.Name = "labelAdvertenciaEmpleado";
            labelAdvertenciaEmpleado.Size = new Size(156, 16);
            labelAdvertenciaEmpleado.TabIndex = 78;
            labelAdvertenciaEmpleado.Text = "No hay coincidencias";
            labelAdvertenciaEmpleado.Visible = false;
            // 
            // btnCloseEmpleado
            // 
            btnCloseEmpleado.BackColor = SystemColors.Control;
            btnCloseEmpleado.Cursor = Cursors.Hand;
            btnCloseEmpleado.ForeColor = Color.DarkRed;
            btnCloseEmpleado.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCloseEmpleado.IconColor = Color.DarkRed;
            btnCloseEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCloseEmpleado.IconSize = 21;
            btnCloseEmpleado.Location = new Point(630, 1);
            btnCloseEmpleado.Margin = new Padding(4, 3, 4, 3);
            btnCloseEmpleado.Name = "btnCloseEmpleado";
            btnCloseEmpleado.Size = new Size(21, 21);
            btnCloseEmpleado.TabIndex = 77;
            btnCloseEmpleado.TabStop = false;
            btnCloseEmpleado.Visible = false;
            btnCloseEmpleado.Click += btnCloseEmpleado_Click;
            // 
            // textSearchEmpleado
            // 
            textSearchEmpleado.Location = new Point(482, 0);
            textSearchEmpleado.Margin = new Padding(4, 3, 4, 3);
            textSearchEmpleado.Name = "textSearchEmpleado";
            textSearchEmpleado.Size = new Size(148, 23);
            textSearchEmpleado.TabIndex = 75;
            textSearchEmpleado.Text = "Buscar identificacion";
            textSearchEmpleado.Visible = false;
            textSearchEmpleado.TextChanged += textSearchEmpleado_TextChanged;
            textSearchEmpleado.Enter += textSearchEmpleado_Enter;
            // 
            // btnSearchEmpleado
            // 
            btnSearchEmpleado.BackColor = SystemColors.Control;
            btnSearchEmpleado.Cursor = Cursors.Hand;
            btnSearchEmpleado.ForeColor = SystemColors.ControlText;
            btnSearchEmpleado.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearchEmpleado.IconColor = SystemColors.ControlText;
            btnSearchEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearchEmpleado.IconSize = 23;
            btnSearchEmpleado.Location = new Point(652, 0);
            btnSearchEmpleado.Margin = new Padding(4, 3, 4, 3);
            btnSearchEmpleado.Name = "btnSearchEmpleado";
            btnSearchEmpleado.Size = new Size(23, 23);
            btnSearchEmpleado.TabIndex = 76;
            btnSearchEmpleado.TabStop = false;
            btnSearchEmpleado.Click += btnSearchEmpleado_Click;
            // 
            // labelVendedor
            // 
            labelVendedor.AutoSize = true;
            labelVendedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelVendedor.Location = new Point(4, 3);
            labelVendedor.Margin = new Padding(4, 0, 4, 0);
            labelVendedor.Name = "labelVendedor";
            labelVendedor.Size = new Size(75, 16);
            labelVendedor.TabIndex = 74;
            labelVendedor.Text = "Vendedor";
            // 
            // labelIdFactura
            // 
            labelIdFactura.AutoSize = true;
            labelIdFactura.Dock = DockStyle.Top;
            labelIdFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelIdFactura.ForeColor = Color.Black;
            labelIdFactura.Location = new Point(0, 0);
            labelIdFactura.Margin = new Padding(4, 0, 4, 0);
            labelIdFactura.Name = "labelIdFactura";
            labelIdFactura.Size = new Size(99, 16);
            labelIdFactura.TabIndex = 77;
            labelIdFactura.Text = "ID de factura:";
            // 
            // labelIdGeneradoDeFactura
            // 
            labelIdGeneradoDeFactura.AutoSize = true;
            labelIdGeneradoDeFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelIdGeneradoDeFactura.ForeColor = Color.Black;
            labelIdGeneradoDeFactura.Location = new Point(115, 0);
            labelIdGeneradoDeFactura.Margin = new Padding(4, 0, 4, 0);
            labelIdGeneradoDeFactura.Name = "labelIdGeneradoDeFactura";
            labelIdGeneradoDeFactura.Size = new Size(15, 16);
            labelIdGeneradoDeFactura.TabIndex = 78;
            labelIdGeneradoDeFactura.Text = "#";
            // 
            // textNombreCliente
            // 
            textNombreCliente.Location = new Point(118, 28);
            textNombreCliente.Margin = new Padding(4, 3, 4, 3);
            textNombreCliente.Name = "textNombreCliente";
            textNombreCliente.Size = new Size(166, 23);
            textNombreCliente.TabIndex = 79;
            // 
            // labelNombreCliente
            // 
            labelNombreCliente.AutoSize = true;
            labelNombreCliente.Location = new Point(6, 31);
            labelNombreCliente.Margin = new Padding(4, 0, 4, 0);
            labelNombreCliente.Name = "labelNombreCliente";
            labelNombreCliente.Size = new Size(108, 15);
            labelNombreCliente.TabIndex = 78;
            labelNombreCliente.Text = "Nombre de cliente:";
            // 
            // textIdentificacionCliente
            // 
            textIdentificacionCliente.Location = new Point(92, 54);
            textIdentificacionCliente.Margin = new Padding(4, 3, 4, 3);
            textIdentificacionCliente.Name = "textIdentificacionCliente";
            textIdentificacionCliente.Size = new Size(166, 23);
            textIdentificacionCliente.TabIndex = 81;
            // 
            // labelIdentificacionCliente
            // 
            labelIdentificacionCliente.AutoSize = true;
            labelIdentificacionCliente.Location = new Point(7, 59);
            labelIdentificacionCliente.Margin = new Padding(4, 0, 4, 0);
            labelIdentificacionCliente.Name = "labelIdentificacionCliente";
            labelIdentificacionCliente.Size = new Size(82, 15);
            labelIdentificacionCliente.TabIndex = 80;
            labelIdentificacionCliente.Text = "Identificacion:";
            // 
            // labelApellidoCliente
            // 
            labelApellidoCliente.AutoSize = true;
            labelApellidoCliente.Location = new Point(287, 32);
            labelApellidoCliente.Margin = new Padding(4, 0, 4, 0);
            labelApellidoCliente.Name = "labelApellidoCliente";
            labelApellidoCliente.Size = new Size(108, 15);
            labelApellidoCliente.TabIndex = 82;
            labelApellidoCliente.Text = "Apellido de cliente:";
            // 
            // textApellidoCliente
            // 
            textApellidoCliente.Location = new Point(399, 28);
            textApellidoCliente.Margin = new Padding(4, 3, 4, 3);
            textApellidoCliente.Name = "textApellidoCliente";
            textApellidoCliente.Size = new Size(166, 23);
            textApellidoCliente.TabIndex = 83;
            // 
            // labelTipoDeId
            // 
            labelTipoDeId.AutoSize = true;
            labelTipoDeId.Location = new Point(264, 59);
            labelTipoDeId.Margin = new Padding(4, 0, 4, 0);
            labelTipoDeId.Name = "labelTipoDeId";
            labelTipoDeId.Size = new Size(62, 15);
            labelTipoDeId.TabIndex = 84;
            labelTipoDeId.Text = "Tipo de Id:";
            // 
            // comboTipoDeId
            // 
            comboTipoDeId.FormattingEnabled = true;
            comboTipoDeId.Items.AddRange(new object[] { "CC", "TI" });
            comboTipoDeId.Location = new Point(331, 54);
            comboTipoDeId.Margin = new Padding(4, 3, 4, 3);
            comboTipoDeId.Name = "comboTipoDeId";
            comboTipoDeId.Size = new Size(67, 23);
            comboTipoDeId.TabIndex = 85;
            comboTipoDeId.Text = "CC";
            // 
            // labelSexo
            // 
            labelSexo.AutoSize = true;
            labelSexo.Location = new Point(404, 58);
            labelSexo.Margin = new Padding(4, 0, 4, 0);
            labelSexo.Name = "labelSexo";
            labelSexo.Size = new Size(35, 15);
            labelSexo.TabIndex = 86;
            labelSexo.Text = "Sexo:";
            // 
            // dateTimeFechaDeNacimiento
            // 
            dateTimeFechaDeNacimiento.Location = new Point(134, 81);
            dateTimeFechaDeNacimiento.Margin = new Padding(4, 3, 4, 3);
            dateTimeFechaDeNacimiento.Name = "dateTimeFechaDeNacimiento";
            dateTimeFechaDeNacimiento.Size = new Size(235, 23);
            dateTimeFechaDeNacimiento.TabIndex = 87;
            // 
            // labelFechaDeNacimiento
            // 
            labelFechaDeNacimiento.AutoSize = true;
            labelFechaDeNacimiento.Location = new Point(7, 84);
            labelFechaDeNacimiento.Margin = new Padding(4, 0, 4, 0);
            labelFechaDeNacimiento.Name = "labelFechaDeNacimiento";
            labelFechaDeNacimiento.Size = new Size(120, 15);
            labelFechaDeNacimiento.TabIndex = 88;
            labelFechaDeNacimiento.Text = "Fecha de nacimiento:";
            // 
            // comboSexo
            // 
            comboSexo.FormattingEnabled = true;
            comboSexo.Items.AddRange(new object[] { "M", "F" });
            comboSexo.Location = new Point(446, 53);
            comboSexo.Margin = new Padding(4, 3, 4, 3);
            comboSexo.Name = "comboSexo";
            comboSexo.Size = new Size(67, 23);
            comboSexo.TabIndex = 89;
            comboSexo.Text = "M";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(9, 111);
            labelTelefono.Margin = new Padding(4, 0, 4, 0);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(55, 15);
            labelTelefono.TabIndex = 90;
            labelTelefono.Text = "Telefono:";
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(68, 107);
            textTelefono.Margin = new Padding(4, 3, 4, 3);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(125, 23);
            textTelefono.TabIndex = 91;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(196, 112);
            labelCorreo.Margin = new Padding(4, 0, 4, 0);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(46, 15);
            labelCorreo.TabIndex = 92;
            labelCorreo.Text = "Correo:";
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(243, 107);
            textCorreo.Margin = new Padding(4, 3, 4, 3);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(258, 23);
            textCorreo.TabIndex = 93;
            // 
            // panelFactura
            // 
            panelFactura.Controls.Add(labelIdGeneradoDeFactura);
            panelFactura.Controls.Add(panel3);
            panelFactura.Controls.Add(panel8);
            panelFactura.Controls.Add(panel5);
            panelFactura.Controls.Add(labelIdFactura);
            panelFactura.Controls.Add(panelTotalesFactura);
            panelFactura.Controls.Add(dataGridFacturaProductos);
            panelFactura.Location = new Point(14, 83);
            panelFactura.Margin = new Padding(4, 3, 4, 3);
            panelFactura.Name = "panelFactura";
            panelFactura.Size = new Size(722, 465);
            panelFactura.TabIndex = 79;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 238);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(722, 25);
            panel3.TabIndex = 79;
            // 
            // panel8
            // 
            panel8.Controls.Add(labelDireccion);
            panel8.Controls.Add(textDireccion);
            panel8.Controls.Add(textCorreo);
            panel8.Controls.Add(panel4);
            panel8.Controls.Add(labelCorreo);
            panel8.Controls.Add(textNombreCliente);
            panel8.Controls.Add(textTelefono);
            panel8.Controls.Add(labelNombreCliente);
            panel8.Controls.Add(labelTelefono);
            panel8.Controls.Add(labelIdentificacionCliente);
            panel8.Controls.Add(comboSexo);
            panel8.Controls.Add(textIdentificacionCliente);
            panel8.Controls.Add(labelFechaDeNacimiento);
            panel8.Controls.Add(labelApellidoCliente);
            panel8.Controls.Add(dateTimeFechaDeNacimiento);
            panel8.Controls.Add(textApellidoCliente);
            panel8.Controls.Add(labelSexo);
            panel8.Controls.Add(labelTipoDeId);
            panel8.Controls.Add(comboTipoDeId);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 100);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(722, 138);
            panel8.TabIndex = 78;
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(372, 85);
            labelDireccion.Margin = new Padding(4, 0, 4, 0);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(60, 15);
            labelDireccion.TabIndex = 94;
            labelDireccion.Text = "Direccion:";
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(438, 81);
            textDireccion.Margin = new Padding(4, 3, 4, 3);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(166, 23);
            textDireccion.TabIndex = 95;
            // 
            // ImprimirDocumento
            // 
            ImprimirDocumento.PrintPage += Imprimir;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(651, 55);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(15, 16);
            label5.TabIndex = 88;
            label5.Text = "$";
            // 
            // labelBase
            // 
            labelBase.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelBase.AutoSize = true;
            labelBase.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBase.ForeColor = Color.Black;
            labelBase.Location = new Point(528, 57);
            labelBase.Margin = new Padding(4, 0, 4, 0);
            labelBase.Name = "labelBase";
            labelBase.Size = new Size(13, 15);
            labelBase.TabIndex = 87;
            labelBase.Text = "*";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(511, 54);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(15, 16);
            label4.TabIndex = 86;
            label4.Text = "$";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(512, 38);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 12);
            label6.TabIndex = 85;
            label6.Text = "-BASE";
            // 
            // iconBase
            // 
            iconBase.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconBase.BackColor = SystemColors.Control;
            iconBase.ForeColor = Color.Maroon;
            iconBase.IconChar = FontAwesome.Sharp.IconChar.Coins;
            iconBase.IconColor = Color.Maroon;
            iconBase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBase.IconSize = 37;
            iconBase.Location = new Point(470, 39);
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
            labelCash.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCash.ForeColor = Color.Black;
            labelCash.Location = new Point(670, 58);
            labelCash.Margin = new Padding(4, 0, 4, 0);
            labelCash.Name = "labelCash";
            labelCash.Size = new Size(13, 15);
            labelCash.TabIndex = 82;
            labelCash.Text = "*";
            // 
            // labelTextFondo
            // 
            labelTextFondo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTextFondo.AutoSize = true;
            labelTextFondo.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTextFondo.ForeColor = Color.Black;
            labelTextFondo.Location = new Point(652, 38);
            labelTextFondo.Margin = new Padding(4, 0, 4, 0);
            labelTextFondo.Name = "labelTextFondo";
            labelTextFondo.Size = new Size(42, 12);
            labelTextFondo.TabIndex = 83;
            labelTextFondo.Text = "VENTA";
            // 
            // iconCash
            // 
            iconCash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconCash.BackColor = SystemColors.Control;
            iconCash.ForeColor = Color.Gold;
            iconCash.IconChar = FontAwesome.Sharp.IconChar.Coins;
            iconCash.IconColor = Color.Gold;
            iconCash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCash.IconSize = 37;
            iconCash.Location = new Point(612, 39);
            iconCash.Margin = new Padding(4, 3, 4, 3);
            iconCash.Name = "iconCash";
            iconCash.Size = new Size(37, 37);
            iconCash.TabIndex = 81;
            iconCash.TabStop = false;
            // 
            // btnSoloVender
            // 
            btnSoloVender.BackColor = Color.Yellow;
            btnSoloVender.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSoloVender.ForeColor = Color.Black;
            btnSoloVender.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnSoloVender.IconColor = Color.Black;
            btnSoloVender.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnSoloVender.IconSize = 32;
            btnSoloVender.Location = new Point(226, 558);
            btnSoloVender.Name = "btnSoloVender";
            btnSoloVender.Size = new Size(137, 40);
            btnSoloVender.TabIndex = 89;
            btnSoloVender.Text = "Solo Vender";
            btnSoloVender.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSoloVender.UseVisualStyleBackColor = false;
            // 
            // btnImprimirFactura
            // 
            btnImprimirFactura.BackColor = Color.Yellow;
            btnImprimirFactura.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimirFactura.ForeColor = Color.Black;
            btnImprimirFactura.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnImprimirFactura.IconColor = Color.Black;
            btnImprimirFactura.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnImprimirFactura.IconSize = 32;
            btnImprimirFactura.Location = new Point(369, 558);
            btnImprimirFactura.Name = "btnImprimirFactura";
            btnImprimirFactura.Size = new Size(162, 40);
            btnImprimirFactura.TabIndex = 90;
            btnImprimirFactura.Text = "Imprimir Factura";
            btnImprimirFactura.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImprimirFactura.UseVisualStyleBackColor = false;
            // 
            // FormFacturaDeProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 606);
            Controls.Add(btnImprimirFactura);
            Controls.Add(btnSoloVender);
            Controls.Add(label5);
            Controls.Add(labelBase);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(iconBase);
            Controls.Add(labelCash);
            Controls.Add(labelTextFondo);
            Controls.Add(iconCash);
            Controls.Add(labelTitleFactura);
            Controls.Add(menuTop);
            Controls.Add(panelFactura);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormFacturaDeProducto";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormFacturaDeProducto";
            MouseDown += FormFacturaDeProducto_MouseDown;
            menuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridFacturaProductos).EndInit();
            panelTotalesFactura.ResumeLayout(false);
            panelTotalesFactura.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSearchCliente).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseEmpleado).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSearchEmpleado).EndInit();
            panelFactura.ResumeLayout(false);
            panelFactura.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconBase).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCash).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel menuTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private DataGridView dataGridFacturaProductos;
        private Label labelTitleFactura;
        private Label labelPago;
        private Label labelVueltos;
        private Label labelVueltosGenerado;
        private Label labelTotalFactura;
        private Label label3;
        private Panel panelTotalesFactura;
        private TextBox textPago;
        private Label labelCliente;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label labelVendedor;
        private Label labelIdFactura;
        private Label labelIdGeneradoDeFactura;
        private TextBox textNombreCliente;
        private Label labelNombreCliente;
        private TextBox textNombreEmpleado;
        private Label labelNombreEmpleado;
        private TextBox textIdentificacionCliente;
        private Label labelIdentificacionCliente;
        private TextBox textApellidoCliente;
        private Label labelApellidoCliente;
        private ComboBox comboTipoDeId;
        private Label labelTipoDeId;
        private Label labelSexo;
        private DateTimePicker dateTimeFechaDeNacimiento;
        private ComboBox comboSexo;
        private Label labelFechaDeNacimiento;
        private TextBox textCorreo;
        private Label labelCorreo;
        private TextBox textTelefono;
        private Label labelTelefono;
        private TextBox textIdentificacionEmpleado;
        private Label labelIdentificacionEmpleado;
        private TextBox textApellidoEmpleado;
        private Label labelApellidoEmpleado;
        private Panel panelFactura;
        private Panel panel3;
        private Panel panel8;
        private FontAwesome.Sharp.IconPictureBox btnCloseCliente;
        private TextBox textSearchCliente;
        private FontAwesome.Sharp.IconPictureBox btnSearchCliente;
        private FontAwesome.Sharp.IconPictureBox btnCloseEmpleado;
        private TextBox textSearchEmpleado;
        private FontAwesome.Sharp.IconPictureBox btnSearchEmpleado;
        private Label labelAdvertenciaCliente;
        private Label labelAdvertenciaEmpleado;
        private Label labelDireccion;
        private TextBox textDireccion;
        private Label label1;
        private ComboBox comboFormaDePago;
        private System.Drawing.Printing.PrintDocument ImprimirDocumento;
        private Label label2;
        private DataGridViewImageColumn Deshacer;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn ReferenciaP;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Detalle;
        private DataGridViewTextBoxColumn Precio;
        private TextBox textTotalFacturaGenerada;
        private Label label5;
        private Label labelBase;
        private Label label4;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconBase;
        private Label labelCash;
        private Label labelTextFondo;
        private FontAwesome.Sharp.IconPictureBox iconCash;
        private FontAwesome.Sharp.IconButton btnSoloVender;
        private FontAwesome.Sharp.IconButton btnImprimirFactura;
    }
}