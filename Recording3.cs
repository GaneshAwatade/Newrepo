﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Mycalcu
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording3 recording.
    /// </summary>
    [TestModule("12e914eb-a0c5-48bf-836d-1b85ae9367f5", ModuleType.Recording, 1)]
    public partial class Recording3 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MycalcuRepository repository.
        /// </summary>
        public static MycalcuRepository repo = MycalcuRepository.Instance;

        static Recording3 instance = new Recording3();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording3()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording3 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.ClearButton' at 40;25.", repo.Calculator.ClearButtonInfo, new RecordItemIndex(0));
            repo.Calculator.ClearButton.Click("40;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.ClearButton' at 40;25.", repo.Calculator.ClearButtonInfo, new RecordItemIndex(1));
            repo.Calculator.ClearButton.Click("40;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num2Button' at 42;12.", repo.Calculator.NumberPad.Num2ButtonInfo, new RecordItemIndex(2));
            repo.Calculator.NumberPad.Num2Button.Click("42;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.PlusButton' at 43;22.", repo.Calculator.PlusButtonInfo, new RecordItemIndex(3));
            repo.Calculator.PlusButton.Click("43;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.PlusButton' at 43;22.", repo.Calculator.PlusButtonInfo, new RecordItemIndex(4));
            repo.Calculator.PlusButton.Click("43;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num1Button' at 76;31.", repo.Calculator.NumberPad.Num1ButtonInfo, new RecordItemIndex(5));
            repo.Calculator.NumberPad.Num1Button.Click("76;31");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num4Button' at 72;27.", repo.Calculator.NumberPad.Num4ButtonInfo, new RecordItemIndex(6));
            repo.Calculator.NumberPad.Num4Button.Click("72;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num4Button' at 72;27.", repo.Calculator.NumberPad.Num4ButtonInfo, new RecordItemIndex(7));
            repo.Calculator.NumberPad.Num4Button.Click("72;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num5Button' at 36;19.", repo.Calculator.NumberPad.Num5ButtonInfo, new RecordItemIndex(8));
            repo.Calculator.NumberPad.Num5Button.Click("36;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num8Button' at 36;44.", repo.Calculator.NumberPad.Num8ButtonInfo, new RecordItemIndex(9));
            repo.Calculator.NumberPad.Num8Button.Click("36;44");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num8Button' at 36;44.", repo.Calculator.NumberPad.Num8ButtonInfo, new RecordItemIndex(10));
            repo.Calculator.NumberPad.Num8Button.Click("36;44");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.EqualButton' at 51;21.", repo.Calculator.EqualButtonInfo, new RecordItemIndex(11));
            repo.Calculator.EqualButton.Click("51;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Open Navigation') on item 'Calculator.TogglePaneButton'.", repo.Calculator.TogglePaneButtonInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.Calculator.TogglePaneButtonInfo, "Text", "Open Navigation");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
