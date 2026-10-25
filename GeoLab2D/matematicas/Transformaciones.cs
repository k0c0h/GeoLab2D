using System;
using System.Collections.Generic;

namespace GeoLab2D.Matematicas
{
    public static class Transformaciones
    {
        public static List<Vector2D> Trasladar(List<Vector2D> vertices, double dx, double dy)
        {
            List<Vector2D> resultado = new List<Vector2D>();
            foreach (var v in vertices)
            {
                resultado.Add(new Vector2D(v.X + dx, v.Y + dy));
            }
            return resultado;
        }

        public static List<Vector2D> Rotar(List<Vector2D> vertices, double anguloGrados, Vector2D pivote)
        {
            double rad = anguloGrados * Math.PI / 180.0;
            double cos = Math.Cos(rad);
            double sin = Math.Sin(rad);

            List<Vector2D> resultado = new List<Vector2D>();
            foreach (var v in vertices)
            {
                double xTrans = v.X - pivote.X;
                double yTrans = v.Y - pivote.Y;

                double xRot = xTrans * cos - yTrans * sin;
                double yRot = xTrans * sin + yTrans * cos;

                resultado.Add(new Vector2D(xRot + pivote.X, yRot + pivote.Y));
            }
            return resultado;
        }

        public static List<Vector2D> Escalar(List<Vector2D> vertices, double factorX, double factorY, Vector2D pivote)
        {
            List<Vector2D> resultado = new List<Vector2D>();
            foreach (var v in vertices)
            {
                double xTrans = v.X - pivote.X;
                double yTrans = v.Y - pivote.Y;

                double xEsc = xTrans * factorX;
                double yEsc = yTrans * factorY;

                resultado.Add(new Vector2D(xEsc + pivote.X, yEsc + pivote.Y));
            }
            return resultado;
        }
    }
}