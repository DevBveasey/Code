#Brandon Veasey

# main function
def feet_to_inches():
    #declare variables
    numFeet = float(input('Enter the number of feet: ')) # Get the number of feet from the user.
    numInches = numFeet * 12 #calculate number of inches
    print(numFeet, "feet = ",  format(numInches, ',.2f'), " inches")# Display the corresponding number of inches.

#function call
feet_to_inches()

