 using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace WebDriverdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\sohesh\Downloads\chromedriver_win32");
            driver.Url = "http://automationpractice.com";
   
            var element = driver.FindElement(By.XPath("//a[@href='#homefeatured']"));
          
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy(0,650);");
            driver.FindElement(By.XPath("//*[@id='homefeatured']/li[1]/div/div[2]/div[2]/a[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[1]/span")).Click();
            driver.FindElement(By.XPath("//*[@id='homefeatured']/li[2]/div/div[2]/div[2]/a[2]")).Click();

            js.ExecuteScript("window.scrollBy(0,250);");
            driver.FindElement(By.Id("quantity_wanted")).Clear();
            driver.FindElement(By.Id("quantity_wanted")).SendKeys("3");
            driver.FindElement(By.Name("Submit")).Click();
            driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[1]/span")).Click();
            driver.FindElement(By.XPath("//*[@id='block_top_menu']/ul/li[3]/a")).Click();
            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("selectProductSort")));
            dropdown.SelectByText("Price: Lowest first");
            js.ExecuteScript("window.scrollBy(0,250);");
            driver.FindElement(By.XPath("//*[@id='center_column']/ul/li/div/div[2]/div[2]/a[1]/span")).Click();
            driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[1]/span")).Click();
            driver.FindElement(By.XPath("//*[@id='header']/div[3]/div/div/div[3]/div/a")).Click();

            driver.FindElement(By.Name("quantity_1_1_0_0")).Clear();
            driver.FindElement(By.Name("quantity_1_1_0_0")).SendKeys("5");
            
            driver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]")).Click();
            driver.Close();



        }
    }
}
