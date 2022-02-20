using System;
namespace GoogleCalendarClone.Models
{
    public class CalendarEvent
    {
        public CalendarEvent(string eventTitle, DateTimeOffset eventTimestamp)
        {
            EventTitle = eventTitle;
            EventTimestamp = eventTimestamp.LocalDateTime;
        }

        public string EventTitle { get; }
        public DateTimeOffset EventTimestamp { get; }

        public DateTime EventLocalDateTime => EventTimestamp.LocalDateTime;
    }
}

