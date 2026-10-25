using GeoLab2D.Matematicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoLab2D
{
    public partial class FrmVectores : Form
    {
        public FrmVectores()
        {
            InitializeComponent();
        }
        private Vector2D vector1Dibujado = null;
        private Vector2D vector2Dibujado = null;


        private void DibujarCuadricula(Graphics g)
        {
            float escala = 30f; // 30 píxeles representan 1 unidad

            // Origen de los ejes: esquina inferior izquierda con margen
            float origenX = 60f;
            float origenY = pnlLienzo.Height - 40f;

            float ancho = pnlLienzo.Width;
            float alto = pnlLienzo.Height;

            using (Pen plumaCuadricula = new Pen(Color.LightGray, 1f))
            using (Pen plumaEjes = new Pen(Color.Black, 2f))
            using (Font fuente = new Font("Arial", 8f))
            using (Brush pincelTexto = new SolidBrush(Color.Black))
            {
                // Cuadrícula vertical
                for (float x = origenX; x <= ancho; x += escala)
                {
                    g.DrawLine(plumaCuadricula, x, 0, x, alto);

                    int valorX = (int)Math.Round((x - origenX) / escala);

                    if (valorX != 0)
                    {
                        g.DrawString(
                            valorX.ToString(),
                            fuente,
                            pincelTexto,
                            x + 2,
                            origenY + 3);
                    }
                }

                for (float x = origenX - escala; x >= 0; x -= escala)
                {
                    g.DrawLine(plumaCuadricula, x, 0, x, alto);

                    int valorX = (int)Math.Round((x - origenX) / escala);

                    g.DrawString(
                        valorX.ToString(),
                        fuente,
                        pincelTexto,
                        x + 2,
                        origenY + 3);
                }

                // Cuadrícula horizontal
                for (float y = origenY; y <= alto; y += escala)
                {
                    g.DrawLine(plumaCuadricula, 0, y, ancho, y);

                    int valorY = (int)Math.Round((origenY - y) / escala);

                    if (valorY != 0)
                    {
                        g.DrawString(
                            valorY.ToString(),
                            fuente,
                            pincelTexto,
                            origenX - 20,
                            y + 2);
                    }
                }

                for (float y = origenY - escala; y >= 0; y -= escala)
                {
                    g.DrawLine(plumaCuadricula, 0, y, ancho, y);

                    int valorY = (int)Math.Round((origenY - y) / escala);

                    g.DrawString(
                        valorY.ToString(),
                        fuente,
                        pincelTexto,
                        origenX - 20,
                        y + 2);
                }

                // Dibujar los ejes principales
                g.DrawLine(plumaEjes, 0, origenY, ancho, origenY);
                g.DrawLine(plumaEjes, origenX, alto, origenX, 0);

                // Etiquetas de los ejes
                using (Font fuenteEjes = new Font("Arial", 10f, FontStyle.Bold))
                {
                    g.DrawString("X", fuenteEjes, pincelTexto, ancho - 18, origenY + 5);
                    g.DrawString("Y", fuenteEjes, pincelTexto, origenX + 5, 2);
                    g.DrawString("(0,0)", fuente, pincelTexto, origenX + 4, origenY + 4);
                }
            }
        }

        private bool TryLeerNumero(string texto, out double valor)
        {
            texto = texto.Trim();

            if (double.TryParse(
                texto,
                NumberStyles.Float,
                CultureInfo.CurrentCulture,
                out valor))
            {
                return true;
            }

            return double.TryParse(
                texto,
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out valor);
        }

        private bool ObtenerVectores(
          out Vector2D v1,
          out Vector2D v2)
        {
            v1 = new Vector2D(0, 0);
            v2 = new Vector2D(0, 0);

            double x1 = 0, y1 = 0, x2 = 0, y2 = 0;

            bool datosValidos =
                TryLeerNumero(txtV1X.Text, out x1) &&
                TryLeerNumero(txtV1Y.Text, out y1) &&
                TryLeerNumero(txtV2X.Text, out x2) &&
                TryLeerNumero(txtV2Y.Text, out y2);

            if (!datosValidos)
            {
                MessageBox.Show(
                    "Ingresa coordenadas válidas para V1 y V2.",
                    "Datos incorrectos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            v1 = new Vector2D(x1, y1);
            v2 = new Vector2D(x2, y2);

            return true;
        }

        private void btnDibujarVectores_Click(object sender, EventArgs e)
        {
            Vector2D v1, v2;

            if (!ObtenerVectores(out v1, out v2))
                return;

            vector1Dibujado = v1;
            vector2Dibujado = v2;

            pnlLienzo.Invalidate();
        }

        private void DibujarVector(
            Graphics g,
            Vector2D vector,
            Color color,
            string etiqueta)
        {
            float escala = 30f;

            float origenX = 60f;
            float origenY = pnlLienzo.Height - 40f;

            PointF origen = new PointF(origenX, origenY);

            PointF extremo = new PointF(
                origenX + (float)vector.X * escala,
                origenY - (float)vector.Y * escala
            );

            using (Pen pluma = new Pen(color, 3f))
            {
                pluma.EndCap =
                    System.Drawing.Drawing2D.LineCap.ArrowAnchor;

                g.DrawLine(pluma, origen, extremo);
            }

            using (Font fuente = new Font("Arial", 10, FontStyle.Bold))
            using (Brush pincel = new SolidBrush(color))
            {
                g.DrawString(
                    etiqueta + " (" +
                    vector.X.ToString("F2") + ", " +
                    vector.Y.ToString("F2") + ")",
                    fuente,
                    pincel,
                    extremo.X + 5,
                    extremo.Y - 20
                );
            }
        }

        private void btnMagnitud_Click(object sender, EventArgs e)
        {
            Vector2D v1, v2;

            if (!ObtenerVectores(out v1, out v2))
                return;

            lblResultados.Text =
                "Magnitud de V1: " +
                v1.Magnitud().ToString("F2") +
                    Environment.NewLine +
                "Magnitud de V2: " +
                v2.Magnitud().ToString("F2");
        }

        private void btnDireccion_Click(object sender, EventArgs e)
        {
            Vector2D v1, v2;

            if (!ObtenerVectores(out v1, out v2))
                return;

            double gradosV1 = v1.Direccion();
            double gradosV2 = v2.Direccion();

            lblResultados.Text =
                "Dirección de V1: " +
                gradosV1.ToString("F2") + "°" +
                Environment.NewLine +
                "Dirección de V2: " +
                gradosV2.ToString("F2") + "°";
        }

        private void btnProductoPunto_Click(object sender, EventArgs e)
        {
            Vector2D v1, v2;

            if (!ObtenerVectores(out v1, out v2))
                return;

            double resultado = Vector2D.ProductoPunto(v1, v2);

            lblResultados.Text =
                "Producto punto: " + resultado.ToString("F2");
        }

        private void btnDeterminante_Click(object sender, EventArgs e)
        {
            Vector2D v1, v2;

            if (!ObtenerVectores(out v1, out v2))
                return;

            double resultado = Vector2D.Determinante(v1, v2);

            lblResultados.Text =
                "Determinante: " + resultado.ToString("F2");
        }


        private void pnlLienzo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            DibujarCuadricula(g);

            if (vector1Dibujado != null)
            {
                DibujarVector(
                    g,
                    vector1Dibujado,
                    Color.DodgerBlue,
                    "V1");
            }

            if (vector2Dibujado != null)
            {
                DibujarVector(
                    g,
                    vector2Dibujado,
                    Color.OrangeRed,
                    "V2");
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            vector1Dibujado = null;
            vector2Dibujado = null;
            txtV1X.Text = "";
            txtV1Y.Text = "";
            txtV2X.Text = "";
            txtV2Y.Text = "";
            lblResultados.Text = "";
            pnlLienzo.Invalidate();

        }

    }

}
