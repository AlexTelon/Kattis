def find_smaller(numbers):
    result = numbers[::-1]
    for index, num in enumerate(reversed(numbers)):
        if num == 0:
            continue
        result[index] = num - 1
        break

    result = reversed(result)
    return int("".join(str(x) for x in result))


n = int(input())
for _ in range(n):
    numbers = list(map(int, input()))
    print(find_smaller(numbers))
