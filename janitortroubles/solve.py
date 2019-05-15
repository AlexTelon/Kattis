from math import sqrt
sides = [int(x) for x in input().split()]

s = sum(sides) / 2
a, b, c, d = sorted(sides)

print(sqrt( (s - a) * (s - b) * (s - c) * (s - d) ))
# derp = input()
# print(sqrt( (sum([int(x) for x in derp.split()]) / 2 - sorted([int(x) for x in derp.split()])[0]) * (sum([int(x) for x in derp.split()]) / 2 - sorted([int(x) for x in derp.split()])[1]) * (sum([int(x) for x in derp.split()]) / 2 - sorted([int(x) for x in derp.split()])[2]) * (sum([int(x) for x in derp.split()]) / 2 - sorted([int(x) for x in derp.split()])[3]) ))
