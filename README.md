# BuggyCarsRating
Testing automation using NUnit, Specflow, and Selenium for Buggy Cars Rating (https://buggy.justtestit.org/).

## Pre-requisites
- Visual Studio 2019 version 16.10
- .Net Core 3.1
- Git

## Setup
1. Clone the repository to your local machine
2. Open Visual Studio and open the solution
3. Install "SpecFlow for Visual Studio 2019" extension
4. Build the project 🤞

## How to run the tests?
In Visual Studio menubar, go to Test and then click Test Explorer. And then click Run All Tests In View button. Easy!

## How to generate the LivingDoc?
What is a LivingDoc? It is a shareable HTML Gherkin feature execution report.

To generate, make sure you installed the LivingDoc CLI first, as a global dotnet tool using command prompt.
```
dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
```

Then execute below command to generate the document with test results.
```
livingdoc test-assembly [YOUR_PROJECT_DIRECTORY]\BuggyCarsRating\BuggyCarsRating.Tests\bin\Debug\netcoreapp3.1\BuggyCarsRating.Tests.dll -t [YOUR_PROJECT_DIRECTORY]\BuggyCarsRating\BuggyCarsRating.Tests\bin\Debug\netcoreapp3.1\TestExecution.json
```

## Testing Approach
Here are the features and functionalities I'm able to cover in this test automation.

**1. Registration and Login**
  - Register with valid data
  - Register an existing user
  - Login with valid credentials
  - Login with invalid credentials
  - Logout

**2. Overall Rating Page**
  - Display list of all registered models
  - Check pagination
  - Check sorting feature
  - Check broken images

**3. Navigation**
  - Check for broken links

### Outstanding Tests to Cover
1. Profile Information Update
2. Make Details Page
  - Models list
    - Pagination
    - Sorting
3. Model Details Page
  - Voting and comment form
  - Comments list
4. Security
5. Performance Testing 
