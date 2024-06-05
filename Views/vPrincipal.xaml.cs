namespace rtoasaS2.Views;

public partial class vPrincipal : ContentPage
{
	public vPrincipal()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
		if(pkCiudades.SelectedIndex <0)
            DisplayAlert("Error", "No hay seleccion de ciudad", "ok");
		else
		{
            string datos = pkCiudades.Items[pkCiudades.SelectedIndex].ToString();
            DisplayAlert("ALERTA", datos, "ok");
        }


        string fecha = dpFecha.Date.ToString();
        DisplayAlert("ALERTA", "lA FECHA SELECCIONADA ES "+fecha, "OK");
    }
}