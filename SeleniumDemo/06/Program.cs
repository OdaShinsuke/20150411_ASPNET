using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace _06 {
  class Program {
    static void Main(string[] args) {
      var driver = new InternetExplorerDriver();
      try {
        driver.Navigate().GoToUrl("http://www.bing.com");
        var txt条件 = driver.FindElementByName("q");
        txt条件.SendKeys("SQLWorld");
        txt条件.Submit();
        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
        wait.Until(ExpectedConditions.TitleIs("SQLWorld - Bing"));
        var lbl件数 = driver.FindElementByClassName("sb_count");
        Console.WriteLine(lbl件数.Text);
        Console.ReadKey();
      } finally {
        driver.Quit();
      }
    }
  }
}
