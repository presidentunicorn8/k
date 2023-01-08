using HtmlAgilityPack;
using KpopComebacks.Model;
using KpopComebacks.ViewModel;

namespace KpopComebacks;

[XamlCompilation(XamlCompilationOptions.Skip)]
public partial class MainPage : ContentPage
{

	public MainPage(MonkeysViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
        var html = @"http://webcache.googleusercontent.com/search?q=cache:https://kpopofficial.com/kpop-comeback-schedule-january-2023/&strip=1&vwsrc=0";

        HtmlWeb web = new HtmlWeb();

        var htmlDoc = web.Load(html);
        string name = htmlDoc.DocumentNode
            .SelectSingleNode("//html/body/div[2]/div[1]/div[3]/div/div[1]/div/p[1]")
            .Attributes["value"].Value;

        //titleLabel.Text = name; 
        
    }
}

