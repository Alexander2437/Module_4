namespace Module_4_App
{
    class Program
    {
        static void Main(string[] args)
        {
            (string firstName, string lastName, int age, string login, int loginLength, bool hasPet, string[] favColors) User;

            for (int j = 0; j < 3; j++)
            {
                Console.Write("Insert user name: ");
                User.firstName = Console.ReadLine();

                Console.Write("Insert user surname:");
                User.lastName = Console.ReadLine();

                Console.Write("Insert password: ");
                User.login = Console.ReadLine();
                User.loginLength = User.login.Length;

                Console.Write("Do you have a pet? (Answer \"Yes\"\"No\".) ");
                var result = Console.ReadLine();

                if (result == "Yes")
                {
                    User.hasPet = true;
                }
                else
                {
                    User.hasPet = false;
                }

                Console.Write("Insert user age: ");
                User.age = int.Parse(Console.ReadLine());

                User.favColors = new string[3];
                Console.WriteLine("Insert three favourite colours:");

                for (int i = 0; i < User.favColors.Length; i++)
                {
                    User.favColors[i] = Console.ReadLine();
                }
            }

            Console.ReadKey();
        }
    }
}