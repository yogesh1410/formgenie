using formgenie.Engine.Repository.DataObjects;

namespace formgenie.Engine.Repository
{
    public interface IFormRepository
    {
        FormInstanceData GetFormInstance(string friendlyName);
    }

}