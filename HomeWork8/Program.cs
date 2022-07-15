namespace HomeWork8
{
    class Program
    {
        public static void Text(string text)
        {
            Console.WriteLine(text);
        }
        public static int ListTest(List<int> numbers)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] > 25 && numbers[i] < 50)
                {
                    counter++;
                }
            }
            return counter;
        }
        public static List<int> FillList(List<int> numbers)
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                numbers.Add(random.Next(101));
            }
            return numbers;
        }
        public static void PrintList(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        public static List<int> SortList(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] > 25 && numbers[i] < 50)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Text("First not sorted list");
            FillList(numbers);
            PrintList(numbers);
            Text("Number of numbers between 25 and 50 in this list: ");
            Text($"{ListTest(numbers)}");
            SortList(numbers);
            Text("Sorted list");
            PrintList(numbers);
            Text("Number of numbers between 25 and 50 in this list: ");
            Text($"{ListTest(numbers)}");

            Console.ReadKey();
        }
    }
}
