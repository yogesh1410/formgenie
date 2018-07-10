using System;

using Xamarin.Forms;

namespace formgenie.Engine.Views.Components
{
    public class LabelView : ContentView
    {
        LabelViewModel lblViewModel;
        public Label lbl = new Label();

        public LabelView()
        {
            Content = lbl;
        }

        public LabelView(string labelText)
        {
            lblViewModel = new LabelViewModel(labelText);
            BindingContext = lblViewModel;

            //set labeltext
            lbl.SetBinding(Label.TextProperty, "LabelText");
            lbl.BindingContext = lblViewModel;


            Content = lbl;
        }
    }
}

