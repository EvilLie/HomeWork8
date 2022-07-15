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
        public static string PhoneNumber()
        {
            Text("Please enter phone number");
            string phoneNumber = Console.ReadLine();
            if (phoneNumber == null)
            {
                return null;
            }
            else
            {
                return phoneNumber;
            }
        }
        public static string FullName()
        {
            Text("Enter full name");
            int i = 0;
            string fullName = Console.ReadLine();
            while (i == 0)
            {
                if (String.IsNullOrEmpty(fullName))
                {
                    Text("Wrong format please try again");
                }
                else
                {
                    i++;
                }
            }
            return fullName;
        }
        public static Dictionary<string, string> AddPhoneBook(Dictionary<string, string> phoneBook, string phoneNumber, string fullName)
        {
            if (String.IsNullOrEmpty(phoneNumber))
            {
                return phoneBook;
            }
            else
            {
                phoneBook.Add(phoneNumber, fullName);
                return phoneBook;
            }
        }
        public static void FindUser(Dictionary<string, string> phoneBook)
        {
            if (phoneBook.TryGetValue(PhoneNumber(), out string fullName) == true)
            {
                Text($"Full name of this user is: {fullName}");
            }
            else
            {
                Text("There is no user with number like this");
                FindUser(phoneBook);
            }

        }

        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            int i = 0;            
            while (true)
            {
                Text("To add new phone number and user write ADD, to find user type FIND, to exit type EXIT");
                switch (UserChoice())
                {
                    case "ADD":
                        {
                            AddPhoneBook(phoneBook, PhoneNumber(), FullName());
                            continue;
                        }
                    case "FIND":
                        {
                            FindUser(phoneBook);
                            continue;
                        }
                    case "EXIT":
                        {
                            Text("Program executed by user");
                            i++;
                            break;
                        }
                }
                if (i != 0)
                {
                    break;
                }
            }
        }
    }
}

