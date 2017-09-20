Feature: SupermarketList
	A simple supermarket list that we can add and remove products from

@mytag
Scenario: A new list no contents
	When I create a new list
	Then the list has no contents
