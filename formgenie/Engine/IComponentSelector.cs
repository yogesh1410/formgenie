using System;
using Xamarin.Forms;

namespace formgenie.Engine
{
    public interface IComponentSelector
    {
        Layout GenerateContent();
    }
}
