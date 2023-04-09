namespace ContactListApp
{
    class Program
    {
        static ContactList _contactList = new ContactList();

        static void Main(string[] args)
        {

            Console.WriteLine("1. Get Number\n 2.Add Number\n 3.Remove Number");

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    GetNumber();
                    break;
                case "2":
                    AddNumber();
                    break;

            }

        }

        private static void AddNumber()
        {
            Console.WriteLine("Nomreni daxil edin: ");
            string number = Console.ReadLine();
            Console.WriteLine("Adi daxil edin: ");
            string name = Console.ReadLine();

            _contactList.AddNumber(name, number);
        }

        private static void GetNumber()
        {
            Console.WriteLine("Adi daxil edin: ");
            string name = Console.ReadLine();

            string number = _contactList.GetNumber(name);

            Console.WriteLine($"Number of {name} is {number}");
        }
    }
}