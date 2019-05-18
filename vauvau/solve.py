a_aggresive, a_calm, b_aggresive, b_calm = map(int, input().split())
arrivals = map(int, input().split())

a_cycle = a_aggresive + a_calm
b_cycle = b_aggresive + b_calm

for arrival in arrivals:
    count = 0
    a_local_time = arrival % a_cycle
    if a_local_time != 0 and a_local_time <= a_aggresive:
        count += 1

    b_local_time = arrival % b_cycle
    if b_local_time != 0 and b_local_time <= b_aggresive:
        count += 1

    if count == 0:
        print("none")
    elif count == 1:
        print("one")
    elif count == 2:
        print("both")
