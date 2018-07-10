using System;
namespace formgenie.DependencyServices
{
    public interface ISaveAndLoad
    {
        void SaveText(string friendlyName, string text);
        string LoadText(string filename);
    }
}
