#author brandon veasey
length1 = float(input("Enter rectangle 1 length:"))#declares and stores user input
width1 = float(input("Enter rectangle 1 width:"))#declares and stores user input
length2 = float(input("Enter rectangle 2 length:"))#declares and stores user input
width2 = float(input("Enter rectangle 2 width:"))#declares and stores user input
areaOne = length1 * width1 #calculates area of rectangle 1
areaTwo = length2 * width2 #calculates area of rectangle 1

# if statment decides which rectangle has more area or if their the same
if (areaOne > areaTwo):
    print('rectangle one has a larger area')
elif (areaTwo > areaOne):
    print('rectangle two has a larger area')
elif (areaTwo == areaOne):
     print('both rectangles have the same area')