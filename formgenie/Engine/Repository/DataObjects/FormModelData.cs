using System;
using System.Collections.Generic;

namespace formgenie.Engine.Repository.DataObjects
{
    public class ComponentData
    {
        public string id { get; set; }
        public string path { get; set; }
        public string type { get; set; }
        public string text { get; set; }
    }

    public class FormGroupData
    {
        public string text { get; set; }
        public string displayorder { get; set; }
        public List<ComponentData> components { get; set; }
    }

    public class FormModelData
    {
        public string title { get; set; }
        public List<FormGroupData> formgroups { get; set; }
    }
}
