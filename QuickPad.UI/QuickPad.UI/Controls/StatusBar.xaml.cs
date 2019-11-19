﻿using Windows.UI.Xaml.Controls;
using QuickPad.Mvvm.ViewModels;
using QuickPad.UI.Common;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace QuickPad.UI.Controls
{
    public sealed partial class StatusBar : UserControl
    {
        public VisualThemeSelector VisualThemeSelector { get; } = VisualThemeSelector.Default;

        public DocumentViewModel ViewModel
        {
            get => DataContext as DocumentViewModel;
            set
            {
                if (value == null || DataContext == value) return;
                DataContext = value;
            }
        }

        public StatusBar()
        {
            this.InitializeComponent();
        }

    }
}