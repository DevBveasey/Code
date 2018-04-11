# Brandon veasey
#description: This is a caculator menu that allows user to enter two numbers and calculates the answer depending on the option they choose

#get num1 ask user for input and declares it as num1
def getnum1():
    num1= int(input("Enter first number:"))#declares and stores user input
    return num1

#getnum2 ask user for second number and stores it as num2
def getnum2():
    num2= int(input("Enter second number:"))#declares and stores user input
    return num2

# dsp option menu to user and returns their option
def menu():
    print("Calculator Program")
    print(' 1) Addition \n 2) Subtraction \n 3) Multiplication \n 4) Division \n 5) Exit')#print options
    option= int(input("Please choose an option: \n"))#declares and stores user input
    return option

# option #1 addition of the entered numbers
def add(num1,num2):
    calc = num1 + num2
    return calc

# option #2 subtraction of entered numbers
def sub(num1,num2):
    calc = num1 - num2
    return calc

#option #3 mutiplication of entered numbers
def muti(num1,num2):
    calc = num1 * num2
    return calc

# option #4 division of numbers entered
def div(num1,num2):
    calc = num1 / num2
    return calc

def main():
    option = menu() # captures user input
    while (option != 5): #begin of loop
        if (option == 1):#begining of if statment
            print("you chose Addition")
            num1 = getnum1()
            num2 = getnum2()
            calc = add(num1, num2) # passes numbers to function
            print (num1, ' + ', num2, ' = ', calc ,'\n')
            option = menu()
        elif(option == 2):
            print("you chose Subtraction")
            num1 = getnum1()
            num2 = getnum2()
            calc = sub(num1, num2)# passes numbers to function
            print (num1, ' - ', num2, ' = ', calc ,'\n')
            option = menu()
        elif(option == 3):
            print("you chose Mutiplication")
            num1 = getnum1()
            num2 = getnum2()
            calc = muti(num1, num2)# passes numbers to function
            print (num1, ' * ', num2, ' = ', calc ,'\n')
            option = menu()

        elif(option == 4):
            print("you chose Division")
            num1 = getnum1()
            num2 = getnum2()
            calc = div(num1, num2)# passes numbers to function
            print (num1, ' / ', num2, ' = ', calc ,'\n')
            option = menu()

        elif(option == 5):
            print("you chose EXIT")
            option = 5 #declares option so that it cancles loop
        else:
            print('Invalid choice -- please try again.')
            option = menu()

main()
print("End of Program.")#end of program statment