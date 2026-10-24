
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeoLab2D.Figuras
{
    public class PoligonoEstrellado
    {
        private PointF centro;
        private float radioExterior;
        private float radioInterior;
        private int numeroLados;
        private float angulo;

        private Color colorRelleno;
        private Color colorBorde;

        private PointF[] verticesExternos;
        private PointF[] verticesEstrella;

        public PoligonoEstrellado(PointF centro, float radioExterior,
                                  float radioInterior, int numeroLados,
                                  float angulo)
        {
            this.centro = centro;
            this.radioExterior = radioExterior;
            this.radioInterior = radioInterior;
            this.numeroLados = numeroLados;
            this.angulo = angulo;

            colorRelleno = Color.Gold;
            colorBorde = Color.DarkRed;

            ActualizarVertices();
        }

        // Calcular los vertices del poligono y la estrella
        private void ActualizarVertices()
        {
            if (numeroLados < 3 || radioExterior <= 0 ||
                radioInterior <= 0 || radioInterior >= radioExterior)
            {
                verticesExternos = new PointF[0];
                verticesEstrella = new PointF[0];
                return;
            }

            verticesExternos = new PointF[numeroLados];
            verticesEstrella = new PointF[numeroLados * 2];

            double separacion = 360.0 / numeroLados;

            // CALCULAR LOS VERTICES EXTERIORES
            for (int i = 0; i < numeroLados; i++)
            {
                double grados = angulo + i * separacion;
                double radianes = grados * Math.PI / 180;

                float x = centro.X +
                          radioExterior * (float)Math.Cos(radianes);

                float y = centro.Y -
                          radioExterior * (float)Math.Sin(radianes);

                verticesExternos[i] = new PointF(x, y);
            }

            // CALCULAR LA DISTANCIA DEL CENTRO AL PUNTO MEDIO
            PointF a = verticesExternos[0];
            PointF b = verticesExternos[1];

            float medioX = (a.X + b.X) / 2;
            float medioY = (a.Y + b.Y) / 2;

            double distancia = Math.Sqrt(
                Math.Pow(medioX - centro.X, 2) +
                Math.Pow(medioY - centro.Y, 2));

            // VALIDAR EL RADIO INTERIOR
            if (radioInterior >= distancia)
            {
                verticesEstrella = new PointF[0];
                return;
            }

            float factor = radioInterior / (float)distancia;

            // CALCULAR LOS VERTICES INTERIORES
            for (int i = 0; i < numeroLados; i++)
            {
                int siguiente = (i + 1) % numeroLados;

                PointF p1 = verticesExternos[i];
                PointF p2 = verticesExternos[siguiente];

                float mx = (p1.X + p2.X) / 2;
                float my = (p1.Y + p2.Y) / 2;

                float ix = centro.X + factor * (mx - centro.X);
                float iy = centro.Y + factor * (my - centro.Y);

                verticesEstrella[i * 2] = p1;
                verticesEstrella[i * 2 + 1] = new PointF(ix, iy);
            }
        }

        // Obtener los vertices exteriores
        public PointF[] CalcularVerticesExternos()
        {
            return (PointF[])verticesExternos.Clone();
        }

        // Obtener los vertices de la estrella
        public PointF[] CalcularVertices()
        {
            return (PointF[])verticesEstrella.Clone();
        }

        // Dibujar el poligono y la estrella
        public void Dibujar(Graphics g)
        {
            if (g == null || verticesEstrella.Length == 0)
                return;

            g.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // DIBUJAR EL POLIGONO EXTERIOR
            using (Pen lineaExterior = new Pen(Color.Gray, 2))
            {
                g.DrawPolygon(lineaExterior, verticesExternos);
            }

            // RELLENAR LA ESTRELLA
            using (Brush pincel = new SolidBrush(colorRelleno))
            {
                g.FillPolygon(pincel, verticesEstrella);
            }

            // DIBUJAR EL CONTORNO DE LA ESTRELLA
            using (Pen linea = new Pen(colorBorde, 2))
            {
                g.DrawPolygon(linea, verticesEstrella);
            }
        }

        // Cambiar colores
        public void CambiarColores(Color relleno, Color borde)
        {
            colorRelleno = relleno;
            colorBorde = borde;
        }

        // Cambiar posicion, radios, lados y angulo
        public void Modificar(PointF nuevoCentro, float nuevoRadioExterior,
                              float nuevoRadioInterior, int nuevosLados,
                              float nuevoAngulo)
        {
            if (nuevosLados < 3 || nuevoRadioExterior <= 0 ||
                nuevoRadioInterior <= 0 ||
                nuevoRadioInterior >= nuevoRadioExterior)
            {
                return;
            }

            centro = nuevoCentro;
            radioExterior = nuevoRadioExterior;
            radioInterior = nuevoRadioInterior;
            numeroLados = nuevosLados;
            angulo = nuevoAngulo;

            ActualizarVertices();
        }
    }
}
