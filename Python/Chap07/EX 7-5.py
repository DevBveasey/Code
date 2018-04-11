#Brandon Veasey
# programming Exercise 7-5

def main():

    try:

        # Open numbers.txt file for reading
        infile = open ('charge_accounts.txt', 'r')

        #read contents of file into list
        accounts = infile.readlines()

        #close file
        infile.close()

        #strip /n from each element
        index = 0
        while index < len(accounts):
            accounts[index] = accounts[index].rstrip('\n')
            index += 1

        # get a account number to search for
        accountNum = input("enter account number: ")

        #detirmine if the account is valid
        if accountNum in accounts:
            print("account ", accountNum , " was found.")
        else:
            print("account ", accountNum , " was not found.")

    except IOError:
        print('some type of error on read error')

#call main
main()