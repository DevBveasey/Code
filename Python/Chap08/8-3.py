#Brandon Veasey
# converts a date entered in the form of mm/dd/yyyy to a print out of the month then the date, year

def main():
    # Receive user input
    date1 = input ('Enter date in the form mm/dd/yyyy: ')

    # Split according to /
    date = date1.split('/')

    # creates month list
    Month_List = ['January', 'February', 'March', 'April', 'May', 'June', 'July'\
                  ,'August', 'September', 'October', 'November', 'December']
    #declare index
    index = 0

    #while loop converts date to int
    while index < len(date):
        date[index]= int(date[index])
        index += 1

    #find written month
    month = Month_List[date[0]-1]

    #disply new date
    print(month , date[1], date[2])

# Call the main function.
main()