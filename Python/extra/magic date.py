#author Brandon Veasey

#input and declare variables
day= int(input("enter day in numeric form:"))#declares and stores user input
month= int(input("enter month in numeric form:"))#declares and stores user input
year= int(input("enter the last two digits of the year in numeric form:"))#declares and stores user input
sentinal = 1
#check month validity
while sentinal == 1:
    if month > 12 or month < 1:
      print()
      print('sorry that is an invalid month')
      month= int(input("enter month in numeric form:"))#declares and stores user input

    elif day > 31 or day <1:
     print()
     print('sorry that is an invalid day')
     day= int(input("enter day in numeric form:"))#declares and stores user input

    elif year > 99 or year < 1:
        print()
        print('sorry that is an invalid year')
        year= int(input("enter the last two digits of the year in numeric form:"))#declares and stores user input
    else:
        print()
        print ('Valid date entered')
        sentinal = 2
        print()

    if day * month == year:
        print(day, '/' , month , '/' , year , ' is a magic date')
    else:
        print(day, '/' , month , '/' , year , ' is not a magic date')