using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinos_e_Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, bem-vindo ao Super Programa de Calculo 6000!\n");

            Console.WriteLine("Digite um número: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite um segundo número: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o que deseja calcular: ");
            Console.WriteLine("Operações Simples: ");
            Console.WriteLine("\ta - Adição");
            Console.WriteLine("\ts - Subtração");
            Console.WriteLine("\tm - Multiplicação");
            Console.WriteLine("\td - Divisão \n");
            Console.WriteLine("Operações Diferenciadas: ");
            Console.WriteLine("\tM - Média");
            Console.WriteLine("\tA - Área de um Retângulo com o Primeiro número como base");
            Console.WriteLine("\tA2 - Área de um Retângulo com o Segundo número como base");
            Console.WriteLine("\tAT - Área de um Triângulo com o Primeiro número como base");
            Console.WriteLine("\tAT2 - Área de um Triângulo com o Segundo número como base");
            Console.WriteLine("\tc - Conversão do primeiro número em C°(Celsius) para F°(Fahrenheit)");
            Console.WriteLine("\tc2 - Conversão do segundo número em C°(Celsius) para F°(Fahrenheit)");
            Console.WriteLine("\ti - IMC \n");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"O resultado da Soma é: {n1} + {n2} = {n1 + n2}");
                    break;
                case "s":
                    Console.WriteLine($"O Resultado da Subtração é: {n1} - {n2} = {n1 - n2}");
                    break;
                case "m":
                    Console.WriteLine($"O resultado da Multiplicação é: {n1} * {n2} = {n1 * n2}");
                    break;
                case "d":
                    Console.WriteLine($"O Resultado da Divisão é: {n1} / {n2} = {n1 / n2}");
                    break;
                case "M":
                    Console.WriteLine($"A Média desses números é: ({n1} + {n2}) / {2} = ({n1 + n2 / 2})");
                    break;
                case "A":
                    Console.WriteLine($"A Área desse Retângulo é: {n1} * {n2} = {n1 * n2}");
                    break;
                case "A2":
                    Console.WriteLine($"A Área desse Retângulo é: {n2} * {n1} = {n2 * n1}");
                    break;
                case "AT":
                    Console.WriteLine($"A Área desse Triângulo é: ({n1} * {n2}) / {2} = ({n1 * n2}) / {2}");
                    break;
                case "AT2":
                    Console.WriteLine($"A Área desse Triângulo é: {n2} * {n1} = {n2 * n1}");
                    break;
                case "c":
                    Console.WriteLine($"A Conversão do primeiro número para Fahrenheit é: {n1} * 1.8 + 32 = {n1 * 1.8 + 32}");
                    break;
                case "c2":
                    Console.WriteLine($"A Conversão do primeiro número para Fahrenheit é: {n2} * 1.8 + 32 = {n2 * 1.8 + 32}");
                    break;
                case "i":
                    Console.WriteLine($"O cálculo do IMC é: {n1} / ({n2} * {n2}) = {n1 / (n2 * n2)}");
                    break;
            }

            Console.WriteLine("Aperte Enter para sair.");
            Console.ReadLine();
        }
    }
}
