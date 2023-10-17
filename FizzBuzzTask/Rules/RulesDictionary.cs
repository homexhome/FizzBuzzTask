namespace FizzBuzzTask.Rules
{
    public static class RulesDictionary
    {
        public static Dictionary<int, string> AllNumberRules { get; private set; }

        static RulesDictionary() {
            AllNumberRules = new Dictionary<int, string>() {
                { 3, "dog" },
                { 5, "cat" },
                { 4, "muzz" },
                { 7, "guzz" },
                { 15, "good-boy" }
            };
        }
    }
}
