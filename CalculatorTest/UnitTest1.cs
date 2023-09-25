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
            float sum = calculator.Add(x, y);

            Assert.IsTrue(realOutput == sum , $"Il risultato corretto è {realOutput}, il tuo risulato è {sum}");
        }

        [Test]
        public void TestSubtractFloat() 
        {
            float x = 5.3f;
            float y = 2.3f;

            float realOutput = 3.0f;

            float subtract = calculator.Subtract(x, y);

            Assert.That(subtract, Is.EqualTo(realOutput));
        }
    }
}