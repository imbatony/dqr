namespace DataSential.Core.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Class)]
    public class DataQulityRuleAttribute : Attribute
    {
        private string Name;
        public double Version;

        public DataQulityRuleAttribute(string name)
        {
            Name = name;
            Version = 1.0;
        }
    }
}
