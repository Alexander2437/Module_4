namespace Module_4_App
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.Write("Pet's name: ");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;

            Console.Write("Pet's type: ");
            Pet.Type = Console.ReadLine();

            Console.Write("Pet's age: ");
            Pet.Age = double.Parse(Console.ReadLine());

            Console.Write($"\nPet's name is {Pet.Name}.\nPet's type is {Pet.Type}.\nPet's age is {Pet.Age}.\nPet's name length is {Pet.NameCount}");

            Console.ReadKey();
        }
    }
}