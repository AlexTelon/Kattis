johan = input()
numbers = (int(x) for x in input().split())
print(abs(sum(x for x in numbers if x < 0)))
