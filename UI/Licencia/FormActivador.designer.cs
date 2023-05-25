
namespace UI
{
    partial class FormActivador
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
            labelTituloActivador = new Label();
            labelText1 = new Label();
            labelText2 = new Label();
            textLicencia = new TextBox();
            btnActivarProducto = new Button();
            pictureLlaveLicencia = new PictureBox();
            pictureLicenciaExpirada = new PictureBox();
            pictureLicenciaActivada = new PictureBox();
            pictureBox1 = new PictureBox();
            labelTextLicencia1 = new Label();
            labelCantidadDiasLicencia = new Label();
            labelTextLicencia2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLlaveLicencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLicenciaExpirada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureLicenciaActivada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTituloActivador
            // 
            labelTituloActivador.AutoSize = true;
            labelTituloActivador.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTituloActivador.Location = new Point(163, 44);
            labelTituloActivador.Margin = new Padding(4, 0, 4, 0);
            labelTituloActivador.Name = "labelTituloActivador";
            labelTituloActivador.Size = new Size(225, 24);
            labelTituloActivador.TabIndex = 1;
            labelTituloActivador.Text = "Activacion de producto";
            // 
            // labelText1
            // 
            labelText1.AutoSize = true;
            labelText1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelText1.Location = new Point(12, 104);
            labelText1.Margin = new Padding(4, 0, 4, 0);
            labelText1.Name = "labelText1";
            labelText1.Size = new Size(489, 15);
            labelText1.TabIndex = 2;
            labelText1.Text = "El tiempo de uso de los componentes del software estan desactivados ponte en contacto";
            // 
            // labelText2
            // 
            labelText2.AutoSize = true;
            labelText2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelText2.Location = new Point(13, 123);
            labelText2.Margin = new Padding(4, 0, 4, 0);
            labelText2.Name = "labelText2";
            labelText2.Size = new Size(164, 15);
            labelText2.TabIndex = 3;
            labelText2.Text = "con tu proveedor de software";
            // 
            // textLicencia
            // 
            textLicencia.BorderStyle = BorderStyle.FixedSingle;
            textLicencia.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textLicencia.ForeColor = SystemColors.WindowFrame;
            textLicencia.Location = new Point(139, 159);
            textLicencia.Margin = new Padding(4, 3, 4, 3);
            textLicencia.Multiline = true;
            textLicencia.Name = "textLicencia";
            textLicencia.Size = new Size(356, 27);
            textLicencia.TabIndex = 7;
            textLicencia.Text = "XXXX-XXXX-XXXX-XXXX-2023";
            textLicencia.Enter += textLicencia_Enter;
            textLicencia.Leave += textLicencia_Leave;
            // 
            // btnActivarProducto
            // 
            btnActivarProducto.Location = new Point(237, 203);
            btnActivarProducto.Margin = new Padding(4, 3, 4, 3);
            btnActivarProducto.Name = "btnActivarProducto";
            btnActivarProducto.Size = new Size(120, 39);
            btnActivarProducto.TabIndex = 8;
            btnActivarProducto.Text = "Activar Producto";
            btnActivarProducto.UseVisualStyleBackColor = true;
            btnActivarProducto.Click += btnActivarProducto_Click;
            // 
            // pictureLlaveLicencia
            // 
            pictureLlaveLicencia.Image = Properties.Resources.LlavesLicencia;
            pictureLlaveLicencia.Location = new Point(83, 157);
            pictureLlaveLicencia.Margin = new Padding(4, 3, 4, 3);
            pictureLlaveLicencia.Name = "pictureLlaveLicencia";
            pictureLlaveLicencia.Size = new Size(51, 35);
            pictureLlaveLicencia.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLlaveLicencia.TabIndex = 6;
            pictureLlaveLicencia.TabStop = false;
            // 
            // pictureLicenciaExpirada
            // 
            pictureLicenciaExpirada.Image = Properties.Resources.licencia_false;
            pictureLicenciaExpirada.Location = new Point(457, 15);
            pictureLicenciaExpirada.Margin = new Padding(4, 3, 4, 3);
            pictureLicenciaExpirada.Name = "pictureLicenciaExpirada";
            pictureLicenciaExpirada.Size = new Size(92, 73);
            pictureLicenciaExpirada.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLicenciaExpirada.TabIndex = 5;
            pictureLicenciaExpirada.TabStop = false;
            pictureLicenciaExpirada.Visible = false;
            // 
            // pictureLicenciaActivada
            // 
            pictureLicenciaActivada.Image = Properties.Resources.licencia_true;
            pictureLicenciaActivada.Location = new Point(457, 17);
            pictureLicenciaActivada.Margin = new Padding(4, 3, 4, 3);
            pictureLicenciaActivada.Name = "pictureLicenciaActivada";
            pictureLicenciaActivada.Size = new Size(92, 70);
            pictureLicenciaActivada.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLicenciaActivada.TabIndex = 4;
            pictureLicenciaActivada.TabStop = false;
            pictureLicenciaActivada.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Licencia;
            pictureBox1.Location = new Point(13, 9);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelTextLicencia1
            // 
            labelTextLicencia1.AutoSize = true;
            labelTextLicencia1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTextLicencia1.Location = new Point(22, 144);
            labelTextLicencia1.Margin = new Padding(4, 0, 4, 0);
            labelTextLicencia1.Name = "labelTextLicencia1";
            labelTextLicencia1.Size = new Size(115, 24);
            labelTextLicencia1.TabIndex = 9;
            labelTextLicencia1.Text = "Usted tiene";
            labelTextLicencia1.Visible = false;
            // 
            // labelCantidadDiasLicencia
            // 
            labelCantidadDiasLicencia.AutoSize = true;
            labelCantidadDiasLicencia.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCantidadDiasLicencia.Location = new Point(149, 145);
            labelCantidadDiasLicencia.Margin = new Padding(4, 0, 4, 0);
            labelCantidadDiasLicencia.Name = "labelCantidadDiasLicencia";
            labelCantidadDiasLicencia.Size = new Size(43, 24);
            labelCantidadDiasLicencia.TabIndex = 10;
            labelCantidadDiasLicencia.Text = "300";
            labelCantidadDiasLicencia.Visible = false;
            // 
            // labelTextLicencia2
            // 
            labelTextLicencia2.AutoSize = true;
            labelTextLicencia2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTextLicencia2.Location = new Point(192, 145);
            labelTextLicencia2.Margin = new Padding(4, 0, 4, 0);
            labelTextLicencia2.Name = "labelTextLicencia2";
            labelTextLicencia2.Size = new Size(321, 24);
            labelTextLicencia2.TabIndex = 11;
            labelTextLicencia2.Text = "de licencia de producto restantes";
            labelTextLicencia2.Visible = false;
            // 
            // FormActivador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 258);
            Controls.Add(labelTextLicencia2);
            Controls.Add(labelCantidadDiasLicencia);
            Controls.Add(labelTextLicencia1);
            Controls.Add(btnActivarProducto);
            Controls.Add(textLicencia);
            Controls.Add(pictureLlaveLicencia);
            Controls.Add(pictureLicenciaExpirada);
            Controls.Add(pictureLicenciaActivada);
            Controls.Add(labelText2);
            Controls.Add(labelText1);
            Controls.Add(labelTituloActivador);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormActivador";
            Opacity = 0.95D;
            ((System.ComponentModel.ISupportInitialize)pictureLlaveLicencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLicenciaExpirada).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureLicenciaActivada).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTituloActivador;
        private Label labelText1;
        private Label labelText2;
        private PictureBox pictureLicenciaActivada;
        private PictureBox pictureLicenciaExpirada;
        private PictureBox pictureLlaveLicencia;
        private TextBox textLicencia;
        private PictureBox pictureBox1;
        private Button btnActivarProducto;
        private Label labelTextLicencia1;
        private Label labelCantidadDiasLicencia;
        private Label labelTextLicencia2;
    }
}