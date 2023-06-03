using Microsoft.Extensions.DependencyInjection;
using Windows.UI.Xaml.Controls;

namespace UwpDependencyInjectionSample
{
    public sealed partial class MainPage : Page
    {
        private readonly ClassWithDI _classWithDI;

        public MainPage()
        {
            this.InitializeComponent();
            _classWithDI = App.Services.GetRequiredService<ClassWithDI>();
            Greeting.Text = _classWithDI.GetGreeting();
        }
    }
}
