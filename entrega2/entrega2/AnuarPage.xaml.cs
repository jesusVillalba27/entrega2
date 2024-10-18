namespace entrega2;

public partial class AnuarPage : ContentPage
{
	public AnuarPage()
	{
		InitializeComponent();
	}
    private async void OnGoToMainPageClicked(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new MainPage());
    }
}