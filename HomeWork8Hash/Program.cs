namespace HomeWork8
{
    class Program
    {
        public static void Text(string text)
        {
            Console.WriteLine(text);
        }
        public static string UserChoice()
        {
            string userChoise = Console.ReadLine().Trim().ToUpper();
            return userChoise;
        }
        public static HashSet<int> AddNumber(HashSet<int> numbers)
        {
            Text("Enter amount of numbers you want to add");
            int amount = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<amount;i++)
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(userNumber))
                {
                    Text("This number already is in collection");
                }
                if(!numbers.Contains(userNumber))
                {
                    numbers.Add(userNumber);
                    Text("Number added succesfully");
                }
            }
            return numbers;
        }
        public static void Print(HashSet<int> numbers)
        {
            foreach(int number in numbers)
            {
                Text($"{number}");
            }
            
        }    
        static void Main(string[] args)
        {
            HashSet<int > numbers = new HashSet<int>();
            int i = 0;
            while (true)
            {
                Text("To add new phone number and user write ADD, to exit type EXIT, PRINT to show whole set");
                switch (UserChoice())
                {
                    case "ADD":
                        {
                            numbers = AddNumber(numbers);
                            continue;
                        }
                    case "PRINT":
                        {
                            Print(numbers);
                            continue;
                        }
                    case "EXIT":
                        {
                            Text("Program executed by user");
                            i++;
                            break;
                        }
                }
                if(i!=0)
                {
                    break;
                }
            }
        }
    }
}

