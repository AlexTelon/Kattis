companies, requests = [int(i) for i in input().split()]
companies = [int(i) for i in input().split()]

for r in range(requests):
    op, a, b = [int(i) for i in input().split()]
    if op == 1:
        # move company from a to b
        companies[a-1] = b
    else:
        # query distance between companies a and b
        print(abs(companies[a-1] - companies[b-1]))

