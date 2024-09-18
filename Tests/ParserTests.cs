using CandidateTest;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldParseDigit()
        {
            var calculatorParser = new Parser(new Lexer(new DefaultTokenFactory()));
            var expression = calculatorParser.Parse("99");

            Assert.AreEqual(99, expression);
        }

        [Test]
        public void ShouldParseAdditionExpression()
        {
            var calculatorParser = new Parser(new Lexer(new DefaultTokenFactory()));
            var expression = calculatorParser.Parse("99 + 1");

            Assert.AreEqual(100, expression);
        }

        [Test]
        public void ShouldParseMultipleAdditionExpression()
        {
            var calculatorParser = new Parser(new Lexer(new DefaultTokenFactory()));
            var expression = calculatorParser.Parse("99 + 1 + 10");

            Assert.AreEqual(110, expression);
        }
    }
}