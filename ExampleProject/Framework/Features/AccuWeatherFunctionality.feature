Feature: AccuWeatherFunctionality
	I am user
	I want to see the accurate weather. 


Background: Open AccuWeather Main Page
    Given I have consented to data usage
    

Scenario: Search city
	When I input 'New York' in the search field
    And Search result is displayed
	And I click on the first result New York
	Then The city weather page header contains the city name New York from the search

Scenario: Recent locations
    When I input 'London' in the search field
    And I click on the first search result London
    And I go back to the main page
    Then Main page is displayed
    When I choose the first city in Recent locations
    Then The city weather page header contains the city name London from the search

Scenario: Current location label
    When I click search field
    Then I use current location label is displayed

