using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDD.Demo.VerySimple.SupermarketList
{
    [Binding]
    public class ListStepDefinitions
    {
        MarketList _list;
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
    }
}

