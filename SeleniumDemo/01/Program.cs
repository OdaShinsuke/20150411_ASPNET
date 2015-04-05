using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;

namespace _01 {
  class Program {
    static void Main(string[] args) {
      IWebDriver driver = new InternetExplorerDriver();
      Console.ReadKey();
      driver.Quit();
    }
  }
}
