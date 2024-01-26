using FinalAutoFrameWork.Global;
using FinalAutoFrameWork.Utilities;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace FinalAutoFrameWork.L2_StepDefinitions.Hooks
{
    [Binding]
    public class LivingDocHooks
    {
        ISpecFlowOutputHelper ldo;
        ShareStateObjects sso;
        public LivingDocHooks(ISpecFlowOutputHelper ldo, ShareStateObjects sso)
        { 
            this.ldo = ldo;
            this.sso = sso;
        }

        [AfterStep]
        public void attachssafterEachStep()
        {
            ldo.WriteLine("custom line ...");
            ldo.AddAttachment(getSS());
        }


        public string getSS()
        {
            var r= Utils.GenerateRandomNumber(3);
            sso.driver.TakeScreenshot().SaveAsFile("ss"+r+".png");
            return "ss" + r + ".png";
        }
    }
}
