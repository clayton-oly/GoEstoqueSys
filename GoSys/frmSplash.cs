using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GoSys
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();

        }


        public void ArredondaCantosdoForm()
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, this.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            PastaGrafica.AddPie(this.Width - 24, this.Height - 26, 24, 26, 0, 90);
            ForeColor = Color.Red;
            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbCarrega.Value < 100){
                pbCarrega.Value = pbCarrega.Value + 2;
                lbCarrrega.Text = pbCarrega.Value.ToString()+ "%";
                ForeColor = Color.Red;

            }

            else {
                timer1.Enabled = false;
                this.Visible = false;
                ForeColor = Color.Red;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            ArredondaCantosdoForm();
           

        }

        private void lbCarrrega_Click(object sender, EventArgs e)
        {

        }
    }
}
