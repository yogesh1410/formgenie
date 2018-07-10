using System;
using formgenie.Engine.Entities;
using Xamarin.Forms;

namespace formgenie.Engine.Views.Components
{
    public class CameraView : ContentView
    {
        Button takePhotoButton;
        Image cameraImage;

        public CameraView(Component c, string formData)
        {
            takePhotoButton = new Button();
            takePhotoButton.Text = c.text;
            takePhotoButton.Clicked += takePhotoButton_Clicked;
            cameraImage = new Image();

            Content = new StackLayout
            {
                Children =
                {
                    takePhotoButton,
                    cameraImage
                }
            };
        }

        private async void takePhotoButton_Clicked(object sender, EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
                cameraImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
        }
    }
}

