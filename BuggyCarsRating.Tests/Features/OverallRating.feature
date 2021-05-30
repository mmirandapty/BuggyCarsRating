Feature: Overall Rating
	List of all registered models.

Background:
	Given I am in overall rating page

@list
Scenario: Display list of all registered models
	Then I will see a list of registered models

@pagination
Scenario: Manually enter page 2 and navigate to next page
	Given I manually enter page 2
	When I press enter key
		And I click next page button
	Then current page should be 3

@pagination
Scenario: Manually enter page 2 and navigate to previous page
	Given I manually enter page 2
	When I press enter key
		And I click previous page button
	Then current page should be 1

@list @image
Scenario: Manually enter page 3 and display image thumbnail for each model
	Given I manually enter page 4
	When I press enter key
		And I click previous page button
	Then all model image thumbnail should display

@list @image
Scenario: Manually enter page 5 and display image thumbnail for each model
	Given I manually enter page 6
	When I press enter key
		And I click previous page button
	Then all model image thumbnail should display

@list @sorting
Scenario: Sort list by Rank in page 1
	When I click column header Rank
	Then list will be sorted as below
	| Rank |
	| 1    |
	| 2    |
	| 3    |
	| 4    |
	| 5    |