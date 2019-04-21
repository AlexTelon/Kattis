def solve():
    n = int(input())
    for i in range(n):
        counter, base, num = (int(i) for i in input().split())

        sum = 0
        while num > 0:
            val = num % base
            num = num // base
            sum += val**2
        print(counter, sum)

solve()
