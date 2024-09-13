using MauiApp1.Ventanas.Login;

namespace MauiApp1.Ventanas;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Crearperfil : ContentPage
    {
	    public Crearperfil()
	    {
		    InitializeComponent();
            BindingContext = new ModeloRegister(Navigation);
	    }

        private async void iniciarsesion_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PopAsync();
        }
    }