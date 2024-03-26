using System;
using EasyAutomationFramework;
using java.sql;
using OpenQA.Selenium;

var drive = new Web();
drive.StartBrowser();
drive.Navigate("https://www.google.com");
drive.AssignValue(TypeElement.Name, "q", "Teste").element.SendKeys(Keys.Enter);
