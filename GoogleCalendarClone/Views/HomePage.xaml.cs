using GoogleCalendarClone.ViewModels;

namespace GoogleCalendarClone.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		this.BindingContext = new HomePageViewModel();
	}
}

