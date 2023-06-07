using NUnit.Framework;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;
using UIAutomation.PageObject;
using UIAutomation.StepDefination;

namespace UIAutomation
{
    [Binding]
    public class ExploiratoryStepDefinitions
    {
        readonly ExploiratoryPage exploiratoryPage;

    public ExploiratoryStepDefinitions()
        {
            exploiratoryPage = new ExploiratoryPage();
        }




        [Given(@"I navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string url)
        {
            exploiratoryPage.NavigateToWebsite(url);
        }

        [Given(@"I click on Services")]
        public void GivenIClickOnServices()
        {
            exploiratoryPage.ClickOnServices();
        }

        [When(@"I click on Trading account")]
        public void WhenIClickOnTradingAccount()
        {
            exploiratoryPage.ClickOnTradingAccount();
        }

        [Then(@"Trading account page should display successfully")]
        public void ThenTradingAccountPageShouldDisplaySuccessfully()
        {
            Assert.That(exploiratoryPage.IsOpenAnAccountDisplayed(), Is.True);
        }

        [Given(@"I navigete to ""([^""]*)""")]
        public void GivenINavigeteTo(string url)
        {
            exploiratoryPage.NavigateToWebsite(url);
        }

        [Given(@"I click on Pensions")]
        public void GivenIClickOnPensions()
        {
            exploiratoryPage.ClickOnPensions();
        }

        [When(@"I click on SIPP charges")]
        public void WhenIClickOnSIPPCharges()
        {
            exploiratoryPage.ClickOnSIPPCharges();
        }

        [Then(@"SIPP charges page should display successfully")]
        public void ThenSIPPChargesPageShouldDisplaySuccessfully()
        {
            Assert.That(exploiratoryPage.IsOpenASIPPDisplayed(), Is.True);
        }

        [Given(@"I click on Investments")]
        public void GivenIClickOnInvestments()
        {
            exploiratoryPage.ClickOnIvestments();
        }

        [When(@"I click on Top UK shares")]
        public void WhenIClickOnTopUKShares()
        {
            exploiratoryPage.ClickOnTopUKShares();
        }

        [Then(@"Top UK shares page should display successfully")]
        public void ThenTopUKSharesPageShouldDisplaySuccessfully()
        {
            Assert.That(exploiratoryPage.IsMostSoldSharesDisplayed(), Is.True);
        }

        [Given(@"T click on Help & learning")]
        public void GivenTClickOnHelpLearning()
        {
            exploiratoryPage.ClickOnHelpAndLearning();
        }

        [When(@"I click on Model portfolios")]
        public void WhenIClickOnModelPortfolios()
        {
            exploiratoryPage.ClickOnModelPortfolios();
        }

        [Then(@"Model portfolios page should display successfully")]
        public void ThenModelPortfoliosPageShouldDisplaySuccessfully()
        {
            Assert. That(exploiratoryPage.IsPastPerfomanceDisplayed(), Is.True);
        }
    }
}
