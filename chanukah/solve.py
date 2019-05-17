n = int(input())

for _ in range(n):
    i, days = [int(x) for x in input().split()]

    days = len(range(1, days + 1))
    # add the shammas candels, one per day
    candels = days

    # 1 + 2 + 3 + ... + n = (1 + n) + (2 + n - 1) + .. + (n/2 - 1) + n/2)
    # sum the days, but with the math formula
    n = days
    candels += int((n + 1) * n / 2)
    print(i, candels)

# day     candels
# 1    -    1 + 1
# 2    -    2 + 1
# 3    -    3 + 1
