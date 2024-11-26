
using Enviromental_Measurement.Common;
using Enviromental_Measurement.Entities.Variable;
using Enviromental_Measurement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enviromental_Measurement.Entities.Variable;

   public class Floor : Entity
    {
        #region Properties
        public string FloorLocation { get; set; }


        public List<Room> Floor_Rooms { get; set; }
        public List<Variable> AssociatedVariables2 { get; set; }

        #endregion

        public Floor (string location)
        {
            FloorLocation = location;
        Floor_Rooms = new List<Room>();
        AssociatedVariables2 = new List<Variable>();
        }

    }

