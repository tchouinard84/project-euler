using System.Text;

namespace ProjectEuler
{
    public abstract class Problem : ISolveProblems
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public string Question { get; set; }
        public string Note { get; set; }

        public abstract int Solve();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Problem {Number}");
            sb.AppendLine(Title);
            sb.AppendLine();
            sb.AppendLine(Question);
            sb.AppendLine();
            sb.AppendLine($"Answer: {Solve()}");
            return sb.ToString();
        }
    }
}
