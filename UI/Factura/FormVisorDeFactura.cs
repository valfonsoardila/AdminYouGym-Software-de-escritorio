
namespace UI
{
    public partial class FormVisorDeFactura : Form
    {
        public string nombreDeArchivo;
        public string rutaDeGuardado;
        public FormVisorDeFactura()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormVisorDeFactura_Load(object sender, EventArgs e)
        {
            labelFileName.Text = nombreDeArchivo;
            labelURL.Text = rutaDeGuardado;
            string pdfDoc = rutaDeGuardado;
            if (File.Exists(pdfDoc))
            {
                this.lectorDePDF.LoadDocument(pdfDoc);
            }
        }
    }
}
