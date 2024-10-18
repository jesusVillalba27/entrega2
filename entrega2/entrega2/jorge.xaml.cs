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
            // Aquí puedes navegar a otra página o mostrar más información
            await DisplayAlert("Más información", "Aquí puedes agregar videos, enlaces o más detalles sobre Ronaldo.", "OK");
        }
    }
}
