
namespace UI
{
    partial class FormVisorDeFactura
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
            panel1 = new Panel();
            btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            labelTitleFileNme = new Label();
            labelTitleURL = new Label();
            labelFileName = new Label();
            labelURL = new Label();
            lectorDePDF = new Patagames.Pdf.Net.Controls.WinForms.PdfViewer();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 31);
            panel1.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.ForeColor = SystemColors.ControlLightLight;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            btnCerrar.IconColor = SystemColors.ControlLightLight;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.IconSize = 23;
            btnCerrar.Location = new Point(523, 5);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 23);
            btnCerrar.TabIndex = 3;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // labelTitleFileNme
            // 
            labelTitleFileNme.AutoSize = true;
            labelTitleFileNme.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleFileNme.Location = new Point(15, 46);
            labelTitleFileNme.Margin = new Padding(4, 0, 4, 0);
            labelTitleFileNme.Name = "labelTitleFileNme";
            labelTitleFileNme.Size = new Size(118, 13);
            labelTitleFileNme.TabIndex = 3;
            labelTitleFileNme.Text = "Nombre de archivo:";
            // 
            // labelTitleURL
            // 
            labelTitleURL.AutoSize = true;
            labelTitleURL.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleURL.Location = new Point(14, 70);
            labelTitleURL.Margin = new Padding(4, 0, 4, 0);
            labelTitleURL.Name = "labelTitleURL";
            labelTitleURL.Size = new Size(151, 13);
            labelTitleURL.TabIndex = 4;
            labelTitleURL.Text = "Ruta de almacenamiento:";
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFileName.Location = new Point(134, 46);
            labelFileName.Margin = new Padding(4, 0, 4, 0);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(12, 13);
            labelFileName.TabIndex = 5;
            labelFileName.Text = "*";
            // 
            // labelURL
            // 
            labelURL.AutoSize = true;
            labelURL.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelURL.Location = new Point(166, 70);
            labelURL.Margin = new Padding(4, 0, 4, 0);
            labelURL.Name = "labelURL";
            labelURL.Size = new Size(12, 13);
            labelURL.TabIndex = 6;
            labelURL.Text = "*";
            // 
            // lectorDePDF
            // 
            lectorDePDF.AutoScroll = true;
            lectorDePDF.BackColor = SystemColors.ControlDark;
            lectorDePDF.CurrentIndex = -1;
            lectorDePDF.CurrentPageHighlightColor = Color.FromArgb(170, 70, 130, 180);
            lectorDePDF.Document = null;
            lectorDePDF.FormHighlightColor = Color.Transparent;
            lectorDePDF.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY;
            lectorDePDF.LoadingIconText = "Loading...";
            lectorDePDF.Location = new Point(18, 86);
            lectorDePDF.Margin = new Padding(4, 3, 4, 3);
            lectorDePDF.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.Default;
            lectorDePDF.Name = "lectorDePDF";
            lectorDePDF.OptimizedLoadThreshold = 1000;
            lectorDePDF.Padding = new Padding(12, 12, 12, 12);
            lectorDePDF.PageAlign = ContentAlignment.MiddleCenter;
            lectorDePDF.PageAutoDispose = true;
            lectorDePDF.PageBackColor = Color.White;
            lectorDePDF.PageBorderColor = Color.Black;
            lectorDePDF.PageMargin = new Padding(10);
            lectorDePDF.PageSeparatorColor = Color.Gray;
            lectorDePDF.RenderFlags = Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT | Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH;
            lectorDePDF.ShowCurrentPageHighlight = true;
            lectorDePDF.ShowLoadingIcon = true;
            lectorDePDF.ShowPageSeparator = true;
            lectorDePDF.Size = new Size(521, 421);
            lectorDePDF.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.FitToWidth;
            lectorDePDF.TabIndex = 7;
            lectorDePDF.TextSelectColor = Color.FromArgb(70, 70, 130, 180);
            lectorDePDF.TilesCount = 2;
            lectorDePDF.UseProgressiveRender = true;
            lectorDePDF.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical;
            lectorDePDF.Zoom = 1F;
            // 
            // FormVisorDeFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 519);
            Controls.Add(lectorDePDF);
            Controls.Add(labelURL);
            Controls.Add(labelFileName);
            Controls.Add(labelTitleURL);
            Controls.Add(labelTitleFileNme);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormVisorDeFactura";
            Text = "FormVisorDeFactura";
            Load += FormVisorDeFactura_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        //private Spire.PdfViewer.Forms.PdfDocumentViewer lectorDePDF;
        private Label labelTitleFileNme;
        private Label labelTitleURL;
        private Label labelFileName;
        private Label labelURL;
        private Patagames.Pdf.Net.Controls.WinForms.PdfViewer lectorDePDF;
    }
}