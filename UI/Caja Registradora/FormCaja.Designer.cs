
namespace UI
{
    partial class FormCaja
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
            panelSubMenu = new Panel();
            btnHistorial = new FontAwesome.Sharp.IconButton();
            btnCerrarCaja = new FontAwesome.Sharp.IconButton();
            btnAbrirCaja = new FontAwesome.Sharp.IconButton();
            panelSubDataGridFarmacos = new Panel();
            textTotalCajasCerradas = new TextBox();
            labelTotalCajasCerradas = new Label();
            textTotalCajasAbiertas = new TextBox();
            labelTotalCajasAbiertas = new Label();
            textTotalCajas = new TextBox();
            labelTotalCajas = new Label();
            dataGridFarmacos = new DataGridView();
            Eliminar = new DataGridViewImageColumn();
            panelTituloDataGridFarmacos = new Panel();
            labelAdvertencia = new Label();
            comboFiltroEstado = new ComboBox();
            labelFiltro = new Label();
            labelConsultarCajas = new Label();
            panelBarraVolver = new Panel();
            label1 = new Label();
            labelTextFondo = new Label();
            labelCash = new Label();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            iconCash = new FontAwesome.Sharp.IconPictureBox();
            btnVolver = new FontAwesome.Sharp.IconButton();
            ImprimirProductosVendidos = new System.Drawing.Printing.PrintDocument();
            panel1 = new Panel();
            label5 = new Label();
            labelBase = new Label();
            label3 = new Label();
            label2 = new Label();
            iconBase = new FontAwesome.Sharp.IconPictureBox();
            panelSubMenu.SuspendLayout();
            panelSubDataGridFarmacos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFarmacos).BeginInit();
            panelTituloDataGridFarmacos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCash).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconBase).BeginInit();
            SuspendLayout();
            // 
            // panelSubMenu
            // 
            panelSubMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelSubMenu.BackColor = Color.FromArgb(89, 2, 2);
            panelSubMenu.BorderStyle = BorderStyle.FixedSingle;
            panelSubMenu.Controls.Add(btnHistorial);
            panelSubMenu.Controls.Add(btnCerrarCaja);
            panelSubMenu.Controls.Add(btnAbrirCaja);
            panelSubMenu.Location = new Point(763, 66);
            panelSubMenu.Margin = new Padding(4, 3, 4, 3);
            panelSubMenu.Name = "panelSubMenu";
            panelSubMenu.Size = new Size(142, 401);
            panelSubMenu.TabIndex = 51;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.Black;
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatAppearance.MouseDownBackColor = Color.Black;
            btnHistorial.FlatAppearance.MouseOverBackColor = Color.Black;
            btnHistorial.FlatStyle = FlatStyle.Popup;
            btnHistorial.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistorial.ForeColor = Color.Yellow;
            btnHistorial.IconChar = FontAwesome.Sharp.IconChar.Stream;
            btnHistorial.IconColor = Color.Yellow;
            btnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHistorial.IconSize = 30;
            btnHistorial.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorial.Location = new Point(0, 111);
            btnHistorial.Margin = new Padding(4, 3, 4, 3);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(144, 55);
            btnHistorial.TabIndex = 53;
            btnHistorial.Text = "Eliminar Cajas Cerradas";
            btnHistorial.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnCerrarCaja
            // 
            btnCerrarCaja.BackColor = Color.Black;
            btnCerrarCaja.FlatAppearance.BorderSize = 0;
            btnCerrarCaja.FlatAppearance.MouseDownBackColor = Color.Black;
            btnCerrarCaja.FlatAppearance.MouseOverBackColor = Color.Black;
            btnCerrarCaja.FlatStyle = FlatStyle.Popup;
            btnCerrarCaja.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarCaja.ForeColor = Color.White;
            btnCerrarCaja.IconChar = FontAwesome.Sharp.IconChar.SackXmark;
            btnCerrarCaja.IconColor = Color.White;
            btnCerrarCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarCaja.IconSize = 30;
            btnCerrarCaja.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarCaja.Location = new Point(0, 69);
            btnCerrarCaja.Margin = new Padding(4, 3, 4, 3);
            btnCerrarCaja.Name = "btnCerrarCaja";
            btnCerrarCaja.Size = new Size(144, 40);
            btnCerrarCaja.TabIndex = 52;
            btnCerrarCaja.Text = "  Cerrar Caja";
            btnCerrarCaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarCaja.UseVisualStyleBackColor = false;
            btnCerrarCaja.Click += btnCerrarCaja_Click;
            // 
            // btnAbrirCaja
            // 
            btnAbrirCaja.BackColor = Color.Black;
            btnAbrirCaja.FlatAppearance.BorderSize = 0;
            btnAbrirCaja.FlatAppearance.MouseDownBackColor = Color.Black;
            btnAbrirCaja.FlatAppearance.MouseOverBackColor = Color.Black;
            btnAbrirCaja.FlatStyle = FlatStyle.Popup;
            btnAbrirCaja.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbrirCaja.ForeColor = Color.White;
            btnAbrirCaja.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            btnAbrirCaja.IconColor = Color.White;
            btnAbrirCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAbrirCaja.IconSize = 30;
            btnAbrirCaja.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirCaja.Location = new Point(0, 28);
            btnAbrirCaja.Margin = new Padding(4, 3, 4, 3);
            btnAbrirCaja.Name = "btnAbrirCaja";
            btnAbrirCaja.Size = new Size(144, 40);
            btnAbrirCaja.TabIndex = 51;
            btnAbrirCaja.Text = "   Abrir Caja";
            btnAbrirCaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAbrirCaja.UseVisualStyleBackColor = false;
            btnAbrirCaja.Click += btnAbrirCaja_Click;
            // 
            // panelSubDataGridFarmacos
            // 
            panelSubDataGridFarmacos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSubDataGridFarmacos.BackColor = Color.FromArgb(89, 2, 2);
            panelSubDataGridFarmacos.Controls.Add(textTotalCajasCerradas);
            panelSubDataGridFarmacos.Controls.Add(labelTotalCajasCerradas);
            panelSubDataGridFarmacos.Controls.Add(textTotalCajasAbiertas);
            panelSubDataGridFarmacos.Controls.Add(labelTotalCajasAbiertas);
            panelSubDataGridFarmacos.Controls.Add(textTotalCajas);
            panelSubDataGridFarmacos.Controls.Add(labelTotalCajas);
            panelSubDataGridFarmacos.Location = new Point(27, 442);
            panelSubDataGridFarmacos.Margin = new Padding(4, 3, 4, 3);
            panelSubDataGridFarmacos.Name = "panelSubDataGridFarmacos";
            panelSubDataGridFarmacos.Size = new Size(735, 25);
            panelSubDataGridFarmacos.TabIndex = 51;
            // 
            // textTotalCajasCerradas
            // 
            textTotalCajasCerradas.Location = new Point(550, 2);
            textTotalCajasCerradas.Margin = new Padding(4, 3, 4, 3);
            textTotalCajasCerradas.Name = "textTotalCajasCerradas";
            textTotalCajasCerradas.Size = new Size(54, 23);
            textTotalCajasCerradas.TabIndex = 53;
            textTotalCajasCerradas.Text = "0";
            // 
            // labelTotalCajasCerradas
            // 
            labelTotalCajasCerradas.AutoSize = true;
            labelTotalCajasCerradas.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalCajasCerradas.ForeColor = SystemColors.Control;
            labelTotalCajasCerradas.Location = new Point(399, 6);
            labelTotalCajasCerradas.Margin = new Padding(4, 0, 4, 0);
            labelTotalCajasCerradas.Name = "labelTotalCajasCerradas";
            labelTotalCajasCerradas.Size = new Size(129, 13);
            labelTotalCajasCerradas.TabIndex = 52;
            labelTotalCajasCerradas.Text = "Total Cajas Cerradas:";
            // 
            // textTotalCajasAbiertas
            // 
            textTotalCajasAbiertas.Location = new Point(335, 1);
            textTotalCajasAbiertas.Margin = new Padding(4, 3, 4, 3);
            textTotalCajasAbiertas.Name = "textTotalCajasAbiertas";
            textTotalCajasAbiertas.Size = new Size(54, 23);
            textTotalCajasAbiertas.TabIndex = 51;
            textTotalCajasAbiertas.Text = "0";
            // 
            // labelTotalCajasAbiertas
            // 
            labelTotalCajasAbiertas.AutoSize = true;
            labelTotalCajasAbiertas.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalCajasAbiertas.ForeColor = SystemColors.Control;
            labelTotalCajasAbiertas.Location = new Point(170, 6);
            labelTotalCajasAbiertas.Margin = new Padding(4, 0, 4, 0);
            labelTotalCajasAbiertas.Name = "labelTotalCajasAbiertas";
            labelTotalCajasAbiertas.Size = new Size(141, 13);
            labelTotalCajasAbiertas.TabIndex = 50;
            labelTotalCajasAbiertas.Text = "Total de cajas abiertas:";
            // 
            // textTotalCajas
            // 
            textTotalCajas.Location = new Point(111, 1);
            textTotalCajas.Margin = new Padding(4, 3, 4, 3);
            textTotalCajas.Name = "textTotalCajas";
            textTotalCajas.Size = new Size(54, 23);
            textTotalCajas.TabIndex = 49;
            textTotalCajas.Text = "0";
            // 
            // labelTotalCajas
            // 
            labelTotalCajas.AutoSize = true;
            labelTotalCajas.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalCajas.ForeColor = SystemColors.Control;
            labelTotalCajas.Location = new Point(5, 6);
            labelTotalCajas.Margin = new Padding(4, 0, 4, 0);
            labelTotalCajas.Name = "labelTotalCajas";
            labelTotalCajas.Size = new Size(92, 13);
            labelTotalCajas.TabIndex = 49;
            labelTotalCajas.Text = "Total de cajas:";
            // 
            // dataGridFarmacos
            // 
            dataGridFarmacos.AllowUserToAddRows = false;
            dataGridFarmacos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridFarmacos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFarmacos.Columns.AddRange(new DataGridViewColumn[] { Eliminar });
            dataGridFarmacos.Location = new Point(27, 93);
            dataGridFarmacos.Margin = new Padding(4, 3, 4, 3);
            dataGridFarmacos.Name = "dataGridFarmacos";
            dataGridFarmacos.ReadOnly = true;
            dataGridFarmacos.RowHeadersVisible = false;
            dataGridFarmacos.Size = new Size(735, 351);
            dataGridFarmacos.TabIndex = 50;
            dataGridFarmacos.CellClick += dataGridFarmacos_CellClick;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = UI.Properties.Resources.deleRojBlack;
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Width = 50;
            // 
            // panelTituloDataGridFarmacos
            // 
            panelTituloDataGridFarmacos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTituloDataGridFarmacos.BackColor = Color.FromArgb(89, 2, 2);
            panelTituloDataGridFarmacos.Controls.Add(labelAdvertencia);
            panelTituloDataGridFarmacos.Controls.Add(comboFiltroEstado);
            panelTituloDataGridFarmacos.Controls.Add(labelFiltro);
            panelTituloDataGridFarmacos.Controls.Add(labelConsultarCajas);
            panelTituloDataGridFarmacos.Location = new Point(27, 66);
            panelTituloDataGridFarmacos.Margin = new Padding(4, 3, 4, 3);
            panelTituloDataGridFarmacos.Name = "panelTituloDataGridFarmacos";
            panelTituloDataGridFarmacos.Size = new Size(736, 28);
            panelTituloDataGridFarmacos.TabIndex = 49;
            // 
            // labelAdvertencia
            // 
            labelAdvertencia.AutoSize = true;
            labelAdvertencia.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAdvertencia.ForeColor = Color.Yellow;
            labelAdvertencia.Location = new Point(426, 6);
            labelAdvertencia.Margin = new Padding(4, 0, 4, 0);
            labelAdvertencia.Name = "labelAdvertencia";
            labelAdvertencia.Size = new Size(200, 16);
            labelAdvertencia.TabIndex = 60;
            labelAdvertencia.Text = "No hay datos Registrados!!!";
            labelAdvertencia.Visible = false;
            // 
            // comboFiltroEstado
            // 
            comboFiltroEstado.FormattingEnabled = true;
            comboFiltroEstado.Items.AddRange(new object[] { "Todos", "Abierta", "Cerrada" });
            comboFiltroEstado.Location = new Point(304, 1);
            comboFiltroEstado.Margin = new Padding(4, 3, 4, 3);
            comboFiltroEstado.Name = "comboFiltroEstado";
            comboFiltroEstado.Size = new Size(100, 23);
            comboFiltroEstado.TabIndex = 52;
            comboFiltroEstado.Text = "Todos";
            comboFiltroEstado.SelectedIndexChanged += comboFiltroEstado_SelectedIndexChanged;
            // 
            // labelFiltro
            // 
            labelFiltro.AutoSize = true;
            labelFiltro.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFiltro.ForeColor = SystemColors.Control;
            labelFiltro.Location = new Point(260, 7);
            labelFiltro.Margin = new Padding(4, 0, 4, 0);
            labelFiltro.Name = "labelFiltro";
            labelFiltro.Size = new Size(39, 13);
            labelFiltro.TabIndex = 50;
            labelFiltro.Text = "Filtro:";
            // 
            // labelConsultarCajas
            // 
            labelConsultarCajas.AutoSize = true;
            labelConsultarCajas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelConsultarCajas.ForeColor = Color.White;
            labelConsultarCajas.Location = new Point(4, 5);
            labelConsultarCajas.Margin = new Padding(4, 0, 4, 0);
            labelConsultarCajas.Name = "labelConsultarCajas";
            labelConsultarCajas.Size = new Size(116, 16);
            labelConsultarCajas.TabIndex = 51;
            labelConsultarCajas.Text = "Consultar Cajas";
            // 
            // panelBarraVolver
            // 
            panelBarraVolver.BackColor = Color.FromArgb(89, 2, 2);
            panelBarraVolver.Location = new Point(12, 1);
            panelBarraVolver.Margin = new Padding(4, 3, 4, 3);
            panelBarraVolver.Name = "panelBarraVolver";
            panelBarraVolver.Size = new Size(8, 40);
            panelBarraVolver.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 29);
            label1.TabIndex = 56;
            label1.Text = "Gestionar Cajas";
            // 
            // labelTextFondo
            // 
            labelTextFondo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTextFondo.AutoSize = true;
            labelTextFondo.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTextFondo.ForeColor = Color.White;
            labelTextFondo.Location = new Point(822, 3);
            labelTextFondo.Margin = new Padding(4, 0, 4, 0);
            labelTextFondo.Name = "labelTextFondo";
            labelTextFondo.Size = new Size(42, 12);
            labelTextFondo.TabIndex = 59;
            labelTextFondo.Text = "VENTA";
            // 
            // labelCash
            // 
            labelCash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCash.AutoSize = true;
            labelCash.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCash.ForeColor = Color.White;
            labelCash.Location = new Point(842, 22);
            labelCash.Margin = new Padding(4, 0, 4, 0);
            labelCash.Name = "labelCash";
            labelCash.Size = new Size(13, 15);
            labelCash.TabIndex = 58;
            labelCash.Text = "*";
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.HeaderText = "Eliminar";
            dataGridViewImageColumn1.Image = UI.Properties.Resources.deleRojBlack;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
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
            iconCash.Location = new Point(783, 0);
            iconCash.Margin = new Padding(4, 3, 4, 3);
            iconCash.Name = "iconCash";
            iconCash.Size = new Size(37, 42);
            iconCash.TabIndex = 57;
            iconCash.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.FlatAppearance.BorderColor = Color.FromArgb(89, 2, 2);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ActiveCaptionText;
            btnVolver.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            btnVolver.IconColor = SystemColors.Window;
            btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVolver.IconSize = 30;
            btnVolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolver.Location = new Point(23, 1);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(36, 40);
            btnVolver.TabIndex = 55;
            btnVolver.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // ImprimirProductosVendidos
            // 
            ImprimirProductosVendidos.PrintPage += Imprimir;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.MenuText;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(labelBase);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iconBase);
            panel1.Controls.Add(labelCash);
            panel1.Controls.Add(labelTextFondo);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconCash);
            panel1.Controls.Add(panelBarraVolver);
            panel1.Location = new Point(0, 14);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 42);
            panel1.TabIndex = 60;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(824, 21);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(15, 16);
            label5.TabIndex = 64;
            label5.Text = "$";
            // 
            // labelBase
            // 
            labelBase.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelBase.AutoSize = true;
            labelBase.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBase.ForeColor = Color.White;
            labelBase.Location = new Point(686, 22);
            labelBase.Margin = new Padding(4, 0, 4, 0);
            labelBase.Name = "labelBase";
            labelBase.Size = new Size(13, 15);
            labelBase.TabIndex = 63;
            labelBase.Text = "*";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(665, 20);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(15, 16);
            label3.TabIndex = 62;
            label3.Text = "$";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(666, 3);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 12);
            label2.TabIndex = 61;
            label2.Text = "-BASE";
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
            iconBase.Location = new Point(624, 5);
            iconBase.Margin = new Padding(4, 3, 4, 3);
            iconBase.Name = "iconBase";
            iconBase.Size = new Size(37, 37);
            iconBase.TabIndex = 60;
            iconBase.TabStop = false;
            // 
            // FormGestionCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(926, 502);
            Controls.Add(panelSubDataGridFarmacos);
            Controls.Add(panelSubMenu);
            Controls.Add(dataGridFarmacos);
            Controls.Add(panelTituloDataGridFarmacos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormGestionCaja";
            Text = "FormGestionCaja";
            panelSubMenu.ResumeLayout(false);
            panelSubDataGridFarmacos.ResumeLayout(false);
            panelSubDataGridFarmacos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFarmacos).EndInit();
            panelTituloDataGridFarmacos.ResumeLayout(false);
            panelTituloDataGridFarmacos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCash).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconBase).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelSubDataGridFarmacos;
        private TextBox textTotalCajasCerradas;
        private Label labelTotalCajasCerradas;
        private TextBox textTotalCajasAbiertas;
        private Label labelTotalCajasAbiertas;
        private TextBox textTotalCajas;
        private Label labelTotalCajas;
        private DataGridView dataGridFarmacos;
        private Panel panelTituloDataGridFarmacos;
        private ComboBox comboFiltroEstado;
        private Label labelFiltro;
        private Label labelConsultarCajas;
        private Panel panelSubMenu;
        private FontAwesome.Sharp.IconButton btnHistorial;
        private FontAwesome.Sharp.IconButton btnCerrarCaja;
        private FontAwesome.Sharp.IconButton btnAbrirCaja;
        private FontAwesome.Sharp.IconButton btnVolver;
        private Panel panelBarraVolver;
        private Label label1;
        private Label labelTextFondo;
        private Label labelCash;
        private FontAwesome.Sharp.IconPictureBox iconCash;
        private Label labelAdvertencia;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Drawing.Printing.PrintDocument ImprimirProductosVendidos;
        private Panel panel1;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconBase;
        private Label label3;
        private Label labelBase;
        private Label label5;
    }
}