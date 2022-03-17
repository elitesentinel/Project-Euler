
is_it_smallest= False
test_num = 200000000

while is_it_smallest == False:
    test_num += 1
    number = 2
    while number < 21:

        if test_num % number == 0:
            if number == 20:
                is_it_smallest = True
                number += 1
            else:
                number +=1

        else:
            break

print(test_num)