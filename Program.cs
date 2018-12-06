using System;
using System.Globalization;

namespace Teste2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x = new Funcionario();
            double porcent;

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            x.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Desconto: ");
            x.Desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Dados do funcionário: ");
            Console.WriteLine(x.Nome);
            Console.WriteLine(x.salarioBruto);
            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.AumentarSalario(porcent);
            Console.WriteLine();
            Console.WriteLine("Dados do funcionário: " + x);
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
       
    

