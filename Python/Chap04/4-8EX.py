#BRANDON VEASEY

#DECLARE VARIABLES
num = float(input("Enter positive number & negative number to end: "))
total = 0.0
count = 0

while num >= 0:
   total += num
   num = float(input("Enter positive number & negative number to end: "))
   count += 1
else:
     print('total = ' , format(total,',.2f'))
     print(count, "positive number entered")