#Brandon veasey

print("Calculator Program")
print(' 1) Addition \n 2) Subtraction \n 3) Multiplication \n 4) Division \n 5) Exit')#print options
option= int(input("Please choose an option: \n"))#declares and stores user input
while (option > 0): #begin of loop
    if (option == 1):#begining of if statment
        print("you chose addition")
        num1= int(input("Enter first number:"))#declares and stores user input
        num2= int(input("Enter second number:"))#declares and stores user input
        print (num1, ' + ', num2, ' = ', num1 + num2 ,'\n')
        print("Calculator Program")
        print(' 1) Addition \n 2) Subtraction \n 3) Multiplication \n 4) Division \n 5) Exit')#print options
        option= int(input("Please choose an option: \n"))#declares and stores user input
    elif(option == 2):
        print("you chose Subtraction")
        num1= int(input("Enter first number:"))#declares and stores user input
        num2= int(input("Enter second number:"))#declares and stores user input
        print(num1, ' - ', num2, ' = ', num1 - num2,'\n')
        print("Calculator Program")
        print(' 1) Addition \n 2) Subtraction \n 3) Multiplication \n 4) Division \n 5) Exit')#print options
        option= int(input("Please choose an option: \n"))#declares and stores user input
    elif(option == 3):
        print("you chose Multiplication")
        num1= int(input("Enter first number:"))#declares and stores user input
        num2= int(input("Enter second number:"))#declares and stores user input
        print(num1, ' * ', num2, ' = ', num1 * num2 ,'\n')
        print("Calculator Program")
        print(' 1) Addition \n 2) Subtraction \n 3) Multiplication \n 4) Division \n 5) Exit')#print options
        option= int(input("Please choose an option: \n"))#declares and stores user input
    elif(option == 4):
        print("you chose Division")
        num1= int(input("Enter first number:"))#declares and stores user input
        num2= int(input("Enter second number:"))#declares and stores user input
        print(num1, ' / ', num2, ' = ', num1 / num2 ,'\n')
        print("Calculator Program")
        print(' 1) Addition \n 2) Subtraction \n 3) Multiplication \n 4) Division \n 5) Exit')#print options
        option= int(input("Please choose an option: \n"))#declares and stores user input
    elif(option == 5):
        print("you chose EXIT")
        option = -1 #declares option so that it cancles loop
    else:#catches all numbers not used and prompts user to re-enter option
        print('Invalid choice -- please try again.')
        print("Calculator Program")
        print(' 1) Addition \n 2) Subtraction \n 3) Multiplication \n 4) Division \n 5) Exit')#print options
        option= int(input("Please choose an option: \n"))#declares and stores user input

print("End of Program.")#end of program statment