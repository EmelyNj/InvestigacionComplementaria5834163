namespace InvestigacionComplementaria5834163;

public partial class Calificaciones : ContentPage
{
	public Calificaciones()
	{
		InitializeComponent();
	}

    /// <summary>
    /// El boton hace la conversion de los datos obtenidos 
    /// en el .xaml, en este caso los convertimos a tipo INT
    /// hacemos la formula para obtener el promedio y lo guardamos en la variable
    /// nota, pasamos esa variable a tipo STRING y lo mostramos en el text Resultado del
    /// .xaml
    /// Encuanto a los if, nos ayudan a enviar mensajes de error y evitar que el programa se "rompa"
    /// para en casos de ingresar una letra en vez de un número simplemente envie un mensaje de error y correción
    /// </summary>

    private void Button_Clicked(object sender, EventArgs e)
    {
        double n1, n2, n3, n4, n5, nota;

        if (!string.IsNullOrEmpty(nota1.Text) && !string.IsNullOrEmpty(nota2.Text) &&
            !string.IsNullOrEmpty(nota4.Text) && !string.IsNullOrEmpty(nota4.Text)&&
            !string.IsNullOrEmpty(nota5.Text))
        {
            if (Double.TryParse(nota1.Text, out n1) && Double.TryParse(nota2.Text, out n2)&&
                Double.TryParse(nota3.Text,out n3) && Double.TryParse(nota4.Text, out n4) &&
                Double.TryParse(nota5.Text, out n5))
            {

                n1 = Convert.ToDouble(nota1.Text);
                n2 = Convert.ToDouble(nota2.Text);
                n3 = Convert.ToDouble(nota3.Text);
                n4 = Convert.ToDouble(nota4.Text);
                n5 = Convert.ToDouble(nota5.Text);

                nota = (n1 + n2 + n3 + n4 + n5) / 5;

                resultado.Text = nota.ToString();
            }
            else
            {
                DisplayAlert("Error", "No es posible el ingreso de letras, por favor ingresar un número", "OK");
            }
        }
    }

    
}