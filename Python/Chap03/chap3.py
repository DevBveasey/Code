# Programming Exercise 3-1
# Using simple If Statments


# Get the number for the day of the week.
day = int(input('Enter a number (1-7) for the day of the week: '))

# Determine the name of the day of the week, and display it.
if day == 1:
    print('Monday')
if day == 2:
    print('Tuesday')
if day == 3:
    print('Wednesday')
if day == 4:
    print ('Thursday')
if day == 5:
    print ('Friday')
if day == 6:
    print ('Saturday')
if day == 7:
    print ('Sunday')
if day > 7 or day < 1:
    print ('Error: Please enter a number in the range 1-7.')