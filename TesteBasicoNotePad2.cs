using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using System;
using System.Threading;

namespace NotePadTest
{
    [TestClass]
    public class TesteBasicoNotePad2
    {
        [TestMethod]
        public void TestMethod1()
        {
            WindowsDriver<WindowsElement> NotePadSession;
            AppiumOptions desiredCapabilities = new AppiumOptions();
            desiredCapabilities.AddAdditionalCapability("app", @"C:\Windows\system32\notepad.exe");
            NotePadSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), desiredCapabilities);

            NotePadSession.FindElementByName("Editor de Texto").SendKeys("Teste, teste...");
            NotePadSession.FindElementByName("Formatar").Click();
            NotePadSession.FindElementByName("Fonte...").Click();
            NotePadSession.FindElementByName("Corbel").Click();
            NotePadSession.FindElementByName("Itálico").Click();
            NotePadSession.FindElementByName("Uma linha abaixo").Click();
            NotePadSession.FindElementByName("26").Click();
            NotePadSession.FindElementByName("OK").Click();
            NotePadSession.FindElementByName("Editor de Texto").SendKeys("Tudo certo!");
            Thread.Sleep(3000);
            NotePadSession.FindElementByName("Fechar").Click();
            Thread.Sleep(3000);
            NotePadSession.FindElementByName("Não Salvar").Click();


        }
    }
}
