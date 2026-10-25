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
    public partial class FrmFiguras : Form
    {
        public FrmFiguras()
        {
            InitializeComponent();
        }

        private Hexagono hexagono;
        private FlorMargarita flor;
        private PoligonoEstrellado estrella;
        private PointF? puntoAnalizado = null;
        private bool? puntoEstaDentro = null;

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
            float x, y, radio, angulo;

            if (!float.TryParse(txtCentroX.Text, NumberStyles.Float,
                    CultureInfo.CurrentCulture, out x) ||
                !float.TryParse(txtCentroY.Text, NumberStyles.Float,
                    CultureInfo.CurrentCulture, out y) ||
                !float.TryParse(txtRadioLado.Text, NumberStyles.Float,
                    CultureInfo.CurrentCulture, out radio) ||
                !float.TryParse(txtAngulo.Text, NumberStyles.Float,
                    CultureInfo.CurrentCulture, out angulo))
            {
                MessageBox.Show(
                    "Ingresa valores numéricos válidos.",
                    "Datos incorrectos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (radio <= 0)
            {
                MessageBox.Show("El radio o lado debe ser mayor que cero.");
                return;
            }

            // Limpiar la selección anterior.
            hexagono = null;
            flor = null;
            estrella = null;
            verticesTransformados = null;

            PointF centro = new PointF(x, y);

            switch (cmbFigura.Text)
            {
                case "Hexágono":
                    hexagono = new Hexagono(centro, radio, angulo);
                    break;

                case "Flor margarita":
                    flor = new FlorMargarita(centro, radio, angulo);
                    break;


                case "Polígono estrellado":
                    int numeroLados;

                    if (!int.TryParse(txtNumeroLados.Text, out numeroLados)
                        || numeroLados < 3)
                    {
                        MessageBox.Show(
                            "Ingresa un número de puntas N mayor o igual que 3.",
                            "Número incorrecto",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    estrella = new PoligonoEstrellado(
                        centro,
                        radio,
                        radio * 0.4f,
                        numeroLados,
                        angulo);
                    break;


                default:
                    MessageBox.Show("Selecciona una figura.");
                    return;
            }

            puntoAnalizado = null;
            puntoEstaDentro = null;

            extremoA = null;
            extremoB = null;
            puntoProyeccionP = null;
            puntoProyeccionQ = null;

            lblResultados.Text = "";
            pnlLienzo.Invalidate();
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

        private void pnlLienzo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 1. Dibujar la figura seleccionada
            if (hexagono != null)
                hexagono.Dibujar(g);

            if (flor != null)
                flor.Dibujar(g);

            if (estrella != null)
                estrella.Dibujar(g);

            // 2. Dibujar el resultado de punto dentro/fuera
            if (puntoAnalizado.HasValue)
            {
                PointF p = puntoAnalizado.Value;

                Color colorPunto = puntoEstaDentro == true
                    ? Color.Green
                    : Color.Red;

                using (Brush pincel = new SolidBrush(colorPunto))
                using (Pen borde = new Pen(Color.Black, 1.5f))
                {
                    g.FillEllipse(pincel, p.X - 6, p.Y - 6, 12, 12);
                    g.DrawEllipse(borde, p.X - 6, p.Y - 6, 12, 12);
                }

                using (Font fuente = new Font("Arial", 10, FontStyle.Bold))
                using (Brush pincelTexto = new SolidBrush(colorPunto))
                {
                    string texto = puntoEstaDentro == true
                        ? "P: DENTRO"
                        : "P: FUERA";

                    g.DrawString(texto, fuente, pincelTexto, p.X + 9, p.Y - 20);
                }
            }

            // 3. Dibujar la proyección sobre el segmento AB
            if (extremoA.HasValue &&
                extremoB.HasValue &&
                puntoProyeccionP.HasValue &&
                puntoProyeccionQ.HasValue)
            {
                PointF a = extremoA.Value;
                PointF b = extremoB.Value;
                PointF p = puntoProyeccionP.Value;
                PointF q = puntoProyeccionQ.Value;

                // Segmento AB
                using (Pen penSegmento = new Pen(Color.Blue, 3))
                {
                    g.DrawLine(penSegmento, a, b);
                }

                // Línea desde P hasta su proyección Q
                using (Pen penProyeccion = new Pen(Color.DarkOrange, 2))
                {
                    penProyeccion.DashStyle =
                        System.Drawing.Drawing2D.DashStyle.Dash;

                    g.DrawLine(penProyeccion, p, q);
                }

                // Dibujar y etiquetar A, B, P y Q
                DibujarPunto(g, a, Color.Blue, "A");
                DibujarPunto(g, b, Color.Blue, "B");
                DibujarPunto(g, p, Color.Red, "P");
                DibujarPunto(g, q, Color.DarkOrange, "Q");
            }

            // Dibujar el contorno de la figura transformada
            if (verticesTransformados != null &&
                verticesTransformados.Count >= 3)
            {
                PointF[] puntos = new PointF[verticesTransformados.Count];

                for (int i = 0; i < verticesTransformados.Count; i++)
                {
                    puntos[i] = new PointF(
                        (float)verticesTransformados[i].X,
                        (float)verticesTransformados[i].Y
                    );
                }

                using (Pen pluma = new Pen(colorTransformacion, 3))
                {
                    pluma.DashStyle =
                        System.Drawing.Drawing2D.DashStyle.Dash;

                    g.DrawPolygon(pluma, puntos);
                }
            }
        }

        private void DibujarPunto(
            Graphics g, PointF punto, Color color, string etiqueta)
        {
            const float radio = 5f;

            using (Brush pincel = new SolidBrush(color))
            using (Pen borde = new Pen(Color.Black, 1))
            {
                g.FillEllipse(
                    pincel,
                    punto.X - radio,
                    punto.Y - radio,
                    radio * 2,
                    radio * 2);

                g.DrawEllipse(
                    borde,
                    punto.X - radio,
                    punto.Y - radio,
                    radio * 2,
                    radio * 2);
            }

            using (Font fuente = new Font("Arial", 10, FontStyle.Bold))
            using (Brush pincelTexto = new SolidBrush(color))
            {
                g.DrawString(
                    etiqueta,
                    fuente,
                    pincelTexto,
                    punto.X + 7,
                    punto.Y + 5);
            }
        }



        private List<Vector2D> ObtenerVertices()
        {
            PointF[] puntos = null;

            if (hexagono != null)
            {
                puntos = hexagono.CalcularVertices();
            }
            else if (flor != null)
            {
                // Para la flor, por ahora usamos el primer pentágono.
                PointF[][] pentagonos = flor.CalcularVertices();

                if (pentagonos != null && pentagonos.Length > 0)
                    puntos = pentagonos[0];
            }
            else if (estrella != null)
            {
                puntos = estrella.CalcularVertices();
            }

            List<Vector2D> vertices = new List<Vector2D>();

            if (puntos != null)
            {
                foreach (PointF punto in puntos)
                {
                    vertices.Add(new Vector2D(punto.X, punto.Y));
                }
            }

            return vertices;
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            List<Vector2D> vertices = ObtenerVertices();

            if (vertices.Count < 3)
            {
                MessageBox.Show(
                    "Primero dibuja una figura.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            double perimetro = Geometria.CalcularPerimetro(vertices);

            lblResultados.Text = "Perímetro: " + perimetro.ToString("F2");
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            List<Vector2D> vertices = ObtenerVertices();

            if (vertices.Count < 3)
            {
                MessageBox.Show(
                    "Primero dibuja una figura.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            double area = Geometria.CalcularArea(vertices);

            lblResultados.Text = "Área: " + area.ToString("F2");
        }

        private void btnPuntoDentro_Click(object sender, EventArgs e)
        {
            double x, y;

            if (!TryLeerNumero(txtPuntoPX.Text, out x) ||
                !TryLeerNumero(txtPuntoPY.Text, out y))
            {
                MessageBox.Show(
                    "Ingresa números válidos en las coordenadas X e Y.",
                    "Coordenadas incorrectas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            List<Vector2D> vertices = ObtenerVertices();

            if (vertices == null || vertices.Count < 3)
            {
                MessageBox.Show("Primero dibuja una figura.");
                return;
            }

            Vector2D punto = new Vector2D(x, y);
            bool dentro = Geometria.PuntoEnPoligono(punto, vertices);

            puntoAnalizado = new PointF((float)x, (float)y);
            puntoEstaDentro = dentro;

            // Limpiar la proyección anterior
            extremoA = null;
            extremoB = null;
            puntoProyeccionP = null;
            puntoProyeccionQ = null;

            lblResultados.Text = dentro
                ? "El punto está DENTRO del polígono."
                : "El punto está FUERA del polígono.";

            pnlLienzo.Invalidate();
        }

        private void btnProyeccion_Click(object sender, EventArgs e)
        {
            double px = 0, py = 0;
            double ax = 0, ay = 0;
            double bx = 0, by = 0;

            bool datosValidos =
                TryLeerNumero(txtPuntoX.Text, out px) &&
                TryLeerNumero(txtPuntoY.Text, out py) &&
                TryLeerNumero(txtAX.Text, out ax) &&
                TryLeerNumero(txtAY.Text, out ay) &&
                TryLeerNumero(txtBX.Text, out bx) &&
                TryLeerNumero(txtBY.Text, out by);

            if (!datosValidos)
            {
                MessageBox.Show(
                    "Completa las seis coordenadas numéricas de P, A y B.",
                    "Coordenadas incorrectas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Vector2D p = new Vector2D(px, py);
            Vector2D a = new Vector2D(ax, ay);
            Vector2D b = new Vector2D(bx, by);

            Vector2D q = Geometria.PuntoMasCercanoSegmento(p, a, b);

            // Guardar los puntos para dibujarlos en el lienzo
            extremoA = new PointF((float)a.X, (float)a.Y);
            extremoB = new PointF((float)b.X, (float)b.Y);
            puntoProyeccionP = new PointF((float)p.X, (float)p.Y);
            puntoProyeccionQ = new PointF((float)q.X, (float)q.Y);

            // Limpiar el marcador de punto dentro/fuera
            puntoAnalizado = null;
            puntoEstaDentro = null;

            double dx = p.X - q.X;
            double dy = p.Y - q.Y;
            double distancia = Math.Sqrt(dx * dx + dy * dy);

            lblResultados.Text =
                "Proyección Q = (" +
                q.X.ToString("F2", CultureInfo.CurrentCulture) + ", " +
                q.Y.ToString("F2", CultureInfo.CurrentCulture) + ")" +
                Environment.NewLine +
                "Distancia P-Q = " +
                distancia.ToString("F2", CultureInfo.CurrentCulture);

            pnlLienzo.Invalidate();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            hexagono = null;
            flor = null;
            estrella = null;


            puntoAnalizado = null;
            puntoEstaDentro = null;

            extremoA = null;
            extremoB = null;
            puntoProyeccionP = null;
            puntoProyeccionQ = null;
            verticesTransformados = null;

            lblResultados.Text = "";

            LimpiarCampos(this);
            cmbFigura.SelectedIndex = -1;

            pnlLienzo.Invalidate();
        }
        private void LimpiarCampos(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }

                if (control.HasChildren)
                {
                    LimpiarCampos(control);
                }
            }
        }



        private Vector2D ObtenerCentro(List<Vector2D> vertices)
        {
            double sumaX = 0;
            double sumaY = 0;

            foreach (Vector2D punto in vertices)
            {
                sumaX += punto.X;
                sumaY += punto.Y;
            }

            return new Vector2D(
                sumaX / vertices.Count,
                sumaY / vertices.Count
            );
        }

        private void btnTrasladar_Click(object sender, EventArgs e)
        {
            List<Vector2D> vertices = ObtenerVertices();

            if (vertices == null || vertices.Count < 3)
            {
                MessageBox.Show("Primero dibuja una figura.");
                return;
            }

            double dx, dy;

            if (!TryLeerNumero(txtTrasladarX.Text, out dx) ||
                !TryLeerNumero(txtTrasladarY.Text, out dy))
            {
                MessageBox.Show("Ingresa valores válidos para X e Y.");
                return;
            }

            verticesTransformados =
                Transformaciones.Trasladar(vertices, dx, dy);

            colorTransformacion = Color.MediumVioletRed;

            lblResultados.Text =
                "Traslación aplicada: (" +
                dx.ToString("F2") + ", " +
                dy.ToString("F2") + ")";

            pnlLienzo.Invalidate();
        }

        private void btnRotar_Click(object sender, EventArgs e)
        {
            List<Vector2D> vertices = ObtenerVertices();

            if (vertices == null || vertices.Count < 3)
            {
                MessageBox.Show("Primero dibuja una figura.");
                return;
            }

            double angulo;

            if (!TryLeerNumero(txtRotacion.Text, out angulo))
            {
                MessageBox.Show("Ingresa un ángulo válido.");
                return;
            }

            Vector2D centro = ObtenerCentro(vertices);

            verticesTransformados =
                Transformaciones.Rotar(vertices, angulo, centro);

            colorTransformacion = Color.DarkOrange;

            lblResultados.Text =
                "Rotación aplicada: " +
                angulo.ToString("F2") + " grados";

            pnlLienzo.Invalidate();
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            List<Vector2D> vertices = ObtenerVertices();

            if (vertices == null || vertices.Count < 3)
            {
                MessageBox.Show("Primero dibuja una figura.");
                return;
            }

            double escalaX, escalaY;

            if (!TryLeerNumero(txtEscalaX.Text, out escalaX) ||
                !TryLeerNumero(txtEscalaY.Text, out escalaY))
            {
                MessageBox.Show("Ingresa factores de escala válidos.");
                return;
            }

            if (escalaX <= 0 || escalaY <= 0)
            {
                MessageBox.Show(
                    "Los factores de escala deben ser mayores que cero.");
                return;
            }

            Vector2D centro = ObtenerCentro(vertices);

            verticesTransformados =
                Transformaciones.Escalar(
                    vertices, escalaX, escalaY, centro);

            colorTransformacion = Color.DarkViolet;

            lblResultados.Text =
                "Escala aplicada: X = " +
                escalaX.ToString("F2") +
                ", Y = " + escalaY.ToString("F2");

            pnlLienzo.Invalidate();
        }

       

    }
}
