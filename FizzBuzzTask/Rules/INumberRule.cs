using System.Collections.ObjectModel;

namespace FizzBuzzTask.Rules
{
    public interface INumberRule
    {
        public string CheckNumberForRule(int number);
        public List<string> HandleMultipleRules(Collection<int> rules);
    }
}
