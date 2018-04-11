# Task 1:  Copy and paste this program into PyCharm and run it.
# Task 2: Add the code to determine and print the Letter Grade of the student.

# This program gets four test scores
# displays average.

# Get the  test sum scores.
testSum= 0.0
count = int(input('Enter number of test you want to enter: '))
for count in range (1,count + 1,1):
    testSum += float(input('Enter test grade: '))


# Calculate the average test score.
avg = testSum/count


if avg >= 92:
    print('You got an A')
elif avg == 2:
    print('You got an B')
elif avg == 3:
    print('You got an C')
elif avg > 100 or avg < 0:
    print('Error enter a grade between 0-100')
else:

# Print the average.
    print('You got an F cuz you suck!')