﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double imc;
            //entrada de dados 
            Console.WriteLine("Insira o Seu Peso em KG: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a Sua Altura em Metros: ");
            double alt= double.Parse(Console.ReadLine());

            //processamento

            imc = peso/(alt*alt);

            //saida de dados

            Console.WriteLine("O seu imc está em: " + imc);
            //tabela de peso
            if (imc < 17)
            {
                Console.WriteLine("Muito Abaixo do Peso");
            }
            else if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do Peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso Normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Acima do Peso");
            }
            else if (imc < 35)
            {
                Console.WriteLine("Obesidade Grau 1");
            }
            else if (imc < 41) 
            { 
            Console.WriteLine("Obesidade Grau 2");
            }else if(imc > 40)
            {
                Console.WriteLine("Obesidade Grau 2");
            }
            else
            {
                Console.WriteLine("Informação inválida.");
            }



            Console.ReadKey();
        }
    }
}
