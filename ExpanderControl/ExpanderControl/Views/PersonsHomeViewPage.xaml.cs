using ExpanderControl.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpanderControl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonsHomeViewPage : ContentPage
    {
        public PersonsHomeViewPage()
        {
            InitializeComponent();
            BindingContext = new PersonsHomeViewModel();
        }
    }
}