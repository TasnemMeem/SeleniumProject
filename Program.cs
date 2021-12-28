using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


namespace SeleniumProjectOPUS
{
    class Program
    {
        public static string webUrl = "https://bongobd.com/"; 
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(webUrl);
            driver.Manage().Window.Maximize();

            PlayVideo(driver);
            Console.WriteLine("Video Play Successfully");
        }


        public static void PlayVideo(IWebDriver driver)
        {
            //Search Box Clear
            driver.FindElement(By.XPath("//*[@id='root']/ div/div/div/div[2]/header/div/div/div[2]/div[2]/div[1]/div[2]/input")).Clear();
            Thread.Sleep(5000);

            //Search Box Input Value
            driver.FindElement(By.XPath("//*[@id='root']/ div/div/div/div[2]/header/div/div/div[2]/div[2]/div[1]/div[2]/input")).SendKeys("Panther");
            Thread.Sleep(5000);

            //Search Box Input Enter Press
            driver.FindElement(By.XPath("//*[@id='root']/ div/div/div/div[2]/header/div/div/div[2]/div[2]/div[1]/div[2]/input")).SendKeys(Keys.Return);
            Thread.Sleep(5000);

            //Click Movie List Image
            driver.FindElement(By.XPath("//*[@id='root']/div/div/div/div[3]/div/div/div/div[1]/div/div[2]/div/a/div/div/div/div[1]/div/img")).Click();
            
            Thread.Sleep(5000);
        }
    }
}
