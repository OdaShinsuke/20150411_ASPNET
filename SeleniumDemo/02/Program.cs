using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;

namespace _02 {
  class Program {
    static void Main(string[] args) {
      IWebDriver driver = new InternetExplorerDriver();
      driver.Navigate().GoToUrl("http://www.bing.com");
      Console.WriteLine(driver.Title);
      Console.ReadKey();
      driver.Quit();
    }
  }
}
