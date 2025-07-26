namespace Module_4_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Tom", 27);

            Console.WriteLine("My name is {0}, my age is {1}", name, age);

            Console.Write("Insert your name: ");
            name = Console.ReadLine();
            Console.Write("Insert your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Your name is {name}, your age is {age}");

            Console.ReadKey();
        }
    }
}