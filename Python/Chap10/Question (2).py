#Brandon Veasey
#Program 10-8
import question
def main():
    # variable declarations
    attempts = 10
    p1Points = 0
    p2Points = 0

    #creates questions list
    questions = get_questions()

    #print title
    print( "time for the quiz\n")

    # for loop to go through 10 questions
    for count in range(attempts):
        # if else to detirmine which player
        if count % 2 ==0:
            player = " first"
        else:
            player = " second "
        print( 'questions for the ', player , " player")

        #populate next question
        current = questions[count]
        print(current)

        #collect user input for answer
        user_answer = int(input(' enter your solution(a number between 1 & 4):'))
        print('\n')

        #if else to check current answer is currect and add point for score
        if current.isCorrect(user_answer):
            if player == " first":
                p1Points += 1
            else:
                p2Points += 1
    # display player scores
    print('Player 1 scored', p1Points, ' points')
    print('Player 2 scored', p2Points, ' points', '\n')

    #detirmine winner
    if p1Points > p2Points:
        print(' Player 1 wins!!!')
    else:
        print(' Player 2 wins!!!')
def get_questions():

    questions = []

    # Create questions and add to list.
    question1 = question.Question('How many days are in a ' + \
                                  'lunar year?', '354', '365', \
                                  '243', '379', 1)
    questions.append(question1)
    question2 = question.Question('What is the largest planet?', \
                                  'Mars', 'Jupiter', 'Earth', \
                                  'Pluto', 2)
    questions.append(question2)
    question3 = question.Question('What is the largest kind of ' + \
                                  'whale?', 'Orca whale', \
                                  'Humpback whale', \
                                  'Beluga whale', 'Blue whale', 4)
    questions.append(question3)
    question4 = question.Question('Which dinosaur could fly?', \
                                  'Triceratops', 'Tyranosaurus Rex', \
                                  'Pteranodon', 'Diplodocus', 3)
    questions.append(question4)
    question5 = question.Question('Which of these Winnie the Pooh ' + \
                                  'characters is a donkey?', \
                                  'Pooh', 'Eeyore', 'Piglet', \
                                  'Kanga', 2)
    questions.append(question5)
    question6 = question.Question('What is the hottest planet?', \
                                  'Mars', 'Pluto', 'Earth', \
                                  'Venus', 4)
    questions.append(question6)
    question7 = question.Question('Which dinosaur had the ' + \
                                  'largest brain compared to body' + \
                                  ' size?', 'Troodon', 'Stegosaurus', \
                                  'Ichthyosaurus', 'Gigantoraptor', 1)
    questions.append(question7)
    question8 = question.Question('What is the largest type ' + \
                                  'of penguins?', \
                                  'Chinstrap penguins', \
                                  'Macaroni penguins', \
                                  'Emperor penguins', \
                                  'White-flippered penguins', 3)
    questions.append(question8)
    question9 = question.Question("Which children's story " + \
                                  'character is a monkey?', \
                                  'Winnie the Pooh', \
                                  'Curious George', 'Horton', \
                                  'Goofy', 2)
    questions.append(question9)
    question10 = question.Question('How long is a year on Mars?', \
                                   '550 Earth days', \
                                   '498 Earth days', \
                                   '126 Earth days', \
                                   '687 Earth days', 4)
    questions.append(question10)

    return questions

#call main
main()