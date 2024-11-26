using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enviromental_Measurement.Common;

namespace Enviromental_Measurement.ValueObjects
{
  public class Measurement_Unit : ValueObject
    {
        #region Properties
        public string Symbol { get; }
   public string Name { get; }
        #endregion
        public Measurement_Unit(string symbol, string name)
        {
       
                Symbol = symbol;
                Name = name;
            
        }

        #region Value Object Desing Pattern
        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones
        /// </summary>
        protected Measurement_Unit()
        {
            Symbol = String.Empty;
            Name = String.Empty;
        }
       

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Symbol;
            yield return Name;
        }
        #endregion
    }
}
