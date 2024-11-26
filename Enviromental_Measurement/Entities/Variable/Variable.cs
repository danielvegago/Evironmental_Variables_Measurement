
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enviromental_Measurement.Types.Enum_VariableTypes;
using Enviromental_Measurement.ValueObjects;
using Enviromental_Measurement.Common;

namespace Enviromental_Measurement.Entities.Variable
{
    /// <summary>
    /// Clase base para las Variables de Medicion
    /// </summary>
    public class Variable : Entity
    {

        #region Properties
        public VariableType VariableType;
        public string VariableName { get; }

        public Measurement_Unit Measurement_Unit;

        public VariableCode VariableCode { get; }
        #endregion


        #region Entity Dising
        public Building building { get; set; }
        public Guid buildingId { get; set; }
        #endregion




        #region Constructors
        public Variable(VariableType variableType, string variableName, Measurement_Unit measurement_Unit, VariableCode variableCode)
        {
            VariableType = variableType;
            VariableName = variableName;
            Measurement_Unit = measurement_Unit;
            VariableCode = variableCode;


        }

        protected Variable() : base()
        {//Constructor protegido para el correcto funcionamiento de Entity
            VariableName = String.Empty;
            Measurement_Unit = new Measurement_Unit("N/A", "N'A");
            VariableCode = new VariableCode("N/A");
            VariableType = 0;
        }

        #endregion


        public string getVariableType()
        {
            switch (VariableType)
            {
                case VariableType.Continous: return "Variable continua";
                case VariableType.Discrete: return "Variable discreta";
                case VariableType.Boolean: return "Variable booleana";
                default: return "Tipo de Variable desconocida";
            }
        }
    }


}
