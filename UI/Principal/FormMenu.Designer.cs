
namespace UI
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panelHeaderbar = new Panel();
            btnWindowMaximize = new FontAwesome.Sharp.IconPictureBox();
            btnWindowRestore = new FontAwesome.Sharp.IconPictureBox();
            btnWindowCerrar = new FontAwesome.Sharp.IconPictureBox();
            btnWindowMinimize = new FontAwesome.Sharp.IconPictureBox();
            panelSidebar = new Panel();
            panelSelectionMembresia = new Panel();
            panelSelectionAjustes = new Panel();
            btnAjustes = new FontAwesome.Sharp.IconButton();
            panelSelectionProductos = new Panel();
            panelSelectionPlanes = new Panel();
            btnGestionProductos = new FontAwesome.Sharp.IconButton();
            btnGestionPlanesDeEjercicio = new FontAwesome.Sharp.IconButton();
            btnGestionMembresia = new FontAwesome.Sharp.IconButton();
            panelSelectionUsuario = new Panel();
            panelSelectionCaja = new Panel();
            subMenuUsuario = new Panel();
            btnEmpleado = new FontAwesome.Sharp.IconButton();
            btnAdministrador = new FontAwesome.Sharp.IconButton();
            btnEntrenador = new FontAwesome.Sharp.IconButton();
            btnClientes = new FontAwesome.Sharp.IconButton();
            btnGestionUsurio = new FontAwesome.Sharp.IconButton();
            btnGestionCaja = new FontAwesome.Sharp.IconButton();
            panelLogoContainer = new Panel();
            panel2 = new Panel();
            panelSidebarClose = new Panel();
            labelMenu = new Label();
            pictureBox1 = new PictureBox();
            btnOpenSidebar = new FontAwesome.Sharp.IconPictureBox();
            btnCloseSidebar = new FontAwesome.Sharp.IconPictureBox();
            labelLogoName = new Label();
            pictureLogo = new PictureBox();
            panelPerfil = new GroupBox();
            labelRolPerfil = new Label();
            pictureBox3 = new PictureBox();
            picturePerfil = new PictureBox();
            labelNombrePerfil = new Label();
            panelContenedorInterno = new Panel();
            btnModeLight = new FontAwesome.Sharp.IconPictureBox();
            panelHeader = new Panel();
            btnModeDark = new FontAwesome.Sharp.IconPictureBox();
            iconClock = new FontAwesome.Sharp.IconPictureBox();
            pictureAlert = new PictureBox();
            iconThemeSun = new FontAwesome.Sharp.IconPictureBox();
            textTiempoLicencia = new TextBox();
            labelTiempoLicencia = new Label();
            btnVerLicencia = new FontAwesome.Sharp.IconButton();
            labelAvsio = new Label();
            labelHeaderRuta = new Label();
            iconThemeMoon = new FontAwesome.Sharp.IconPictureBox();
            panelSalir = new GroupBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panelHeaderbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnWindowMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnWindowRestore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnWindowCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnWindowMinimize).BeginInit();
            panelSidebar.SuspendLayout();
            subMenuUsuario.SuspendLayout();
            panelLogoContainer.SuspendLayout();
            panel2.SuspendLayout();
            panelSidebarClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnOpenSidebar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCloseSidebar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            panelPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnModeLight).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnModeDark).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconClock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureAlert).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconThemeSun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconThemeMoon).BeginInit();
            panelSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelHeaderbar
            // 
            panelHeaderbar.BackColor = Color.Black;
            panelHeaderbar.Controls.Add(btnWindowMaximize);
            panelHeaderbar.Controls.Add(btnWindowRestore);
            panelHeaderbar.Controls.Add(btnWindowCerrar);
            panelHeaderbar.Controls.Add(btnWindowMinimize);
            panelHeaderbar.Dock = DockStyle.Top;
            panelHeaderbar.Location = new Point(0, 0);
            panelHeaderbar.Margin = new Padding(4, 3, 4, 3);
            panelHeaderbar.Name = "panelHeaderbar";
            panelHeaderbar.Size = new Size(1027, 31);
            panelHeaderbar.TabIndex = 2;
            panelHeaderbar.MouseDown += panelHeaderbar_MouseDown;
            // 
            // btnWindowMaximize
            // 
            btnWindowMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnWindowMaximize.ForeColor = SystemColors.ControlLightLight;
            btnWindowMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnWindowMaximize.IconColor = SystemColors.ControlLightLight;
            btnWindowMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnWindowMaximize.IconSize = 23;
            btnWindowMaximize.Location = new Point(966, 5);
            btnWindowMaximize.Margin = new Padding(4, 3, 4, 3);
            btnWindowMaximize.Name = "btnWindowMaximize";
            btnWindowMaximize.Size = new Size(23, 23);
            btnWindowMaximize.TabIndex = 4;
            btnWindowMaximize.TabStop = false;
            btnWindowMaximize.Click += btnWindowMaximize_Click;
            // 
            // btnWindowRestore
            // 
            btnWindowRestore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnWindowRestore.BackColor = Color.FromArgb(2, 56, 89);
            btnWindowRestore.ForeColor = SystemColors.ControlLightLight;
            btnWindowRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnWindowRestore.IconColor = SystemColors.ControlLightLight;
            btnWindowRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnWindowRestore.IconSize = 23;
            btnWindowRestore.Location = new Point(966, 5);
            btnWindowRestore.Margin = new Padding(4, 3, 4, 3);
            btnWindowRestore.Name = "btnWindowRestore";
            btnWindowRestore.Size = new Size(23, 23);
            btnWindowRestore.TabIndex = 5;
            btnWindowRestore.TabStop = false;
            btnWindowRestore.Click += btnWindowRestore_Click;
            // 
            // btnWindowCerrar
            // 
            btnWindowCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnWindowCerrar.ForeColor = SystemColors.ControlLightLight;
            btnWindowCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            btnWindowCerrar.IconColor = SystemColors.ControlLightLight;
            btnWindowCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnWindowCerrar.IconSize = 23;
            btnWindowCerrar.Location = new Point(993, 5);
            btnWindowCerrar.Margin = new Padding(4, 3, 4, 3);
            btnWindowCerrar.Name = "btnWindowCerrar";
            btnWindowCerrar.Size = new Size(23, 23);
            btnWindowCerrar.TabIndex = 3;
            btnWindowCerrar.TabStop = false;
            btnWindowCerrar.Click += btnWindowCerrar_Click;
            // 
            // btnWindowMinimize
            // 
            btnWindowMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnWindowMinimize.ForeColor = SystemColors.ControlLightLight;
            btnWindowMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnWindowMinimize.IconColor = SystemColors.ControlLightLight;
            btnWindowMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnWindowMinimize.IconSize = 23;
            btnWindowMinimize.Location = new Point(939, 5);
            btnWindowMinimize.Margin = new Padding(4, 3, 4, 3);
            btnWindowMinimize.Name = "btnWindowMinimize";
            btnWindowMinimize.Size = new Size(23, 23);
            btnWindowMinimize.TabIndex = 1;
            btnWindowMinimize.TabStop = false;
            btnWindowMinimize.Click += btnWindowMinimize_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.AutoScroll = true;
            panelSidebar.BackColor = SystemColors.ControlLight;
            panelSidebar.Controls.Add(panelSalir);
            panelSidebar.Controls.Add(panelSelectionMembresia);
            panelSidebar.Controls.Add(panelSelectionAjustes);
            panelSidebar.Controls.Add(btnAjustes);
            panelSidebar.Controls.Add(panelSelectionProductos);
            panelSidebar.Controls.Add(panelSelectionPlanes);
            panelSidebar.Controls.Add(btnGestionProductos);
            panelSidebar.Controls.Add(btnGestionPlanesDeEjercicio);
            panelSidebar.Controls.Add(btnGestionMembresia);
            panelSidebar.Controls.Add(panelSelectionUsuario);
            panelSidebar.Controls.Add(panelSelectionCaja);
            panelSidebar.Controls.Add(subMenuUsuario);
            panelSidebar.Controls.Add(btnGestionUsurio);
            panelSidebar.Controls.Add(btnGestionCaja);
            panelSidebar.Controls.Add(panelLogoContainer);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 31);
            panelSidebar.Margin = new Padding(4, 3, 4, 3);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(217, 677);
            panelSidebar.TabIndex = 3;
            panelSidebar.MouseDown += panelSidebar_MouseDown;
            // 
            // panelSelectionMembresia
            // 
            panelSelectionMembresia.BackColor = SystemColors.ControlLightLight;
            panelSelectionMembresia.Location = new Point(0, 441);
            panelSelectionMembresia.Margin = new Padding(4, 3, 4, 3);
            panelSelectionMembresia.Name = "panelSelectionMembresia";
            panelSelectionMembresia.Size = new Size(7, 43);
            panelSelectionMembresia.TabIndex = 12;
            panelSelectionMembresia.Visible = false;
            // 
            // panelSelectionAjustes
            // 
            panelSelectionAjustes.BackColor = SystemColors.ControlLightLight;
            panelSelectionAjustes.Location = new Point(0, 572);
            panelSelectionAjustes.Margin = new Padding(4, 3, 4, 3);
            panelSelectionAjustes.Name = "panelSelectionAjustes";
            panelSelectionAjustes.Size = new Size(7, 43);
            panelSelectionAjustes.TabIndex = 12;
            panelSelectionAjustes.Visible = false;
            // 
            // btnAjustes
            // 
            btnAjustes.BackColor = Color.FromArgb(89, 2, 2);
            btnAjustes.Dock = DockStyle.Top;
            btnAjustes.FlatAppearance.BorderColor = Color.FromArgb(62, 178, 191);
            btnAjustes.FlatAppearance.BorderSize = 0;
            btnAjustes.FlatAppearance.MouseDownBackColor = Color.Black;
            btnAjustes.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 178, 191);
            btnAjustes.FlatStyle = FlatStyle.Flat;
            btnAjustes.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAjustes.ForeColor = SystemColors.ButtonHighlight;
            btnAjustes.IconChar = FontAwesome.Sharp.IconChar.Gear;
            btnAjustes.IconColor = Color.White;
            btnAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAjustes.IconSize = 22;
            btnAjustes.Location = new Point(0, 572);
            btnAjustes.Margin = new Padding(4, 3, 4, 3);
            btnAjustes.Name = "btnAjustes";
            btnAjustes.Size = new Size(217, 43);
            btnAjustes.TabIndex = 24;
            btnAjustes.Text = "   Ajustes";
            btnAjustes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAjustes.UseVisualStyleBackColor = false;
            btnAjustes.Click += btnAjustes_Click;
            // 
            // panelSelectionProductos
            // 
            panelSelectionProductos.BackColor = SystemColors.ControlLightLight;
            panelSelectionProductos.Location = new Point(0, 529);
            panelSelectionProductos.Margin = new Padding(4, 3, 4, 3);
            panelSelectionProductos.Name = "panelSelectionProductos";
            panelSelectionProductos.Size = new Size(7, 43);
            panelSelectionProductos.TabIndex = 11;
            panelSelectionProductos.Visible = false;
            // 
            // panelSelectionPlanes
            // 
            panelSelectionPlanes.BackColor = SystemColors.ControlLightLight;
            panelSelectionPlanes.Location = new Point(0, 486);
            panelSelectionPlanes.Margin = new Padding(4, 3, 4, 3);
            panelSelectionPlanes.Name = "panelSelectionPlanes";
            panelSelectionPlanes.Size = new Size(7, 43);
            panelSelectionPlanes.TabIndex = 10;
            panelSelectionPlanes.Visible = false;
            // 
            // btnGestionProductos
            // 
            btnGestionProductos.BackColor = Color.FromArgb(89, 2, 2);
            btnGestionProductos.Dock = DockStyle.Top;
            btnGestionProductos.FlatAppearance.BorderColor = Color.FromArgb(62, 178, 191);
            btnGestionProductos.FlatAppearance.BorderSize = 0;
            btnGestionProductos.FlatAppearance.MouseDownBackColor = Color.Black;
            btnGestionProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 178, 191);
            btnGestionProductos.FlatStyle = FlatStyle.Flat;
            btnGestionProductos.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionProductos.ForeColor = SystemColors.ButtonHighlight;
            btnGestionProductos.IconChar = FontAwesome.Sharp.IconChar.BottleWater;
            btnGestionProductos.IconColor = Color.White;
            btnGestionProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGestionProductos.IconSize = 22;
            btnGestionProductos.Location = new Point(0, 529);
            btnGestionProductos.Margin = new Padding(4, 3, 4, 3);
            btnGestionProductos.Name = "btnGestionProductos";
            btnGestionProductos.Size = new Size(217, 43);
            btnGestionProductos.TabIndex = 11;
            btnGestionProductos.Text = "   Productos";
            btnGestionProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGestionProductos.UseVisualStyleBackColor = false;
            btnGestionProductos.Click += btnGestionProductos_Click;
            // 
            // btnGestionPlanesDeEjercicio
            // 
            btnGestionPlanesDeEjercicio.BackColor = Color.FromArgb(89, 2, 2);
            btnGestionPlanesDeEjercicio.Dock = DockStyle.Top;
            btnGestionPlanesDeEjercicio.FlatAppearance.BorderColor = Color.FromArgb(62, 178, 191);
            btnGestionPlanesDeEjercicio.FlatAppearance.BorderSize = 0;
            btnGestionPlanesDeEjercicio.FlatAppearance.MouseDownBackColor = Color.Black;
            btnGestionPlanesDeEjercicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 178, 191);
            btnGestionPlanesDeEjercicio.FlatStyle = FlatStyle.Flat;
            btnGestionPlanesDeEjercicio.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionPlanesDeEjercicio.ForeColor = SystemColors.ButtonHighlight;
            btnGestionPlanesDeEjercicio.IconChar = FontAwesome.Sharp.IconChar.VoteYea;
            btnGestionPlanesDeEjercicio.IconColor = Color.White;
            btnGestionPlanesDeEjercicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGestionPlanesDeEjercicio.IconSize = 22;
            btnGestionPlanesDeEjercicio.Location = new Point(0, 486);
            btnGestionPlanesDeEjercicio.Margin = new Padding(4, 3, 4, 3);
            btnGestionPlanesDeEjercicio.Name = "btnGestionPlanesDeEjercicio";
            btnGestionPlanesDeEjercicio.Size = new Size(217, 43);
            btnGestionPlanesDeEjercicio.TabIndex = 23;
            btnGestionPlanesDeEjercicio.Text = "   Planes de ejercicio";
            btnGestionPlanesDeEjercicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGestionPlanesDeEjercicio.UseVisualStyleBackColor = false;
            btnGestionPlanesDeEjercicio.Click += btnGestionPlanesDeEjercicio_Click;
            // 
            // btnGestionMembresia
            // 
            btnGestionMembresia.BackColor = Color.FromArgb(89, 2, 2);
            btnGestionMembresia.Dock = DockStyle.Top;
            btnGestionMembresia.FlatAppearance.BorderColor = Color.FromArgb(62, 178, 191);
            btnGestionMembresia.FlatAppearance.BorderSize = 0;
            btnGestionMembresia.FlatAppearance.MouseDownBackColor = Color.Black;
            btnGestionMembresia.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 178, 191);
            btnGestionMembresia.FlatStyle = FlatStyle.Flat;
            btnGestionMembresia.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionMembresia.ForeColor = SystemColors.ButtonHighlight;
            btnGestionMembresia.IconChar = FontAwesome.Sharp.IconChar.Wpforms;
            btnGestionMembresia.IconColor = Color.White;
            btnGestionMembresia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGestionMembresia.IconSize = 22;
            btnGestionMembresia.Location = new Point(0, 443);
            btnGestionMembresia.Margin = new Padding(4, 3, 4, 3);
            btnGestionMembresia.Name = "btnGestionMembresia";
            btnGestionMembresia.Size = new Size(217, 43);
            btnGestionMembresia.TabIndex = 15;
            btnGestionMembresia.Text = "   Membresias";
            btnGestionMembresia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGestionMembresia.UseVisualStyleBackColor = false;
            btnGestionMembresia.Click += btnGestionMembresia_Click;
            // 
            // panelSelectionUsuario
            // 
            panelSelectionUsuario.BackColor = SystemColors.ControlLightLight;
            panelSelectionUsuario.Location = new Point(0, 224);
            panelSelectionUsuario.Margin = new Padding(4, 3, 4, 3);
            panelSelectionUsuario.Name = "panelSelectionUsuario";
            panelSelectionUsuario.Size = new Size(7, 43);
            panelSelectionUsuario.TabIndex = 8;
            panelSelectionUsuario.Visible = false;
            // 
            // panelSelectionCaja
            // 
            panelSelectionCaja.BackColor = SystemColors.ControlLightLight;
            panelSelectionCaja.Location = new Point(0, 182);
            panelSelectionCaja.Margin = new Padding(4, 3, 4, 3);
            panelSelectionCaja.Name = "panelSelectionCaja";
            panelSelectionCaja.Size = new Size(7, 43);
            panelSelectionCaja.TabIndex = 0;
            panelSelectionCaja.Visible = false;
            // 
            // subMenuUsuario
            // 
            subMenuUsuario.BackColor = SystemColors.ControlLight;
            subMenuUsuario.Controls.Add(btnEmpleado);
            subMenuUsuario.Controls.Add(btnAdministrador);
            subMenuUsuario.Controls.Add(btnEntrenador);
            subMenuUsuario.Controls.Add(btnClientes);
            subMenuUsuario.Dock = DockStyle.Top;
            subMenuUsuario.Location = new Point(0, 267);
            subMenuUsuario.Margin = new Padding(4, 3, 4, 3);
            subMenuUsuario.Name = "subMenuUsuario";
            subMenuUsuario.Size = new Size(217, 176);
            subMenuUsuario.TabIndex = 10;
            // 
            // btnEmpleado
            // 
            btnEmpleado.BackColor = Color.FromArgb(64, 1, 1);
            btnEmpleado.Dock = DockStyle.Top;
            btnEmpleado.FlatAppearance.BorderSize = 0;
            btnEmpleado.FlatAppearance.MouseDownBackColor = Color.Black;
            btnEmpleado.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 178, 191);
            btnEmpleado.FlatStyle = FlatStyle.Flat;
            btnEmpleado.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmpleado.ForeColor = SystemColors.ButtonHighlight;
            btnEmpleado.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            btnEmpleado.IconColor = Color.White;
            btnEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEmpleado.IconSize = 10;
            btnEmpleado.Location = new Point(0, 133);
            btnEmpleado.Margin = new Padding(4, 3, 4, 3);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(217, 43);
            btnEmpleado.TabIndex = 14;
            btnEmpleado.Text = "Empleado";
            btnEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpleado.UseVisualStyleBackColor = false;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnAdministrador
            // 
            btnAdministrador.BackColor = Color.FromArgb(64, 1, 1);
            btnAdministrador.Dock = DockStyle.Top;
            btnAdministrador.FlatAppearance.BorderSize = 0;
            btnAdministrador.FlatAppearance.MouseDownBackColor = Color.Black;
            btnAdministrador.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 178, 191);
            btnAdministrador.FlatStyle = FlatStyle.Flat;
            btnAdministrador.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdministrador.ForeColor = SystemColors.ButtonHighlight;
            btnAdministrador.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            btnAdministrador.IconColor = Color.White;
            btnAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdministrador.IconSize = 10;
            btnAdministrador.Location = new Point(0, 88);
            btnAdministrador.Margin = new Padding(4, 3, 4, 3);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Size = new Size(217, 45);
            btnAdministrador.TabIndex = 13;
            btnAdministrador.Text = "Administrador";
            btnAdministrador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdministrador.UseVisualStyleBackColor = false;
            btnAdministrador.Click += btnAdministrador_Click;
            // 
            // btnEntrenador
            // 
            btnEntrenador.BackColor = Color.FromArgb(64, 1, 1);
            btnEntrenador.Dock = DockStyle.Top;
            btnEntrenador.FlatAppearance.BorderSize = 0;
            btnEntrenador.FlatAppearance.MouseDownBackColor = Color.Black;
            btnEntrenador.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 178, 191);
            btnEntrenador.FlatStyle = FlatStyle.Flat;
            btnEntrenador.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrenador.ForeColor = SystemColors.ButtonHighlight;
            btnEntrenador.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            btnEntrenador.IconColor = Color.White;
            btnEntrenador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEntrenador.IconSize = 10;
            btnEntrenador.Location = new Point(0, 43);
            btnEntrenador.Margin = new Padding(4, 3, 4, 3);
            btnEntrenador.Name = "btnEntrenador";
            btnEntrenador.Size = new Size(217, 45);
            btnEntrenador.TabIndex = 12;
            btnEntrenador.Text = "Entrenador";
            btnEntrenador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEntrenador.UseVisualStyleBackColor = false;
            btnEntrenador.Click += btnEntrenador_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(64, 1, 1);
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.Black;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 178, 191);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClientes.ForeColor = SystemColors.ButtonHighlight;
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            btnClientes.IconColor = Color.White;
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientes.IconSize = 10;
            btnClientes.Location = new Point(0, 0);
            btnClientes.Margin = new Padding(4, 3, 4, 3);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(217, 43);
            btnClientes.TabIndex = 11;
            btnClientes.Text = "Clientes";
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnGestionUsurio
            // 
            btnGestionUsurio.BackColor = Color.FromArgb(89, 2, 2);
            btnGestionUsurio.Dock = DockStyle.Top;
            btnGestionUsurio.FlatAppearance.BorderColor = Color.FromArgb(62, 178, 191);
            btnGestionUsurio.FlatAppearance.BorderSize = 0;
            btnGestionUsurio.FlatAppearance.MouseDownBackColor = Color.Black;
            btnGestionUsurio.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 178, 191);
            btnGestionUsurio.FlatStyle = FlatStyle.Flat;
            btnGestionUsurio.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionUsurio.ForeColor = SystemColors.ButtonHighlight;
            btnGestionUsurio.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            btnGestionUsurio.IconColor = Color.White;
            btnGestionUsurio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGestionUsurio.IconSize = 22;
            btnGestionUsurio.Location = new Point(0, 224);
            btnGestionUsurio.Margin = new Padding(4, 3, 4, 3);
            btnGestionUsurio.Name = "btnGestionUsurio";
            btnGestionUsurio.Size = new Size(217, 43);
            btnGestionUsurio.TabIndex = 9;
            btnGestionUsurio.Text = "   Usuarios";
            btnGestionUsurio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGestionUsurio.UseVisualStyleBackColor = false;
            btnGestionUsurio.Click += btnGestionUsurio_Click;
            // 
            // btnGestionCaja
            // 
            btnGestionCaja.BackColor = Color.FromArgb(89, 2, 2);
            btnGestionCaja.Dock = DockStyle.Top;
            btnGestionCaja.FlatAppearance.BorderSize = 0;
            btnGestionCaja.FlatAppearance.MouseDownBackColor = Color.Black;
            btnGestionCaja.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 178, 191);
            btnGestionCaja.FlatStyle = FlatStyle.Flat;
            btnGestionCaja.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionCaja.ForeColor = SystemColors.ButtonHighlight;
            btnGestionCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnGestionCaja.IconColor = Color.White;
            btnGestionCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGestionCaja.IconSize = 22;
            btnGestionCaja.Location = new Point(0, 181);
            btnGestionCaja.Margin = new Padding(4, 3, 4, 3);
            btnGestionCaja.Name = "btnGestionCaja";
            btnGestionCaja.Size = new Size(217, 43);
            btnGestionCaja.TabIndex = 2;
            btnGestionCaja.Text = "   Caja registradora";
            btnGestionCaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGestionCaja.UseVisualStyleBackColor = false;
            btnGestionCaja.Click += btnGestionCaja_Click;
            // 
            // panelLogoContainer
            // 
            panelLogoContainer.Controls.Add(panel2);
            panelLogoContainer.Controls.Add(panelPerfil);
            panelLogoContainer.Dock = DockStyle.Top;
            panelLogoContainer.Location = new Point(0, 0);
            panelLogoContainer.Margin = new Padding(4, 3, 4, 3);
            panelLogoContainer.Name = "panelLogoContainer";
            panelLogoContainer.Size = new Size(217, 181);
            panelLogoContainer.TabIndex = 0;
            panelLogoContainer.MouseDown += panelLogoContainer_MouseDown;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelSidebarClose);
            panel2.Controls.Add(btnOpenSidebar);
            panel2.Controls.Add(btnCloseSidebar);
            panel2.Controls.Add(labelLogoName);
            panel2.Controls.Add(pictureLogo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(217, 120);
            panel2.TabIndex = 8;
            // 
            // panelSidebarClose
            // 
            panelSidebarClose.Controls.Add(labelMenu);
            panelSidebarClose.Controls.Add(pictureBox1);
            panelSidebarClose.Location = new Point(-5, 35);
            panelSidebarClose.Margin = new Padding(4, 3, 4, 3);
            panelSidebarClose.Name = "panelSidebarClose";
            panelSidebarClose.Size = new Size(61, 80);
            panelSidebarClose.TabIndex = 11;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelMenu.Location = new Point(4, 54);
            labelMenu.Margin = new Padding(4, 0, 4, 0);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(38, 13);
            labelMenu.TabIndex = 7;
            labelMenu.Text = "Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnOpenSidebar
            // 
            btnOpenSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenSidebar.BackColor = SystemColors.ControlLight;
            btnOpenSidebar.ForeColor = Color.FromArgb(89, 2, 2);
            btnOpenSidebar.IconChar = FontAwesome.Sharp.IconChar.CircleChevronRight;
            btnOpenSidebar.IconColor = Color.FromArgb(89, 2, 2);
            btnOpenSidebar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOpenSidebar.IconSize = 35;
            btnOpenSidebar.Location = new Point(181, 2);
            btnOpenSidebar.Margin = new Padding(4, 3, 4, 3);
            btnOpenSidebar.Name = "btnOpenSidebar";
            btnOpenSidebar.Size = new Size(36, 35);
            btnOpenSidebar.TabIndex = 10;
            btnOpenSidebar.TabStop = false;
            btnOpenSidebar.Click += btnOpenSidebar_Click;
            // 
            // btnCloseSidebar
            // 
            btnCloseSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseSidebar.BackColor = SystemColors.ControlLight;
            btnCloseSidebar.ForeColor = Color.FromArgb(89, 2, 2);
            btnCloseSidebar.IconChar = FontAwesome.Sharp.IconChar.CircleChevronLeft;
            btnCloseSidebar.IconColor = Color.FromArgb(89, 2, 2);
            btnCloseSidebar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCloseSidebar.IconSize = 35;
            btnCloseSidebar.Location = new Point(185, 2);
            btnCloseSidebar.Margin = new Padding(4, 3, 4, 3);
            btnCloseSidebar.Name = "btnCloseSidebar";
            btnCloseSidebar.Size = new Size(36, 35);
            btnCloseSidebar.TabIndex = 9;
            btnCloseSidebar.TabStop = false;
            btnCloseSidebar.Click += btnCloseSidebar_Click;
            // 
            // labelLogoName
            // 
            labelLogoName.AutoSize = true;
            labelLogoName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogoName.Location = new Point(31, 89);
            labelLogoName.Margin = new Padding(4, 0, 4, 0);
            labelLogoName.Name = "labelLogoName";
            labelLogoName.Size = new Size(112, 16);
            labelLogoName.TabIndex = 8;
            labelLogoName.Text = "Admin YouGym";
            // 
            // pictureLogo
            // 
            pictureLogo.Image = Properties.Resources.Logo;
            pictureLogo.Location = new Point(33, 6);
            pictureLogo.Margin = new Padding(4, 3, 4, 3);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(111, 80);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 7;
            pictureLogo.TabStop = false;
            // 
            // panelPerfil
            // 
            panelPerfil.Controls.Add(labelRolPerfil);
            panelPerfil.Controls.Add(pictureBox3);
            panelPerfil.Controls.Add(picturePerfil);
            panelPerfil.Controls.Add(labelNombrePerfil);
            panelPerfil.Dock = DockStyle.Bottom;
            panelPerfil.FlatStyle = FlatStyle.System;
            panelPerfil.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            panelPerfil.Location = new Point(0, 120);
            panelPerfil.Name = "panelPerfil";
            panelPerfil.Size = new Size(217, 61);
            panelPerfil.TabIndex = 0;
            panelPerfil.TabStop = false;
            panelPerfil.Text = "Perfil de usuario";
            // 
            // labelRolPerfil
            // 
            labelRolPerfil.AutoSize = true;
            labelRolPerfil.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelRolPerfil.Location = new Point(53, 36);
            labelRolPerfil.Margin = new Padding(4, 0, 4, 0);
            labelRolPerfil.Name = "labelRolPerfil";
            labelRolPerfil.Size = new Size(100, 20);
            labelRolPerfil.TabIndex = 4;
            labelRolPerfil.Text = "Rol de usuario";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Green_dot_svg;
            pictureBox3.Location = new Point(38, 46);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 10);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // picturePerfil
            // 
            picturePerfil.Image = Properties.Resources.User;
            picturePerfil.Location = new Point(8, 19);
            picturePerfil.Name = "picturePerfil";
            picturePerfil.Size = new Size(38, 38);
            picturePerfil.SizeMode = PictureBoxSizeMode.Zoom;
            picturePerfil.TabIndex = 0;
            picturePerfil.TabStop = false;
            picturePerfil.Paint += picturePerfil_Paint;
            // 
            // labelNombrePerfil
            // 
            labelNombrePerfil.AutoSize = true;
            labelNombrePerfil.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelNombrePerfil.Location = new Point(53, 17);
            labelNombrePerfil.Margin = new Padding(4, 0, 4, 0);
            labelNombrePerfil.Name = "labelNombrePerfil";
            labelNombrePerfil.Size = new Size(128, 20);
            labelNombrePerfil.TabIndex = 2;
            labelNombrePerfil.Text = "Nombre de usuario";
            // 
            // panelContenedorInterno
            // 
            panelContenedorInterno.Dock = DockStyle.Fill;
            panelContenedorInterno.Location = new Point(217, 60);
            panelContenedorInterno.Margin = new Padding(4, 3, 4, 3);
            panelContenedorInterno.Name = "panelContenedorInterno";
            panelContenedorInterno.Size = new Size(810, 648);
            panelContenedorInterno.TabIndex = 6;
            // 
            // btnModeLight
            // 
            btnModeLight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModeLight.BackColor = Color.FromArgb(41, 34, 33);
            btnModeLight.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            btnModeLight.IconColor = Color.White;
            btnModeLight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModeLight.IconSize = 28;
            btnModeLight.Location = new Point(746, -1);
            btnModeLight.Margin = new Padding(4, 3, 4, 3);
            btnModeLight.Name = "btnModeLight";
            btnModeLight.Size = new Size(28, 29);
            btnModeLight.TabIndex = 6;
            btnModeLight.TabStop = false;
            btnModeLight.Click += btnModeLight_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 34, 33);
            panelHeader.Controls.Add(btnModeDark);
            panelHeader.Controls.Add(btnModeLight);
            panelHeader.Controls.Add(iconClock);
            panelHeader.Controls.Add(pictureAlert);
            panelHeader.Controls.Add(iconThemeSun);
            panelHeader.Controls.Add(textTiempoLicencia);
            panelHeader.Controls.Add(labelTiempoLicencia);
            panelHeader.Controls.Add(btnVerLicencia);
            panelHeader.Controls.Add(labelAvsio);
            panelHeader.Controls.Add(labelHeaderRuta);
            panelHeader.Controls.Add(iconThemeMoon);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(217, 31);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(810, 29);
            panelHeader.TabIndex = 5;
            // 
            // btnModeDark
            // 
            btnModeDark.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModeDark.BackColor = Color.FromArgb(41, 34, 33);
            btnModeDark.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            btnModeDark.IconColor = Color.White;
            btnModeDark.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModeDark.IconSize = 28;
            btnModeDark.Location = new Point(746, -1);
            btnModeDark.Margin = new Padding(4, 3, 4, 3);
            btnModeDark.Name = "btnModeDark";
            btnModeDark.Size = new Size(28, 29);
            btnModeDark.TabIndex = 7;
            btnModeDark.TabStop = false;
            btnModeDark.Click += btnModeDark_Click;
            // 
            // iconClock
            // 
            iconClock.BackColor = Color.FromArgb(41, 34, 33);
            iconClock.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            iconClock.IconColor = Color.White;
            iconClock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconClock.IconSize = 28;
            iconClock.Location = new Point(456, 0);
            iconClock.Name = "iconClock";
            iconClock.Size = new Size(28, 28);
            iconClock.TabIndex = 7;
            iconClock.TabStop = false;
            iconClock.Visible = false;
            // 
            // pictureAlert
            // 
            pictureAlert.Image = Properties.Resources.Alert;
            pictureAlert.Location = new Point(280, 1);
            pictureAlert.Name = "pictureAlert";
            pictureAlert.Size = new Size(29, 26);
            pictureAlert.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAlert.TabIndex = 7;
            pictureAlert.TabStop = false;
            pictureAlert.Visible = false;
            // 
            // iconThemeSun
            // 
            iconThemeSun.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconThemeSun.BackColor = Color.FromArgb(41, 34, 33);
            iconThemeSun.ForeColor = Color.Yellow;
            iconThemeSun.IconChar = FontAwesome.Sharp.IconChar.Sun;
            iconThemeSun.IconColor = Color.Yellow;
            iconThemeSun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconThemeSun.IconSize = 28;
            iconThemeSun.Location = new Point(716, 0);
            iconThemeSun.Margin = new Padding(4, 3, 4, 3);
            iconThemeSun.Name = "iconThemeSun";
            iconThemeSun.Size = new Size(28, 29);
            iconThemeSun.TabIndex = 9;
            iconThemeSun.TabStop = false;
            // 
            // textTiempoLicencia
            // 
            textTiempoLicencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textTiempoLicencia.Location = new Point(634, 3);
            textTiempoLicencia.Margin = new Padding(4, 3, 4, 3);
            textTiempoLicencia.Name = "textTiempoLicencia";
            textTiempoLicencia.Size = new Size(40, 23);
            textTiempoLicencia.TabIndex = 54;
            textTiempoLicencia.Visible = false;
            // 
            // labelTiempoLicencia
            // 
            labelTiempoLicencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTiempoLicencia.AutoSize = true;
            labelTiempoLicencia.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTiempoLicencia.ForeColor = SystemColors.ControlLightLight;
            labelTiempoLicencia.Location = new Point(482, 6);
            labelTiempoLicencia.Margin = new Padding(4, 0, 4, 0);
            labelTiempoLicencia.Name = "labelTiempoLicencia";
            labelTiempoLicencia.Size = new Size(111, 16);
            labelTiempoLicencia.TabIndex = 13;
            labelTiempoLicencia.Text = "Tiempo de uso";
            labelTiempoLicencia.Visible = false;
            // 
            // btnVerLicencia
            // 
            btnVerLicencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerLicencia.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            btnVerLicencia.IconColor = Color.DarkGoldenrod;
            btnVerLicencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerLicencia.IconSize = 20;
            btnVerLicencia.Location = new Point(596, 0);
            btnVerLicencia.Margin = new Padding(4, 3, 4, 3);
            btnVerLicencia.Name = "btnVerLicencia";
            btnVerLicencia.Size = new Size(35, 28);
            btnVerLicencia.TabIndex = 12;
            btnVerLicencia.UseVisualStyleBackColor = true;
            btnVerLicencia.Visible = false;
            // 
            // labelAvsio
            // 
            labelAvsio.AutoSize = true;
            labelAvsio.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAvsio.ForeColor = Color.Orange;
            labelAvsio.Location = new Point(310, 8);
            labelAvsio.Margin = new Padding(4, 0, 4, 0);
            labelAvsio.Name = "labelAvsio";
            labelAvsio.Size = new Size(144, 13);
            labelAvsio.TabIndex = 11;
            labelAvsio.Text = "Alerta                          ";
            labelAvsio.Visible = false;
            // 
            // labelHeaderRuta
            // 
            labelHeaderRuta.AutoSize = true;
            labelHeaderRuta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeaderRuta.ForeColor = SystemColors.ControlLightLight;
            labelHeaderRuta.Location = new Point(7, 5);
            labelHeaderRuta.Margin = new Padding(4, 0, 4, 0);
            labelHeaderRuta.Name = "labelHeaderRuta";
            labelHeaderRuta.Size = new Size(44, 16);
            labelHeaderRuta.TabIndex = 10;
            labelHeaderRuta.Text = "Inicio";
            // 
            // iconThemeMoon
            // 
            iconThemeMoon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconThemeMoon.BackColor = Color.FromArgb(41, 34, 33);
            iconThemeMoon.Enabled = false;
            iconThemeMoon.ForeColor = Color.FromArgb(4, 140, 128);
            iconThemeMoon.IconChar = FontAwesome.Sharp.IconChar.Moon;
            iconThemeMoon.IconColor = Color.FromArgb(4, 140, 128);
            iconThemeMoon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconThemeMoon.IconSize = 28;
            iconThemeMoon.Location = new Point(777, 0);
            iconThemeMoon.Margin = new Padding(4, 3, 4, 3);
            iconThemeMoon.Name = "iconThemeMoon";
            iconThemeMoon.Size = new Size(28, 29);
            iconThemeMoon.TabIndex = 8;
            iconThemeMoon.TabStop = false;
            // 
            // panelSalir
            // 
            panelSalir.Controls.Add(iconPictureBox1);
            panelSalir.Dock = DockStyle.Bottom;
            panelSalir.FlatStyle = FlatStyle.System;
            panelSalir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            panelSalir.Location = new Point(0, 616);
            panelSalir.Name = "panelSalir";
            panelSalir.Size = new Size(217, 61);
            panelSalir.TabIndex = 25;
            panelSalir.TabStop = false;
            panelSalir.Text = "Salir";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.ControlLight;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(81, 17);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Rotation = 180D;
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 708);
            Controls.Add(panelContenedorInterno);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeaderbar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMenu";
            Text = "Form1";
            panelHeaderbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnWindowMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnWindowRestore).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnWindowCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnWindowMinimize).EndInit();
            panelSidebar.ResumeLayout(false);
            subMenuUsuario.ResumeLayout(false);
            panelLogoContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelSidebarClose.ResumeLayout(false);
            panelSidebarClose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnOpenSidebar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCloseSidebar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            panelPerfil.ResumeLayout(false);
            panelPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnModeLight).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnModeDark).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconClock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureAlert).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconThemeSun).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconThemeMoon).EndInit();
            panelSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeaderbar;
        private FontAwesome.Sharp.IconPictureBox btnWindowMaximize;
        private FontAwesome.Sharp.IconPictureBox btnWindowRestore;
        private FontAwesome.Sharp.IconPictureBox btnWindowCerrar;
        private FontAwesome.Sharp.IconPictureBox btnWindowMinimize;
        private Panel panelSidebar;
        private Panel panelSelectionPlanes;
        private FontAwesome.Sharp.IconButton btnGestionPlanesDeEjercicio;
        private FontAwesome.Sharp.IconButton btnGestionProductos;
        private Panel panelSelectionUsuario;
        private Panel panelSelectionCaja;
        private Panel subMenuUsuario;
        private FontAwesome.Sharp.IconButton btnEntrenador;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnGestionUsurio;
        private FontAwesome.Sharp.IconButton btnGestionCaja;
        private Panel panelLogoContainer;
        private Panel panelContenedorInterno;
        private Panel panelHeader;
        private TextBox textTiempoLicencia;
        private Label labelTiempoLicencia;
        private FontAwesome.Sharp.IconButton btnVerLicencia;
        private Label labelAvsio;
        private Label labelHeaderRuta;
        private FontAwesome.Sharp.IconPictureBox iconThemeSun;
        private FontAwesome.Sharp.IconPictureBox iconThemeMoon;
        private FontAwesome.Sharp.IconPictureBox btnModeLight;
        private FontAwesome.Sharp.IconPictureBox btnModeDark;
        private FontAwesome.Sharp.IconButton btnAdministrador;
        private FontAwesome.Sharp.IconButton btnGestionMembresia;
        private FontAwesome.Sharp.IconButton btnAjustes;
        private Panel panelSelectionProductos;
        private Panel panelSelectionAjustes;
        private Panel panelSelectionMembresia;
        private PictureBox pictureAlert;
        private FontAwesome.Sharp.IconPictureBox iconClock;
        private FontAwesome.Sharp.IconButton btnEmpleado;
        private PictureBox picturePerfil;
        private Label labelNombrePerfil;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Panel panelSidebarClose;
        private Label labelMenu;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox btnOpenSidebar;
        private FontAwesome.Sharp.IconPictureBox btnCloseSidebar;
        private Label labelLogoName;
        private PictureBox pictureLogo;
        private GroupBox panelPerfil;
        private Label labelRolPerfil;
        private GroupBox panelSalir;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}

