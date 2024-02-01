using Avalonia.Controls;
using Avalonia.Interactivity;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;


namespace RBWRMultitool.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        private bool _PaneOpen;

        public bool PaneOpen
        {
            get => _PaneOpen;
            private set => this.RaiseAndSetIfChanged(ref _PaneOpen, value);
        }

        public void TriggerPane()
        {
            PaneOpen = !PaneOpen;
        }

        public MainWindowViewModel()
        {
            PaneOpen = true;
        }

    }
}

