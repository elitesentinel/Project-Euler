

sum_of_numbers=0

for number in range(1000):
    if number % 5:
        sum_of_numbers += number
    if number % 3:
        sum_of_numbers += number

print(sum_of_numbers)