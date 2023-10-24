using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MODULE2_INOTIFY.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Compass : ContentPage
    {
        public Compass()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (!DesignMode.IsDesignModeEnabled)
                ((MyCompassViewModel)BindingContext).StartCommand.Execute(null);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (!DesignMode.IsDesignModeEnabled)
                ((MyCompassViewModel)BindingContext).StopCommand.Execute(null);
        }
    }
}