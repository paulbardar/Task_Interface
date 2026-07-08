namespace Output_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, New Array Interface!");

            int[] myNumbers = { 15, -5, 42, 0, 8, 23 };
            Array myArray = new Array(myNumbers);

            myArray.Show();
            Console.WriteLine("=== === === === === === ===");
            myArray.Show("Current Array:");
            Console.WriteLine();

   

            Console.WriteLine("--- Test Method Show(string info) ---");
            myArray.Show("This is Array of int numbers.");
            
            Console.WriteLine("--- Test IMath ---");
            Console.WriteLine($"Max item: {myArray.Max()}");
            Console.WriteLine($"Min Item:  {myArray.Min()}");
            Console.WriteLine($"Average Item:  {myArray.Avg():F2}");
            Console.WriteLine();

            Console.WriteLine("--- Test Search ---");
            int target1 = 42;
            int target2 = 99;


            Console.WriteLine($"Is there a number in the array? {target1}? Answer: {myArray.Search(target1)}");
            Console.WriteLine($"Is there a number in the array? {target2}? Answer: {myArray.Search(target2)}");
            Console.WriteLine();

            myArray.SortAsc();
            myArray.Show("Sorting in ascending order (SortAsc):");
            Console.WriteLine();

            myArray.SortDesc();
            myArray.Show("Sorting in Descending order (SortDesc):");
            Console.WriteLine();

            Console.WriteLine("Calling SortByParam(true):");
            myArray.SortByParam(true);
            myArray.Show("Result:");
            Console.WriteLine();

            Console.WriteLine("Calling SortByParam(false):");
            myArray.SortByParam(false);
            myArray.Show("Result:");
        }
    }

    public class Array : IOutput, IMath, ISort
    {
        private int[] _data;

        public Array(int[] data)
        {
            _data = data ?? new int[0];
        }

        public void Show()
        {
            Console.WriteLine("Array items:");
            Console.WriteLine(string.Join(", ", _data));
        }

        public void Show(string info)
        {
            Console.WriteLine($"Information: {info}");
            Show();
        }

        public int Max()
        {
            return _data.Max();
        }

        public int Min() { 
            return _data.Min();
        }

        public float Avg()
        {
            return (float)_data.Average();
        }

        public bool Search(int valueToSearch)
        {
            return _data.Contains(valueToSearch);
        }

        public void SortAsc()
        {
            System.Array.Sort(_data);
        }

        public void SortDesc()
        {
            System.Array.Sort(_data);
            System.Array.Reverse(_data);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }
}
