using FizzBuzzTask.Rules;
using NUnit.Framework.Internal;

namespace FizzBuzzTask.Tests
{
    [TestFixture]
    public class NumbersProcessorTests
    {
        [Test]
        public void ProcessNumbers_ShouldReturnCorrectResult() {
            List<int> testList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            INumberRule numberRule = new NumberRule();
            NumbersProcessor numbersProcessor = new NumbersProcessor(numberRule);

            var result = numbersProcessor.ProcessNumbers(testList);

            Assert.That(result, Is.EqualTo(new List<string>
            {
                "1", "2", "dog", "muzz", "cat", "dog",
                "guzz", "muzz", "dog", "cat", "11", "dog-muzz", "13",
                "guzz", "good-boy", "good-boy-muzz", "good-boy-guzz", "good-boy-muzz-guzz"
            }));
        }
    }
}



