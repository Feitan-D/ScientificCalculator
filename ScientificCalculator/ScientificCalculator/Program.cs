using System;

namespace CalculadoraCientifica
{
    class ScientificCalculator
    {
        // Método para adição
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Método para subtração
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Método para multiplicação
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Método para divisão
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Divisão por zero não permitida.");
            }
            return a / b;
        }

        // Método para elevar um número a uma potência
        public double Power(double a, double exponent)
        {
            return Math.Pow(a, exponent);
        }

        // Método para calcular a raiz quadrada
        public double SquareRoot(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Raiz quadrada de número negativo não permitida.");
            }
            return Math.Sqrt(a);
        }

        // Método para calcular o logaritmo natural
        public double Log(double a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Logaritmo de número menor ou igual a zero não permitido.");
            }
            return Math.Log(a);
        }

        // Método para calcular o logaritmo na base 10
        public double Log10(double a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Logaritmo de número menor ou igual a zero não permitido.");
            }
            return Math.Log10(a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ScientificCalculator calculator = new ScientificCalculator();

            // Exemplos de uso
            Console.WriteLine($"Adição: 5 + 3 = {calculator.Add(5, 3)}");
            Console.WriteLine($"Subtração: 5 - 3 = {calculator.Subtract(5, 3)}");
            Console.WriteLine($"Multiplicação: 5 * 3 = {calculator.Multiply(5, 3)}");
            Console.WriteLine($"Divisão: 10 / 2 = {calculator.Divide(10, 2)}");
            Console.WriteLine($"Potência: 2^3 = {calculator.Power(2, 3)}");
            Console.WriteLine($"Raiz quadrada: sqrt(16) = {calculator.SquareRoot(16)}");
            Console.WriteLine($"Logaritmo natural: ln(10) = {calculator.Log(10)}");
            Console.WriteLine($"Logaritmo base 10: log10(100) = {calculator.Log10(100)}");
        }
    }
}
