using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Valida
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int ano;

            do
            {

                Console.WriteLine("Digite um dia: ");
                dia = Convert.ToInt32(Console.ReadLine());
                if (dia >= 1 && dia <= 31)
                {
                    Console.WriteLine("Dia inserido correto!");
                }
                else
                {
                    Console.WriteLine("Dia inserido incorreto");
                }
            }
            while (dia < 1 || dia > 31);
            Console.Clear();


            do
            {
                Console.WriteLine("Digite um mês: ");
                mes = Convert.ToInt32(Console.ReadLine());
                if (mes >= 1 && mes <= 12)
                {
                    Console.WriteLine("Mês inserido correto!");
                }
                else
                {
                    Console.WriteLine("Mês inserido incorreto");
                }
            }
            while (mes < 1 || mes > 12);
            Console.Clear();

            do
            {
                Console.WriteLine("Digite um ano: ");
                ano = Convert.ToInt32(Console.ReadLine());
                if (ano >= 1 && ano <= 9999)
                {
                    Console.WriteLine("Ano inserido correto!");
                }
                else
                {
                    Console.WriteLine("Ano inserido incorreto");
                }
            }
            while (ano < 1 || ano > 9999);
            Console.Clear();

            DataValida(dia, mes, ano);
            Console.ReadLine();
        }

        public static void DataValida(int dia, int mes, int ano)
        {
            if ((dia == 30 && mes == 2) || (dia == 31 && mes == 2) || (dia == 31 && mes == 4) || (dia == 31 && mes == 6) || (dia == 31 && mes == 9) || (dia == 31 && mes == 11))
                Console.WriteLine("A data inserida está invalida!");
            else
                Console.WriteLine("A data inserida é: " + dia.ToString("00") + "/" + mes.ToString("00") + "/" + ano.ToString("0000"));
        }
    }
}
