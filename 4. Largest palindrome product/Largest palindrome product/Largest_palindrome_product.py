val = int(input("Enter how many digits the palindrome you wanted to find: "))
val = 10 ** val
test_value = 0
palindrome_test_one=0
palindrome_test_two=0
latest_palindrome=0
for number in range(100, val):
        for second_number in range(100, val):
            test_value = number * second_number
            palindrome_test_one, palindrome_test_two = [int(a) for a in str(test_value)], [int(a) for a in str(test_value)]
            palindrome_test_two.reverse()
            if (palindrome_test_one == palindrome_test_two):
                    if number * second_number > latest_palindrome:
                        print(number,second_number)
                        latest_palindrome = number * second_number

print(latest_palindrome)