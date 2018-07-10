using System;

using Xamarin.Forms;

namespace formgenie.Engine.Views.Components
{
    public class FormGroupBoxView : ContentView
    {
        BoxView box = new BoxView();
        public string text { get; set; }
        public FormGroupBoxView(string boxText)
        {
            LabelView boxLabel = new LabelView(boxText);
            Button btn = new Button();
            btn.WidthRequest = 50;
            btn.HeightRequest = 50;
            btn.BackgroundColor = Color.Aqua;
            btn.Text = boxText;

            Content = new ScrollView
            {
                FlowDirection = FlowDirection.LeftToRight,
                Content = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,

                    Children = { btn }
                }
            };
        }

    }
}

