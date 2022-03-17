fibonacci_one = 1
fibonacci_two = 2
changer_value = 0
sum_of_numbers = 2
while changer_value < 4000000:
    changer_value = fibonacci_two + fibonacci_one
    fibonacci_one = fibonacci_two
    fibonacci_two = changer_value
    if fibonacci_two % 2 == 0:
        sum_of_numbers += changer_value


print(sum_of_numbers)