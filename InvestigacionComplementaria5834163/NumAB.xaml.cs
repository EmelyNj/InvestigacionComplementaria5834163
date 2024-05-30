namespace InvestigacionComplementaria5834163;

public partial class NumAB : ContentPage
{
	public NumAB()
	{
		InitializeComponent();
	}

    /// <summary>
    /// El boton hace la conversion de los datos obtenidos 
    /// en el .xaml, en este caso los convertimos a tipo INT
    /// hacemos la formula para obtener el resultado de la formula
    /// y lo guardamos en la variable total,
    /// pasamos esa variable a tipo STRING y lo mostramos en el text resultado del
    /// .xaml
    /// Encuanto a los if, nos ayudan a enviar mensajes de error y evitar que el programa se "rompa"
    /// para en casos de ingresar una letra en vez de un número simplemente envie un mensaje de error y correción
    /// </summary>

    private void Resultado_Clicked(object sender, EventArgs e)
    {
        int numA, numB, total;

        if(!string.IsNullOrEmpty(num1.Text)&& !string.IsNullOrEmpty(num2.Text))
        {
            if(int.TryParse(num1.Text, out numA) && int.TryParse(num2.Text, out numB))
                {

                numA = Convert.ToInt32(num1.Text);
                numB = Convert.ToInt32(num2.Text);

                total = (numA + numB) ^ 2 / 2;
                resultado.Text = total.ToString();
            }
            else
            {
                DisplayAlert("Error", "No es posible el ingreso de letras, por favor ingresar un número", "OK");
            }
        }

       
    }
}