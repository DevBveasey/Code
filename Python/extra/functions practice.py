#Brandon Veasey

def sqrMe(num1):
    print("the number squared is", num1 * num1)

num1 = int(input('Enter a number to be squared:(negative number to end) '))

while (num1 > 0):
    sqrMe(num1)
    num1 = int(input('Enter a number to be squared: (negative number to end)'))