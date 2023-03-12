using CPP.Lab1;
using CPP.LabsTestPlans.Contracts;
using CPP.Utils;

namespace CPP.LabsTestPlans;

public class Lab1TestPlan
    : ILabTestPlan
{
    public string Name => "Lab 1: Робота з текстовою iнформацiєю у .NET";

    public string TaskDescription => "Variant 2:\nНехай надано рядок, що складається зiслiв, вiдокремлених одневiд одного одним i бiльше пропусками. Сформувати новий рядок, що складається зi слiв початкового рядка. У результуючийрядок не включати тi слова, в яких є символи, що повторюються.";

    public void RunDefaultCases()
    {
        Execute("This is former message see the new one.");
        Console.WriteLine();
        Execute("Here   you  have     another   one");
    }

    public void RunUserInputCases()
    {
        var str = InputHelper.GetString();
        Execute(str);
    }

    private void Execute(string str)
    {
        Console.WriteLine($"Original string: {str}");

        var result = str.RemoveWordsWithRepeatingCharacters();

        Console.WriteLine($"New string: {result}");
    }
}
