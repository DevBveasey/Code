#Brandon Veasey
# Programming Exercise 8-7

def main():
    # Local variables
    numupper = 0
    numlower = 0
    numspace = 0
    numdigits = 0
    data = ''

    # Open file text.txt for reading.
    infile = open('text.txt', 'r')

    # Read in data from the file.
    data = infile.read()

    # Step through each character in the file.
    # Determine if the character is uppercase,
    # lowercase, a digit, or space, and keep a
    # running total of each.
    for ch in data:
        if ch.isupper():
            num_upper = numupper + 1
        if ch.islower():
            num_lower = numlower + 1
        if ch.isdigit():
            num_digits = numdigits + 1
        if ch.isspace():
            num_space = numspace + 1

    # Close the file.
    infile.close()

    # Display the totals.
    print('Uppercase letters:', numupper)
    print('Lowercase letters:', numlower)
    print('Digits:', numdigits)
    print('Spaces:', numspace)

# Call the main function.
main()