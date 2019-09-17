using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace aula6
{
    public class Carlo
    {
        public double f1;
        public double f2;
        public double x1 = 0;  //x inicial
        public double x2 = 1;  //x final
        public double x;
        public double aleatorio;
        public double alturas1 = 0;
        public double alturas2 = 0;
        public double alturamedia1 = 0;
        public double alturamedia2 = 0;
        public double area1 = 0;
        public double area2 = 0;

        public Carlo(int iteration) //construtor receve a quantidade de iterações
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Random rand = new Random();
            for (int i = 0; i < iteration; i++)
            {
                aleatorio = Convert.ToDouble(rand.Next(0,100))/100; //gera um aleatório entre 0 e 1
                f1 = 4 / (1 + Math.Pow(aleatorio, 2)); //primeira função
                alturas1 += f1; //vai somando as alturas encontradas com os Xs aleatórios na função 1
                f2 = Math.Sqrt(aleatorio + Math.Sqrt(aleatorio)); //segunda função
                alturas2 += f2; //vai somando as alturas encontradas com os Xs aleatórios na função 2
            }
            alturamedia1 = alturas1 / iteration; //pega as alturas média da função 1
            alturamedia2 = alturas2 / iteration; //pega as alturas média da função 2
            area1 = alturamedia1 / (x2 - x1); //pega a área da função 1
            area2 = alturamedia2 / (x2 - x1); //pega a área da função 2
            Console.WriteLine("Área da função 1: " + area1);
            Console.WriteLine("Área da função 2: " + area2);
            stopWatch.Stop();
            int time = stopWatch.Elapsed.Milliseconds + stopWatch.Elapsed.Milliseconds * 1000;
            Console.WriteLine("RunTime " + time + " Milliseconds");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Carlo teste = new Carlo(100000000);
        }
    }
}
