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
			Guard.Argument(calendarService, nameof(calendarService))
								   .NotNull();

			LoadEvents(calendarService.GetCalendarEvents());
		}

		private void LoadEvents(IEnumerable<CalendarEvent> events)
		{
			var result = events
				.GroupBy(x => new DateTimeOffset(new DateTime(x.EventTimestamp.Year, x.EventTimestamp.Month, x.EventTimestamp.Day), x.EventTimestamp.Offset))
				.Select(x => new GroupedEvents(x.Key, x.ToList()));

			_events = result.ToList();

		}

		public IReadOnlyCollection<GroupedEvents> Events => _events;
		private List<GroupedEvents> _events;

	}
}

