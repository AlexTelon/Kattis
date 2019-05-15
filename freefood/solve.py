n = int(input())

free_food_days = set()
for _ in range(n):
    start, stop = [int(x) for x in input().split()]
    free_food_days.update(range(start, stop + 1))

print(len(free_food_days))

