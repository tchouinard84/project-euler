namespace ProjectEuler
{
    public interface ISolveProblems
    {
        int Number { get; set; }
        string Title { get; set; }
        string Question { get; set; }
        string Note { get; set; }

        int Solve();
    }
}
