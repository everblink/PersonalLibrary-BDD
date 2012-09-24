using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using NUnit.Framework;
using PersonalLibrary_BDD.Controllers;
using PersonalLibrary_BDD.Models;
using TechTalk.SpecFlow;
using System.Web.Mvc;

namespace PersonalLibrary.Features
{
    [Binding]
    class RegisterUser
    {
        AccountController _controller;
        ActionResult _result;
        RegisterModel _registerModel;

       [When(@"the user goes to the register user screen")]
        public void WhenTheUserGoesToTheRegisterUserScreen()
       {
           _controller = new AccountController();
           _result = _controller.Register();
       }

        [Then(@"the register user view should be displayed")]
        public void ThenTheRegisterUserViewShouldBeDisplayed()
        {
            Assert.IsInstanceOf<ViewResult>(_result);
            Assert.IsEmpty(((ViewResult)_result).ViewName);
            Assert.AreEqual("Register",
                   _controller.ViewData["Title"],
                   "Page title is wrong");
        }

        [Given(@"The user has entered all the information")]
        public void GivenTheUserHasEnteredAllTheInformation()
        {
            _registerModel = new RegisterModel
            {
                UserName = "user" + new Random(1000).NextDouble().ToString(CultureInfo.InvariantCulture),
                Email = "test@dummy.com",
                Password = "test123",
                ConfirmPassword = "test123"
            };
            _controller = new AccountController();
        }

        [When(@"He Clicks on Register button")]
        public void WhenHeClicksOnRegisterButton()
        {
            _result = _controller.Register(_registerModel);
        }

        [Then(@"He should be redirected to the home page")]
        public void ThenHeShouldBeRedirectedToTheHomePage()
        {
            const string expected = "Index";
            Assert.IsNotNull(_result);
            Assert.IsInstanceOf<ViewResult>(_result);
        }

    }
}
