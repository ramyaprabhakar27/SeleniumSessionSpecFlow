@demo
Feature: AddStudentsWithExample
	In order to avoid silly mistakes
	As a admin
	I want to be told the students are added

@demo
Scenario Outline: Add New Students With Example
	Given I Enter the name as <Name>
	And I Select the class as <Class>
	And I Enter the roll number as <RollNo>
	And I Select the gender as <GenderType>
	And I save the student data
	Then I should see the added student

	Examples: 
	| Name   | Class | RollNo | GenderType |
	| Kam    | V     | 189    | Female     |
	| Barsha | VI    | 190    | Female     |
	| Ramya  | VII   | 191    | Female     |
	| Test   | VIII  | 129    | Male       |