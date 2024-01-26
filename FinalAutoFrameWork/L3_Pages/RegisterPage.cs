using FinalAutoFrameWork.Global;
using FinalAutoFrameWork.L2_StepDefinitions.Hooks;
using FinalAutoFrameWork.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinalAutoFrameWork.L3_Pages
{
    public class RegisterPage : BasePage
    {

        public RegisterPage(ShareStateObjects sso): base(sso)
        {
            
        }

        // Attributes of the page
        By username = By.Name("usernameRegisterPage");
        By email = By.Name("emailRegisterPage");
        By pword = By.Name("passwordRegisterPage");
        By cpword = By.Name("confirm_passwordRegisterPage");
        By agree = By.Name("i_agree");
        By regButton = By.Id("register_btn");
        By fname = By.Name("first_nameRegisterPage");
        By lname = By.Name("last_nameRegisterPage");



        //Actions on the page
        public void FillDetails ()
        {
            var uname = "Tuser" + Utils.GenerateRandomNumber(4);
            SendKeys(username, uname);
            //sso.driver.FindElement(username).SendKeys(uname);
            SendKeys(email, uname + "@gmail.co.uk");
            //sso.driver.FindElement(email).SendKeys(uname + "@gmail.co.uk");

            Click(pword);
            //sso.driver.FindElement(pword).Click();
            SendKeys(pword, "Test@1223");
            // sso.driver.FindElement(pword).SendKeys("Test@1234");
            Click(cpword);
            SendKeys(cpword, "Test@1223");
            /*sso.driver.FindElement(cpword).Click();
            sso.driver.FindElement(cpword).SendKeys("Test@1234");*/

            SendKeys(fname, DataHooks.RegData["firstname"]);
            SendKeys(lname, DataHooks.RegData["lastname"]);

        }

        public void AgreeTerms()
        {
            Click(agree);
            DriverUtils.waiitUntilTheSpinningWheelDisappers(sso.driver);
        }

        public void ClickSubmit()
        {
            Click(regButton);
            DriverUtils.waiitUntilTheSpinningWheelDisappers(sso.driver);

        }


       
    }
}
