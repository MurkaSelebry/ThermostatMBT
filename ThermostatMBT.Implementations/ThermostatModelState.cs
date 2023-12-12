using System;
using System.Text;
using Microsoft.Modeling;

namespace ThermostatMBT.Implementations
{
    public struct ThermostatModelState
    {
        public string CurrentState;
        public int CurrentTemperature;
        public string CurrentMode;

        public override string ToString()
        {
            var text = new StringBuilder();

            text.Append("State: ").Append(CurrentState);
            text.Append(", Temperature: ").Append(CurrentTemperature);
            text.Append(", Mode: ").Append(CurrentMode);

            return text.ToString();
        }
    }
}
