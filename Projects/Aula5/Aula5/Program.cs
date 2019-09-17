using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Medios
{
    public double f1;
    public double f2;
    public double f3;
    public double a1 = 0;
    public double a2 = 0;
    public double a3 = 0;
    public int x1 = 0; //x inicial
    public double x;
    public int x2 = 1; //x final
    public double p = 0.001; //precisão (largura do retângulo)

    public Medios()
    {
        x = p;
        while (x <= x2)
        {
            f1 = Math.Exp(x);
            f2 = Math.Sqrt(1 - Math.Pow(x, 2));
            f3 = Math.Exp(Math.Pow(-x, 2));

            a1 = a1 + 2 * p * Math.Sqrt(Math.Pow(f1,2));
            a2 = a2 + 2 * p * Math.Sqrt(Math.Pow(f2,2));
            a3 = a3 + 2 * p * Math.Sqrt(Math.Pow(f3,2));

            x = x + 2*p;
        }
        Console.WriteLine("Método dos Pontos Médios");
        Console.WriteLine("Área da função 1: " + a1);
        Console.WriteLine("Área da função 2: " + a2);
        Console.WriteLine("Área da função 3: " + a3);
        Console.WriteLine();
    }
}

public class Trapezios
{
    public double f1a;
    public double f1b;
    public double f2a;
    public double f2b;
    public double f3a;
    public double f3b;
    public double a1 = 0;
    public double a2 = 0;
    public double a3 = 0;
    public int x1 = 0; //x inicial
    public double x;
    public int x2 = 1; //x final
    public double p = 0.000001; //precisão (largura do retângulo)

    public Trapezios()
    {
        x = x1;
        while (x < x2)
        {
            f1a = Math.Exp(x);
            f1b = Math.Exp(x+p);
            f2a = Math.Sqrt(1 - Math.Pow(x, 2));
            f2b = Math.Sqrt(1 - Math.Pow(x+p, 2));
            f3a = Math.Exp(Math.Pow(-x, 2));
            f3b = Math.Exp(Math.Pow(-x+p, 2));

            a1 = a1 + p * ((Math.Sqrt(Math.Pow(f1a, 2)) * Math.Sqrt(Math.Pow(f1b, 2))) / 2);
            a2 = a2 + p * ((Math.Sqrt(Math.Pow(f2a, 2)) * Math.Sqrt(Math.Pow(f2b, 2))) / 2);
            a3 = a3 + p * ((Math.Sqrt(Math.Pow(f3a, 2)) * Math.Sqrt(Math.Pow(f3b, 2))) / 2);

            x = x + p;
        }
        Console.WriteLine("Método Trapezoidal");
        Console.WriteLine("Área da função 1: " + a1);
        Console.WriteLine("Área da função 2: " + a2);
        Console.WriteLine("Área da função 3: " + a3);
        Console.WriteLine();
    }
}

public class Simpson
{
    public double f1a;
    public double f1m;
    public double f1b;
    public double f2a;
    public double f2m;
    public double f2b;
    public double f3a;
    public double f3m;
    public double f3b;
    public double a1 = 0;
    public double a2 = 0;
    public double a3 = 0;
    public int x1 = 0; //x inicial
    public double x;
    public int x2 = 1; //x final
    public double p = 0.000001; //precisão (largura do trapézio)
    public double P; //polinômio a ser calculado

    public Simpson()
    {
        x = x1;
        while (x < x2)
        {
            f1a = Math.Exp(x);
            f1m = Math.Exp(x + p);
            f1b = Math.Exp(x + p + p);
            f2a = Math.Sqrt(1 - Math.Pow(x, 2));
            f2m = Math.Sqrt(1 - Math.Pow(x + p, 2));
            f2b = Math.Sqrt(1 - Math.Pow(x + p + p, 2));
            f3a = Math.Exp(Math.Pow(-x, 2));
            f3m = Math.Exp(Math.Pow(-x + p, 2));
            f3b = Math.Exp(Math.Pow(-x + p + p, 2));

            a1 = a1 + f1a*(1);
            a2 = a2 + 0;
            a3 = a3 + 0;

            x = x + 2 * p;
        }
        Console.WriteLine("Método Simson");
        Console.WriteLine("Área da função 1: " + a1);
        Console.WriteLine("Área da função 2: " + a2);
        Console.WriteLine("Área da função 3: " + a3);
        Console.WriteLine();
    }
}

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Medios A = new Medios();
            Trapezios B = new Trapezios();
            Simpson C = new Simpson();
            Console.ReadKey();
        }
    }
}
