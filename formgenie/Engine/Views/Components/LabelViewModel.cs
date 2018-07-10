using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace formgenie.Engine.Views.Components
{
    public class LabelViewModel: INotifyPropertyChanged
    {
        private string _labelText;
        public string LabelText
        {
            get { 
                return _labelText; 
            }
            set{
                _labelText = value;
                OnPropertyChanged();
            }
        }
        public LabelViewModel(string labelText)
        {
            LabelText = labelText;
        }

        public event PropertyChangedEventHandler PropertyChanged;  
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {  
            PropertyChanged ? .Invoke(this, new PropertyChangedEventArgs(propertyName));  
        }  

    }
}
