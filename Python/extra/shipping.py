#author brandon veasey
weight = float(input("Enter shipping weight:"))#declares and stores user input

#statments decide shipping cost based on weight
#prints out shipping cost
if weight <= 2:
    print('shipping cost $1.50')
elif weight > 2 and weight <= 6:
      print('shipping cost $3.00')
elif weight > 6 and weight <= 10:
      print('shipping cost $4.00')
elif weight > 10:
      print('shipping cost $4.75')