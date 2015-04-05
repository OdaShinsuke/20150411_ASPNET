using System;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace _08 {
  class Program {
    static void Main(string[] args) {
      var driver = new InternetExplorerDriver();
      try {
        driver.Navigate().GoToUrl("http://sqlworld.org/event/20150425/");
        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
        wait.Until(ExpectedConditions.TitleIs("SqlWorld :: SQLWorld★大阪#30"));
        driver.FindElementByName("name").SendKeys("あなたのお名前");
        driver.FindElementByName("email").SendKeys("あなたのE-Mail");
        driver.FindElementByName("commentText").SendKeys(@"宜しくお願いします！
懇親会：参加");
        Console.ReadKey();
        driver.FindElementByName("Post Comment").Submit();
        Console.ReadKey();
      } finally {
        driver.Quit();
      }
    }
  }
}
