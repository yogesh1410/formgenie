using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace formgenie
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
            CameraButton.Clicked += CameraButton_Clicked;
        }

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
                PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
        }
    }
}
