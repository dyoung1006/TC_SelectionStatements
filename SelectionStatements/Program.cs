namespace SelectionStatements
{
    class Program
    {
        static void Main()
        {
            var r = new Random();
            int favNumber = r.Next(1, 9);
            Console.WriteLine("Guess the favorite number. Hint: Below 10");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high");
            }
            else if (userInput == favNumber)
            {
                Console.WriteLine("Winner Winner Chicken Dinner");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }
        }
    }
}
    