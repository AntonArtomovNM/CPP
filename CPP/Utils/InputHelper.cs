using CPP.LabsTestPlans.Contracts;
using CPP.LabsTestPlans;

namespace CPP.Utils;

public static class InputHelper
{
    private static readonly List<ILabTestPlan> _testPlans = new()
    {
        new Lab1TestPlan(),
    };

    public static ILabTestPlan GetTestPlan()
    {
        bool incorrectInput;
        ILabTestPlan? testPlan = null;

        do
        {
            Console.WriteLine("\nSelect lab to test:\n");

            for (var i = 0; i < _testPlans.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_testPlans[i].Name}");
            }

            var input = Console.ReadLine();

            incorrectInput = !int.TryParse(input, out int option);
            var testPlanIndex = option - 1;

            if (incorrectInput || _testPlans.ElementAtOrDefault(testPlanIndex) is null)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid option number");
            }
            else
            {
                testPlan = _testPlans[testPlanIndex];
            }
        } while (testPlan is null);

        return testPlan;
    }

    public static string GetString()
    {
        string? result;

        do
        {
            Console.WriteLine("Enter any text: ");

            result = Console.ReadLine();
            
            Console.WriteLine();
        } while (string.IsNullOrWhiteSpace(result));

        return result;
    }
}
