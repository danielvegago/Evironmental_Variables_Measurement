using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enviromental_Measurement.Entities.Variable;
using static Enviromental_Measurement.Types.Enum2_RoomType;
using Enviromental_Measurement.ValueObjects;
using Enviromental_Measurement.Common;

namespace Enviromental_Measurement.Entities.Variable
{
    public class Room : Entity
    {

        #region Properties

        public int RoomNumber { get; set; }
        public RoomType RoomType;
        public string RoomDescription { get; set; }
        public List<Variable> AssociatedVariables3 { get; set; }

        #endregion

        public Room( string roomDescription, RoomType roomType, int roomNumber) 
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            RoomDescription = roomDescription;
            AssociatedVariables3 = new List<Variable>();

        }

        public  string getRoomType()
        {
            switch (RoomType)
            {
                case RoomType.OfficceRom: return "Habitacion de Oficina";
                case RoomType.ProductionRom: return "Habitacion de Produccion";
                default: return "Tipo de Habitacion desconocida";
            }
        }

    }
}
