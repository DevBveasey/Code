# declaring variables and capturing user input
totalHrs = float(input("Enter total hours worked: "))
payRate = float(input("Enter pay rate per hour: "))
overTime = totalHrs - 40
overRate = 2.5
overPay = 0.0
totalPay = 0.0
underHrs = totalHrs - overTime
underPay = underHrs * payRate

#calculating overtime
if totalHrs > 40:
    overPay = overTime * overRate
else:
    print('no over time.')

#calclate total pay
totalPay = underPay + overPay
print("Total pay is $" + format(totalPay, '.2f') + ".")
