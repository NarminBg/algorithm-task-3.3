namespace algorithm_task_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            decimal k, tam;
            tam = (int)number;
            k = (number - tam) * 1000;

            tam /= 1000;

            k = k + tam;

            Console.WriteLine($"{k}");
        }
    }
}