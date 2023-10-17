using FizzBuzzTask.Rules;

namespace FizzBuzzTask
{
    public class NumbersProcessor
    {
        private readonly INumberRule _numberRule;
        public NumbersProcessor(INumberRule numberRule) {
            _numberRule = numberRule;
        }

        public List<string> ProcessNumbers(List<int> numbers) {
            return numbers.Select(number => {
                var replacement = _numberRule.CheckNumberForRule(number);
                return replacement;
            }).ToList();
        }
    }
}
