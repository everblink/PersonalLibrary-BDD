﻿Feature: RegisterUser
	Register a user 
    As a member of the site
    So that they can log in to use its features

@mytag
Scenario: Navigate to the Register Page
	When the user goes to the register user screen
	Then the register user view should be displayed

Scenario: On Successful registration the user should be redirected to Home Page
    Given The user has entered all the information
    When He Clicks on Register button
    Then He should be redirected to the home page
