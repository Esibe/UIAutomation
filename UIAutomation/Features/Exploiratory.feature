Feature: Exploiratory

#A simple user journey on the Interactive Investors website

@tag1
	
	Scenario: "Trading Account" user journey
	Given I navigate to "https://www.ii.co.uk/"
	And I click on Services 
	When I click on Trading account 
	Then Trading account page should display successfully


Scenario: "SIPP charges" user journey
	Given I navigete to "https://www.ii.co.uk/"
	And I click on Pensions
	When I click on SIPP charges 
	Then SIPP charges page should display successfully 


	Scenario: "Top UK shares" user journey
	Given I navigate to "https://www.ii.co.uk/"
	And I click on Investments
	When I click on Top UK shares
	Then Top UK shares page should display successfully 


	Scenario: "Model portfolios" user journey
	Given I navigate to "https://www.ii.co.uk/"
	And T click on Help & learning
	When I click on Model portfolios
	Then Model portfolios page should display successfully
