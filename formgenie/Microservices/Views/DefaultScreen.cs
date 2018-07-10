using System;
using Xamarin.Forms;

namespace formgenie.Microservices.Views
{
    public class DefaultScreen : ContentPage
    {
        public DefaultScreen()
        {
            //Page level padding
            this.Padding = new Thickness(5, 20, 5, 0);

            /*Definign ScrollView and StackLayout. Reverse engineer from here*/
            Content = new ScrollView
            {
                Content = new StackLayout
                {

                    Children = {
                        new Label { Text = "Default Screen Container for Microservice",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes = FontAttributes.Bold | FontAttributes.Italic
                        }
                    }
                }
            };
        }
    }
}
 