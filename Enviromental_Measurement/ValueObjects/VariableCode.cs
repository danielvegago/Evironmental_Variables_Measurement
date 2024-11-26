using Enviromental_Measurement.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enviromental_Measurement.ValueObjects
{
   public class VariableCode : ValueObject
    {
        public string code { get; set; }

        public VariableCode(string value)
        {
            if(string.IsNullOrEmpty(value))
                throw new ArgumentException("Code cannot be null or empty");

            else { code = value; }

        }
        #region Value Object Desing Pattern
        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones
        /// </summary>
        protected VariableCode()
        {
           code= String.Empty;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return code;
            
        }
        #endregion
    }
}
