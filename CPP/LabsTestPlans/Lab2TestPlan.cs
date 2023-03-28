using CPP.Lab2;
using CPP.LabsTestPlans.Contracts;
using CPP.Utils;

namespace CPP.LabsTestPlans;

public class Lab2TestPlan
    : ILabTestPlan
{
    public string Name => "Lab 2: Jagged Arrays";

    public string TaskDescription => "Variant 1:\nВвести цiлий двовимiрний рваний масив (jagged array), що складається з рядкiв довiльної довжини. Видалити з нього рядки, що складаються лише з парних елементiв. Для перевiрки рядка на парнiсть необхiдно реалiзувати окрему функцiю.";

    public void RunDefaultCases()
    {
        var jaggedArr1 = new int[][]
        {
            new int[] { 1, 2, 3, 4, 5, 6 },
            new int[] { 2, 4, 6, 8 },
            new int[] { 1, 3, 5},
            new int[] { 10, 12 }
        };

        Execute(jaggedArr1);

        var jaggedArr2 = new int[][]
        {
            new int[] { 2, 4, 6 },
            new int[] { 8, 10, 12},
            new int[] { 14, 16, 18, 20 },
            new int[] { 22, 24 }
        };

        Execute(jaggedArr2);
    }

    public void RunUserInputCases()
    {
        var jaggedArr = InputHelper.GetJaggedArray();
        Execute(jaggedArr);
    }

    private void Execute(int[][] jaggedArr)
    {
        Console.WriteLine($"Original jagged array:");
        ShowJaggedArray(jaggedArr);

        var result = Lab2Execution.RemoveArraysOfEvens(jaggedArr);

        Console.WriteLine($"New jagged array:");
        ShowJaggedArray(result);
    }

    private void ShowJaggedArray(int[][] jaggedArray )
    {
        foreach (var arr in jaggedArray)
        {
            foreach (var value in arr)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}
