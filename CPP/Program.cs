using CPP.Utils;

Console.WriteLine("Greetings!");

try
{
    var testPlan = InputHelper.GetTestPlan();

    Console.Clear();
    Console.WriteLine($"{testPlan.Name}\n\n{testPlan.TaskDescription}\n");

    testPlan.RunDefaultCases();

    Console.WriteLine("\nPress any key to continue");
    Console.ReadKey();

    Console.Clear();
    Console.WriteLine($"{testPlan.Name}\n\n{testPlan.TaskDescription}\n");

    bool shouldExit;
    do
    {
        testPlan.RunUserInputCases();

        Console.WriteLine("\nPress 0 to exit, press any other key to try again");
        var key = Console.ReadKey();
        shouldExit = key.KeyChar.Equals('0');

        Console.WriteLine();
        Console.WriteLine();
    } while (!shouldExit);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

