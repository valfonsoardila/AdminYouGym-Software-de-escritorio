
namespace Presentacion
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.menuTop = new System.Windows.Forms.Panel();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnRestaurar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.SideBarWrapper = new System.Windows.Forms.Panel();
            this.menuBar = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.iconPapelera = new FontAwesome.Sharp.IconPictureBox();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.iconGestionCliente = new FontAwesome.Sharp.IconPictureBox();
            this.iconGestionCaja = new FontAwesome.Sharp.IconPictureBox();
            this.iconGestionServicios = new FontAwesome.Sharp.IconPictureBox();
            this.iconGestionEntrenador = new FontAwesome.Sharp.IconPictureBox();
            this.btnGestionCaja = new FontAwesome.Sharp.IconButton();
            this.btnGestionServicios = new FontAwesome.Sharp.IconButton();
            this.btnGestionEntrenador = new FontAwesome.Sharp.IconButton();
            this.btnGestionCliente = new FontAwesome.Sharp.IconButton();
            this.menuBarPanelTittle = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panelInfoLogo = new System.Windows.Forms.Panel();
            this.menuBarCerrado = new FontAwesome.Sharp.IconButton();
            this.menuBarAbierto = new FontAwesome.Sharp.IconButton();
            this.logoYougymMini = new System.Windows.Forms.PictureBox();
            this.nombreDashBoard = new System.Windows.Forms.Label();
            this.panelContenedorInterno = new System.Windows.Forms.Panel();
            this.menuTop.SuspendLayout();
            this.SideBarWrapper.SuspendLayout();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPapelera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGestionCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGestionCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGestionServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGestionEntrenador)).BeginInit();
            this.menuBarPanelTittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panelInfoLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoYougymMini)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTop
            // 
            this.menuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.menuTop.Controls.Add(this.btnMaximizar);
            this.menuTop.Controls.Add(this.btnRestaurar);
            this.menuTop.Controls.Add(this.btnMinimizar);
            this.menuTop.Controls.Add(this.btnCerrar);
            this.menuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(1054, 26);
            this.menuTop.TabIndex = 1;
            this.menuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuTop_MouseDown);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 25;
            this.btnMaximizar.Location = new System.Drawing.Point(998, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(24, 23);
            this.btnMaximizar.TabIndex = 6;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestaurar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.btnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestaurar.IconSize = 25;
            this.btnRestaurar.Location = new System.Drawing.Point(994, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(33, 23);
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 25;
            this.btnMinimizar.Location = new System.Drawing.Point(967, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 23);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 28;
            this.btnCerrar.Location = new System.Drawing.Point(1028, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // SideBarWrapper
            // 
            this.SideBarWrapper.AutoScroll = true;
            this.SideBarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.SideBarWrapper.Controls.Add(this.menuBar);
            this.SideBarWrapper.Controls.Add(this.panelInfoLogo);
            this.SideBarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarWrapper.Location = new System.Drawing.Point(0, 26);
            this.SideBarWrapper.Name = "SideBarWrapper";
            this.SideBarWrapper.Size = new System.Drawing.Size(219, 602);
            this.SideBarWrapper.TabIndex = 2;
            // 
            // menuBar
            // 
            this.menuBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuBar.BackColor = System.Drawing.Color.Transparent;
            this.menuBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuBar.BackgroundImage")));
            this.menuBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuBar.BorderRadius = 1;
            this.menuBar.Controls.Add(this.iconPapelera);
            this.menuBar.Controls.Add(this.btnCerrarSesion);
            this.menuBar.Controls.Add(this.iconGestionCliente);
            this.menuBar.Controls.Add(this.iconGestionCaja);
            this.menuBar.Controls.Add(this.iconGestionServicios);
            this.menuBar.Controls.Add(this.iconGestionEntrenador);
            this.menuBar.Controls.Add(this.btnGestionCaja);
            this.menuBar.Controls.Add(this.btnGestionServicios);
            this.menuBar.Controls.Add(this.btnGestionEntrenador);
            this.menuBar.Controls.Add(this.btnGestionCliente);
            this.menuBar.Controls.Add(this.menuBarPanelTittle);
            this.menuBar.GradientBottomLeft = System.Drawing.Color.Maroon;
            this.menuBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.menuBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.menuBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.menuBar.Location = new System.Drawing.Point(1, 69);
            this.menuBar.Name = "menuBar";
            this.menuBar.Quality = 10;
            this.menuBar.Size = new System.Drawing.Size(216, 550);
            this.menuBar.TabIndex = 2;
            // 
            // iconPapelera
            // 
            this.iconPapelera.BackColor = System.Drawing.Color.Transparent;
            this.iconPapelera.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPapelera.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.iconPapelera.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPapelera.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPapelera.Location = new System.Drawing.Point(6, 175);
            this.iconPapelera.Name = "iconPapelera";
            this.iconPapelera.Size = new System.Drawing.Size(32, 32);
            this.iconPapelera.TabIndex = 14;
            this.iconPapelera.TabStop = false;
            this.iconPapelera.Click += new System.EventHandler(this.iconCerrarSesion_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.IconSize = 30;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 175);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(216, 35);
            this.btnCerrarSesion.TabIndex = 15;
            this.btnCerrarSesion.Text = "   CERRAR SESION";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // iconGestionCliente
            // 
            this.iconGestionCliente.BackColor = System.Drawing.Color.Transparent;
            this.iconGestionCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconGestionCliente.IconChar = FontAwesome.Sharp.IconChar.PencilSquare;
            this.iconGestionCliente.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconGestionCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGestionCliente.Location = new System.Drawing.Point(6, 140);
            this.iconGestionCliente.Name = "iconGestionCliente";
            this.iconGestionCliente.Size = new System.Drawing.Size(32, 32);
            this.iconGestionCliente.TabIndex = 3;
            this.iconGestionCliente.TabStop = false;
            this.iconGestionCliente.Click += new System.EventHandler(this.iconGestionCliente_Click);
            // 
            // iconGestionCaja
            // 
            this.iconGestionCaja.BackColor = System.Drawing.Color.Transparent;
            this.iconGestionCaja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconGestionCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.iconGestionCaja.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconGestionCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGestionCaja.Location = new System.Drawing.Point(6, 38);
            this.iconGestionCaja.Name = "iconGestionCaja";
            this.iconGestionCaja.Size = new System.Drawing.Size(32, 32);
            this.iconGestionCaja.TabIndex = 4;
            this.iconGestionCaja.TabStop = false;
            this.iconGestionCaja.Click += new System.EventHandler(this.iconGestionCaja_Click);
            // 
            // iconGestionServicios
            // 
            this.iconGestionServicios.BackColor = System.Drawing.Color.Transparent;
            this.iconGestionServicios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconGestionServicios.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.iconGestionServicios.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconGestionServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGestionServicios.Location = new System.Drawing.Point(6, 106);
            this.iconGestionServicios.Name = "iconGestionServicios";
            this.iconGestionServicios.Size = new System.Drawing.Size(32, 32);
            this.iconGestionServicios.TabIndex = 4;
            this.iconGestionServicios.TabStop = false;
            // 
            // iconGestionEntrenador
            // 
            this.iconGestionEntrenador.BackColor = System.Drawing.Color.Transparent;
            this.iconGestionEntrenador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconGestionEntrenador.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconGestionEntrenador.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconGestionEntrenador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGestionEntrenador.Location = new System.Drawing.Point(6, 71);
            this.iconGestionEntrenador.Name = "iconGestionEntrenador";
            this.iconGestionEntrenador.Size = new System.Drawing.Size(32, 32);
            this.iconGestionEntrenador.TabIndex = 13;
            this.iconGestionEntrenador.TabStop = false;
            this.iconGestionEntrenador.Click += new System.EventHandler(this.iconGestionEntrenador_Click);
            // 
            // btnGestionCaja
            // 
            this.btnGestionCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionCaja.FlatAppearance.BorderSize = 0;
            this.btnGestionCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGestionCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnGestionCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionCaja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnGestionCaja.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnGestionCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionCaja.IconSize = 30;
            this.btnGestionCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionCaja.Location = new System.Drawing.Point(0, 140);
            this.btnGestionCaja.Name = "btnGestionCaja";
            this.btnGestionCaja.Size = new System.Drawing.Size(216, 35);
            this.btnGestionCaja.TabIndex = 10;
            this.btnGestionCaja.Text = "   GESTION DE CAJA";
            this.btnGestionCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionCaja.UseVisualStyleBackColor = true;
            this.btnGestionCaja.Click += new System.EventHandler(this.btnGestionCaja_Click);
            // 
            // btnGestionServicios
            // 
            this.btnGestionServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionServicios.FlatAppearance.BorderSize = 0;
            this.btnGestionServicios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGestionServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnGestionServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionServicios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionServicios.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.btnGestionServicios.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnGestionServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionServicios.IconSize = 30;
            this.btnGestionServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionServicios.Location = new System.Drawing.Point(0, 105);
            this.btnGestionServicios.Name = "btnGestionServicios";
            this.btnGestionServicios.Size = new System.Drawing.Size(216, 35);
            this.btnGestionServicios.TabIndex = 9;
            this.btnGestionServicios.Text = "   GESTION DE SERVICIOS";
            this.btnGestionServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionServicios.UseVisualStyleBackColor = true;
            // 
            // btnGestionEntrenador
            // 
            this.btnGestionEntrenador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionEntrenador.FlatAppearance.BorderSize = 0;
            this.btnGestionEntrenador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGestionEntrenador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnGestionEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionEntrenador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionEntrenador.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnGestionEntrenador.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnGestionEntrenador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionEntrenador.IconSize = 30;
            this.btnGestionEntrenador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionEntrenador.Location = new System.Drawing.Point(0, 70);
            this.btnGestionEntrenador.Name = "btnGestionEntrenador";
            this.btnGestionEntrenador.Size = new System.Drawing.Size(216, 35);
            this.btnGestionEntrenador.TabIndex = 6;
            this.btnGestionEntrenador.Text = " GESTION DE ENTRENADOR";
            this.btnGestionEntrenador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionEntrenador.UseVisualStyleBackColor = true;
            this.btnGestionEntrenador.Click += new System.EventHandler(this.btnGestionEntrenador_Click);
            // 
            // btnGestionCliente
            // 
            this.btnGestionCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionCliente.FlatAppearance.BorderSize = 0;
            this.btnGestionCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGestionCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnGestionCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionCliente.IconChar = FontAwesome.Sharp.IconChar.PencilSquare;
            this.btnGestionCliente.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnGestionCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionCliente.IconSize = 30;
            this.btnGestionCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionCliente.Location = new System.Drawing.Point(0, 35);
            this.btnGestionCliente.Name = "btnGestionCliente";
            this.btnGestionCliente.Size = new System.Drawing.Size(216, 35);
            this.btnGestionCliente.TabIndex = 0;
            this.btnGestionCliente.Text = "   GESTION DE CLIENTE";
            this.btnGestionCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionCliente.UseVisualStyleBackColor = true;
            this.btnGestionCliente.Click += new System.EventHandler(this.btnGestionCliente_Click);
            // 
            // menuBarPanelTittle
            // 
            this.menuBarPanelTittle.BackColor = System.Drawing.Color.Transparent;
            this.menuBarPanelTittle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuBarPanelTittle.BackgroundImage")));
            this.menuBarPanelTittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuBarPanelTittle.BorderRadius = 1;
            this.menuBarPanelTittle.Controls.Add(this.bunifuSeparator2);
            this.menuBarPanelTittle.Controls.Add(this.label1);
            this.menuBarPanelTittle.Controls.Add(this.iconPictureBox2);
            this.menuBarPanelTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBarPanelTittle.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.menuBarPanelTittle.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.menuBarPanelTittle.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.menuBarPanelTittle.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.menuBarPanelTittle.Location = new System.Drawing.Point(0, 0);
            this.menuBarPanelTittle.Name = "menuBarPanelTittle";
            this.menuBarPanelTittle.Quality = 10;
            this.menuBarPanelTittle.Size = new System.Drawing.Size(216, 35);
            this.menuBarPanelTittle.TabIndex = 5;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(7, 31);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(169, 5);
            this.bunifuSeparator2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(6, 4);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 0;
            this.iconPictureBox2.TabStop = false;
            // 
            // panelInfoLogo
            // 
            this.panelInfoLogo.Controls.Add(this.menuBarCerrado);
            this.panelInfoLogo.Controls.Add(this.menuBarAbierto);
            this.panelInfoLogo.Controls.Add(this.logoYougymMini);
            this.panelInfoLogo.Controls.Add(this.nombreDashBoard);
            this.panelInfoLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoLogo.Location = new System.Drawing.Point(0, 0);
            this.panelInfoLogo.Name = "panelInfoLogo";
            this.panelInfoLogo.Size = new System.Drawing.Size(219, 67);
            this.panelInfoLogo.TabIndex = 0;
            this.panelInfoLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelInfoLogo_MouseDown);
            // 
            // menuBarCerrado
            // 
            this.menuBarCerrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuBarCerrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBarCerrado.FlatAppearance.BorderSize = 0;
            this.menuBarCerrado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.menuBarCerrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(14)))), ((int)(((byte)(2)))));
            this.menuBarCerrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBarCerrado.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.menuBarCerrado.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.menuBarCerrado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuBarCerrado.IconSize = 30;
            this.menuBarCerrado.Location = new System.Drawing.Point(187, 21);
            this.menuBarCerrado.Name = "menuBarCerrado";
            this.menuBarCerrado.Rotation = 90D;
            this.menuBarCerrado.Size = new System.Drawing.Size(27, 28);
            this.menuBarCerrado.TabIndex = 5;
            this.menuBarCerrado.UseVisualStyleBackColor = true;
            this.menuBarCerrado.Click += new System.EventHandler(this.menuBarCerrado_Click);
            // 
            // menuBarAbierto
            // 
            this.menuBarAbierto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuBarAbierto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBarAbierto.FlatAppearance.BorderSize = 0;
            this.menuBarAbierto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.menuBarAbierto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(14)))), ((int)(((byte)(2)))));
            this.menuBarAbierto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBarAbierto.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.menuBarAbierto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.menuBarAbierto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuBarAbierto.IconSize = 30;
            this.menuBarAbierto.Location = new System.Drawing.Point(189, 21);
            this.menuBarAbierto.Name = "menuBarAbierto";
            this.menuBarAbierto.Size = new System.Drawing.Size(27, 28);
            this.menuBarAbierto.TabIndex = 4;
            this.menuBarAbierto.UseVisualStyleBackColor = true;
            this.menuBarAbierto.Click += new System.EventHandler(this.menuBarAbierto_Click);
            // 
            // logoYougymMini
            // 
            this.logoYougymMini.Image = ((System.Drawing.Image)(resources.GetObject("logoYougymMini.Image")));
            this.logoYougymMini.Location = new System.Drawing.Point(11, 4);
            this.logoYougymMini.Name = "logoYougymMini";
            this.logoYougymMini.Size = new System.Drawing.Size(79, 63);
            this.logoYougymMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoYougymMini.TabIndex = 0;
            this.logoYougymMini.TabStop = false;
            this.logoYougymMini.Visible = false;
            // 
            // nombreDashBoard
            // 
            this.nombreDashBoard.AutoSize = true;
            this.nombreDashBoard.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.nombreDashBoard.Location = new System.Drawing.Point(99, 27);
            this.nombreDashBoard.Name = "nombreDashBoard";
            this.nombreDashBoard.Size = new System.Drawing.Size(62, 15);
            this.nombreDashBoard.TabIndex = 0;
            this.nombreDashBoard.Text = "YOUGYM";
            // 
            // panelContenedorInterno
            // 
            this.panelContenedorInterno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorInterno.Location = new System.Drawing.Point(219, 26);
            this.panelContenedorInterno.Name = "panelContenedorInterno";
            this.panelContenedorInterno.Size = new System.Drawing.Size(835, 602);
            this.panelContenedorInterno.TabIndex = 3;
            this.panelContenedorInterno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContenedorInterno_MouseDown);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(1054, 628);
            this.Controls.Add(this.panelContenedorInterno);
            this.Controls.Add(this.SideBarWrapper);
            this.Controls.Add(this.menuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenuPrincipal";
            this.Text = "MenuPrincipal";
            this.menuTop.ResumeLayout(false);
            this.SideBarWrapper.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPapelera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGestionCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGestionCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGestionServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGestionEntrenador)).EndInit();
            this.menuBarPanelTittle.ResumeLayout(false);
            this.menuBarPanelTittle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panelInfoLogo.ResumeLayout(false);
            this.panelInfoLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoYougymMini)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuTop;
        private FontAwesome.Sharp.IconButton btnRestaurar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel SideBarWrapper;
        private System.Windows.Forms.Panel panelInfoLogo;
        private System.Windows.Forms.PictureBox logoYougymMini;
        private System.Windows.Forms.Label nombreDashBoard;
        private FontAwesome.Sharp.IconButton menuBarCerrado;
        private FontAwesome.Sharp.IconButton menuBarAbierto;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private System.Windows.Forms.Panel panelContenedorInterno;
        private Bunifu.UI.WinForms.BunifuGradientPanel menuBar;
        private FontAwesome.Sharp.IconButton btnGestionCaja;
        private FontAwesome.Sharp.IconButton btnGestionServicios;
        private FontAwesome.Sharp.IconButton btnGestionEntrenador;
        private FontAwesome.Sharp.IconButton btnGestionCliente;
        private Bunifu.UI.WinForms.BunifuGradientPanel menuBarPanelTittle;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPapelera;
        private FontAwesome.Sharp.IconPictureBox iconGestionCliente;
        private FontAwesome.Sharp.IconPictureBox iconGestionCaja;
        private FontAwesome.Sharp.IconPictureBox iconGestionServicios;
        private FontAwesome.Sharp.IconPictureBox iconGestionEntrenador;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
    }
}

