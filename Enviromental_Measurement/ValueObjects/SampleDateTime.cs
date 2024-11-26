using Enviromental_Measurement.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enviromental_Measurement.ValueObjects
{
    public class SampleDateTime : ValueObject
    {
        /// <summary>
        /// Almacena (dia,mes,ano)
        /// </summary>
        public DateTime Date { get; }

        /// <summary>
        /// Almacena(Hora,minuto,segundo)
        /// </summary>
        public TimeSpan Time { get; }

        public SampleDateTime(DateTime date, TimeSpan time)
        {
            if (time.TotalHours > 24 || time.TotalMinutes < 0)
                throw new ArgumentException(nameof(time), "Time must be between 00:00 and 23:59");
            else
            {
                Date = date;
                Time = time;
            }

        }
        #region Value Object Desing Pattern
        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones
        /// </summary>
        protected SampleDateTime()
        {
            Date= DateTime.MinValue;//(01,01,0001)
            Time = TimeSpan.Zero;//(0,0,0)
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Date;
            yield return Time;
        }

        #endregion




    }



}
