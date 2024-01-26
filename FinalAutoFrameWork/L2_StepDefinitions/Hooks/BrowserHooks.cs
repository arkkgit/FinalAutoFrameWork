using FinalAutoFrameWork.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;


//move as required
[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(4)]

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
            string runOnGrid = TestContext.Parameters["grid"] ?? "no";
            string browsername = TestContext.Parameters["browser"] ?? "chrome";

            if (runOnGrid == "yes")
            {
                setBrowserGrid();
              
            }
            else
            {
                setBrowser(browsername);
            }
            
            sso.driver.Manage().Window.Maximize();
            sso.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            sso.driver.Url = EnvHooks.EnvData["app.url"];
        }

        
        
        
        [AfterScenario]
        public void TearDownBrowser()
        {
            sso.driver.Quit();
        }


        public void setBrowser(string bname)
        {
            switch(bname.ToLower())
            {
                case "chrome":
                    sso.driver = new ChromeDriver();
                    break;
                
                case "edge":
                    sso.driver = new EdgeDriver();
                    break;
                
                case "firefox":
                    sso.driver = new FirefoxDriver();
                    break;

                default:
                    sso.driver = new ChromeDriver();
                    break;



            }

           
        }



        public void setBrowserGrid() // has potential to to input of broswer, version, platform , etc etc and use switch
        {
            var GridURI = new Uri("http://192.168.1.10:4444");
            ChromeOptions options = new ChromeOptions();
            //options.PlatformName = "Windows 11";
            //options.BrowserVersion = 

            sso.driver = new RemoteWebDriver(GridURI, options);
        }

    }
}
