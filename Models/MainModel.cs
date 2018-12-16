using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Math;

namespace Lab5.Models
{
    class MainModel
    {
        public static Tuple<double, double, double> Func(int R, double alfa, double beta)
        {
            double x = R * Sin(alfa) * Cos(beta) * (1 + 0.5 * Abs(Sin(2 * beta)));
            double y = R * Sin(alfa) * Sin(beta) *(1 + 0.5 * Abs(Sin(2 * beta)));
            double z = R * Cos(alfa); //*Abs(Cos(beta + alfa))
            return Tuple.Create(x,y,z);
        }
        public static Tuple<double, double, double> Axonometry(Tuple<double, double, double> coords, double alfa, double beta)
        {
            double x = coords.Item1 * Cos(alfa) + coords.Item2 * Sin(alfa);
            double y = -coords.Item1 * Sin(alfa) * Cos(beta) + coords.Item2 * Cos(alfa) * Cos(beta) + coords.Item3 * Sin(beta);
            double z = coords.Item1 * Sin(alfa) * Sin(beta) - coords.Item2 * Cos(alfa) * Sin(beta) + coords.Item3 * Cos(beta);
            return Tuple.Create(x, y, z);
        }
        public static void Line(WriteableBitmap wb, int x1, int y1, int x2, int y2, Color color)
        {
            int lengthX = Math.Abs(x2 - x1);
            int lengthY = Math.Abs(y2 - y1);

            int dx = (x2 - x1 >= 0 ? 1 : -1);
            int dy = (y2 - y1 >= 0 ? 1 : -1);

            int length = Math.Max(lengthX, lengthY);

            if (length == 0)
            {
                if (x1 < wb.PixelWidth && y1 < wb.PixelHeight && x1 > 0 && y1 > 0)
                    wb.SetPixel(x1, y1, color);
            }
            if (lengthY <= lengthX)
            {
                int x = x1;
                int y = y1;
                int d = -lengthX;
                length++;
                while (length > 0)
                {
                    if (x < wb.PixelWidth && y < wb.PixelHeight && x > 0 && y > 0)
                    wb.SetPixel(x, y, color);
                    x += dx;
                    d += 2 * lengthY;
                    if (d > 0)
                    {
                        d -= 2 * lengthX;
                        y += dy;
                    }
                    length--;
                }
            }
            else
            {
                int x = x1;
                int y = y1;
                int d = -lengthY;

                length++;
                while (length > 0)
                {
                    if (x < wb.PixelWidth && y < wb.PixelHeight && x>0 && y>0)
                        wb.SetPixel(x, y, color);
                    y += dy;
                    d += 2 * lengthX;
                    if (d > 0)
                    {
                        d -= 2 * lengthY;
                        x += dx;
                    }
                    length--;
                }
            }
        }
        [Obsolete]
        public static void Line(WriteableBitmap wb, int x1, int y1, int x2, int y2, Color color, ref int[,] Z, int z_value)
        {
            int lengthX = Abs(x2 - x1);
            int lengthY = Abs(y2 - y1);

            int dx = (x2 - x1 >= 0 ? 1 : -1);
            int dy = (y2 - y1 >= 0 ? 1 : -1);

            int length = Max(lengthX, lengthY);

            if (length == 0)
            {
                if (x1 < wb.PixelWidth && y1 < wb.PixelHeight && x1 > 0 && y1 > 0)
                    wb.SetPixel(x1, y1, color);
            }
            if (lengthY <= lengthX)
            {
                int x = x1;
                int y = y1;
                int d = -lengthX;
                length++;
                if (Z[x, y] < z_value)
                {                    
                    //Z[x - 1, y - 1] = z_value;
                    //Z[x, y - 1] = z_value;
                    //Z[x + 1, y - 1] = z_value;

                    //Z[x-1, y] = z_value;
                    //Z[x, y] = z_value;
                    for(int i = 10; i >= 0; i--)
                    {
                        for (int j = 10; j >= 0; j--)
                        {
                            Z[x-j,y-i] = z_value;
                        }
                    }                   
                    //Z[x + 1, y] = z_value;

                    //Z[x-1, y+1] = z_value;
                    //Z[x, y+1] = z_value;
                    //Z[x+1, y+1] = z_value;

                    while (length > 0)
                    {
                    
                        if (x < wb.PixelWidth && y < wb.PixelHeight && x > 0 && y > 0)
                            wb.SetPixel(x, y, color);
                        x += dx;
                        d += 2 * lengthY;
                        if (d > 0)
                        {
                            d -= 2 * lengthX;
                            y += dy;
                        }
                        length--;
                    }
                    
                }
            }
            else
            {
                int x = x1;
                int y = y1;
                int d = -lengthY;

                length++;
                if (Z[x, y] < z_value)
                {
                    //Z[x - 1, y - 1] = z_value;
                    //Z[x, y - 1] = z_value;
                    //Z[x + 1, y - 1] = z_value;

                    //Z[x - 1, y] = z_value;
                    //Z[x, y] = z_value;
                    for (int i = 10; i >= 0; i--)
                    {
                        for (int j = 10; j >= 0; j--)
                        {
                            Z[x - j, y - i] = z_value;
                        }
                    }
                    //Z[x + 1, y] = z_value;

                    //Z[x - 1, y + 1] = z_value;
                    //Z[x, y + 1] = z_value;
                    //Z[x + 1, y + 1] = z_value;

                    while (length > 0)
                    {
                    
                        if (x < wb.PixelWidth && y < wb.PixelHeight && x > 0 && y > 0)
                            wb.SetPixel(x, y, color);
                        y += dy;
                        d += 2 * lengthX;
                        if (d > 0)
                        {
                            d -= 2 * lengthY;
                            x += dx;
                        }
                        length--;
                    }
                }
            }
        }
        public static void Polygon(WriteableBitmap wb, Point a, Point b,Point c,Point d, Color color)
        {
            wb.DrawPolyline(new int[] { (int)a.X, (int)a.Y, (int)b.X, (int)b.Y, (int)c.X, (int)c.Y
            , (int)d.X, (int)d.Y, (int)a.X, (int)a.Y}, color);
        }
        public static Tuple<double, double, double> Scaling(Tuple<double, double, double> coords, int k)
        {
            double x = coords.Item1 * k;
            double y = coords.Item2 * k;
            double z = coords.Item3 * k;
            return Tuple.Create(x, y, z);
        }
        public static Tuple<double, double, double> Moving(Tuple<double, double, double> coords, int dx, int dy,int dz)
        {
            double x = coords.Item1 + dx;
            double y = coords.Item2 + dy;
            double z = coords.Item3 + dz;
            return Tuple.Create(x, y, z);
        }
        public static Tuple<double, double, double> RotationX(Tuple<double, double, double> coords, int angle)
        {
            double x = coords.Item1;
            double y = coords.Item2 * Cos(angle) - coords.Item3 * Sin(angle);
            double z = coords.Item2 * Sin(angle) + coords.Item3 * Cos(angle);
            return Tuple.Create(x, y, z);
        }
        public static Tuple<double, double, double> RotationY(Tuple<double, double, double> coords, int angle)
        {
            double x = coords.Item1* Cos(angle) + coords.Item3 * Sin(angle);
            double y = coords.Item2;
            double z = -coords.Item1 * Sin(angle) + coords.Item3 * Cos(angle);
            return Tuple.Create(x, y, z);
        }
        public static Tuple<double, double, double> RotationZ(Tuple<double, double, double> coords, int angle)
        {
            double x = coords.Item1 * Cos(angle) - coords.Item2 * Sin(angle);
            double y = coords.Item1 * Sin(angle) + coords.Item2* Cos(angle);
            double z = coords.Item3;
            return Tuple.Create(x, y, z);
        }
    }
}
