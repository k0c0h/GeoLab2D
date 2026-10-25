
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeoLab2D.Figuras
{
    public class Hexagono
    {
        private PointF centro;
        private float lado;
        private float angulo;
        private Color[] colores;

        public Hexagono(PointF centro, float lado, float angulo)
        {
            this.centro = centro;
            this.lado = lado;
            this.angulo = angulo;

            colores = new Color[]
            {
                Color.Red,
                Color.Orange,
                Color.Yellow,
                Color.Green,
                Color.Blue,
                Color.Violet
            };
        }

        // Calcular los seis vertices
        public PointF[] CalcularVertices()
        {
            if (lado <= 0)
                return new PointF[0];

            PointF[] vertices = new PointF[6];

            for (int i = 0; i < 6; i++)
            {
                double grados = angulo + i * 60;
                double radianes = grados * Math.PI / 180;

                float x = centro.X +
                          lado * (float)Math.Cos(radianes);

                float y = centro.Y -
                          lado * (float)Math.Sin(radianes);

                vertices[i] = new PointF(x, y);
            }

            return vertices;
        }

        // Dibujar los seis triangulos de colores
        public void Dibujar(Graphics g)
        {
            if (g == null || lado <= 0)
                return;

            PointF[] vertices = CalcularVertices();

            g.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            for (int i = 0; i < 6; i++)
            {
                int siguiente = (i + 1) % 6;

                PointF[] triangulo =
                {
                    centro,
                    vertices[i],
                    vertices[siguiente]
                };

                using (Brush pincel = new SolidBrush(colores[i]))
                {
                    g.FillPolygon(pincel, triangulo);
                }

                using (Pen linea = new Pen(Color.Black, 2))
                {
                    g.DrawPolygon(linea, triangulo);
                }
            }
        }

        // Cambiar los colores
        public void CambiarColores(Color[] nuevosColores)
        {
            if (nuevosColores != null && nuevosColores.Length == 6)
            {
                colores = (Color[])nuevosColores.Clone();
            }
        }

        // Cambiar las dimensiones y posicion
        public void Modificar(PointF nuevoCentro, float nuevoLado,
                              float nuevoAngulo)
        {
            if (nuevoLado <= 0)
                return;

            centro = nuevoCentro;
            lado = nuevoLado;
            angulo = nuevoAngulo;
        }
    }
}
