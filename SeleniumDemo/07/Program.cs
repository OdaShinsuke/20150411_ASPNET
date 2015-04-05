using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Drawing.Imaging;

namespace _07 {
  class Program {
    static void Main(string[] args) {
      var driver = new InternetExplorerDriver();
      try {
        driver.Navigate().GoToUrl("http://sqlworld.org/event/20150425/");
        var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
        wait.Until(ExpectedConditions.TitleIs("SqlWorld :: SQLWorld★大阪#30"));
        driver.GetScreenshot().SaveAsFile(
          Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 
            + @"\\sqlworld.png",
          ImageFormat.Png);
        Console.ReadKey();
      } finally {
        driver.Quit();
      }
    }
  }
}
