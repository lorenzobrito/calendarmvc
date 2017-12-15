using poc1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poc1.Service
{
    public class MesService
    {
        List<DayOfWeek> worksdays = new List<DayOfWeek>()
        {
            DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
            DayOfWeek.Friday
        };
        List<DateTime> holidays = new List<DateTime>()
        {
          new DateTime(2017,9,10),
          new DateTime(2017,8,10),
          new DateTime(2017,7,10),
          new DateTime(2018,1,10),
          new DateTime(2018,2,10),
          new DateTime(2018,3,10),
          new DateTime(2018,4,10),
          new DateTime(2018,5,10),

          new DateTime(2017,6,10),
          new DateTime(2017,7,10),

        };

        bool AddDay(DateTime date)
        {
            if (worksdays.Contains(date.DayOfWeek))
            {
                if (holidays.Contains(date))
                    return false;
                else
                    return true;
            }
            else
                return false;
        }
      
        public VacationList GetListVacaton(DateTime dateTime,int dias)
        {
            VacationList list = new VacationList(); 
            DateTime baseTime=dateTime.AddDays(1);
            if (AddDay(baseTime))
            {
                list.AddDAY(new Dia() { Day = baseTime });
                dias--;
            }
           
            for (int i = 0; i < dias; )
            {
                 baseTime = baseTime.AddDays(1);
                if (AddDay(baseTime))
                {
                    list.AddDAY(new Dia() { Day = baseTime });
                    i++;
                }
            }
            list.RemainDays();
            return list;
        }
    }
}
