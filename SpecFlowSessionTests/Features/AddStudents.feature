@demo
Feature: AddStudents
	In order to avoid silly mistakes
	As a admin
	I want to be told the students are added

@demo
Scenario: Add New Students
	Given I am at the Demo Page
	And I login as admin
	When I Add students
	Then I should see the added students

