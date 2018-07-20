@demo
Feature: AddStudentsWithTable
	In order to avoid silly mistakes
	As a admin
	I want to be told the students are added

@demo
Scenario: Add New Students With Table
	Given I am at the Demo Page
	And I login as admin
	When I Add students
	| Name | Class          | RollNo | GenderType    |
	| Kam  | V | 189    | Female |
	Then I should see the added students

@demo
Scenario: Add New Students With Table in Bulk
	Given I am at the Demo Page
	And I login as admin
	When I Add students in Bulk
	| Name   | Class | RollNo | GenderType |
	| Kam    | V     | 189    | Female     |
	| Barsha | VI    | 190    | Female     |
	| Ramya  | VII   | 191    | Female     |
	| Test   | VIII  | 129    | Male       |
	Then I should see the added students

