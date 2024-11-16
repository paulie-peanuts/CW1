def futureInvestmentValue(investmentAmount, monthlyInterestRate, years):
	return investmentAmount * (1 + monthlyInterestRate) ** (years * 12)

def main():
	investmentAmount = float(input("Please enter the investment amount: "))
	annualInterestRate = float(input("Please enter the annual interest rate (as a percentage): "))

	monthlyInterestRate = annualInterestRate / 100 / 12

	print("\nYears\t\tFuture Value")
	print("-----------------------------")

	for years in range(1, 31):
		futureValue = futureInvestmentValue(investmentAmount, monthlyInterestRate, years)
		print(f"{years}\t\t{futureValue:.2f}")

if __name__ == "__main__":
	main()