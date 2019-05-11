def encode(data):
    previous_char = data[0]
    previous_count = 1
    encoded = ""
    for c in data[1:]:
        if previous_char == c:
            previous_count += 1
        else:
            # Save.
            encoded += previous_char
            encoded += str(previous_count)

            # Reset.
            previous_char = c
            previous_count = 1

    # Save the last char sequence.
    encoded += previous_char
    encoded += str(previous_count)

    
    return encoded

def decode(data):
    previous_char = data[0]
    decoded = ""
    for c in data[1:]:
        if c.isdigit():
            decoded += previous_char * int(c)
        else:
            previous_char = c

    return decoded


if __name__ == '__main__':
    mode, data = input().split()
    encode_mode = (mode == 'E')
    if encode_mode:
        print(encode(data))
    else:
        print(decode(data))
