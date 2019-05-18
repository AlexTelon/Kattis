import itertools
import sys

count = itertools.count(start=1)
for line in sys.stdin:
    numbers = list(map(int, line.split()))
    del numbers[0]
    minimum = min(numbers)
    maximum = max(numbers)
    print(f"Case {next(count)}: {minimum} {maximum} {maximum - minimum}")
