Feature: Bicycle

Scenario: Check bicycle page header

	Given I have opened 'StartPageBicycle' page
	Then Bicycle start page should be displayed
		And Bicycle start page`s header should be 'BICYCLE CLAIM'
