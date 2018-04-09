namespace HelpLibrary
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public sealed class ConditionAttribute : System.Attribute
    {
        public ConditionAttribute(string functionName, string conditionString)
        {
            this.FunctionName = functionName;
            this.ConditionString = conditionString;
        }

        public string FunctionName { get; set; }

        public string ConditionString { get; set; }
    }
}
