order = []
order.extend(map(int, input().split()))
order.extend(map(int, input().split()))
order.extend(map(int, input().split()))

def distance(a, b):
    import math
    diff_x = a[0] - b[0]
    diff_y = a[1] - b[1]
    return math.sqrt(diff_x ** 2 + diff_y ** 2)

def index_to_pos(index):
    return (index % 3, index // 3)

# find the total travel dist. 1 unit grid.
dist = 0

for num in range(1, 9):
    current = order.index(num)
    derp = order.index(num + 1)

    current_pos = index_to_pos(current)
    next_pos = index_to_pos(derp)

    d = distance(current_pos, next_pos)
    dist += d

print(dist)
