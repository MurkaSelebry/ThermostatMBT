using Microsoft.Modeling;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThermostatMBT.Implementations;
using ThermostatMBT.Models;

namespace ThermostatMBT.UnitTests
{
    [TestClass]
    public class ThermostatModelTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            // Reset state before every test
            ThermostatModel.ModelState = new ThermostatModelState()
            {
                CurrentState = "Off",
                CurrentTemperature = 0,
                CurrentMode = "Heat"
            };
        }

        [TestMethod]
        public void TurnOnResultsInThermostatIsOn()
        {
            ThermostatModel.TurnOn();

            Assert.AreEqual("On", ThermostatModel.ModelState.CurrentState, "Expected thermostat to be turned on");
        }

        [TestMethod]
        public void TurnOffResultsInThermostatIsOff()
        {
            ThermostatModel.TurnOn();
            ThermostatModel.TurnOff();

            Assert.AreEqual("Off", ThermostatModel.ModelState.CurrentState, "Expected thermostat to be turned off");
        }

        [TestMethod]
        public void SetTemperatureWhenThermostatIsOnResultsInExpectedTemperature()
        {
            ThermostatModel.TurnOn();
            ThermostatModel.SetTemperature(25);

            Assert.AreEqual(25, ThermostatModel.ModelState.CurrentTemperature, "Expected temperature value of 25");
        }

        [TestMethod]
        public void SetTemperatureWhenThermostatIsOffDoesNotChangeTemperature()
        {
            ThermostatModel.SetTemperature(0);

            Assert.AreEqual(0, ThermostatModel.ModelState.CurrentTemperature, "Expected temperature value to remain 0 when thermostat is off");
        }

        [TestMethod]
        public void ChangeModeSwitchesBetweenHeatAndCool()
        {
            ThermostatModel.ChangeMode();
            Assert.AreEqual("Cool", ThermostatModel.ModelState.CurrentMode, "Expected mode to switch to Cool");

            ThermostatModel.ChangeMode();
            Assert.AreEqual("Heat", ThermostatModel.ModelState.CurrentMode, "Expected mode to switch back to Heat");
        }
    }
}
