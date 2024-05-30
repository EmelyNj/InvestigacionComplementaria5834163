namespace InvestigacionComplementaria5834163;

public partial class OrdenNumeros : ContentPage
{
	public OrdenNumeros()
	{
		InitializeComponent();
	}

    //IMPORTANTE: La validación es para casos donde no se ingresen valores, ya que se han dejado como de tipo STRING


    /// <summary>
    /// El boton hace la conversion de los datos obtenidos 
    /// en el .xaml, en este caso los convertimos a tipo STRING
    /// para poder ordenar los numeros, ya que si son de tipo INT se sumarian, 
    /// guardamos el orden de los numeros(invertidos) en la variable inv
    /// pasamos esa variable a tipo STRING y lo mostramos en el text resultado del
    /// .xaml
    /// Encuanto a los if, nos ayudan a enviar mensajes de error y evitar que el programa se "rompa"
    /// para en casos de no ingresar un numero o valor, simplemente envie un mensaje de error y correción
    /// </summary>
    private void Invertir_Clicked(object sender, EventArgs e)
    {
      
        if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text) &&
            !string.IsNullOrEmpty(num3.Text) && !string.IsNullOrEmpty(num4.Text))
        {
            string n1, n2, n3, n4, inv;

            n1 = num1.Text;
            n2 = num2.Text;
            n3 = num3.Text;
            n4 = num4.Text;

            inv = n4 + n3 + n2 + n1;
            resultado.Text = inv.ToString();
        }
        else
        {
            DisplayAlert("Error", "Por favor ingresar todos los numeros", "OK");
        }
    }

    /// <summary>
    /// El boton hace la conversion de los datos obtenidos 
    /// en el .xaml, en este caso los convertimos a tipo STRING
    /// para poder ordenar los numeros, ya que si son de tipo INT se sumarian, 
    /// guardamos el orden de los numeros en la variable norm
    /// pasamos esa variable a tipo STRING y lo mostramos en el text resultado del
    /// .xaml
    /// Encuanto a los if, nos ayudan a enviar mensajes de error y evitar que el programa se "rompa"
    /// para en casos de no ingresar un numero o valor, simplemente envie un mensaje de error y correción
    /// </summary>
    private void Ordenar_Clicked(object sender, EventArgs e)
    {
       
        if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text) &&
            !string.IsNullOrEmpty(num3.Text) && !string.IsNullOrEmpty(num4.Text))
        {
            string n1, n2, n3, n4, norm;

                n1 = num1.Text;
                n2 = num2.Text;
                n3 = num3.Text;
                n4 = num4.Text;

                norm = n1+ n2 + n3 + n4;
                resultado.Text = norm.ToString();
            }
            else
            {
                DisplayAlert("Error", "Por favor ingresar todos los numeros", "OK");
            }
        }
    }
