using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace formgenie.Engine.Utilities
{
    public class Utility
    {
        public Utility()
        {
        }

        public static object GetFormDataValue(string formData, string path)
        {
            string[] pathItems = path.Split(new char[] { '.' });

            JObject formDataJson = JObject.Parse(formData);
            var val = formDataJson[pathItems[0]][pathItems[1]][pathItems[2]];

            return val;
        }

        public static object SetFormDataValue(string formData, string path, object value)
        {
            string[] pathItems = path.Split(new char[] { '.' });

            JObject formDataJson = JObject.Parse(formData);
            formDataJson[pathItems[0]][pathItems[1]][pathItems[2]] = JToken.FromObject(value);

            return formDataJson.ToString();
        }
    }
}
