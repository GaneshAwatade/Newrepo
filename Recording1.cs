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
    ///The Recording1 recording.
    /// </summary>
    [TestModule("2767e751-817a-4af8-b59d-0bf21e1e5d1a", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MycalcuRepository repository.
        /// </summary>
        public static MycalcuRepository repo = MycalcuRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num2Button' at 62;34.", repo.Calculator.NumberPad.Num2ButtonInfo, new RecordItemIndex(0));
            repo.Calculator.NumberPad.Num2Button.Click("62;34");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.PlusButton' at 18;33.", repo.Calculator.PlusButtonInfo, new RecordItemIndex(1));
            repo.Calculator.PlusButton.Click("18;33");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num3Button' at 41;23.", repo.Calculator.NumberPad.Num3ButtonInfo, new RecordItemIndex(2));
            repo.Calculator.NumberPad.Num3Button.Click("41;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.EqualButton' at 35;25.", repo.Calculator.EqualButtonInfo, new RecordItemIndex(3));
            repo.Calculator.EqualButton.Click("35;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Text2' at 12;9.", repo.Calculator.NumberPad.Text2Info, new RecordItemIndex(4));
            repo.Calculator.NumberPad.Text2.Click("12;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num5Button' at 29;54.", repo.Calculator.NumberPad.Num5ButtonInfo, new RecordItemIndex(5));
            repo.Calculator.NumberPad.Num5Button.Click("29;54");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Calculator.PlusButton' at 30;23.", repo.Calculator.PlusButtonInfo, new RecordItemIndex(6));
            repo.Calculator.PlusButton.DoubleClick("30;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num2Button' at 60;15.", repo.Calculator.NumberPad.Num2ButtonInfo, new RecordItemIndex(7));
            repo.Calculator.NumberPad.Num2Button.Click("60;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.EqualButton' at 32;33.", repo.Calculator.EqualButtonInfo, new RecordItemIndex(8));
            repo.Calculator.EqualButton.Click("32;33");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'Calculator.EqualButton' at 32;33.", repo.Calculator.EqualButtonInfo, new RecordItemIndex(9));
            repo.Calculator.EqualButton.Click(System.Windows.Forms.MouseButtons.Right, "32;33");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Standard') on item 'Calculator.Header'.", repo.Calculator.HeaderInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.Calculator.HeaderInfo, "Text", "Standard");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}