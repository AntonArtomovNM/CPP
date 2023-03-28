using CPP.Lab1;
using CPP.LabsTestPlans.Contracts;
using CPP.Utils;

namespace CPP.LabsTestPlans;

public class Lab1TestPlan
    : ILabTestPlan
{
    public string Name => "Lab 1: Робота з текстовою iнформацiєю у .NET";

    public string TaskDescription => "Variant 1:\nНехай надано рядок, що складається зi слiв, вiдокремлених одне вiд одного одним i бiльше пропусками. Видалити в ньому всi слова, що складаються з трьох i менше символiв.";

    public void RunDefaultCases()
    {
        Execute("This is an old message see the novel one");
        Console.WriteLine();
        Execute("Here   you  got     another   one");
    }

    public void RunUserInputCases()
    {
        var str = InputHelper.GetString();
        Execute(str);
    }

    private void Execute(string str)
    {
        Console.WriteLine($"Original string: {str}");

        var result = Lab1Execution.RemoveWordWithLengthOfThreeOrLess(str);

        Console.WriteLine($"New string: {result}");
    }
}
