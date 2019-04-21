def greater_harshad(num):
    while True:
        if is_harshad(num):
            return num
        num += 1

def is_harshad(num):
    if num == 0:
        return False
        
    numbers = [int(x) for x in str(num)]
    total = sum(numbers)
    return num % total == 0

num = int(input())
print(greater_harshad(num))

