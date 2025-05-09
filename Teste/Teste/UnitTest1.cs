using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Teste
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;  
        [TestInitialize]
        public void AntesDeTodos()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [TestMethod]
        public void CasoDeTeste()
        {
            //Navegar até a página de login
           
            Assert.AreEqual("Swag Labs", driver.Title);
        }

        [TestMethod]
        public void CasoDeTeste2()
        {
            var usernameInput = driver.FindElement(By.Id("user-name"));
           var passwordInput = driver.FindElement(By.Id("password"));
            

            usernameInput.SendKeys("Kaiky");
            passwordInput.SendKeys("senha");

            Assert.AreEqual("Kaiky", usernameInput.GetAttribute("value"));
            Assert.AreEqual("senha", passwordInput.GetAttribute("value"));
        }

        [TestMethod]
        public void CasoDeTeste3()
        {
            var usernameInput = driver.FindElement(By.Id("user-name"));
            var passwordInput = driver.FindElement(By.Id("password"));
            var buttonLogin = driver.FindElement(By.Id("login-button"));

            usernameInput.SendKeys("standard_user");
            passwordInput.SendKeys("secret_sauce");

            buttonLogin.Click();
            Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url);



        }

        [TestCleanup]
        public void DepoisDeTodos()
        {
        
        }

    }
}