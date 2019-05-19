signal = input()
length = len(signal)
shortest = len(signal)
for i in range(length):
    for j in range(i, length):

        candidate = signal.replace(signal[i:j], 'M')
        macro_encoding_msg_len = j - i

        encoded_msg_len = len(candidate) + macro_encoding_msg_len
        shortest = min(shortest, encoded_msg_len)

print(shortest)
