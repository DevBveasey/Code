# Declare variables to hold the temperatures.
celsius = 0.0
fahrenheit = 0.0

# Get the Celsius temperature.
celsius = float(input("Enter a Celsius temperature: "))

# Calculate the Fahrenheit equivalent.
fahrenheit = ((celsius *2.0) + 30.0)

# Display the Fahrenheit temperature.
print ("Celsius = ", format(fahrenheit, '.2f'), "degrees Fahrenheit.")