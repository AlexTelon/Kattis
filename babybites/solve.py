from contextlib import suppress

input()
words = input().strip().split()

for index, word in enumerate(words, start=1):
    with suppress(Exception):
        number = int(word)
        if number != index:
            print("something is fishy")
            break
else:
    print("makes sense")
