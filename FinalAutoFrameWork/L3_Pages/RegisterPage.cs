using FinalAutoFrameWork.Global;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAutoFrameWork.L3_Pages
{
    public class RegisterPage
    {
        ShareStateObjects sso;
        public RegisterPage(ShareStateObjects xsso)
        {
            this.sso = xsso;
        }

        // Attributes of the page
        By username = By.Name("usernameRegisterPage");



        //Actions on the page
        public void FillDetails ()
        {
            sso.driver.FindElement(username).SendKeys("abcd1212");
        }

        public void AgreeTerms()
        {

        }

        public void ClickSubmit()
        {

        }
    }
}
