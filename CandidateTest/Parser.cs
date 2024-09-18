namespace CandidateTest
{
    /// <summary>
    /// Parses a string with arithmetical expression and calculates value.
    /// </summary>
    public class Parser
    {
        private readonly Lexer lexer;

        public Parser(Lexer lexer)
        {
            this.lexer = lexer;
        }

        /// <summary>
        /// Takes a characters string and calculates arithemetical expression.
        /// </summary>
        /// <param name="stringExpression">Input characters string</param>
        /// <returns>calculated value</returns>
        public double Parse(string stringExpression)
        {
            double result = 0;
            string operation = string.Empty;

            var tokens = lexer.Tokenize(stringExpression);

            for (var i = 0; i < tokens.Count; i++)
            {
                if (tokens[i].GetType() == typeof(NumberToken))
                {
                    if (string.IsNullOrEmpty(operation))
                    {
                        result = ((NumberToken)tokens[i]).Value;
                    }
                    else
                    {
                        result += ((NumberToken)tokens[i]).Value;
                        operation = string.Empty;
                    }
                }

                if (tokens[i].GetType() == typeof(AdditionOperatorToken))
                {
                    operation = "+";
                }
            }

            return result;
        }
    }
}
