#Brandon Veasey

# Declare constants for the percentage increase in tuition per year,
# and the starting tuition amount.
percentIncrese = .03
tuition = 8000
# Calculate and print amount of increase each year.
newTuition = (tuition * percentIncrese) + tuition
#header
print("Year\tProjected Tuition(per Semester)")
print("-------------------------------------")
#for loop to generate list
for year in range (1,6,1):
    print(year, '\t ', format(newTuition, ',.2f'))
    newTuition = (newTuition * percentIncrese) + newTuition
    tuition = newTuition