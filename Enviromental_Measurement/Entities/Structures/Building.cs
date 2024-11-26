using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enviromental_Measurement.Common;
using Enviromental_Measurement.ValueObjects;

namespace Enviromental_Measurement.Entities.Variable;

public class Building : Entity
{
    #region Properties
    public int BuildingNumber { get; set; }
    public PhysicalAddress PhysicalAddress{get; set; }
    public List<Variable> AssociatedVariables1 { get; set; }
    public List<Floor> Building_Floors { get; set; }

    #endregion

    public Building(int buildingNumber, PhysicalAddress physicalAddress)
    {
        BuildingNumber = buildingNumber;
        PhysicalAddress = physicalAddress;
        AssociatedVariables1 = new List<Variable>();
        Building_Floors = new List<Floor>();

    }

    protected Building() : base()
    {//Constructor protegido para el correcto funcionamiento de Entity
        BuildingNumber = 0;
        PhysicalAddress = new PhysicalAddress("N/A", "N'A");
        AssociatedVariables1 = new List<Variable>();

    }
}
