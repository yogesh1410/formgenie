using System;
using System.IO;
using System.Reflection;
using formgenie.Data;
using formgenie.DependencyServices;
using formgenie.Engine.Entities;
using formgenie.Engine.Repository.DataObjects;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace formgenie.Engine.Repository
{
    public class FormRepository: IFormRepository
    {
        public FormRepository()
        {
        }

        public FormInstanceData GetFormInstance(string friendlyName)
        {
            FormInstanceData formInstanceData = new FormInstanceData();
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(FormModelData)).Assembly;
            string savedFormData = string.Empty;
            string FormModel = string.Empty;
            if (friendlyName.Equals(PreventionSection.Pullets))
            {
                //formModel
                Stream stream = assembly.GetManifestResourceStream("formgenie.Data.Pullets.FormModel.json");
                using (var reader = new System.IO.StreamReader(stream))
                {
                    formInstanceData.FormModel = reader.ReadToEnd();
                }

                //formdata
                savedFormData = DependencyService.Get<ISaveAndLoad>().LoadText(friendlyName);

                if (string.IsNullOrEmpty(savedFormData))
                {
                    stream = assembly.GetManifestResourceStream("formgenie.Data.Pullets.FormData.json");
                    using (var reader = new System.IO.StreamReader(stream))
                    {
                        formInstanceData.FormData = reader.ReadToEnd();
                    }
                }
                else
                {
                    formInstanceData.FormData = savedFormData;
                }

                //ValidationSchema
                stream = assembly.GetManifestResourceStream("formgenie.Data.Pullets.ValidationSchema.json");
                using (var reader = new System.IO.StreamReader(stream))
                {
                    formInstanceData.ValidationSchema = reader.ReadToEnd();
                }

            }
            else if (friendlyName.Equals(PreventionSection.Biosecurity))
            {
                //formModel
                Stream stream = assembly.GetManifestResourceStream("formgenie.Data.Biosecurity.FormModel.json");
                using (var reader = new System.IO.StreamReader(stream))
                {
                    formInstanceData.FormModel = reader.ReadToEnd();
                }

                //formdata
                savedFormData = DependencyService.Get<ISaveAndLoad>().LoadText(friendlyName);
                if (string.IsNullOrEmpty(savedFormData))
                {
                    stream = assembly.GetManifestResourceStream("formgenie.Data.Biosecurity.FormData.json");
                    using (var reader = new System.IO.StreamReader(stream))
                    {
                        formInstanceData.FormData = reader.ReadToEnd();
                    }
                }
                else{
                    formInstanceData.FormData = savedFormData;
                }

                //ValidationSchema
                stream = assembly.GetManifestResourceStream("formgenie.Data.Biosecurity.ValidationSchema.json");
                using (var reader = new System.IO.StreamReader(stream))
                {
                    formInstanceData.ValidationSchema = reader.ReadToEnd();
                }
            }
            else if (friendlyName.Equals(PreventionSection.RodentsFliesOtherPestControl))
            {
                //formModel
                Stream stream = assembly.GetManifestResourceStream("formgenie.Data.RodentFliesPestControl.FormModel.json");
                using (var reader = new System.IO.StreamReader(stream))
                {
                    formInstanceData.FormModel = reader.ReadToEnd();
                }

                //formData
                savedFormData = DependencyService.Get<ISaveAndLoad>().LoadText(friendlyName);

                if (string.IsNullOrEmpty(savedFormData))
                {
                    stream = assembly.GetManifestResourceStream("formgenie.Data.RodentFliesPestControl.FormData.json");
                    using (var reader = new System.IO.StreamReader(stream))
                    {
                        formInstanceData.FormData = reader.ReadToEnd();
                    }
                }
                else{
                    formInstanceData.FormData = savedFormData;
                }
                //ValidationSchema
                stream = assembly.GetManifestResourceStream("formgenie.Data.RodentFliesPestControl.ValidationSchema.json");
                using (var reader = new System.IO.StreamReader(stream))
                {
                    formInstanceData.ValidationSchema = reader.ReadToEnd();
                }

            }
            else if (friendlyName.Equals(PreventionSection.CleaningAndDisinfectionProducts))
            {
                //formModel
                Stream stream = assembly.GetManifestResourceStream("formgenie.Data.CleaningAndDisinfectionProducts.FormModel.json");
                using (var reader = new System.IO.StreamReader(stream))
                {
                    formInstanceData.FormModel = reader.ReadToEnd();
                }

                //formData
                savedFormData = DependencyService.Get<ISaveAndLoad>().LoadText(friendlyName);

                if (string.IsNullOrEmpty(savedFormData))
                { 
                    stream = assembly.GetManifestResourceStream("formgenie.Data.CleaningAndDisinfectionProducts.FormData.json");
                    using (var reader = new System.IO.StreamReader(stream))
                    {
                        formInstanceData.FormData = reader.ReadToEnd();
                    }
                }
                else{
                    formInstanceData.FormData = savedFormData;
                }

                //ValidationSchema
                stream = assembly.GetManifestResourceStream("formgenie.Data.CleaningAndDisinfectionProducts.ValidationSchema.json");
                using (var reader = new System.IO.StreamReader(stream))
                {
                    formInstanceData.ValidationSchema = reader.ReadToEnd();
                }
            }
            else if (friendlyName.Equals(PreventionSection.RefrigerationProcedures))
            {
                //formmodel
                Stream stream = assembly.GetManifestResourceStream("formgenie.Data.RefrigerationProcedures.FormModel.json");
                using (var reader = new System.IO.StreamReader(stream))
                {
                    formInstanceData.FormModel = reader.ReadToEnd();
                }


                //formdata
                savedFormData = DependencyService.Get<ISaveAndLoad>().LoadText(friendlyName);

                if (string.IsNullOrEmpty(savedFormData))
                {
                    stream = assembly.GetManifestResourceStream("formgenie.Data.RefrigerationProcedures.FormData.json");
                    using (var reader = new System.IO.StreamReader(stream))
                    {
                        formInstanceData.FormData = reader.ReadToEnd();
                    }
                }else{
                    formInstanceData.FormData = savedFormData;
                }

                //ValidationSchema
                stream = assembly.GetManifestResourceStream("formgenie.Data.RefrigerationProcedures.ValidationSchema.json");
                using (var reader = new System.IO.StreamReader(stream))
                {
                    formInstanceData.ValidationSchema = reader.ReadToEnd();
                }
            }
            return formInstanceData;
        }
    }
}
