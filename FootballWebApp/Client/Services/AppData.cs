using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using FootballWebApp.Client.Annotations;
using FootballWebApp.Shared.Entities;

namespace FootballWebApp.Client.Services
{
    public class AppData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Match _selectedMatch;

        public Match SelectedMatch
        {
            get => _selectedMatch;
            set
            {
                _selectedMatch = value;
                OnPropertyChanged();
            }
        }
    }
}
