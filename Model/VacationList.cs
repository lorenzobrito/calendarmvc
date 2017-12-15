using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace poc1.Model
{
    public class VacationList
    {
        public VacationList()
        {
            diastomar = new List<Mes>();
        }
        List<Mes> diastomar { get; set; }
        public void RemainDays()
        {
            if (CurrentMes != null)
            {
                diastomar.Add(CurrentMes);
                CurrentMes = null;
            }
        }
        public List<Mes> DiasTomar { get {
                
                return diastomar;
            } }
        public Mes CurrentMes { get; set; }
        int? CurrentMonth { get; set; }
        public void AddDAY(Dia dia)
        {
            if (CurrentMonth == null)
            {
                CurrentMonth = dia.Mes;
                CurrentMes = new Mes()
                {
                    Dias = new List<Dia>(),
                    Name = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dia.Mes)
                };
            }
             if (CurrentMonth.Value == dia.Mes)
                {
                    CurrentMes.AddDay(dia);
                }
                else
                {

                   diastomar.Add(CurrentMes);
                CurrentMonth = dia.Mes;
                   CurrentMes = new Mes()
                    {
                    Dias = new List<Dia>(),
                    Name = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dia.Mes)
                    };
                CurrentMes.AddDay(dia);
            }
            }
        }
    }


    
