correct_friend = int(input())

my_answers = [c for c in input()]
friend_answers = [c for c in input()]

answer_pairs = zip(my_answers, friend_answers)
nr_of_common_answers = len([x[0] for x in answer_pairs if x[0] == x[1]])
# print("nr_of_common_answers", nr_of_common_answers)

nr_of_different_answers = len(my_answers) - nr_of_common_answers
# print("nr_of_different_answers", nr_of_different_answers)

max_correct_common = min(nr_of_common_answers, correct_friend)
# print("max_correct_common", max_correct_common)

max_correct_from_different_answers = len(my_answers) - max(nr_of_common_answers, correct_friend)
# print("max_correct_from_different_answers", max_correct_from_different_answers)

max_total = max_correct_from_different_answers + max_correct_common
# print("max_total", max_total)
print(max_total)
