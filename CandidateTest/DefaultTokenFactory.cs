namespace CandidateTest
{
    public class DefaultTokenFactory : ITokenFactory
    {
        public IToken CreateNumberToken(double value) => new NumberToken(value);
        public IToken CreateAdditionOperatorToken() => new AdditionOperatorToken();
    }
}
