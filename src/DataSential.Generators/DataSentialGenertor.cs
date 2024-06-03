namespace DataSential.Generators
{
    using System.Linq;
    using Microsoft.CodeAnalysis;

    [Generator]
    public class DataSentialGenertor : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            // Code generation goes here
            var types = context.Compilation.GetTypesByMetadataName("DataSential.Core.Attributes.DataQulityRuleAttribute");
            foreach (var type in types)
            {
                var attribute = type.GetAttributes().First();
                var name = attribute.ConstructorArguments[0].Value;
                var version = attribute.NamedArguments.First(x => x.Key == "Version").Value.Value;

                var source = $@"";
            }
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // No initialization required for this one
        }
    }
}
