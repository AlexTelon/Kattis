from dataclasses import dataclass

@dataclass(frozen=True)
class Position:
    """Immutable position/vector class that handels the needed add and multiply methods"""
    x: int
    y: int

    # The x and y values are not to be below 0 or above the below values.
    # Nothing hinders you from initializing the values wrong since I have not manually created a constructor,
    # but __add__ and __mul__ will not return new values outside these ranges if specified.
    max_x: int = None
    max_y: int = None

    def __add__(self, other):
        x = self._within_bounds(self.x + other.x, self.max_x)
        y = self._within_bounds(self.y + other.y, self.max_y)
        return Position(x, y, max_x=self.max_x, max_y=self.max_y)

    def __mul__(self, const):
        x = self._within_bounds(self.x * const, self.max_x)
        y = self._within_bounds(self.y * const, self.max_y)
        return Position(x, y, max_x=self.max_x, max_y=self.max_y)

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
