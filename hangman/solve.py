# The chars that are included in the answer.
answer = set(c for c in input())
guess_order = input()

wrong_guesses = 0
for c in guess_order:
    if len(answer) == 0:
        print("WIN")
        break
    if wrong_guesses == 10:
        print("LOSE")
        break
    if c in answer:
        answer.discard(c)
    else:
        wrong_guesses += 1
