namespace NicaExpress.Vistas;

public partial class Reservacion : ContentPage
{
	public Reservacion()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private async void btnsur_Clicked(object sender, EventArgs e)
    {
        await this.Navigation.PushAsync(new Vistas.terminalsur());
    }

    private async void btnnorte_Clicked(object sender, EventArgs e)
    {
        await this.Navigation.PushAsync(new Vistas.terminalnorte());
    }
}