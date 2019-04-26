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
                Command = new Command((obj) =>
                {
                    Navigation.PopAsync();
                })
            });
        }
    }
}
