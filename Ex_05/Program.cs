using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*05. Dadas as seguintes informações de um funcionário: matrícula (somente números), idade e o
seu salário bruto, considere:
• O salário bruto teve um reajuste de 38%.
• O funcionário receberá uma gratificação de 20% do salário bruto.
• O Salário total é descontado em 15%.
Faça um programa para:
1. Imprimir a matrícula;
2. Calcular e imprimir o salário bruto;
3. Calcular e imprimir o salário líquido*/

namespace Ex_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matricula, idade;
            double salarioBruto, salarioBrutoAjustado, gratificação, salarioLiquido;

            Console.WriteLine("Informe sua matricula: ");
            matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu salário bruto: ");
            salarioBruto = double.Parse(Console.ReadLine());

            salarioBrutoAjustado = 0.38 * salarioBruto;
            gratificação = 0.20 * salarioBrutoAjustado;
            salarioLiquido = gratificação - 0.15;

            Console.WriteLine("A matrícua=la é: " + matricula);
            Console.WriteLine("O salário bruto ajustado é: " + gratificação);
            Console.WriteLine("O salário líquido é: " + salarioLiquido);
        }
    }
}
