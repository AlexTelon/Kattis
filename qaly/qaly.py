if __name__ == '__main__':
    n = int(input())

    sum = 0
    for i in range(n):
        years, quality = [float(x) for x in input().split()]
        # years, quality = map(float, line.split())
        sum += years * quality

    print(sum)
