using System;
using System.Globalization;

namespace ExercicioDolar {
    class Program {
        static void Main(string[] args) {
            ConversorDeMoedas cm = new ConversorDeMoedas();

            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qtdeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor pago em reais: " + cm.Conversao(cotacaoDolar, qtdeDolar).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
