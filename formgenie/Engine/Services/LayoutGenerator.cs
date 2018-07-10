using System;
using formgenie.Engine.Entities;
using formgenie.Engine.Views.Components;
using Xamarin.Forms;

namespace formgenie.Engine.Services
{
    public class LayoutGenerator
    {
        public LayoutGenerator()
        {
        }

        public Layout GenerateLayout(FormModel formModel, string formData)
        {
            var FormModelLayout = new StackLayout();
            FormModelLayout.Orientation = StackOrientation.Vertical;

            var formGroupLayout = new StackLayout();
            formGroupLayout.Orientation = StackOrientation.Horizontal;

            var formComponentLayout = new StackLayout();
            formComponentLayout.Orientation = StackOrientation.Vertical;

            //Form Header Label
            Label formTitle = new Label();
            formTitle.Text = formModel.title;
            formTitle.FontSize = 30;


            //get groups
            foreach (FormGroup fg in formModel.formgroups)
            {
                //FormGroupBoxView boxView = new FormGroupBoxView(fg.text);
                //formGroupLayout.Children.Add(boxView);

                //Component Selector. Need to be more robust
                foreach (Component c in fg.components)
                {
                    if (c.type.Equals(ComponentTypes.YesNoSwitchView))
                    {
                        YesNoSwitchView yesNo = new YesNoSwitchView(c, formData);
                        formComponentLayout.Children.Add(yesNo);
                    }
                    else if (c.type.Equals(ComponentTypes.LabelEditorView))
                    {
                        LabelEditorView labelEditorView = new LabelEditorView(c, formData);
                        formComponentLayout.Children.Add(labelEditorView);
                    }
                    else if(c.type.Equals(ComponentTypes.CameraView))
                    {
                        CameraView cameraView = new CameraView(c, formData);
                        formComponentLayout.Children.Add(cameraView);
                    }
                }
            }

            FormModelLayout.Children.Add(formTitle);
            FormModelLayout.Children.Add(formGroupLayout);
            FormModelLayout.Children.Add(formComponentLayout);


            return FormModelLayout;
        }
    }
}
