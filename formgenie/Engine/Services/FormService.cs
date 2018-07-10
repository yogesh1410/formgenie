using System;
using formgenie.Data;
using formgenie.Engine.Entities;
using formgenie.Engine.Repository;
using formgenie.Engine.Repository.DataObjects;
using formgenie.Engine.Views.Components;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace formgenie.Engine.Services
{
    public class FormService
    {
        FormRepository _formRepository;
        LayoutGenerator _layoutGenerator;
        public FormService()
        {
            _formRepository = new FormRepository();
            _layoutGenerator = new LayoutGenerator();
        }



        /*public Layout GetFormLayout(string friendlyName)
        {
            var sl = new StackLayout();

            string FormModelJson = _formRepository.GetFormModel(friendlyName);
            FormModel view = JsonConvert.DeserializeObject<FormModel>(FormModelJson);

            return _layoutGenerator.GenerateLayout(view);
        }*/

        public FormInstance GetFormInstance(string friendlyName)
        {
            FormInstanceData formInstanceData = new FormInstanceData();
            formInstanceData = _formRepository.GetFormInstance(friendlyName);

            FormInstance formInstance = new FormInstance();
            formInstance.FormModelView = JsonConvert.DeserializeObject<FormModel>(formInstanceData.FormModel);
            formInstance.FormData = formInstanceData.FormData;
            formInstance.ValidationSchema = formInstanceData.ValidationSchema;
            //formInstance.FormModelLayout = _layoutGenerator.GenerateLayout(formInstance.FormModelView, formInstance.FormData);
            return formInstance;
        }

        public Layout GenerateLayout(FormModel formModelView, string formData)
        {
            return _layoutGenerator.GenerateLayout(formModelView, formData);
        }

        /*public Layout GetFormLayout(string FormModelJson)
        {
            var sl = new StackLayout();

            //string FormModelJson = _formRepository.GetFormModel(friendlyName);
            FormModel view = JsonConvert.DeserializeObject<FormModel>(FormModelJson);

            return _layoutGenerator.GenerateLayout(view);
        }*/



    }
}
