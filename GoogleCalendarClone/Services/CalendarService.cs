using System;
using GoogleCalendarClone.Data;
using GoogleCalendarClone.Models;

namespace GoogleCalendarClone.Services
{
	public class CalendarService : ICalendarService
	{
		public CalendarService()
		{

		}

        public IEnumerable<CalendarEvent> GetCalendarEvents()
        {
            return CalendarData.GetCalendarEvents();
        }
    }
}

