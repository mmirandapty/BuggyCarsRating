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
Wait! What is a LivingDoc?
It is an extension to our SpecFlow-BDD-Framework. LivingDoc displays Gherkin feature specifications and their automated validation results as a single source of truth outside of an IDE – within your browser. In short, it is an automation reporting made easy - automatically generate, display, share, review, and discuss your scenarios with your stakeholders via any browser.

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
