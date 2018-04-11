#Brandon Veasey

#declare variables
budget = float(input('Enter amount budgeted for the month: '))
amountSpent = 0.0
num1 = float(input('Enter an amount spent(0 to quit): '))

#while loop accumulates amount spent
while num1 > 0:
    amountSpent = amountSpent + num1
    num1 = float(input('Enter an amount spent(0 to quit): '))

#display budget and amount spent
print('Budgeted: $',format(budget,',.2f'))
print('Spent: $', format(amountSpent,',.2f'))

#if statment to detirmin statment
if amountSpent > budget:
    print('You are',amountSpent - budget, 'over budget. PLAN BETTER!')
elif amountSpent == budget:
    print('Spending matches budget. GOOD PLANNING!')
else:
    print('You are',budget - amountSpent, 'under budget. WELL DONE!')
