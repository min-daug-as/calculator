namespace CandidateTest
{
    public class NumberToken : IToken
    {
        public double Value { get; set; }

        public NumberToken(double value)
        {
            this.Value = value;
        }
    }
}
