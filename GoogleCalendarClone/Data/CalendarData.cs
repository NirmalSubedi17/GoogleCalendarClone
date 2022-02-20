using System;
using GoogleCalendarClone.Models;

namespace GoogleCalendarClone.Data
{
	//This class is here just to create some sample data.
	//In real life; Calendar Service would read the data from Android/iPhone Google account;

	public class CalendarData
	{
		public static IEnumerable<CalendarEvent> GetCalendarEvents()
		{
			var result = new List<CalendarEvent>();
			Random random = new Random();

			for (int year = DateTime.Now.Year; year <= DateTime.Now.Year + 12; year++)
			{
				for (int month = 1; month <= 12; month++)
				{
					for (int day = 1; day <= 28; day++)
					{
						var luckyDay = random.Next(1, 28);

						if (day == luckyDay)
						{
							var luckyHour = random.Next(1, 24);
							var luckyMinute = random.Next(1, 59);

							var luckyEvent = new CalendarEvent("Random Event",
								new DateTimeOffset(year, month, day, luckyHour, luckyMinute, 0, DateTimeOffset.Now.TimeOfDay));

							result.Add(luckyEvent);
						}
					}
				}
			}

			return result;
		}
	}
}

