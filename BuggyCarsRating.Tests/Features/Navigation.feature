Feature: Navigation

@navigation
Scenario: Navigate back to home page from popular make page
	Given I navigate to https://buggy.justtestit.org/make/c0bm09bgagshpkqbsuag
	When I click logo link
	Then I should be sent back to home page

@navigation
Scenario: Navigate back to home page from popular model page
	Given I navigate to https://buggy.justtestit.org/model/c0bm09bgagshpkqbsuag%7Cc0bm09bgagshpkqbsuh0
	When I click logo link
	Then I should be sent back to home page

@navigation
Scenario: Navigate back to home page from overall rating page
	Given I navigate to https://buggy.justtestit.org/overall
	When I click logo link
	Then I should be sent back to home page