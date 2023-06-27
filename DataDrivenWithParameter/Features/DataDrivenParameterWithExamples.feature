Feature: DataDrivenParameterWithExamples

A short summary of the feature

@tag1
Scenario Outline: Data Driven With Example
	#Given I navigate to "https://angularjs.realworld.io/#/register"
	#And I click on Sign up 
	#And I enter my Username text "<Username>"
	#And I enter my email text "<Email>"
	#And I enter my password text "<Password>"
    #When  I click on the Sign up button
	#Then I should be able to register successfully

	Examples: 
	| Username   | Email             | Password   |
	| Blessing02 | blesing@gmail.com | blessing08 |
	| emeka 1    | emeka@gmail.com   | emekao73   |
	| one        | onw@gmail.com     | one2356    |

