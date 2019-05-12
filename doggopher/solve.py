import sys 

def dist(x, y, x2, y2):
    from math import sqrt
    return sqrt( (x - x2) ** 2 + (y - y2) ** 2)

x_prey, y_prey, x_dog, y_dog = (float(x) for x in input().split())

for line in sys.stdin:
    if not line:
        break

    x, y = [float(x) for x in line.split()]
    dist_prey = dist(x_prey, y_prey, x, y)
    dist_dog = dist(x_dog, y_dog, x, y)

    # dog is twice as fast as the prey
    if dist_prey * 2 <= dist_dog:
        print("the gopher can escape through the hole at ({},{}).".format(x,y))
        break
else:
    print("The gopher cannot escape.")
