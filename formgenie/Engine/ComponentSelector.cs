using System;
using Xamarin.Forms;
using formgenie.Engine.Views.Components;

namespace formgenie.Engine
{
    public class ComponentSelector : IComponentSelector
    {
        public ComponentSelector()
        {
        }

        Layout IComponentSelector.GenerateContent()
        {
            throw new NotImplementedException();
        }
    }
}
