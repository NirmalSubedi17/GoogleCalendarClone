using System;
using System.Collections;
using Dawn;

namespace GoogleCalendarClone.Models
{
    public class GroupedEvents : List<CalendarEvent>
    {
        public GroupedEvents(DateTimeOffset eventTimestamp, IEnumerable<CalendarEvent> events)
        {
            EventTimestamp = eventTimestamp.LocalDateTime;
            _calendarEvents = events != null ? events.ToList() : new List<CalendarEvent>();
        }

        public int Year => EventTimestamp.Year;
        public int Day => EventTimestamp.Day;

        public string DayOfWeek => EventTimestamp.DayOfWeek.ToString().Substring(0, 3).ToUpperInvariant();

        private readonly DateTime EventTimestamp;
        public IReadOnlyCollection<CalendarEvent> Events => _calendarEvents;
        private readonly List<CalendarEvent> _calendarEvents;
    }
}

