Feature: OrderingSpecs
	In order to order stuff from the website
	As a customer
	I want to be shown my basket

@mytag
Scenario: Ordering a book
	Given I am on the detail page of '50 Tinten Grijs'
	And I am logged in as a registered customer
	When I press Buy
	Then there is one item in my shopping basket
	Then the ordered item is in my shopping basket	

Scenario: Getting special discount
	Given I am on the detail page of '50 Tinten Grijs'
	And I am logged in as a registered customer
	And I have already 2 item in my shopping basket
	When I press Buy
	Then there are 3 items in my shopping basket
	Then I get a reduction of 50% 

