using System;
using System.Collections.Generic;

namespace formgenie.Engine.Entities
{
    public class Component
    {
        public string id { get; set; }
        public string path { get; set; }
        public string type { get; set; }
        public string text { get; set; }
    }

    public class FormGroup
    {
        public string text { get; set; }
        public string displayorder { get; set; }
        public List<Component> components { get; set; }
    }

    public class FormModel
    {
        public string title { get; set; }
        public List<FormGroup> formgroups { get; set; }
    }
}
