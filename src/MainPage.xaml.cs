using Plugin.Maui.Audio;
using Domain;
namespace LanguageLearningApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	public void Correct(object sender, EventArgs e)
	{
		Word.TextColor = Colors.Green;
	}

	private async void OnImageOneClicked(object sender, EventArgs e)
	{
		//Word.Text = $"Apple";
		var word = new AppWord("","","", WordLanguage.English);
		Correct(sender, e);
		Thread.Sleep(500);
		var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("apple.m4a"));
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

