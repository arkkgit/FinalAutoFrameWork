using FinalAutoFrameWork.Global;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace FinalAutoFrameWork.L2_StepDefinitions.Hooks
{
    [Binding]
    public class BrowserHooks
    {
        ShareStateObjects sso;

        public BrowserHooks(ShareStateObjects xsso) {
            this.sso = xsso;
        }



        [BeforeScenario]
        public void SetUpBrowser()
        {
            sso.driver = new ChromeDriver();
            sso.driver.Manage().Window.Maximize();
            sso.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            sso.driver.Url = "https://www.advantageonlineshopping.com/";
        }

        
        
        
        [AfterScenario]
        public void TearDownBrowser()
        {
            //sso.driver.Quit();
        }

    }
}
