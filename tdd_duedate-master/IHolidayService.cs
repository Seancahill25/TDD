using System;

namespace PaymentDateCheck
{
    public interface IHolidayService
    {
         bool IsHoliday(DateTime duedate);
    }
}