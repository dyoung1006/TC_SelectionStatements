namespace SelectionStatements
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your favorite school subject ?");
            string favSubject = Console.ReadLine();


            switch (favSubject)
            {
                case "Math":
                    Console.WriteLine("how many bands we dropping in the strip club?");
                    break;
                case "Science":
                    Console.WriteLine("Breaking Bad?");
                    break;
                case "Gym":
                    Console.WriteLine("Jocks sucks!");
                    break;
                case "Music":
                    Console.WriteLine("Look, if you had one shot or one opportunity, to seize everything..name that song");
                    break;
                case "Home Economics":
                    Console.WriteLine("Cook on family!");
                    break;
                default:
                    Console.WriteLine(@"well... that's not on my list ¯\_(ツ)_/¯");
                    break;

            }

        }
    }
}