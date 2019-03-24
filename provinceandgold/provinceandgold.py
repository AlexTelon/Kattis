from collections import OrderedDict

gold, silver, copper = [int(x) for x in input().split()]

coins = gold * 3 + silver * 2 + copper

victory = [
    ("Estate" , 2),
    ("Duchy", 5),
    ("Province", 8)
]
victory = OrderedDict(victory)

treasure = [
    ("Copper", 0),
    ("Silver", 3),
    ("Gold", 6)
]

treasure = OrderedDict(treasure)

best_victory = ""
for card, cost in victory.items():
    if coins >= cost:
        best_victory = card

best_treasure = ""
for card, cost in treasure.items():
    if coins >= cost:
        best_treasure = card


output = ""
if best_treasure == "" or best_victory == "":
    output += best_treasure + best_victory
else:
    output = "{} or {}".format(best_victory, best_treasure)

print(output)
