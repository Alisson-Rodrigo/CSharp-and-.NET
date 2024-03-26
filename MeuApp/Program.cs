using System;
using EasyAutomationFramework;
using OpenQA.Selenium;

namespace MeuApp {
    class Program {
        static void Main(string[] args) {
            // Instanciando o driver
            var driver = new Web();

            driver.StartBrowser();
            driver.Navigate("https://www.google.com");
            driver.AssignValue(TypeElement.Name, "q", "oi").element.SendKeys(Keys.Enter);
            driver.CloseBrowser();

        }
    }
}