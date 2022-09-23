using System.Collections;

namespace ExtractVowels;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnVowelBtnCheck(object sender, EventArgs e)
	{
        ArrayList vowelListArr = new ArrayList();
        ArrayList nonVowelListArr = new ArrayList();
        for (int i = 0; i < entryText.Text.Length; i++)
        {
            //Console.WriteLine(i);
            bool isVowel = "aeiouAEIOU".IndexOf(entryText.Text[i]) >= 0;
            if (isVowel)
            {
                vowelList.Text += " " + entryText.Text[i];
                vowelListArr.Add(entryText.Text[i]);
            }
            else
            {
                nonVowelList.Text += " " + entryText.Text[i];
                nonVowelListArr.Add(entryText.Text[i]);
            }
        }
    }
}


