Feature: SignUp
	In order to use the benefit of the website
	I will need to first sign up

@mytag
Scenario: Valid Sign Up
	Given I navigate to the website
	And I enter the username 
	And I enter the email 
	And I enter the password 
	When I click on Sign up
	Then I should be able to register successfully 