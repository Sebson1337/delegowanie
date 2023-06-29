using System;

class Program
{
    static void Main(string[] args)
    {
       
        double x1 = 3.5;
        double y1 = 1.5;
        double x2 = 2.5;
        double y2 = 5.5;

        double dlugoscOdcinka = ObliczDlugoscOdcinka(x1, y1, x2, y2);
        Console.WriteLine($"dlugosc odcinka: {dlugoscOdcinka}");
    }

    static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;

        double dlugosc = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        return dlugosc;
    }
}