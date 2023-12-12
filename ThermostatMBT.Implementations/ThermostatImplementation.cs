using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ThermostatMBT.Implementations
{
    public static class ThermostatImplementation
    {
        // Model state variables
        private static string currentState;
        private static int currentTemperature;
        private static string currentMode;

        public static void Checker(ThermostatModelState state)
        {
            Assert.AreEqual(state.CurrentState, currentState, "States not equal");
            Assert.AreEqual(state.CurrentTemperature, currentTemperature, "Temperatures not equal");
            Assert.AreEqual(state.CurrentMode, currentMode, "Modes not equal");
        }

        public static void TurnOn()
        {
            currentState = "On";
        }

        public static void TurnOff()
        {
            currentState = "Off";
        }

        public static void ChangeMode()
        {
            currentMode = (currentMode == "Heat") ? "Cool" : "Heat";
        }
        public static void SetTemperature(int temp)
        {
            currentTemperature = temp;
        }
    }
}
