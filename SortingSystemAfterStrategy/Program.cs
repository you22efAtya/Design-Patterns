namespace SortingSystemWithStrategyAfter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 56, 33, 88, 18 };
            Console.WriteLine("Original Array " + string.Join(" , ", array));

            BubbleSort bubbleSort = new BubbleSort();
            Sorter sorter = new Sorter(bubbleSort);
            sorter.Sort(array);
            Console.WriteLine(" Array After Sort " + string.Join(" , ", array));

        }
    }
}
