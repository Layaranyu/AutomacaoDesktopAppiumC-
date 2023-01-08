using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;
using System.Security.Principal;
using System.Threading;

namespace NotePadTest
{
    [TestClass]
    public class TesteBasicoNotePad
    {
        [TestMethod]
        public void TestMethod1()
        {
            WindowsDriver<WindowsElement> NotePadSession;
            AppiumOptions desiredCapabilities = new AppiumOptions();
            desiredCapabilities.AddAdditionalCapability("app", @"C:\Windows\system32\notepad.exe");
            NotePadSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), desiredCapabilities);

            NotePadSession.FindElementByName("Editor de Texto").SendKeys("Testando...");
            NotePadSession.FindElementByName("Editor de Texto").SendKeys(Keys.Return);
            NotePadSession.FindElementByName("Editor de Texto").SendKeys("Testando2...");
            Thread.Sleep(3000);
            NotePadSession.FindElementByName("Editor de Texto").SendKeys(Keys.Control + "n" );
            Thread.Sleep(3000);
            NotePadSession.FindElementByName("Não Salvar").Click();
            Thread.Sleep(3000);
            NotePadSession.FindElementByName("Fechar").Click();












        }
    }
}
