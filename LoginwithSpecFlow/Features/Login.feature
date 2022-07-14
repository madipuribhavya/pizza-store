Feature: Login

@mytag
Scenario: Successful Login with Valid Credentials
	Given User is at the Login Page
	When User enter 'bhavya' and 'indra'
	And Click on the LogIn button
	Then the result should be 0