using System;
using System.Collections.Generic;
using Microsoft.Modeling;
using ThermostatMBT.Implementations;

namespace ThermostatMBT.Models
{
    public static class ThermostatModel
    {
        // Model state
        public static ThermostatModelState ModelState = new ThermostatModelState()
        {
            CurrentState = "Off",
            CurrentTemperature = 0,
            CurrentMode = "Heat"
        };

        #region Domains
        public static IEnumerable<int> TemperatureValues()
        {
            return new int[] { 20, 25, 30 };  // Example temperature values
        }
        #endregion

        [AcceptingStateCondition]
        static bool IsAcceptingState()
        {
            return (ModelState.CurrentState == "Off");
        }

        [Rule]
        static void Checker(ThermostatModelState state)
        {
            Condition.IsTrue(state.Equals(ModelState));
        }

        [StateFilter]
        static bool Filter()
        {
            return (ModelState.CurrentTemperature >= 0 && ModelState.CurrentTemperature <= 100);
        }

        [Rule]
        public static void SetTemperature([Domain("TemperatureValues")] int temp) 
        {
            ModelState.CurrentTemperature = temp;
        }

        [Rule]
        public static void TurnOn()
        {
            ModelState.CurrentState = "On";
        }


        [Rule]
        public static void TurnOff()
        {
            ModelState.CurrentState = "Off";
        }

        [Rule]
        public static void ChangeMode()
        {
            ModelState.CurrentMode = (ModelState.CurrentMode == "Heat") ? "Cool" : "Heat";
        }

    }
}
