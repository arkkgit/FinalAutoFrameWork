using FinalAutoFrameWork.Global;
using FinalAutoFrameWork.L3_Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace FinalAutoFrameWork.L2_StepDefinitions
{
    [Binding]
    public class HomePageSteps
    {
        ShareStateObjects sso;
        public HomePageSteps(ShareStateObjects xsso)
        {
            this.sso = xsso;
        }

        [Then(@"the user should be redirected to the home page")]
        public void ThenTheUserShouldBeRedirectedToTheHomePage()
        {
            HomePage homePage = new HomePage(sso);
            var actualURL = homePage.getURL();
            Assert.AreEqual("https://www.advantageonlineshopping.com/#", actualURL);
        }

    }
}
