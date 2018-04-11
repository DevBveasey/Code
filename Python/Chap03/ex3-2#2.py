# Programming Exercise 3-1
# Using If -Else Statements and Nested If-Else Statements

# Get the number for the day of the week.
day = int(input('Enter a number (1-7) for the day of the week: '))

# Determine the name of the day of the week, and display it.
if day == 1:
    print('Monday')
else:
    if day == 2:
        print('Tuesday')
    else:
        if day == 3:
            print('Wednesday')
        else:
            if day == 4:
                print('Thursday')
            else:
                if day == 5:
                    print('Friday')
                else:
                    if day == 6:
                        print('Saturday')
                    else:
                        if day == 7:
                            print('Sunday')
                        else:
                            print('Error: Please enter a number in the range 1-7.')