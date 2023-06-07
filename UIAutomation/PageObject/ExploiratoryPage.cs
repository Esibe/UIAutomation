using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAutomation.Utilities;

namespace UIAutomation.PageObject
{
    internal class ExploiratoryPage
    {

        public ExploiratoryPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver? driver;

        IWebElement Services => driver.FindElement(By.XPath("//*[@id='root']/div/header/div/nav/ul/li[1]/div[1]/span"));
        IWebElement TradingAccount => driver.FindElement(By.XPath("//*[@id=\"navigationItemServices\"]/div/div[1]/ul/li[2]/a"));
        IWebElement OpenAnAccount => driver.FindElement(By.XPath("//*[@id=\"root\"]/div/main/div/div/div[2]/div[2]/div/div[1]/div/div/div[2]/div[1]/a/span"));
        IWebElement Pensions => driver.FindElement(By.XPath("//*[@id='root']/div/header/div/nav/ul/li[2]/div[1]/span"));
        IWebElement SIPPCharges => driver.FindElement(By.XPath("//*[@id='navigationItemPensions']/div/div[1]/ul/li[3]/a"));
        IWebElement OpenASIPP => driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div/div[2]/div[2]/div/div[1]/div/div/div[2]/div[1]/a/span"));
        IWebElement Investments => driver.FindElement(By.XPath("//*[@id='root']/div/header/div/nav/ul/li[3]/div[1]/span"));
        IWebElement TopUKShares => driver.FindElement(By.XPath("//*[@id='navigationItemInvestments']/div/div[1]/ul/li[2]/a"));
        IWebElement MostSoldShares => driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div/div[2]/div[2]/div/div[1]/div/div/div[1]/ul/li[4]/a"));
        IWebElement HelpAndLearning => driver.FindElement(By.XPath("//*[@id='root']/div/header/div/nav/ul/li[4]/div[1]/span"));
        IWebElement ModelPortfolios => driver.FindElement(By.XPath("//*[@id='navigationItemHelpLearning']/div/div[1]/ul/li[4]/a"));

        IWebElement PastPerfomance => driver.FindElement(By.XPath("//*[@id='root']/div/main/div/div/div[2]/div[2]/div/div[1]/div/div/div/ul/li[2]/a"));



        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickOnServices()
        {
            Services.Click();
        }
        public void ClickOnTradingAccount()
        {
            TradingAccount.Click();
        }

        public bool IsOpenAnAccountDisplayed()
        {
            return OpenAnAccount.Displayed;
        }

        public void ClickOnPensions()
        {
            Pensions.Click();
        }

      public void ClickOnSIPPCharges()
        { SIPPCharges.Click();
        }
        
         public bool IsOpenASIPPDisplayed()
        {
            return OpenASIPP.Displayed; 
        }
        

        public void ClickOnIvestments()
        {
            Investments.Click();
        }

        public void ClickOnTopUKShares()
        {
            TopUKShares.Click();
        }

        public bool IsMostSoldSharesDisplayed()
        {
            return MostSoldShares.Displayed;
        }


        public void ClickOnHelpAndLearning()
        {
            HelpAndLearning.Click();
        }
        public void ClickOnModelPortfolios()
        {
            ModelPortfolios.Click();
        }

        public bool IsPastPerfomanceDisplayed()
        {
            return PastPerfomance.Displayed;
        }







    }
}
