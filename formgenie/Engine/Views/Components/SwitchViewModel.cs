using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace formgenie.Engine.Views.Components
{
    public class SwitchViewModel: INotifyPropertyChanged
    {
        private bool _switchValue;
        public bool SwitchValue
        {
            get
            {
                return _switchValue;
            }
            set
            {
                _switchValue = value;
                OnPropertyChanged("Switch");
            }
        }
        public SwitchViewModel(bool switchValue)
        {
            SwitchValue = switchValue;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
