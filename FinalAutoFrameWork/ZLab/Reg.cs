using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinalAutoFrameWork.ZLab
{
    public class Reg
    {

        [Test]
        public void reg()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);  
            driver.Url = "https://www.advantageonlineshopping.com/#/register";
            driver.FindElement(By.Name("usernameRegisterPage")).SendKeys("TestsAb89");
            driver.FindElement(By.Name("emailRegisterPage")).SendKeys("TesstAb89@gmail.co.uk");
            driver.FindElement(By.Name("passwordRegisterPage")).Click();
            driver.FindElement(By.Name("passwordRegisterPage")).SendKeys("Test@1234");
            
            driver.FindElement(By.Name("confirm_passwordRegisterPage")).Click();
            driver.FindElement(By.Name("confirm_passwordRegisterPage")).SendKeys("Test@1234");
           
            driver.FindElement(By.Name("i_agree")).Click();
            driver.FindElement(By.Id("register_btn")).Click();
            Thread.Sleep(10000);

            Assert.AreEqual("https://www.advantageonlineshopping.com/#/", driver.Url);
        }
    }
}
