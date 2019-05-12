n = int(input())

for _ in range(n):
    numbers = list(reversed([int(x) for x in input()]))
    
    total = 0
    for i, num in enumerate(numbers):
        if i % 2 == 0:
            total += num
        else:
            # every other number from the back shall be multiplied by two
            digits = [int(c) for c in str(num * 2)]

            # if the value of num * 2 has more than one digit, then sum the digits together until only one is left.
            # 9 * 2 = 18 becomes 1 + 8 = 9
            # A loop is not strictly neccessary since 18 is the largest one and is handled by one iteration.
            while len(digits) > 1:
                digits = [int(c) for c in str(sum(digits))]

            total += digits[0]

    if total % 10 == 0:
        print("PASS")
    else:
        print("FAIL")
