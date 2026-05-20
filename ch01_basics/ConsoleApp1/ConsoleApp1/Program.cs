namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Congratulations!");
            Console.WriteLine("You worte your first lines of code.");

            Console.WriteLine("This is the first line.");
            Console.Write("This is the second line.");

            Console.WriteLine('b');
            Console.WriteLine(123);
            //Console.WriteLine('Hello World!');
            //CS1012: Too many characters in character literal
            Console.WriteLine("Hello World!");
            Console.WriteLine(123);
            Console.WriteLine(0.25F); //리터럴 접미사 float
            Console.WriteLine(2.625); //double 
            Console.WriteLine(12.39816m); //리터럴 접미사 decimal
            Console.WriteLine(true);
            Console.WriteLine(false);

            // Output: 123
            Console.WriteLine("123");
            // Output: 123
            Console.WriteLine(123);

            // Output: true
            Console.WriteLine("true");
            // Output: True
            Console.WriteLine(true);
        }
    }
}
