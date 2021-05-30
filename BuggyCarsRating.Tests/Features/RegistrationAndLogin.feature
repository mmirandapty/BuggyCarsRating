Feature: Registration and Login

Background:
	Given I am in registration page

@registration
Scenario: Register with valid data
	Given I enter my user detail
	| Username | FirstName | LastName | Password | ConfirmPassword |
	| random   | John      | Doe      | Password123! | Password123!|
	When I click register button
	Then I will be registered
		And I will be able to login using the registered login credentials

@registration
Scenario: Register an existing user
	Given I enter my user detail
	| Username | FirstName | LastName | Password | ConfirmPassword |
	| john     | John      | Doe      | Password123! | Password123!|
	When I click register button
	Then I will see user already exist error

@login
Scenario: Login with valid credentials
	Given I enter username john and password Password123!
	When I click login button
	Then I should be logged in

@login
Scenario: Login with invalid credentials
	Given I enter username notregisteredusername and password incorrectpassword
	When I click login button
	Then I should not be logged in

@logout
Scenario: Logout
	Given I am logged in
	When I click logout button
	Then I should be logged out