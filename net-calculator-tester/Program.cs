namespace net_calculator_tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcolatrice");

            Console.Write("Inserisci due numeri e dato delle funzioni ti faro una somma, una sottrazione, una moltiplicazione e una divisione: ");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            try
            {
                float sum = Calculator.Add((float)num1, (float)num2);
                float subtract = Calculator.Subtract((float)num1, (float)num2);
                float divide = Calculator.Divide((float)num1, (float)num2);
                float multiply = Calculator.Multiply((float)num1, (float)num2);

                Console.WriteLine($"Ecco il risultato della prima funzione{sum}");
                Console.WriteLine($"Ecco il risultato della seconda funzione{subtract}");
                Console.WriteLine($"Ecco il risultato della terza funzione{divide}");
                Console.WriteLine($"Ecco il risultato della quarta funzione{multiply}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}