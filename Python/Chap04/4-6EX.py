#brandon veasey
#display user info
print("celslus\t\tfahrenheit")
print("---------------------")

#for loop to generate list
for celslus in range (0,21,1):
    fahrenheit =(celslus * 9/5 + 32)#caculates fehrenheit
    print(celslus,'\t\t', format(fahrenheit,',.2f') )#prints celsus and fehrenheit(rounded)