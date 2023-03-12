namespace CPP.LabsTestPlans.Contracts;

public interface ILabTestPlan
{
    string Name { get; }

    string TaskDescription { get; }

    void RunDefaultCases();

    void RunUserInputCases();
}
