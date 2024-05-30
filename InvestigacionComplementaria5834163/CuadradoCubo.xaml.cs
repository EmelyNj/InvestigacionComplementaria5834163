namespace InvestigacionComplementaria5834163;

public partial class CuadradoCubo : ContentPage
{
	public CuadradoCubo()
	{
		InitializeComponent();
	}

    /// <summary>
    /// El boton hace la conversion de los datos obtenidos 
    /// en el .xaml, en este caso los convertimos a tipo INT
    /// hacemos la formula para obtener el cuadrado y el cubo de un número
    /// y lo guardamos en las variables tot y totCubo,
    /// pasamos esa variable a tipo STRING y lo mostramos en el text total y totalCubo del
    /// .xaml
    /// Encuanto a los if, nos ayudan a enviar mensajes de error y evitar que el programa se "rompa"
    /// para en casos de ingresar una letra en vez de un número simplemente envie un mensaje de error y correción
    /// </summary>

    private void Total_Clicked(object sender, EventArgs e)
    {
        int n, tot, totCubo;

        if (!string.IsNullOrEmpty(num1.Text))
        {
            if (int.TryParse(num1.Text, out n) )
            {

                n = Convert.ToInt32(num1.Text);

                tot = n * n;
                total.Text = tot.ToString();

                totCubo = n * n * n;
                totalCubo.Text = totCubo.ToString();
            }
            else
            {
                DisplayAlert("Error", "No es posible el ingreso de letras, por favor ingresar un número", "OK");
            }
        }
    }
    
}