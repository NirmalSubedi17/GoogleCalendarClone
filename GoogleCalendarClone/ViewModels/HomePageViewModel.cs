using System.Collections.ObjectModel;
using Dawn;
using GoogleCalendarClone.Models;
using GoogleCalendarClone.Services;

namespace GoogleCalendarClone.ViewModels
{
    public class HomePageViewModel : BaseViewModel
	{
		public HomePageViewModel(ICalendarService calendarService)
		{
			_calendarService = Guard.Argument(calendarService, nameof(calendarService))
									.NotNull()
									.Value;

			_events = calendarService.GetCalendarEvents().ToList();
		}

		public IReadOnlyCollection<CalendarEvent> Events => _events;
		private List<CalendarEvent> _events;

		private readonly ICalendarService _calendarService;
	}
}

