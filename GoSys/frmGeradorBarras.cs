using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace GoSys
{

    public partial class frmGeradorBarras : Form
    {
        public frmGeradorBarras()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edCodigo.Text))
            {
                MessageBox.Show("Digite uma sequencia de numero para gerar o codigo de barras", "Alerta");
                edCodigo.Focus();
                return;
            }


            try
            {


                BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                Codigo.IncludeLabel = true;
                pnResultado.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.EAN13, edCodigo.Text, Color.Black, Color.White, 400, 100);
                btnSalvar.Enabled = true;
            }
            catch (Exception )
            {

                MessageBox.Show("É obrigatorio ter 13 digitos para gerar um codigo de barras válido", "Alerta");
                edCodigo.Focus();
            }
       
        }

        private void frmGeradorBarras_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Image imgFinal = (Image)pnResultado.BackgroundImage.Clone();

                SaveFileDialog CajaDeDiaologoGuardar = new SaveFileDialog();
                CajaDeDiaologoGuardar.AddExtension = true;
                CajaDeDiaologoGuardar.Filter = "Image PNG (*.png)|*.png";
                CajaDeDiaologoGuardar.ShowDialog();
                if (!string.IsNullOrEmpty(CajaDeDiaologoGuardar.FileName))
                {
                    imgFinal.Save(CajaDeDiaologoGuardar.FileName, ImageFormat.Png);
                }
                imgFinal.Dispose();

            }
            catch (Exception)
            {

              
            }
            
        }
    }
}
