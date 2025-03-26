using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*06. Uma companhia de carros paga a seu vendedor um salário de R$ 2.000,00 por mês mais uma
comissão de R$ 500,00 para cada carro vendido e mais 5% do valor da venda. Todo mês a
companhia prepara os seguintes dados para um determinado vendedor: matrícula (somente
números), número de carros vendidos e o valor total das vendas. Elabore um algoritmo para calcular
e imprimir o salário do vendedor num dado mês.*/

namespace Ex_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matricula;
            double totalVendas, porcentagemVendas, quantidadeCarros, salarioFinal;
            const double salarioFixo = 2.000;
            double comissao = 500;

            Console.WriteLine("Informe a matrícula do vendedor: ");
            matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade de carros vendidos: ");
            quantidadeCarros = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor total das vendas: ");
            totalVendas = int.Parse(Console.ReadLine());

            porcentagemVendas = 0.05 * totalVendas;
            salarioFinal = salarioFixo + (comissao * quantidadeCarros) + porcentagemVendas;

            Console.WriteLine($"O salário final do funcionário referente a matrícula {matricula} é R${salarioFinal}.");

        }
    }
}
