using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;

namespace _04 {
  class Program { 
    static void Main(string[] args) { 
      IWebDriver driver = new InternetExplorerDriver(); 
      driver.Navigate().GoToUrl("http://www.bing.com"); 

      IWebElement elementByName = driver.FindElement(By.Name("q")); 
      elementByName.SendKeys("セレニウム　ウェブドライバー"); 

      IWebElement elementById = driver.FindElement(By.Id("sb_form_q")); 
      elementById.SendKeys(" ID で取ったお"); 

      IWebElement elementByCss = driver.FindElement(
        By.CssSelector("input.b_searchbox")); 
      elementByCss.Clear(); 
      elementByCss.SendKeys("CssSelector で");  

      Console.ReadKey(); 
      driver.Quit(); 
    }
  } 
}
