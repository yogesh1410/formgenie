using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using formgenie.Engine.Entities;

namespace formgenie.Engine.Views.Components
{
    public class LabelEditorViewModel:INotifyPropertyChanged
    {
        private string _labelText;
        public string LabelText
        {
            get { return _labelText; }
            set
            {
                _labelText = value;
                OnPropertyChanged("LabelText");
            }
        }

        private string _editorText;
        public string EditorText
        {
            get{
                return _editorText;
            }
            set{
                _editorText = value;
                OnPropertyChanged("EditorText");
            }
        }

        public LabelEditorViewModel(string labelText, string editorText)
        {
            LabelText = labelText;
            EditorText = editorText;
        }

        public event PropertyChangedEventHandler PropertyChanged;  
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {  
            PropertyChanged ? .Invoke(this, new PropertyChangedEventArgs(propertyName));  
        } 
    }
}
