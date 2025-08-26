using System;
using System.Globalization;

namespace INSS
{
    public class Program
    {
        static void Main(string[] args)
        {
            DetalharData();
            CalcularDescontoINSS();
        }

        public static void DetalharData()
        {
            System.Console.WriteLine("Digite uma data: ");
            DateTime Dia = DateTime.Parse(System.Console.ReadLine());
            string diaSemana = Dia.ToString("dddd", new CultureInfo("pt-BR"));
            string Mes = Dia.ToString("MMMM", new CultureInfo("pt-BR"));
            if (Dia.DayOfWeek == DayOfWeek.Sunday)
            {
                string Hora = DateTime.Now.ToString("hh:mm:ss");
                System.Console.WriteLine($"{Hora}");
            }

            System.Console.WriteLine($"{diaSemana}");
            System.Console.WriteLine($"{Mes}");
        }

        public static void CalcularDescontoINSS()
        {
            System.Console.WriteLine("Digite seu salário: ");
            double Salario = Double.Parse(System.Console.ReadLine());
            Double Desconto = 0;
            Double DescontoExibido = 0;

            if (Salario <= 1212.00)
            {
                DescontoExibido = 7.5;
                Desconto = Salario * 0.075;
            }
            else if (Salario <= 2427.35)
            {
                DescontoExibido = 9;
                Desconto = Salario * 0.09;
            }
            else if (Salario <= 3641.03)
            {
                DescontoExibido = 12;
                Desconto = Salario * 0.12;
            }
            else if (Salario <= 7087.22)
            {
                DescontoExibido = 14;
                Desconto = Salario * 0.14;
            }

            double SalarioLiquido = Salario - Desconto;
            System.Console.WriteLine($"Desconto aplicado: {DescontoExibido}%");
            System.Console.WriteLine($"Desconto do INSS: R${Desconto.ToString("F2")}");
            Console.WriteLine("Salário líquido: R$ " + SalarioLiquido.ToString("F2"));
        }

    }

}