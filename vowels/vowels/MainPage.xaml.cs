namespace vowels;

public partial class MainPage : ContentPage
{
	int count = 0;
	char[] word;
	char[] vowel = { 'a','o','u','e','i' };
	Boolean flag = false;
	string vowelContain, word2;
	
	public MainPage()
	{
		InitializeComponent();
	}

	private void check_Clicked(object sender, EventArgs e)
	{
		word = (Enteredletter.Text.ToString()).ToLower().ToCharArray();

		if (word.Length == 1)
		{
			for(int i=0; i<vowel.Length; i++)
			{
				if (word[0] == vowel[i])
				{
					
					flag = true;
					break;

                }
			}
			if  (flag){
                output.Text = "is vowel? " + "yes";
				flag = false;
			}
			else
			{
                output.Text = "is vowel? " + "No";
            }
		}
		else
		{
			for(int i=0; i<word.Length; i++)
			{
                for (int j = 0; j < vowel.Length; i++)
                {
                    if (word[i] == vowel[j])
                    {

						count++;
						vowelContain = vowelContain + word[i];

                    }
					else
					{
						word2 = word2 + word[i];
					}
                }
            }

			output.Text = "Vowel Count: " + count + "containVowels: " + vowelContain + "word without vowel: " + word2;
		}
	}
}


