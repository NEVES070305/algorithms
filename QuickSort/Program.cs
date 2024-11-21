namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escreva um número: ");
                List<int> list = new List<int>();
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    list.Add(number);
                    QuickSort.QuickSortFunction(list, 0,list.Count - 1);
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
}
