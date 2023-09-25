using net_calculator_tester;

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
    }
}