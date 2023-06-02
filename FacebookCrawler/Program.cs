using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;

namespace FacebookCrawler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = null;

            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--window-size=1000,1080");
            
            driver = new ChromeDriver();

            driver.Url = "https://dantri.com.vn/xa-hoi/trai-nghiem-thuc-te-dung-vneid-thay-can-cuoc-cong-dan-tai-san-bay-noi-bai-20230602172154335.htm";
            IWebElement element = driver.FindElement(By.CssSelector("h1.title-page.detail"));
            Console.WriteLine($"Crawled title: {element.Text}");
            Console.ReadLine();
        }
    }
}
