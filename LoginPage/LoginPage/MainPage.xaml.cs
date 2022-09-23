namespace LoginPage;

public partial class MainPage : ContentPage
{
	int attempts = 0;
	string pass = "test";
	string user = "test";

	public MainPage()
	{
		InitializeComponent();
	}

	private async void LoginButton_Clicked(object sender, EventArgs e)
	{
		attempts++;
		if (attempts < 6)
		{
			if(user.Equals(Username.Text.ToString()) && pass.Equals(Password.Text.ToString()))
			{
                Login.Text = $"Welcome";
				if (await this.DisplayAlert(
					"LoggedIn",
					"Welcome",
					"ok",
					"Cancel"));

            }
			else
			{
                Login.Text = $"Clicked {attempts} time";
            }
		}
		else
		{
            Login.Text = $"Locked";
            if(await this.DisplayAlert(
		   "Error",
		   "You have tried more than 5 times",
		   "Ok",
		   "Cancel"))
			{
				Console.Write("alert clicked");
			}
        }

    }
}


