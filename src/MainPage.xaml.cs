using Plugin.Maui.Audio;
namespace LanguageLearningApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}


	private async void OnImageOneClicked(object sender, EventArgs e)
	{
		//Word.Text = $"Apple";
		
		var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("apple.m4a"));
		Thread.Sleep(250);
		if (Word.Text == "Apple")
		{
			audioPlayer.Play();
		}
		
	}
	private void OnImageTwoClicked(object sender, EventArgs e)
	{
		Word.Text = $"Car";
	}
	private void OnImageThreeClicked(object sender, EventArgs e)
	{
		Word.Text = $"Boy";
	}
}

