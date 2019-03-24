def factorial(n):
    if n == 0: return 1
    if n == 1: return 1
    return n * factorial(n-1)

if __name__ == '__main__':
    n = int(input())

    for i in range(n):
        num = int(input())

        f = factorial(num)
        # We shall only print the very last digit of f
        d = str(f)[-1]
        print(d)
