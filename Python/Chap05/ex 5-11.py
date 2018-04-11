#Brandon Veasey
import random

#generates random number
num1 = random.randint(1, 500)
num2 = random.randint(1, 500)

#detirmin the correct answer
comAnswer = num1 + num2

#ask user for answer
print('enter the sum of ',num1, ' + ' , num2,)
userAnswer = float(input())

 #if statment detirmines if the user entered the correct answer
if comAnswer == userAnswer:
    print('Correct answer – Good Work!')
else:
    print('Incorrect... The correct answer is: ', comAnswer)