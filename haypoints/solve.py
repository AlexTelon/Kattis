from collections import defaultdict

m, n = (int(x) for x in input().split())

# find all haywords
worth = defaultdict(int)
for i in range(m):
    line = input().split()
    worth[line[0]] = int(line[1])


# job descriptions
for i in range(n):
    job_desc = ""
    while True:
        line = input()
        job_desc += line + ' '
        if line == '.':
            break

    points = 0
    for word in job_desc.split():
        points += worth[word]
    print(points)
