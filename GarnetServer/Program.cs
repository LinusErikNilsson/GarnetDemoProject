using Garnet;

try
{
    using var server = new GarnetServer(args);
    server.Start();

    Thread.Sleep(Timeout.Infinite);
}
catch (Exception ex)
{
    Console.WriteLine($"Could not start server due to an exception: {ex.Message}");
}