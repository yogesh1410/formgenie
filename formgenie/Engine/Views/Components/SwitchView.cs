using System;
using formgenie.Engine.Entities;
using formgenie.Engine.Services;
using Xamarin.Forms;

namespace formgenie.Engine.Views.Components
{
    public class SwitchView : ContentView
    {
        Switch sw;
        public string SelectedAnswerValue { get; set; }
        LabelView lblAnswer;
        SwitchViewModel switchViewModel;

        string path;

        public SwitchView(Component c, string formData)
        {
            path = c.path;
            bool switchValue = false;
            //read formData based on the c.path
            var switchValueFormData = Utilities.Utility.GetFormDataValue(formData, path);
            if (switchValueFormData.ToString().ToUpper().Equals("FALSE"))
                switchValue = false;
            else
                switchValue = true;
            
            sw = new Switch();
            lblAnswer= new LabelView();
            switchViewModel = new SwitchViewModel(switchValue);
            BindingContext = switchViewModel;

            sw.SetBinding(Switch.IsToggledProperty, "SwitchValue");
            sw.BindingContext = switchViewModel;

            //Switch command
            sw.Toggled += sw_Toggled;

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Children = {                      
                        sw,lblAnswer

                }
                }
            };
        }
        private void sw_Toggled(object sender, ToggledEventArgs e)
        {
            //lblAnswer.lbl.Text = e.Value.ToString();
            FormDataService.UpdateFormDataValue(path, Convert.ToBoolean(e.Value));
        }
    }
}

