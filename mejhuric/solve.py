numbers = [int(x) for x in input().split()]
answer = sorted(numbers)

while True:
    for i in range(len(numbers ) - 1):
        if numbers[i] > numbers[i + 1]:
            numbers[i], numbers[i + 1] = numbers[i + 1], numbers[i]
            print(' '.join(str(x) for x in numbers))

    if numbers == answer:
        break
