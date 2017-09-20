using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDD.SupermarketList._3rdAndMoreScenarios
{
    [Binding]
    public class ListStepDefinitions
    {
        MarketList _list;
        [Given(@"I create a new list")]
        [When(@"I create a new list")]
        public void WhenICreateANewList()
        {
            _list = new MarketList();
        }

        [Then(@"the list has no contents")]
        public void ThenTheListHasNoContents()
        {
            Assert.IsEmpty(_list.Contents);
        }


        [When(@"I add an product to the list")]
        public void WhenIAddAnProductToTheList()
        {
            var product = new MarketProduct();
            _list.Add(product);
        }

        [Then(@"the list contains the product added")]
        public void ThenTheListContainsTheProductAdded()
        {
            Assert.IsNotEmpty(_list.Contents);
        }

        [When(@"I add (.*) Cookies to the list")]
        public void WhenIAddCookiesToTheList(int p0)
        {
            var product = new MarketProduct("Cookie", p0);
            _list.Add(product);
        }

        [Then(@"the list contains a quantity of (.*) cookies")]
        public void ThenTheListContainsAQuantityOfCookies(int p0)
        {
            Assert.AreEqual(_list.GetQuantity("Cookie"), p0);
        }

        [Given(@"I add (.*) '(.*)'")]
        public void GivenIAdd(int p0, string p1)
        {
            var product = new MarketProduct(p1, p0);
            _list.Add(product);
        }

        [Then(@"the list contains a quantity of (.*) '(.*)'")]
        public void ThenTheListContainsAQuantityOf(int p0, string p1)
        {
            Assert.AreEqual(_list.GetQuantity(p1), p0);
        }

        [When(@"I remove '(.*)' from the list")]
        public void WhenIRemoveFromTheList(string p0)
        {
            _list.Remove(p0);
        }

        [Then(@"the list doesnt contains '(.*)'")]
        public void ThenTheListDoesntContains(string p0)
        {
            Assert.AreEqual(_list.GetQuantity(p0), 0);
        }

        [When(@"I remove (.*) '(.*)' from the list")]
        public void WhenIRemoveFromTheList(int p0, string p1)
        {
            _list.Remove(p1, p0);
        }
    }
}

