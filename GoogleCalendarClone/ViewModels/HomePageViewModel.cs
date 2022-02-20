using System;
using System.Collections.ObjectModel;
using GoogleCalendarClone.Models;

namespace GoogleCalendarClone.ViewModels
{
	public class HomePageViewModel : BindableObject
	{
		public HomePageViewModel()
		{

		}

		public ReadOnlyObservableCollection<CalendarEvent> Events => _events;

		private ReadOnlyObservableCollection<CalendarEvent> _events = new ReadOnlyObservableCollection<CalendarEvent>();
	}
}

