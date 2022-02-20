using System;
using GoogleCalendarClone.Models;

namespace GoogleCalendarClone.Services
{
	public interface ICalendarService
	{
		public IEnumerable<CalendarEvent> GetCalendarEvents();
	}
}

