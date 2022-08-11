namespace Brian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("    /|")
            Console.WriteLine("   / |")
            Console.WriteLine("  /  |")
            Console.WriteLine(" /   |")
            Console.WriteLine("/____|")
            string characterName = "John";
            int characterAge = 35;
            
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was" + characterAge + "years old");
            Console.WriteLine("He really liked the name" + characterName);
            Console.WriteLine("But didn't like being" + characterAge);

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello" + name);

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);


            Console.ReadLine();
        }
    }
}