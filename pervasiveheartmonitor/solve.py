import sys

for words in sys.stdin:
    words = words.split()
    readings = []
    name = []

    for word in words:
        try:
            value = float(word)
            readings.append(value)
        except:
            name.append(word)

    average = sum(readings) / len(readings)
    name = ' '.join(name) 
    print(average, name)
