using StackExchange.Redis;

while (true)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Welcome to Garnet Client!");
    Console.ResetColor();
    Console.WriteLine();

    // Configure connection
    var connString = "localhost:3278,password=012345";
    //var connString = "162.128.1.12:3278,password=012345";

    Console.WriteLine("Select an option");
    Console.WriteLine("1. Write a string to Garnet");
    Console.WriteLine("2. Search a string from Garnet");
    Console.WriteLine("q. Quit");

    // Create connection
    var connection = ConnectionMultiplexer.Connect(connString);
    var db = connection.GetDatabase();


    switch (Console.ReadLine())
    {
        case "1": //Write a string from Garnet
            Console.Clear();
            Console.WriteLine("Enter a string to write to Garnet");
            var input = Console.ReadLine();
            db.StringSet("StringKey", input);
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to continue...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            break;

        case "2": // Search a string from Garnet
            Console.Clear();
            Console.WriteLine("Getting a string from Garnet");
            var value = db.StringGet("StringKey");
            Console.WriteLine($"Response from Garnet: {value}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to continue...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            break;


        case "q":
            System.Environment.Exit(0);
            break;

        default:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("You have not selected a valid option - press any key to continue");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            break;
    }
}
