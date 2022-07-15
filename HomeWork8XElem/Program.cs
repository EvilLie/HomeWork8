using System.Xml.Linq;
namespace HomeWork8XElem
{
    class Program
    {
        public static void Text(string text)
        {
            Console.WriteLine(text);
        }
        public static Person CreatePerson()
        {
            Person person = new Person();
            Text("Please enter full name: ");
            person.FullName = Console.ReadLine();
            Text("Please enter street where person live: ");
            person.Adress = Console.ReadLine();
            Text("Enter number of person house ");
            int i = 0;
            while (i == 0)
            {
                if (int.TryParse(Console.ReadLine(), out int houseNumber))
                {
                    person.HouseNumber = houseNumber;
                    i++;
                }
                else
                {
                    Text("Wrong format");
                }
            }
            Text("Enter number of person flat ");
            int h = 0;
            while (h == 0)
            {
                if (int.TryParse(Console.ReadLine(), out int flatNumber))
                {
                    person.FlatNumber = flatNumber;
                    h++;
                }
                else
                {
                    Text("Wrong format");
                }
            }
            Text("Enter mobile phone number");
            person.MobileNumber = Console.ReadLine();
            Text("Enter home phone number");
            person.HomePhoneNum = Console.ReadLine();
            return person;
        }
        public static void Xml(Person person)
        {
            XElement MyPerson = new XElement("Person");
            XElement MyAdress = new XElement("Adress");
            XElement MyPhones = new XElement("Phones");
            XAttribute PersonName = new XAttribute("name", person.FullName);
            MyPerson.Add(PersonName);
            XAttribute Street = new XAttribute("street",person.Adress);
            XAttribute HouseNumber = new XAttribute("housenumber", person.HouseNumber);
            XAttribute FlatNumber = new XAttribute("flatnumber", person.FlatNumber);
            MyAdress.Add(Street, HouseNumber, FlatNumber);
            XAttribute MobilePhone = new XAttribute("mobilephone", person.MobileNumber);
            XAttribute FlatPhone = new XAttribute("homephone", person.HomePhoneNum);
            MyPhones.Add(MobilePhone, FlatPhone);
            MyPerson.Add(MyAdress, MyPhones);
            MyPerson.Save("Person.xml");
        }
        static void Main(string[] args)
        {
            Xml(CreatePerson());
            Console.ReadKey();
        }
    }
}

