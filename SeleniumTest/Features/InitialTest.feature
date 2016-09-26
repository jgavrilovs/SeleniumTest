Feature: InitialTest
	In order to test web driver
	I want to open www.google.com
	And check if it loads correctly

Scenario: Open Google
	Given I have opened page with URL 'https://www.google.com/'
	Then search page should be visible
