﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThermostatMBT.TestSuites
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using Microsoft.SpecExplorer.Runtime.Testing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ThermostatMBT.Implementations;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Spec Explorer", "3.5.3146.0")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ThermostatTestSuite : VsTestClassBase
    {
        public ThermostatTestSuite()
        {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "30000");
        }

        #region Test Initialization and Cleanup
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            this.InitializeTestManager();
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void TestCleanup()
        {
            this.CleanupTestManager();
        }
        #endregion

        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ThermostatTestSuiteS0()
        {
            this.Manager.BeginTest("ThermostatTestSuiteS0");
            this.Manager.Comment("reaching state \'S0\'");
            this.Manager.Comment("executing step \'call Checker([Off,0,Heat])\'");
            ThermostatImplementation.Checker(
                this.Make<ThermostatModelState>(
                    new string[] { "CurrentState", "CurrentTemperature", "CurrentMode" },
                    new object[] { "Off", 0, "Heat" }));

            this.Manager.Comment("reaching state \'S1\'");
            this.Manager.Comment("checking step \'return Checker\'");
            this.Manager.Comment("reaching state \'S10\'");
            this.Manager.Comment("executing step \'call TurnOn()\'");
            ThermostatImplementation.TurnOn();
            this.Manager.Comment("reaching state \'S20\'");
            this.Manager.Comment("checking step \'return TurnOn\'");
            this.Manager.Comment("reaching state \'S30\'");
            this.Manager.Comment("executing step \'call Checker([On,0,Heat])\'");
            ThermostatImplementation.Checker(
                this.Make<ThermostatModelState>(
                    new string[] { "CurrentState", "CurrentTemperature", "CurrentMode" },
                    new object[] { "On", 0, "Heat" }));

            this.Manager.Comment("reaching state \'S40\'");
            this.Manager.Comment("checking step \'return Checker\'");
            this.Manager.Comment("reaching state \'S50\'");
            this.Manager.Comment("executing step \'call SetTemperature(25)\'");
            ThermostatImplementation.SetTemperature(25);
            this.Manager.Comment("reaching state \'S60\'");
            this.Manager.Comment("checking step \'return SetTemperature\'");
            this.Manager.Comment("reaching state \'S70\'");
            this.Manager.Comment("executing step \'call Checker([On,25,Heat])\'");
            ThermostatImplementation.Checker(
                this.Make<ThermostatModelState>(
                    new string[] { "CurrentState", "CurrentTemperature", "CurrentMode" },
                    new object[] { "On", 25, "Heat" }));

            this.Manager.Comment("reaching state \'S80\'");
            this.Manager.Comment("checking step \'return Checker\'");
            this.Manager.Comment("reaching state \'S90\'");
            this.Manager.Comment("executing step \'call TurnOff()\'");
            ThermostatImplementation.TurnOff();
            this.Manager.Comment("reaching state \'S100\'");
            this.Manager.Comment("checking step \'return TurnOff\'");
            this.Manager.Comment("reaching state \'S110\'");
            this.Manager.Comment("executing step \'call Checker([Off,25,Heat])\'");
            ThermostatImplementation.Checker(
                this.Make<ThermostatModelState>(
                    new string[] { "CurrentState", "CurrentTemperature", "CurrentMode" },
                    new object[] { "Off", 25, "Heat" }));

            this.Manager.Comment("reaching state \'S120\'");
            this.Manager.Comment("checking step \'return Checker\'");
            this.Manager.Comment("reaching state \'S130\'");
            this.Manager.Comment("executing step \'call ChangeMode()\'");
            ThermostatImplementation.ChangeMode();
            this.Manager.Comment("reaching state \'S140\'");
            this.Manager.Comment("checking step \'return ChangeMode\'");
            this.Manager.Comment("reaching state \'S150\'");
            this.Manager.Comment("executing step \'call Checker([Off,25,Cool])\'");
            ThermostatImplementation.Checker(
                this.Make<ThermostatModelState>(
                    new string[] { "CurrentState", "CurrentTemperature", "CurrentMode" },
                    new object[] { "Off", 25, "Cool" }));

            this.Manager.Comment("reaching state \'S160\'");
            this.Manager.Comment("checking step \'return Checker\'");
            this.Manager.EndTest();
        }
        #endregion
        #region Test Starting in S2
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ThermostatTestSuiteS2()
        {
            this.Manager.BeginTest("ThermostatTestSuiteS2");
            this.Manager.Comment("reaching state \'S2\'");
            this.Manager.Comment("executing step \'call Checker([Off,0,Heat])\'");
            ThermostatImplementation.Checker(
                this.Make<ThermostatModelState>(
                    new string[] { "CurrentState", "CurrentTemperature", "CurrentMode" },
                    new object[] { "Off", 0, "Heat" }));

            this.Manager.Comment("reaching state \'S3\'");
            this.Manager.Comment("checking step \'return Checker\'");
            this.Manager.Comment("reaching state \'S21\'");
            this.Manager.Comment("executing step \'call TurnOn()\'");
            ThermostatImplementation.TurnOn();
            this.Manager.Comment("reaching state \'S31\'");
            this.Manager.Comment("checking step \'return TurnOn\'");
            this.Manager.Comment("reaching state \'S41\'");
            this.Manager.Comment("executing step \'call Checker([On,0,Heat])\'");
            ThermostatImplementation.Checker(
                this.Make<ThermostatModelState>(
                    new string[] { "CurrentState", "CurrentTemperature", "CurrentMode" },
                    new object[] { "On", 0, "Heat" }));

            this.Manager.Comment("reaching state \'S51\'");
            this.Manager.Comment("checking step \'return Checker\'");
            this.Manager.EndTest();
        }
        #endregion

        #region Test Starting in S4
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ThermostatTestSuiteS4()
        {
            this.Manager.BeginTest("ThermostatTestSuiteS4");
            this.Manager.Comment("reaching state \'S4\'");
            this.Manager.Comment("executing step \'call Checker([Off,0,Heat])\'");
            ThermostatImplementation.Checker(
                this.Make<ThermostatModelState>(
                    new string[] { "CurrentState", "CurrentTemperature", "CurrentMode" },
                    new object[] { "Off", 0, "Heat" }));

            this.Manager.Comment("reaching state \'S5\'");
            this.Manager.Comment("checking step \'return Checker\'");
            this.Manager.Comment("reaching state \'S21\'");
            this.Manager.Comment("executing step \'call TurnOn()\'");
            ThermostatImplementation.TurnOn();
            this.Manager.Comment("reaching state \'S31\'");
            this.Manager.Comment("checking step \'return TurnOn\'");
            this.Manager.Comment("reaching state \'S41\'");
            this.Manager.Comment("executing step \'call Checker([On,0,Heat])\'");
            ThermostatImplementation.Checker(
                this.Make<ThermostatModelState>(
                    new string[] { "CurrentState", "CurrentTemperature", "CurrentMode" },
                    new object[] { "On", 0, "Heat" }));

            this.Manager.Comment("reaching state \'S51\'");
            this.Manager.Comment("checking step \'return Checker\'");
            this.Manager.EndTest();
        }
        #endregion
        #region Test Starting in S6
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ThermostatTestSuiteS6()
        {
            this.Manager.BeginTest("ThermostatTestSuiteS6");
            this.Manager.Comment("reaching state \'S6\'");
            this.Manager.Comment("executing step \'call Checker([Off,0,Heat])\'");
            ThermostatImplementation.Checker(
                this.Make<ThermostatModelState>(
                    new string[] { "CurrentState", "CurrentTemperature", "CurrentMode" },
                    new object[] { "Off", 0, "Heat" }));

            this.Manager.Comment("reaching state \'S7\'");
            this.Manager.Comment("checking step \'return Checker\'");
            this.Manager.Comment("reaching state \'S21\'");
            this.Manager.Comment("executing step \'call TurnOn()\'");
            ThermostatImplementation.TurnOn();
            this.Manager.Comment("reaching state \'S31\'");
            this.Manager.Comment("checking step \'return TurnOn\'");
            this.Manager.Comment("reaching state \'S41\'");
            this.Manager.Comment("executing step \'call Checker([On,0,Heat])\'");
            ThermostatImplementation.Checker(
                this.Make<ThermostatModelState>(
                    new string[] { "CurrentState", "CurrentTemperature", "CurrentMode" },
                    new object[] { "On", 0, "Heat" }));

            this.Manager.Comment("reaching state \'S51\'");
            this.Manager.Comment("checking step \'return Checker\'");
            this.Manager.EndTest();
        }
        #endregion

        #region Test Starting in S8
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void ThermostatTestSuiteS8()
        {
            this.Manager.BeginTest("ThermostatTestSuiteS8");
            this.Manager.Comment("reaching state \'S8\'");
            this.Manager.Comment("executing step \'call Checker([Off,0,Heat])\'");
            ThermostatImplementation.Checker(
                this.Make<ThermostatModelState>(
                    new string[] { "CurrentState", "CurrentTemperature", "CurrentMode" },
                    new object[] { "Off", 0, "Heat" }));

            this.Manager.Comment("reaching state \'S9\'");
            this.Manager.Comment("checking step \'return Checker\'");
            this.Manager.Comment("reaching state \'S21\'");
            this.Manager.Comment("executing step \'call TurnOn()\'");
            ThermostatImplementation.TurnOn();
            this.Manager.Comment("reaching state \'S31\'");
            this.Manager.Comment("checking step \'return TurnOn\'");
            this.Manager.Comment("reaching state \'S41\'");
            this.Manager.Comment("executing step \'call Checker([On,0,Heat])\'");
            ThermostatImplementation.Checker(
                this.Make<ThermostatModelState>(
                    new string[] { "CurrentState", "CurrentTemperature", "CurrentMode" },
                    new object[] { "On", 0, "Heat" }));

            this.Manager.Comment("reaching state \'S51\'");
            this.Manager.Comment("checking step \'return Checker\'");
            this.Manager.EndTest();
        }
        #endregion
    }
}
