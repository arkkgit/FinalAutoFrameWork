using FinalAutoFrameWork.Utilities;
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

       // [Test]
        public void reg()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);  
            driver.Url = "https://www.advantageonlineshopping.com/#/register";

            var uname = "Tuser" + Utils.GenerateRandomNumber(4);
            driver.FindElement(By.Name("usernameRegisterPage")).SendKeys(uname);
            driver.FindElement(By.Name("emailRegisterPage")).SendKeys(uname+"@gmail.co.uk");
            driver.FindElement(By.Name("passwordRegisterPage")).Click();
            driver.FindElement(By.Name("passwordRegisterPage")).SendKeys("Test@1234");
            
            driver.FindElement(By.Name("confirm_passwordRegisterPage")).Click();
            driver.FindElement(By.Name("confirm_passwordRegisterPage")).SendKeys("Test@1234");
           
            driver.FindElement(By.Name("i_agree")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("register_btn")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Forward();
            Thread.Sleep(4000);
            //driver.FindElement(By.Id("register_btn")).Click();
            Assert.AreEqual("https://www.advantageonlineshopping.com/#/", driver.Url);
        }


       
    }
}
