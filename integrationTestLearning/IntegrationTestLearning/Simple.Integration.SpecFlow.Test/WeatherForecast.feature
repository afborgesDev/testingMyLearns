Feature: WeatherForecast

A short summary of the feature


Scenario: Get endpoint works as expected
	Given I have the application up
	When I perform a request to the get endpoint
	Then I receive a Ok status code
