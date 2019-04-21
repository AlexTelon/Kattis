from collections import Counter
cards = input().split()

ranks = (card[0:-1] for card in cards)
counter = Counter(ranks)

# is a tuple of the value and how many it found
most_common = counter.most_common(1)[0]
print(most_common[1])
