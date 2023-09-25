using net_calculator_tester;
using System.Security.Cryptography.X509Certificates;

namespace CalculatorTest
{
    public class Tests
    {
        Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void TestAddFloat()
        {
            float x = 3.6f;
            float y = 1.5f;

            float realOutput = 5.1f;
            float sum = Calculator.Add(x, y);

            Assert.IsTrue(realOutput == sum , $"Il risultato corretto è {realOutput}, il tuo risulato è {sum}");
        }

        [Test]
        public void TestSubtractFloat() 
        {
            float x = 5.3f;
            float y = 2.3f;

            float realOutput = 3.0f;
            float subtract = Calculator.Subtract(x, y);

            Assert.AreEqual(realOutput, subtract);
        }

        [Test]
        public void TestDividerFloat()
        {
            float x = 10.0f;
            float y = 2.0f;

            float realOutput = 5.0f;
            float divided = Calculator.Divide(x, y);

            Assert.AreEqual(realOutput, divided);
        }

        [Test]
        public void TestMultiplyFloat()
        {
            float x = 12.0f;
            float y = 3.6f;

            float realOutput = 43.2f;
            float multiplied = Calculator.Multiply(x, y);

            Assert.AreEqual(realOutput, multiplied);
        }
    }
}