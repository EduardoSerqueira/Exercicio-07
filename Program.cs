using System;
using System.Globalization;

namespace Exercicio_sete
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFunc;
            float horasTrab, salario, salPorHora;

            Console.WriteLine("Informe o número do funcionário: ");
            numFunc = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe as horas trabalhadas do funcionário: ");
            horasTrab = float.Parse(Console.ReadLine());

            Console.WriteLine("Valor que recebe por horas trabalhadas: ");
            salPorHora = float.Parse(Console.ReadLine());

            salario = salPorHora * horasTrab;

            Console.WriteLine("Número do funcionário: " + numFunc);
            Console.WriteLine("Salário: U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
