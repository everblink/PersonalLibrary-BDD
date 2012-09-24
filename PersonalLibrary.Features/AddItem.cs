using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using PersonalLibrary_BDD.Controllers;
using PersonalLibrary_BDD.Models;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace PersonalLibrary.Features
{
    [Binding]
    class AddItem
    {
        AccountController _controller;
        LoginModel _loginModel;
        ActionResult _result;
        AddItemController _addItemController;
        ItemModel _itemModel;

        [Given(@"the user is logged in")]
        public void GivenTheUserIsLoggedIn()
        {
            _loginModel = new LoginModel
            {
                UserName = "Jeff",
                Password = "password",
                RememberMe = true
            };
            _controller = new AccountController();
        }

        [Given(@"they have clicked on Add Items link")]
        public void GivenTheyHaveClickedOnAddItemsLink()
        {
            _addItemController = new AddItemController();
            _result = _addItemController.Index();
        }

        [Then(@"the user should be redirected to the Add Items page")]
        public void ThenTheUserShouldBeRedirectedToTheAddItemsPage()
        {
            const string expected = "Index";
            Assert.IsNotNull(_result);
            Assert.IsInstanceOf<ViewResult>(_result);
        }

        [Given(@"The user has entered all the information except the Item Name")]
        public void GivenTheUserHasEnteredAllTheInformationExceptTheItemName()
        {
            _itemModel = new ItemModel
            {
                ItemName = string.Empty,
                ItemFormat = "DVD",
                ItemType = "Movie"
            };
            _addItemController = new AddItemController();
        }

        [Given(@"they have clicked on the Add button")]
        public void GivenTheyHaveClickedOnTheAddButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the user should be displayed ""(.*)""")]
        public void ThenTheUserShouldBeDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }


    }
}
