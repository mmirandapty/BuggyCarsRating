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
5. Build the project

## How to run the tests?
In Visual Studio menubar, go to Test and then click Test Explorer.
Click Run All Tests In View button.

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

## Technology Used
- nunit 3.13.2
- NUnit3TestAdapter 3.11.0
- SpecFlow 3.8.14
- SpecFlow.Assist.Dynamic 1.4.2
- SpecFlow.NUnit 3.8.14
- SpecFlow.Plus.LivingDocPlugin 3.8.35
- SpecFlow.Tools.MsBuild.Generation 3.8.14
- Selenium.WebDriver 3.141.0
- Selenium.WebDriver.ChromeDriver 90.0.4430.2400
