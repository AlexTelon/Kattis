n = int(input())

state = {}

for _ in range(n):
    action, name = input().split()

    anomaly = False
    if name in state:
        if action == "entry":
            anomaly = True
    else:
        if action == "exit":
            anomaly = True


    output = ""
    if action == "exit":
        state.pop(name, None)
        output = f"{name} exited"
    else:
        state[name] = 1
        output = f"{name} entered"

    if anomaly:
        output += " (ANOMALY)"

    print(output)
