# ------------------ REGEX TO DFA ------------------
# import re
# def dfa(user):
#     if re.findall('^ab', user):
#         return 'string is valid'
#     return 'string invalid'


# user = input("Enter a string: ")
# print(dfa(user))


def start(str):
    state = 0

    if state == 0 and str[0] == "a":
        state = 1

        if state == 1 and str[1] == 'b':
            return " string accepted"

        return "String rejected"
    return "string rejected"


user = input("Enter a string: ")

print(start(user))
