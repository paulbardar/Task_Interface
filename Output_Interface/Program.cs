namespace Output_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, New Array Interface!");

            int[] numbers = { 10, 25, 30, 45, 50 };

            Array myArray = new Array(numbers);

            Console.WriteLine("--- Method Show() ---");
            myArray.Show();

            Console.WriteLine();

            Console.WriteLine("--- Test Method Show(string info) ---");
            myArray.Show("This is Array of int numbers.");
        }
    }

    public class Array : IOutput
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
    }
}
