final_account_value = float(input("Enter the final account value: "))
monthly_interest_rate = (float(input("Enter the annual interest rate in percent: "))/100)/12
number_of_months = int(input("Enter the number of years: "))*12
initial_deposit_amount = final_account_value/((1+monthly_interest_rate)**number_of_months)
print("The initial deposit amount is " + str(initial_deposit_amount))