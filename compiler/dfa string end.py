# ----------------- REGEX VERSION -----------------
# import re

# def valid(user):
#     if re.findall('ab$', user):
#         return 'string is valid'
#     return 'string invalid'


# user = input("Enter a string: ")
# print(valid(user))


def end(str):
    count = 0
    state = 0

    # aabbbbab
    while (count != len(str)):
        if state == 0:
            if str[count] == "a":
                state = 1
                count += 1
                continue
            else:
                state = 0
                count += 1
                continue

        if state == 1:
            if str[count] == "b":
                state = 2
                count += 1
                continue
            else:
                state = 0
                count += 1
                continue

        if state == 2:
            if str[count] == "b":
                state = 0
                count += 1
                continue
            else:
                state = 1
                continue

    if state == 2:
        return " String accpeted"
    return " String not accepted"


user = input("Enter a string: ")
print(end(user))
