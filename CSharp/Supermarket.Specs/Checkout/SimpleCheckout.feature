Feature: On checking out, a receipt with useful information is printed

	In order to check that I did not pay too much
	As a customer
	I want to see from which parts the total amount I have paid consists of.


Background: Products we have in stock
	Given we have the following products in stock:
	| Name                    | Unit Price | Tax Rate |
	| Milk 1l                 | 1.00€      | 20%      |
	| Butter 250g             | 1.50€      | 20%      |
	| Gherkins 350g           | 3.00€      | 20%      |
	| Book "Harry Potter"     | 12.00€     | 10%      |
	| Book "Cucumber Slicing" | 8.00€      | 10%      |



Scenario: Scanning just products with the same tax rate. The tax contained in the total price is shown.
	Given I scan the following products at the cash desk:
	| Product       |
	| Milk 1l       |
	| Gherkins 350g |

	When I check out

	Then the receipt contains this information:
		"""
		Milk 1l         1.20€
		Gherkins 350g   3.60€
		---------------------
		Total           4.80€
		Incl. 20% VAT   0.80€
		"""
