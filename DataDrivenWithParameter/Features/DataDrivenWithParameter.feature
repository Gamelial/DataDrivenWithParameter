Feature: DataDrivenWithParameter

A short summary of the feature

@tag1
Scenario: Valid Registration
	Given I navigate to "https://angularjs.realworld.io/#/register"
	And I click on Sign up 
	And I enter my Username text "Learnwithpride67843"
	And I enter my email text "chugamzyl267@gmail.com"
	And I enter my password text "Chukwudi7949"
	When I click on the Sign up button
	Then I should be able to register successfully
