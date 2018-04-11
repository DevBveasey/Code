#brandon Veasey
def main():
    # Open numbers.txt file for reading
    infile = open ('numbers.txt', 'r')

    # Declare variables
    num1 = 0
    num2 = 0
    num3 = 0

    #read file keep track of counter, accumulate total
    num1 = int(infile.readline())
    num2 = int(infile.readline())
    num3 = int(infile.readline())

    # Close file
    infile.close()

    # Calculate average
    avg = ((num1 + num2 + num3) / 3)

    # Display the average of the numbers in the file
    print ('the average of the 3 numbers are:' , avg)

# Call the main function.main()
main()