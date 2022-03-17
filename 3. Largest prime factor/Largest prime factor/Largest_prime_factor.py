
from typing import Dict


val = int(input("Enter the number to find largest prime factor: " ))
number = 2
prime_factors = []
while number < val + 1:
    while val % number == 0:
        prime_factors.append(number)
        val = val / number
    number += 1
prime_factors = list(Dict.fromkeys(prime_factors))
print(prime_factors)