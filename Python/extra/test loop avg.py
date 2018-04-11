#BRANDON VEASEY

#DECLARE VARIABLES
testSum = 0.0
name = input("Enter full name seperated by one space: ")
avg = 0.0
grade = float(input("Enter test grade & negative number to end: "))
count = 0

while grade >= 0:
    testSum += grade
    grade = float(input("Enter test grade & negative number to end: "))
    count += 1
else:
    avg = testSum / count
    print('test average = ' , format(avg,',.2f'))
    print(  "you entered "  ,count, " test")
    if avg >= 92:
        print(name , 'You got an A')
    elif avg >= 83:
        print(name , 'You got an B')
    elif avg >= 75:
        print(name , 'You got an C')
    else:
        print(name , "you failed")