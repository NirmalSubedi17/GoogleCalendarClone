using System;
namespace GoogleCalendarClone.Models
{
    public class CalendarEvent
    {
        public CalendarEvent(string eventTitle, DateTimeOffset eventTimestamp)
        {
            EventTitle = eventTitle;
            EventTimestamp = eventTimestamp;
        }

        public string EventTitle { get; }
        public DateTimeOffset EventTimestamp { get; }
    }
}

