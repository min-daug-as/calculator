using System.Collections.Generic;
using System.Text;

namespace CandidateTest
{
    /// <summary>
    /// Lexer converts a sequence of characters into a sequence of tokens.
    /// Where token is either a number or arithmetical operator.
    /// </summary>
    public class Lexer
    {
        private readonly ITokenFactory _tokenFactory;

        public Lexer(ITokenFactory tokenFactory)
        {
            _tokenFactory = tokenFactory;
        }

        /// <summary>
        /// Converts a sequence of characters into a sequence of tokens.
        /// </summary>
        /// <param name="data">Input characters string</param>
        /// <returns>List of tokens</returns>
        public List<IToken> Tokenize(string data)
        {
            var res = new List<IToken>();
            var numberBuilder = new StringBuilder();

            foreach (var d in data)
            {
                if (char.IsDigit(d))
                {
                    numberBuilder.Append(d);
                    continue;
                }

                if (numberBuilder.Length > 0)
                {
                    res.Add(_tokenFactory.CreateNumberToken(double.Parse(numberBuilder.ToString())));
                    numberBuilder.Clear();
                }

                if (d == '+')
                {
                    res.Add(_tokenFactory.CreateAdditionOperatorToken());
                    continue;
                }
            }

            if (numberBuilder.Length > 0)
            {
                res.Add(_tokenFactory.CreateNumberToken(double.Parse(numberBuilder.ToString())));
            }

            return res;
        }
    }
}