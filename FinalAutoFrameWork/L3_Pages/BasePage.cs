using FinalAutoFrameWork.Global;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAutoFrameWork.L3_Pages
{
    public class BasePage
    {

         protected ShareStateObjects sso;
        public BasePage(ShareStateObjects xsso)
        {
            this.sso = xsso;
        }

        public void Click(By by)
        {
            sso.driver.FindElement(by).Click();
        }

        public void SendKeys(By by, string txt)
        {
            sso.driver.FindElement(by).SendKeys(txt);
        }

        public string GetText(By by)
        {
            return sso.driver.FindElement(by).Text;
        }

    }
}
