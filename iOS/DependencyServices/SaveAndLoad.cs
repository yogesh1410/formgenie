using System;
using System.IO;
using System.Reflection;
using formgenie.Data;
using formgenie.DependencyServices;
using formgenie.Engine.Repository.DataObjects;
using formgenie.iOS.DependencyServices;
using Xamarin.Forms;
using System.IO;

[assembly: Dependency(typeof(SaveAndLoad))]
namespace formgenie.iOS.DependencyServices
{
    public class SaveAndLoad: ISaveAndLoad
    {
        public SaveAndLoad()
        {
        }

        public string LoadText(string friendlyName)
        {
            string fileName = friendlyName + ".json";
            string fileText = string.Empty;

            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, fileName);
            if (File.Exists(filePath))
            {
                fileText = System.IO.File.ReadAllText(filePath);
            }
            return fileText;
        }

        public void SaveText(string friendlyName, string text)
        {
            string fileName = friendlyName + ".json";

            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, fileName);

            //if (File.Exists(filePath))
            //    File.Delete(filePath);
             

            File.WriteAllText(filePath, text);
        }
    }
}
