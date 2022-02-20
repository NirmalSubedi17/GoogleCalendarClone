using GoogleCalendarClone.Services;
using GoogleCalendarClone.ViewModels;

namespace GoogleCalendarClone.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		var calenderService = new CalendarService();
		this.BindingContext = new HomePageViewModel(calenderService);
	}
}
