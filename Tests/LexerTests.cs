using CandidateTest;
using NUnit.Framework;

namespace Tests
{
    class LexerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldTokenizeSingleNumber()
        {
            var lexer = new Lexer(new DefaultTokenFactory());
            var tokens = lexer.Tokenize("123");

            Assert.AreEqual(((NumberToken)tokens[0]).Value, 123);
        }

        [Test]
        public void ShouldTokenizeMultipleNumbersSeparatedWithSpace()
        {
            var lexer = new Lexer(new DefaultTokenFactory());
            var tokens = lexer.Tokenize("1 2 3 4 55 66 77");

            Assert.AreEqual(((NumberToken)tokens[0]).Value, 1);
            Assert.AreEqual(((NumberToken)tokens[1]).Value, 2);
            Assert.AreEqual(((NumberToken)tokens[2]).Value, 3);
            Assert.AreEqual(((NumberToken)tokens[3]).Value, 4);
            Assert.AreEqual(((NumberToken)tokens[4]).Value, 55);
            Assert.AreEqual(((NumberToken)tokens[5]).Value, 66);
            Assert.AreEqual(((NumberToken)tokens[6]).Value, 77);
        }

        [Test]
        public void ShouldTokenizeAddExpression()
        {
            var lexer = new Lexer(new DefaultTokenFactory());
            var tokens = lexer.Tokenize(" 1     +     3       ");

            Assert.AreEqual(((NumberToken)tokens[0]).Value, 1);
            Assert.AreEqual(tokens[1].GetType(), typeof(AdditionOperatorToken));
            Assert.AreEqual(((NumberToken)tokens[2]).Value, 3);
        }
    }
}
