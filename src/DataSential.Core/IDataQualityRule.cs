namespace DataSential.Core
{
    public interface IDataQualityRule
    {
        public IEnumerable<IWorkflowConfig> GetWorkflowConfigs();
    }
}
