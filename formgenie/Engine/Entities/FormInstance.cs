using System;
using Xamarin.Forms;

namespace formgenie.Engine.Entities
{
    public class FormInstance
    {
        public FormModel FormModelView { get; set; }
        public string FormData { get; set; }
        //public Layout FormModelLayout { get; set; }
        public string ValidationSchema { get; set; }
    }
}
