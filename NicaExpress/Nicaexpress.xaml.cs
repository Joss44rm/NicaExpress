namespace NicaExpress;

public partial class Nicaexpress : ContentPage
{
	public Nicaexpress()
	{
		InitializeComponent();
	}

    private async void BtnUsuario_Clicked(object sender, EventArgs e)
    {
        await this.Navigation.PushAsync(new Vistas.Usuario());
    }

    private async void BtnTransporte_Clicked(object sender, EventArgs e)
    {
        await this.Navigation.PushAsync(new Vistas.Transporte());
    }

    private async void BtnReservacion_Clicked(object sender, EventArgs e)
    {
        await this.Navigation.PushAsync(new Vistas.Reservacion());
    }


  
}