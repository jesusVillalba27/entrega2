using Microsoft.Maui.Controls;

namespace entrega2
{
    public partial class jorge : ContentPage
    {
        public jorge()
        {
            InitializeComponent();
        }

        private async void OnVerMasClicked(object sender, EventArgs e)
        {
            // Aqu� puedes navegar a otra p�gina o mostrar m�s informaci�n
            await DisplayAlert("M�s informaci�n", "Aqu� puedes agregar videos, enlaces o m�s detalles sobre Ronaldo.", "OK");
        }
    }
}
