Feature: LoggingIntoTheAppliation
	In order to log into the application
	As a user
	I want to be redirected to my home page

Scenario: Log into the application
	Given I am on the login page of the application
	And I fill out 'Jos' as a username
	And I fill out 'den beste' as a password
	When I press login
	Then I am redirected to the general home page

