__author__ = 'Brandon Veasey'
# program excepts 20 whole numbers and provides lowest highest average and total.

#creates an empty list
num_list = []

#accumulater value
Total = 0

#add numbers to list
for count in range (1,21,1):
    # get number
    num = int(input('enter a number'))
    Total += num # accumulates total
    # append number to list
    num_list.append(num)

#print lowest highest average and total.
print()
print('the lowest value is', min(num_list))
print('the highest value is', max(num_list))
print('the total of the list is', Total)
print('the average of the list is' , Total / 20)