days = int(input())
junk = [int(x) for x in input().split()]

junk = junk[:days]
print(junk.index(min(junk)))
