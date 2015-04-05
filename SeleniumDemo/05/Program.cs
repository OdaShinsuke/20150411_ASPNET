using OpenQA.Selenium.IE;
using System;
using System.Threading;

namespace _05 {
  class Program {
    static void Main(string[] args) {
      var driver = new InternetExplorerDriver();
      try {
        driver.Navigate().GoToUrl("http://www.bing.com");
        var txt条件 = driver.FindElementByName("q");
        txt条件.SendKeys("SQLWorld");
        txt条件.Submit();
        Thread.Sleep(3000); // 次の画面に遷移するまで待つ
        var lbl件数 = driver.FindElementByClassName("sb_count");
        Console.WriteLine(lbl件数.Text);
        Console.ReadKey();
      }
      finally {
        driver.Quit();
      }
    }
  }
}
