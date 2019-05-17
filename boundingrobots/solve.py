class Position:
    """Wannabe Immutable position/vector class that handels the needed add and multiply methods"""
    x: int
    y: int

    # The x and y values are not to be below 0 or above the below values.
    max_x: int = None
    max_y: int = None

    def __init__(self, x, y, max_x = None, max_y = None):
        self.max_x = max_x
        self.max_y = max_y
        self.x = self._within_bounds(x, self.max_x)
        self.y = self._within_bounds(y, self.max_y)

    def __add__(self, other):
        return Position(self.x + other.x,
                        self.y + other.y,
                        max_x=self.max_x,
                        max_y=self.max_y)

    def __mul__(self, const):
        return Position(self.x * const,
                        self.y * const,
                        max_x=self.max_x,
                        max_y=self.max_y)

    def _within_bounds(self, a, max_a):
        if max_a:
            if a < 0:
                a = 0
            elif a >= max_a:
                a = max_a - 1
        return a

    def __repr__(self):
        return f'{self.x} {self.y}'

directions = {
    'u' : Position(0,1),
    'd' : Position(0,-1),
    'r' : Position(1,0),
    'l' : Position(-1,0)
    }

while True:
    w, l = (int(x) for x in input().strip().split())
    if w == 0 and l == 0:
        break
    
    segments = int(input().strip())

    robot = Position(0,0)
    actual = Position(0,0, max_x=w, max_y=l)
    
    for _ in range(segments):
        d, dist = input().strip().split()
        dist = int(dist)

        change = directions[d] * dist
        robot += change
        actual += change


    print(f"Robot thinks {robot}")
    print(f"Actually at {actual}")
    print("")
