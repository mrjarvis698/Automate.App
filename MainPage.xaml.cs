namespace Automate;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnContinueClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("continue");
    }
}

