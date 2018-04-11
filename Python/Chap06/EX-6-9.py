#brandon Veasey
def main():

    # Declare local variables
    num1 = 0
    count = 0
    total = 0
    avg = 0

    try:
       # Open numbers.txt file for reading
       infile = open ('numbers.txt', 'r')

       for line in infile:
           count += 1
           num1 = float(line)
           total += num1

       # Close file
       infile.close()
       # Calculate average
       avg = (total / count)

       # Display the average of the numbers in the file
       print ('the average of the ', count, ' numbers are:' , avg)

    except IOError:
        print('some type of error on read error')

    except ValueError:
        print('error about non numeric data')

    except:
        print ('error')

# Call the main function.
main()