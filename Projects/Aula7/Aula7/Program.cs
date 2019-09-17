using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace aula7
{
    public class MPI
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
        static List<double> juntaAlturas1 = new List<double>();
        static List<double> juntaAlturas2 = new List<double>();
        static Random rand = new Random();
        static int parIteration;

        public MPI(int iteration) //construtor recebe a quantidade de iterações
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            parIteration = iteration / 5;
            Parallel.Invoke(
                new Action(somaAlturas),
                new Action(somaAlturas),
                new Action(somaAlturas),
                new Action(somaAlturas),
                new Action(somaAlturas)
            );
            foreach (double number in juntaAlturas1)
            {
                alturas1 += number;
            }
            foreach (double number in juntaAlturas2)
            {
                alturas2 += number;
            }
            alturamedia1 = alturas1 / iteration; //pega as alturas média da função 1
            alturamedia2 = alturas2 / iteration; //pega as alturas média da função 2
            area1 = alturamedia1 / (x2 - x1); //pega a área da função 1
            area2 = alturamedia2 / (x2 - x1); //pega a área da função 2
            Console.WriteLine("Function 1 area: " + area1);
            Console.WriteLine("Function 2 area: " + area2);
            stopWatch.Stop();
            int time = stopWatch.Elapsed.Milliseconds + stopWatch.Elapsed.Milliseconds*1000;
            Console.WriteLine("RunTime " + time + " Milliseconds");
        }

        static void somaAlturas()
        {
            double funcao1;
            double funcao2;
            double alt1 = 0;
            double alt2 = 0;
            double alea;
            for (int i = 0; i < parIteration; i++)
            {
                alea = Convert.ToDouble(rand.Next(0, 100)) / 100; //gera um aleatório entre 0 e 1
                funcao1 = 4 / (1 + Math.Pow(alea, 2)); //primeira função
                funcao2 = Math.Sqrt(alea + Math.Sqrt(alea)); //segunda função
                alt1 += funcao1;
                alt2 += funcao2;
            }
            juntaAlturas1.Add(alt1);
            juntaAlturas2.Add(alt2);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MPI teste = new MPI(100000000);
        }
    }
}
