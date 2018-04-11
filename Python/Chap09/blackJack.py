#Brandon Veasey
#description: This is a blackJack game to be played between two users

import random

def create_deck():
    #  create deck of cards
    deck = {'Ace of Spades' : 1, '2 of Spades' :2, '3 of Spades' :3, '4 of Spades' :4,
            '5 of Spades' :5, '6 of Spades' :6, '7 of Spades' :7, '8 of Spades' :8,
            '9 of Spades' :9, '10 of Spades' :10, 'Jack of Spades' : 10, 'Queen of Spades' :10,
            'King of Spades' :10,

            'Ace of Hearts' : 1, '2 of Hearts' :2, '3 of Hearts' :3, '4 of Hearts' :4,
            '5 of Hearts' :5, '6 of Hearts' :6, '7 of Hearts' :7, '8 of Hearts' :8,
            '9 of Hearts' :9, '10 of Hearts' :10, 'Jack of Hearts' : 10, 'Queen of Hearts' :10,
            'King of Hearts' :10,

            'Ace of Clubs' : 1, '2 of Clubs' :2, '3 of Clubs' :3, '4 of Clubs' :4,
            '5 of Clubs' :5, '6 of Clubs' :6, '7 of Clubs' :7, '8 of Clubs' :8,
            '9 of Clubs' :9, '10 of Clubs' :10, 'Jack of Clubs' : 10, 'Queen of Clubs' :10,
            'King of Clubs' :10,

            'Ace of Diamonds' : 1, '2 of Diamonds' :2, '3 of Diamonds' :3, '4 of Diamonds' :4,
            '5 of Diamonds' :5, '6 of Diamonds' :6, '7 of Diamonds' :7, '8 of Diamonds' :8,
            '9 of Diamonds' :9, '10 of Diamonds' :10, 'Jack of Diamonds' : 10, 'Queen of Diamonds' :10,
            'King of Diamonds' :10,
            }
    #  return deck
    return deck

def main():
    deal = int(input('how many cards would you like to be dealt: '))
    # Create deck
    deck = create_deck()
    hand1, hand2 = Deal_cards(deck, deal)
    calc_winnerhand(hand1, hand2)

def Deal_cards(deck,deal):
    hand1 = 0
    hand2 = 0
    if deal > len(deck)/2:
        deal = len(deck)/2

    for count in range(deal):
        card, value = random.choice(list(deck.items()))
        print("player one was delt", card)
        if not card.startswith('Ace'):
            hand1 += value
        elif hand1 > 10:
            hand1 += 1
        else:
            hand1 += 11
        print("player Two was delt", card)
        if not card.startswith('Ace'):
            hand2 += value
        elif hand2 > 10:
            hand2 += 1
        else:
            hand2 += 11
        return hand1 , hand2

def calc_winnerhand(hand1, hand2):
    if hand1 > 21 and hand2 > 21:
        print("player one bust, player two bust, you both lose")
    elif hand1 > 21:
        print("player one bust, player two wins.")
    elif hand2 > 21:
        print("player two bust, player one wins.")
    elif hand1 > hand2:
        print("player one wins, with a value of", hand1)
    elif hand2 > hand1:
        print("player two wins, with a value of", hand2)
    else:
        print("Good job you tied.")

main()