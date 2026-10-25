using System;

namespace GeoLab2D.Matematicas
{
    public class Vector2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Magnitud()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public double Direccion()
        {
            return Math.Atan2(Y, X) * (180 / Math.PI);

        }

        public static double ProductoPunto(Vector2D v1, Vector2D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        public static double Determinante(Vector2D v1, Vector2D v2)
        {
            return v1.X * v2.Y - v1.Y * v2.X;
        }

        public static Vector2D operator +(Vector2D a, Vector2D b) => new Vector2D(a.X + b.X, a.Y + b.Y);
        public static Vector2D operator -(Vector2D a, Vector2D b) => new Vector2D(a.X - b.X, a.Y - b.Y);
        public static Vector2D operator *(Vector2D a, double escalar) => new Vector2D(a.X * escalar, a.Y * escalar);
    }
}