namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            while (true)
            {
                Console.WriteLine("Escreva um número: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    list.Add(number);
                    BubbleSort.BubbleSortFunction(list);
                    Console.WriteLine("Lista ordenada: " + string.Join(",", list));
                }
                else
                {
                    Console.WriteLine("Digite corretamente.");
                }
            }
        }
    }
}
