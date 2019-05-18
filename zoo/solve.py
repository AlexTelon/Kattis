from collections import Counter

i = 1
while True:
    n = int(input())
    if n == 0:
        break

    animals = []
    for _ in range(n):
        name = [str.lower(x) for x in input().split()]
        # name = list(map(str.lower, input().split()))
        animals.append(name[-1])
        
    count = Counter(animals)

    print(f"List {i}:")
    for key, value in sorted(count.items()):
        print(f"{key} | {value}")

    i += 1
