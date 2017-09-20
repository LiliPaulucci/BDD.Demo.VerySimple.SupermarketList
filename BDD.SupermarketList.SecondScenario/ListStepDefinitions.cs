using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDD.SupermarketList.SecondScenario
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
            var product = new object();
            _list.Add(product);
        }

        [Then(@"the list contains the product added")]
        public void ThenTheListContainsTheProductAdded()
        {
            Assert.IsNotEmpty(_list.Contents);
        }
    }
}

