namespace InvestigacionComplementaria5834163
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Los botones usan la opcion de Navigation para desplazarnos de paginas y volver a la principas
        /// por ello la instancia de cada boton cambia segun la pagina
        /// </summary>
        private void Numeros_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrdenNumeros());
        }

        private void NumAyB_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NumAB());
        }

        private void promedio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calificaciones());
        }

        private void CuadradoCubo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CuadradoCubo());
        }

        private void AlturaBase_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AlturaBase());
        }
    }

}
