using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program {
    static void Main(string[] args){
        IWebDriver driver = new ChromeDriver(@"C:\Users\dboze\Documents\Local-Repos\Web Scraper\Web-Scraper\bin\Debug\net5.0\chromedriver.exe");

        IWebElement textbox = driver.FindElement(By.Name("q"));
        textbox.SendKeys("Dog Pictures");

        textbox.Submit();
        driver.Quit();
    }
}

