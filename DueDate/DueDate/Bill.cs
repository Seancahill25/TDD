using System;

namespace PaymentDateCheck
{
    public class Bill
    {
        private IHolidayService _holidayService = new HolidayService();
        
        public DateTime CheckDate (DateTime dueDate)
        {
            if (dueDate.DayOfWeek == DayOfWeek.Saturday)
            {
                return dueDate.AddDays(2);
            }

            if (dueDate.DayOfWeek == DayOfWeek.Sunday)
            {
                return dueDate.AddDays(1);
            }

            if (_holidayService.isHoliday(dueDate) && dueDate.DayOfWeek == DayOfWeek.Friday)
            {
                return dueDate.AddDays(3);
            }
            else if (_holidayService.isHoliday(dueDate))
            {
                return dueDate.AddDays(1);
            }
            return dueDate;
        }
    }

}

