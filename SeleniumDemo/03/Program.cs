using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;

namespace _03 {
  class Program {
    static void Main(string[] args) {
      IWebDriver driver = new InternetExplorerDriver();
      driver.Navigate().GoToUrl("http://www.bing.com");
      IWebElement element = driver.FindElement(By.Name("q"));
      element.SendKeys("セレニウム　ウェブドライバー");
      Console.ReadKey();
      driver.Quit();
    }
  }

}
