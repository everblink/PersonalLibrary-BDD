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

    }
}
