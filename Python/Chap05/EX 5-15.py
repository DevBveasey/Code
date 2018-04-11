#Brandon Veasey

#prompt user to enter score and store variable
score1 = float(input('Enter score 1: '))
score2 = float(input('Enter score 2: '))
score3 = float(input('Enter score 3: '))
score4 = float(input('Enter score 4: '))
score5 = float(input('Enter score 5: '))
count = 1
total = 0
totalScore = 5.0

# Begining of the output
print("score", '\t', " numeric grade", '\t','\t', "letter grade")
print("----------------------------------------------")

#average
total = score1 + score2 + score3 + score4 + score5
average = total / totalScore
format(average, ".2f")

#declare a method to print the score board
def print1():
    print("score 1:", "\t", score1, "\t", "\t", determine_grade(score1))
    print("score 2:", "\t", score2, "\t", "\t", determine_grade(score2))
    print("score 3:", "\t", score3, "\t", "\t", determine_grade(score3))
    print("score 4:", "\t", score4, "\t", "\t", determine_grade(score4))
    print("score 5:", "\t", score5, "\t", "\t", determine_grade(score5))
	
#method to determines letter grade
def determine_grade(grade):
    if grade >= 90 and grade <= 100:
        return 'A'
    elif grade >= 80 and grade <= 89:
        return 'B'
    elif grade >= 70 and grade <= 79:
        return 'C'
    elif grade >= 60 and grade <= 69:
        return 'D'
    else:
        return 'F'

#print
print1()
print("--------------------------------------------")
#print total average with letter grade
print("Average Score","\t", average, "\t", determine_grade(average) )