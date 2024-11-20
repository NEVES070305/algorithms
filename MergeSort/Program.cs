namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 38, 27, 43, 3, 9, 82, 10 };

            Console.WriteLine("Array original:");
            Console.WriteLine(string.Join(", ", array));

            MergeSort.MergeSortFunction(array);

            Console.WriteLine("Array ordenado:");
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
