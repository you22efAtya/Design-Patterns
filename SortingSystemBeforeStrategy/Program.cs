namespace SortingSystemWithStrategyBefore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 56, 33, 88, 18 };
            Console.WriteLine("Original Array "+string.Join(" , ",array));

            Sorter sorter = new Sorter();
            sorter.Sort(array, "bubble");
            Console.WriteLine(" Array After Sort " + string.Join(" , ", array));

        }
    }
}
