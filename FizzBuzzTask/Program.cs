using FizzBuzzTask.Rules;

namespace FizzBuzzTask
{
    internal class Program
    {
        static void Main(string[] args) {
            List<int> testList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };

            NumberRule ourRules = new();
            NumbersProcessor numbersProcessor = new(ourRules);
            var result = numbersProcessor.ProcessNumbers(testList);

            foreach (var number in result) {
                Console.WriteLine(number.ToString());
            }
        }
    }
}