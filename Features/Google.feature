Feature: Google Search

@tc001
Scenario: Search for Helena Carona Linkedin
	Given I am at website "google"
	When I search for "Helena Carona"
	Then I validate Helenas LinkedIn is displayed