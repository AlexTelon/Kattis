import math

def dist(x, y, x2, y2):
    dx = abs(x - x2)
    dy = abs(y - y2)
    return math.sqrt(dx**2 + dy**2)

if __name__ == "__main__":
    pole_x, pole_y, x1, y1, x2, y2 = [int(x) for x in input().split()]
    # INPUT  = "7 3 0 0 5 4"
    # INPUT  = "6 0 0 2 7 6"
    # INPUT  = "3 -4 -3 -1 -1 2"
    # pole_x, pole_y, x1, y1, x2, y2 = [int(x) for x in INPUT.split()]
    # x, y is the central fence post position.
    # The others are the position of the house.
    # Also x1, y1 < x2, y2, and the fence post is stricly outside the house.

    # Find the minimum distance from post to any point on the house
    
    # find the smallest x_diff and y_diff?

    # print(dist(7,3, 5,4))
    min_dist = dist(x1, y1, pole_x, pole_y)

    # STEP = 0.001
    # INC = 1000
    # print(( x * STEP for x in range(0, 2 * INC)))

    # for y in ( _ * STEP for _ in range(y1, y2 * INC)):
    #     for x in ( _ * STEP for _ in range(x1, x2 * INC)):
    #         min_dist = min(min_dist, dist(x1, y, pole_x, pole_y))
    #         min_dist = min(min_dist, dist(x2, y, pole_x, pole_y))
    #         min_dist = min(min_dist, dist(x, y1, pole_x, pole_y))
    #         min_dist = min(min_dist, dist(x, y2, pole_x, pole_y))

    # for x in ( _ * STEP for _ in range(x1, x2 * INC)):
    #     for y in ( _ * STEP for _ in range(y1, y2 * INC)):
    #         min_dist = min(min_dist, dist(x, y, pole_x, pole_y))


    # we are either closest to a corner
    min_dist = min(min_dist, dist(x1, y1, pole_x, pole_y))
    min_dist = min(min_dist, dist(x2, y1, pole_x, pole_y))
    min_dist = min(min_dist, dist(x1, y2, pole_x, pole_y))
    min_dist = min(min_dist, dist(x2, y2, pole_x, pole_y))

    # or closest to a point along one of the two sides of the house along the y-axis
    if x1 < pole_x and pole_x < x2:
        min_dist = min(min_dist, dist(pole_x, y1, pole_x, pole_y))
        min_dist = min(min_dist, dist(pole_x, y2, pole_x, pole_y))

    # or similarly to the x-axis
    if y1 < pole_y and pole_y < y2:
        min_dist = min(min_dist, dist(x1, pole_y, pole_x, pole_y))
        min_dist = min(min_dist, dist(x2, pole_y, pole_x, pole_y))

    print(min_dist)


def alternative():
    # havent tested this, but the idea of using a array/list and then take the min at the end might be nicer to look at, duno..
    pole_x, pole_y, x1, y1, x2, y2 = [int(x) for x in input().split()]

    options = []

    # we are either closest to a corner
    options.append(dist(x1, y1, pole_x, pole_y))
    options.append(dist(x2, y1, pole_x, pole_y))
    options.append(dist(x1, y2, pole_x, pole_y))
    options.append(dist(x2, y2, pole_x, pole_y))

    # or closest to a point along one of the two sides of the house along the y-axis
    if x1 < pole_x and pole_x < x2:
        options.append(dist(pole_x, y1, pole_x, pole_y))
        options.append(dist(pole_x, y2, pole_x, pole_y))

    # or similarly to the x-axis
    if y1 < pole_y and pole_y < y2:
        options.append(dist(x1, pole_y, pole_x, pole_y))
        options.append(dist(x2, pole_y, pole_x, pole_y))

    return min(options)
