using FinalAutoFrameWork.Global;
using FinalAutoFrameWork.L3_Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace FinalAutoFrameWork.L2_StepDefinitions
{
    [Binding]
    public class RegisterPageSteps
    {
        ShareStateObjects sso;
        public RegisterPageSteps(ShareStateObjects xsso)
        {
            this.sso = xsso;
        }

        [Given(@"the user is on the registration page")]
        public void GivenTheUserIsOnTheRegistrationPage()
        {
            new CommonPage(sso).NavigatetoPage("https://www.advantageonlineshopping.com/#/register");
        }



        [When(@"the user enters valid registration details")]
        public void WhenTheUserEntersValidRegistrationDetails()
        {
            RegisterPage registerPage = new RegisterPage(sso);
            registerPage.FillDetails();
            registerPage.AgreeTerms();
            registerPage.ClickSubmit();

        }


    }
}
