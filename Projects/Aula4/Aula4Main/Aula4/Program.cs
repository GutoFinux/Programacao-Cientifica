using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Gradient
{
    public double x = 2;
    public double x_1 = 2;
    public double x_2 = 2;
    public int y;
    public double min;
    public double tx = 0.1;
    public double func1;
    public double func2;


    public Gradient(double init)
    {
        tx = init;
        func1 = 2 * x_1; //Derivada de X²
        while ((func1 < -0.000001) || (func1 > 0.000001)) // enquanto a derivada não for tão próxima de zero quanto o desejado
        {
            x_1 = x_1 -tx*func1;
            func1 = 2 * x_1;  //Derivada de X²
        }
        func1 = x_1 * x_1;
        
        func2 = 3 * x_2 * x_2 - 4 * x_2; // Derivada x³ - 2x² + 2
        while ((func2 < -0.000001) || (func2 > 0.000001)) // enquanto a derivada não for tão próxima de zero quanto o desejado
        {
            x_2 = x_2 - tx * func2;
            func2 = 3 * x_2 * x_2 - 4 * x_2; // Derivada x³ - 2x² + 2
        }
        func2 = x_2 * x_2 * x_2 - 2 * x_2 * x_2 + 2;

        //Exibindo os mínimos calculados
        Console.WriteLine("X inicial: " + x);
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Função: f(x) = x²");
        Console.WriteLine("Derivada: f'(x) = 2x");
        Console.WriteLine("Mínimo: (" + Math.Round(x_1, 3) + " . " + Math.Round(func1, 3) + ")");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Função: f(x) = x³ - 2x² + 2");
        Console.WriteLine("Derivada: f'(x) = 3x² - 4x");
        Console.WriteLine("Mínimo: (" + Math.Round(x_2, 3) + " . " + Math.Round(func2, 3) + ")");
        Console.WriteLine("----------------------------------------------");
    }
}

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            Gradient teste = new Gradient(0.1); //chama a classe passando a taxa de aprendizado
            Console.ReadKey();
        }
    }
}
