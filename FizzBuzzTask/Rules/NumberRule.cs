using System.Collections.ObjectModel;

namespace FizzBuzzTask.Rules
{
    public class NumberRule : INumberRule
    {
        private readonly Dictionary<int, string> _rulesDictionary;
        public NumberRule() {
            _rulesDictionary = RulesDictionary.AllNumberRules;
        }

        public string CheckNumberForRule(int number) {
            Collection<int> rulesToApply = new();
            foreach (var rule in _rulesDictionary) {
                if (number % rule.Key == 0) {
                    rulesToApply.Add(rule.Key);
                }
            }
            return rulesToApply.Count switch {
                0 => number.ToString(),
                1 => _rulesDictionary[rulesToApply[0]],
                _ => String.Join("-", HandleMultipleRules(rulesToApply)),
            };
        }

        public List<string> HandleMultipleRules(Collection<int> rules) {
            Collection<int> tempRules = rules;
            List<string> result = new();
            if (tempRules.Contains(15)) {
                tempRules.Remove(5);
                tempRules.Remove(3);
                tempRules.Remove(15);
                var specialString = _rulesDictionary.GetValueOrDefault(15);
                if (specialString != null) {
                    result.Add(specialString);
                }
                else {
                    throw new NullReferenceException();
                }
            }
            foreach (var rule in tempRules) {
                var ruleValue = _rulesDictionary.GetValueOrDefault(rule);
                if (ruleValue != null) {
                    result.Add(ruleValue);
                }
                else {
                    throw new NullReferenceException();
                }
            }
            return result;
        }
    }
}
