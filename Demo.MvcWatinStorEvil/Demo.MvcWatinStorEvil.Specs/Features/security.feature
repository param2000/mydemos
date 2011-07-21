Feature: Security
	In blah blah
	As a boo hoo
	I want awesome

Scenario: Good Password
	Given username bob and password 1234
	When I login
    Then I should be logged in as me


	Scenario: Bad Password
	Given username wrong and password 1234
	When I login
    Then I should not be logged in as me