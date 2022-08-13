namespace PickerBug;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		picker.Items.Add("item");
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		picker.Items.Add("won't appear");
	}
}

