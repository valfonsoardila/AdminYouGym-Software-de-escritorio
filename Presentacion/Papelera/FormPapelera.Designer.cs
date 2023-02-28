
namespace Presentacion
{
    partial class FormPapelera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPapelera));
            this.labelTitlePapelera = new System.Windows.Forms.Label();
            this.dataGridHistorialCajas = new System.Windows.Forms.DataGridView();
            this.IdCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVaciarPapelera = new FontAwesome.Sharp.IconButton();
            this.menuTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnBackupHistorial = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorialCajas)).BeginInit();
            this.menuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitlePapelera
            // 
            this.labelTitlePapelera.AutoSize = true;
            this.labelTitlePapelera.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlePapelera.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelTitlePapelera.Location = new System.Drawing.Point(21, 41);
            this.labelTitlePapelera.Name = "labelTitlePapelera";
            this.labelTitlePapelera.Size = new System.Drawing.Size(171, 15);
            this.labelTitlePapelera.TabIndex = 0;
            this.labelTitlePapelera.Text = "Papelera de Cajas Eliminadas";
            // 
            // dataGridHistorialCajas
            // 
            this.dataGridHistorialCajas.AllowUserToDeleteRows = false;
            this.dataGridHistorialCajas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHistorialCajas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.dataGridHistorialCajas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridHistorialCajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistorialCajas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCaja,
            this.FechaApertura,
            this.FechaCierre,
            this.Estado,
            this.Monto});
            this.dataGridHistorialCajas.GridColor = System.Drawing.Color.White;
            this.dataGridHistorialCajas.Location = new System.Drawing.Point(144, 89);
            this.dataGridHistorialCajas.Name = "dataGridHistorialCajas";
            this.dataGridHistorialCajas.RowHeadersVisible = false;
            this.dataGridHistorialCajas.Size = new System.Drawing.Size(528, 299);
            this.dataGridHistorialCajas.TabIndex = 2;
            // 
            // IdCaja
            // 
            this.IdCaja.HeaderText = "IdCaja";
            this.IdCaja.Name = "IdCaja";
            // 
            // FechaApertura
            // 
            this.FechaApertura.HeaderText = "FechaApertura";
            this.FechaApertura.Name = "FechaApertura";
            // 
            // FechaCierre
            // 
            this.FechaCierre.HeaderText = "FechaCierre";
            this.FechaCierre.Name = "FechaCierre";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // btnVaciarPapelera
            // 
            this.btnVaciarPapelera.FlatAppearance.BorderSize = 0;
            this.btnVaciarPapelera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciarPapelera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciarPapelera.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnVaciarPapelera.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnVaciarPapelera.IconColor = System.Drawing.Color.LawnGreen;
            this.btnVaciarPapelera.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVaciarPapelera.IconSize = 30;
            this.btnVaciarPapelera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVaciarPapelera.Location = new System.Drawing.Point(274, 394);
            this.btnVaciarPapelera.Name = "btnVaciarPapelera";
            this.btnVaciarPapelera.Size = new System.Drawing.Size(136, 35);
            this.btnVaciarPapelera.TabIndex = 23;
            this.btnVaciarPapelera.Text = "   VACIAR PAPELERA";
            this.btnVaciarPapelera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVaciarPapelera.UseVisualStyleBackColor = true;
            this.btnVaciarPapelera.Click += new System.EventHandler(this.btnVaciarPapelera_Click);
            // 
            // menuTop
            // 
            this.menuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.menuTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuTop.Controls.Add(this.btnCerrar);
            this.menuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(800, 26);
            this.menuTop.TabIndex = 24;
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
            this.btnCerrar.Location = new System.Drawing.Point(772, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBackupHistorial
            // 
            this.btnBackupHistorial.FlatAppearance.BorderSize = 0;
            this.btnBackupHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupHistorial.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnBackupHistorial.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.btnBackupHistorial.IconColor = System.Drawing.Color.LawnGreen;
            this.btnBackupHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBackupHistorial.IconSize = 30;
            this.btnBackupHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackupHistorial.Location = new System.Drawing.Point(416, 394);
            this.btnBackupHistorial.Name = "btnBackupHistorial";
            this.btnBackupHistorial.Size = new System.Drawing.Size(136, 35);
            this.btnBackupHistorial.TabIndex = 25;
            this.btnBackupHistorial.Text = "   RESPALDAR REGISTROS";
            this.btnBackupHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackupHistorial.UseVisualStyleBackColor = true;
            // 
            // FormPapelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.btnBackupHistorial);
            this.Controls.Add(this.menuTop);
            this.Controls.Add(this.btnVaciarPapelera);
            this.Controls.Add(this.dataGridHistorialCajas);
            this.Controls.Add(this.labelTitlePapelera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPapelera";
            this.Opacity = 0.9D;
            this.Text = "Papelera";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistorialCajas)).EndInit();
            this.menuTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitlePapelera;
        private System.Windows.Forms.DataGridView dataGridHistorialCajas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private FontAwesome.Sharp.IconButton btnVaciarPapelera;
        private System.Windows.Forms.Panel menuTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnBackupHistorial;
    }
}