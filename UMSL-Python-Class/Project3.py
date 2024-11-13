weight1 = float(input("Please enter the weight for package 1: "))
price1 = float(input("Please enter the price for pacakge 1: "))

weight2 = float(input("Please enter the weight for package 2: "))
price2 = float(input("Please enter the price of pacakge 2: "))

price_per_unit1 = price1 / weight1
price_per_unit2 = price2 / weight2

if price_per_unit1 < price_per_unit2:
	print ("Package 1 has the best price.")
else:
	print ("Package 2 has the best price.")