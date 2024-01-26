using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAutoFrameWork.Utilities
{
    public  class DriverUtils
    {

        public static void waiitUntilTheSpinningWheelDisappers(IWebDriver driver)
        {
           
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(drv =>
            {
                // Find all elements matching the specified CSS selector
                IList<IWebElement> loaderElements = drv.FindElements(By.CssSelector("div.loader[style*='display: none;']"));

                // Check if the number of found elements is greater than or equal to 2
                return loaderElements.Count >= 2;
            });

        }
    }
}
