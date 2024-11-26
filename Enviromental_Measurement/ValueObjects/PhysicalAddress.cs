using Enviromental_Measurement.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enviromental_Measurement.ValueObjects
{
    public  class PhysicalAddress : ValueObject
    {
        #region Properties
        public string Street { get; }
     public string City { get; }

        #endregion 
        
        public PhysicalAddress(string street, string city)
        {
            if (string.IsNullOrEmpty(street) || string.IsNullOrEmpty(city))
                throw new ArgumentNullException("These fields cannot be left empty");

            else
            {

                Street = street;
                City = city;
            }

        }


        #region Value Object Desing Pattern
        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones
        /// </summary>
        protected PhysicalAddress()
        {
            Street = String.Empty;
            City = String.Empty;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Street;
            yield return City;
        }
        #endregion



    }



}

    

