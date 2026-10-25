using System;
using System.Collections.Generic;

namespace GeoLab2D.Matematicas
{
    public static class Geometria
    {
        public static double CalcularPerimetro(List<Vector2D> vertices)
        {
            double perimetro = 0;
            int n = vertices.Count;
            for (int i = 0; i < n; i++)
            {
                Vector2D p1 = vertices[i];
                Vector2D p2 = vertices[(i + 1) % n];
                double dx = p2.X - p1.X;
                double dy = p2.Y - p1.Y;
                perimetro += Math.Sqrt(dx * dx + dy * dy);
            }
            return perimetro;
        }

        public static double CalcularArea(List<Vector2D> vertices)
        {
            double suma = 0;
            int n = vertices.Count;
            for (int i = 0; i < n; i++)
            {
                Vector2D p1 = vertices[i];
                Vector2D p2 = vertices[(i + 1) % n];
                suma += (p1.X * p2.Y) - (p2.X * p1.Y);
            }
            return Math.Abs(suma) / 2.0;
        }

        public static double Orientacion(Vector2D p1, Vector2D p2, Vector2D p3)
        {
            return (p2.X - p1.X) * (p3.Y - p1.Y) - (p2.Y - p1.Y) * (p3.X - p1.X);
        }

        public static bool PuntoEnPoligono(Vector2D punto, List<Vector2D> vertices)
        {
            int n = vertices.Count;
            bool dentro = false;
            for (int i = 0, j = n - 1; i < n; j = i++)
            {
                if (((vertices[i].Y > punto.Y) != (vertices[j].Y > punto.Y)) &&
                    (punto.X < (vertices[j].X - vertices[i].X) * (punto.Y - vertices[i].Y) / (vertices[j].Y - vertices[i].Y) + vertices[i].X))
                {
                    dentro = !dentro;
                }
            }
            return dentro;
        }

        public static Vector2D PuntoMasCercanoSegmento(Vector2D p, Vector2D a, Vector2D b)
        {
            Vector2D ab = new Vector2D(b.X - a.X, b.Y - a.Y);
            Vector2D ap = new Vector2D(p.X - a.X, p.Y - a.Y);
            double abLenSq = ab.X * ab.X + ab.Y * ab.Y;

            if (abLenSq == 0) return a;

            double t = Vector2D.ProductoPunto(ap, ab) / abLenSq;
            if (t < 0.0) t = 0.0;
            else if (t > 1.0) t = 1.0;

            return new Vector2D(a.X + t * ab.X, a.Y + t * ab.Y);
        }
    }
}