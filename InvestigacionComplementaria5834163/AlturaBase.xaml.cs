namespace InvestigacionComplementaria5834163;

public partial class AlturaBase : ContentPage
{
	public AlturaBase()
	{
		InitializeComponent();
	}

    /// <summary>
    /// El boton hace la conversion de los datos obtenidos 
    /// en el .xaml, en este caso los convertimos a tipo DOUBLE
    /// hacemos la formula para obtener el resultado de las formulas
    /// y lo guardamos en las variables peri y super,
    /// pasamos esa variable a tipo STRING y lo mostramos en el text totalP y totalS del
    /// .xaml
    /// Encuanto a los if, nos ayudan a enviar mensajes de error y evitar que el programa se "rompa"
    /// para en casos de ingresar una letra en vez de un número simplemente envie un mensaje de error y correción
    /// </summary>

    private void Calculo_Clicked(object sender, EventArgs e)
    {
        double al, ba, peri, super;

        if (!string.IsNullOrEmpty(altura.Text) && !string.IsNullOrEmpty(baseR.Text))
        {
            if (Double.TryParse(altura.Text, out al) && Double.TryParse(baseR.Text, out ba))
            {

                al = Convert.ToDouble(altura.Text);
                ba = Convert.ToDouble(baseR.Text);

                peri = 2*(al + ba);
                super = ba*al;
                totalS.Text = super.ToString();
                totalP.Text = peri.ToString();
            }
            else
            {
                DisplayAlert("Error", "No es posible el ingreso de letras, por favor ingresar un número", "OK");
            }
        }
    }
}