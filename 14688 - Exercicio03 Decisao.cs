using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03decisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a renda familiar: ");
            double renda = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor gasto com alimentaçao: ");
            renda -= double.Parse(Console.ReadLine());

            Console.Write("Informe o valor gasto com farmacia: ");
            renda -= double.Parse(Console.ReadLine());

            Console.Write("Informe o valor gasto com vestuario: ");
            renda -= double.Parse(Console.ReadLine());

            Console.Write("Informe o valor dos outros gastos: ");
            renda -= double.Parse(Console.ReadLine());            

            if (renda < 0)
            {
                Console.WriteLine("Infelizmente, a renda nao foi suficiente, faltaram " + renda.ToString("C"));
            }
            else
            {
                Console.WriteLine("Ufa, esse mês a renda foi suficiente, sobraram " + renda.ToString("C"));
            }

            Console.ReadKey();
        }
    }
}
