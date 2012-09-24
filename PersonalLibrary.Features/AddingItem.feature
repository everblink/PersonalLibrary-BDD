Feature: AddingItem
	In order to have a libary application
    We need to have the ability to add items
    For logged in users

@mytag
Scenario: User must be logged in to navigate to Add items screen
	Given the user is logged in
	And they have clicked on Add Items link
	Then the user should be redirected to the Add Items page

Scenario: Adding Item entry should error if one record is missing
    Given The user has entered all the information except the Item Name
    And they have clicked on the Add button
    Then the user should be displayed "Please add name of item"

