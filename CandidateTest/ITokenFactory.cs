namespace CandidateTest
{
    public interface ITokenFactory
    {
        IToken CreateNumberToken(double value);
        IToken CreateAdditionOperatorToken();
    }
}
