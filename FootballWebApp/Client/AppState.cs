using System;
using FootballWebApp.Shared.Entities;

namespace FootballWebApp.Client
{
    public class AppState
    {
        public event Action OnChange;

        public bool IsNavOpen { get; private set; } = true;

        public void ToggleNav()
        {
            IsNavOpen = !IsNavOpen;
            NotifyStateChanged();
        }


        public Match SelectedMatch { get; private set; }

        public void SetCurrentMatch(Match match)
        {
            SelectedMatch = match;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
