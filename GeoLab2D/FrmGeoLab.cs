using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeoLab2D.Figuras;
using System.Globalization;
using GeoLab2D.Matematicas;

namespace GeoLab2D
{
    public partial class FrmGeoLab : Form
    {

        public FrmGeoLab()
        {
            InitializeComponent();

            this.IsMdiContainer = true;

            this.MdiChildActivate += (s, e) =>
            {
                pnlInicio.Visible = this.ActiveMdiChild == null;
            };
        }


        private Hexagono hexagono;
        private FlorMargarita flor;
        private PoligonoEstrellado estrella;
        // Punto que se está comprobando dentro o fuera
        private PointF? puntoAnalizado = null;
        private bool? puntoEstaDentro = null;

        // Elementos visuales de la proyección
        private PointF? extremoA = null;
        private PointF? extremoB = null;
        private PointF? puntoProyeccionP = null;
        private PointF? puntoProyeccionQ = null;
        private List<Vector2D> verticesTransformados = null;
        private Color colorTransformacion = Color.MediumVioletRed;

        private void lblSeccionA_Click(object sender, EventArgs e)
        {

        }

        private void lblResultados_Click(object sender, EventArgs e)
        {

        }

        private void txtPuntoY_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPuntoX_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPuntoY_Click(object sender, EventArgs e)
        {

        }

        private void lblPuntoX_Click(object sender, EventArgs e)
        {

        }

        private void lblSeccionB_Click(object sender, EventArgs e)
        {

        }

        private void lblSeccionA_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
 
        }

        private void txtAngulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRadioLado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCentroY_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCentroX_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbFigura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAngulo_Click(object sender, EventArgs e)
        {

        }

        private void lblRadioLado_Click(object sender, EventArgs e)
        {

        }

        private void lblCentroY_Click(object sender, EventArgs e)
        {

        }

        private void lblCentroX_Click(object sender, EventArgs e)
        {

        }

        private void lblFigura_Click(object sender, EventArgs e)
        {

        }


        private void pnlLienzo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DibujarPunto(
            Graphics g, PointF punto, Color color, string etiqueta)
        {

        }




        private void btnPerimetro_Click(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {

        }

        private void btnPuntoDentro_Click(object sender, EventArgs e)
        {

        }

        private void btnProyeccion_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos(Control contenedor)
        {

        }


        private void btnTrasladar_Click(object sender, EventArgs e)
        {

    }

        private void btnRotar_Click(object sender, EventArgs e)
        {

        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {

        }

        private void figurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFiguras frmFiguras = new FrmFiguras();
            frmFiguras.MdiParent = this;
            frmFiguras.WindowState = FormWindowState.Maximized;
            frmFiguras.BringToFront();
            frmFiguras.Show();

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVectores frmVectores = new FrmVectores();
            frmVectores.MdiParent = this;
            frmVectores.WindowState = FormWindowState.Maximized;
            frmVectores.BringToFront();
            frmVectores.Show();
        }


        private void btnDibujarVectores_Click(object sender, EventArgs e)
        {

        }

        private void btnMagnitud_Click(object sender, EventArgs e)
        {

        }

        private void btnDireccion_Click(object sender, EventArgs e)
        {

        }

        private void btnProductoPunto_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDeterminante_Click(object sender, EventArgs e)
        {
        }

        private void btnFigura_Click(object sender, EventArgs e)
        {
            FrmFiguras frmFiguras = new FrmFiguras();
            frmFiguras.MdiParent = this;
            frmFiguras.WindowState = FormWindowState.Maximized;
            frmFiguras.BringToFront();
            frmFiguras.Show();

        }

        private void btnVectores_Click(object sender, EventArgs e)
        {
            pnlInicio.Visible = false;

            FrmVectores frmVectores = new FrmVectores();
            frmVectores.MdiParent = this;
            frmVectores.WindowState = FormWindowState.Maximized;
            frmVectores.Show();
        }

    }
}
