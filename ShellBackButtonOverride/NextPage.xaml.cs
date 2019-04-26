using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellBackButtonOverride
{
    public partial class NextPage : ContentPage
    {
        public NextPage()
        {
            InitializeComponent();
            Shell.SetSetPaddingInsets(this, true);

            Shell.SetBackButtonBehavior(this, new BackButtonBehavior
            {
                TextOverride = "Back",
                IconOverride = ImageSource.FromResource("ShellBackButtonOverride.Resources.Keypad4-24.png", GetType().Assembly),
                Command = new Command((obj) =>
                {
                    Navigation.PopAsync();
                })
            });

        }
    }
}
