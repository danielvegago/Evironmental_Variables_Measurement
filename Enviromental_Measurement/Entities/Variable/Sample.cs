using Enviromental_Measurement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enviromental_Measurement.Types.Enum_VariableTypes;


namespace Enviromental_Measurement.Entities.Variable;

    public class Sample : Variable {

    #region Properties
    public SampleDateTime DateTime;

    #endregion

    public Sample(VariableType variableType, string variableName, Measurement_Unit measurement_Unit, VariableCode variableCode, SampleDateTime dateTime) : base(variableType, variableName, measurement_Unit, variableCode)
    {
        DateTime = dateTime;

    }
}




    

