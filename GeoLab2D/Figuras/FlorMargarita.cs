
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeoLab2D.Figuras
{
    public class FlorMargarita
    {
        private PointF centro;
        private float radio;
        private float angulo;
        private float distancia;
        private Color[] colores;

        public FlorMargarita(PointF centro, float radio, float angulo)
        {
            this.centro = centro;
            this.radio = radio;
            this.angulo = angulo;

            distancia = radio * 1.5f;

            colores = new Color[]
            {
                Color.Pink,
                Color.LightBlue,
                Color.Plum,
                Color.LightGreen,
                Color.Khaki
            };
        }

        // Calcular los centros de los cinco pentagonos
        public PointF[] CalcularCentros()
        {
            PointF[] centros = new PointF[5];

            for (int i = 0; i < 5; i++)
            {
                double grados = angulo + i * 72;
                double radianes = grados * Math.PI / 180;

                float x = centro.X +
                          distancia * (float)Math.Cos(radianes);

                float y = centro.Y -
                          distancia * (float)Math.Sin(radianes);

                centros[i] = new PointF(x, y);
            }

            return centros;
        }

        // Calcular los vertices de los cinco pentagonos
        public PointF[][] CalcularVertices()
        {
            PointF[][] pentagonos = new PointF[5][];
            PointF[] centros = CalcularCentros();

            for (int i = 0; i < 5; i++)
            {
                pentagonos[i] = new PointF[5];

                for (int j = 0; j < 5; j++)
                {
                    double grados = angulo + i * 72 + j * 72;
                    double radianes = grados * Math.PI / 180;

                    float x = centros[i].X +
                              radio * (float)Math.Cos(radianes);

                    float y = centros[i].Y -
                              radio * (float)Math.Sin(radianes);

                    pentagonos[i][j] = new PointF(x, y);
                }
            }

            return pentagonos;
        }

        // Dibujar la flor
        public void Dibujar(Graphics g)
        {
            if (g == null || radio <= 0)
                return;

            PointF[][] pentagonos = CalcularVertices();

            g.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibujar los cinco petalos
            for (int i = 0; i < 5; i++)
            {
                using (Brush pincel = new SolidBrush(colores[i]))
                {
                    g.FillPolygon(pincel, pentagonos[i]);
                }

                using (Pen linea = new Pen(Color.DarkSlateGray, 2))
                {
                    g.DrawPolygon(linea, pentagonos[i]);
                }
            }
        }

        // Cambiar colores
        public void CambiarColores(Color[] nuevosColores)
        {
            if (nuevosColores != null && nuevosColores.Length == 5)
            {
                colores = (Color[])nuevosColores.Clone();
            }
        }

        // Modificar los parametros de la flor
        public void Modificar(PointF nuevoCentro, float nuevoRadio,
                              float nuevoAngulo)
        {
            if (nuevoRadio <= 0)
                return;

            centro = nuevoCentro;
            radio = nuevoRadio;
            angulo = nuevoAngulo;
            distancia = radio * 1.5f;
        }

        // Cambiar la separacion de los petalos
        public void CambiarDistancia(float nuevaDistancia)
        {
            if (nuevaDistancia > 0)
            {
                distancia = nuevaDistancia;
            }
        }
    }
}
