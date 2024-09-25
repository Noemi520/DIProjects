namespace PagesDemo;

public partial class ContentPagesDemo : ContentPage
{
	public ContentPagesDemo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }

    private void Button_Clicked_Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}