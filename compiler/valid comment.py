import re

f = open('comment.txt', 'r+')
ls = f.readlines()
validcount = 0
invalidcount = 0
for i in ls:
    if re.search('^#', i):
        validcount += 1
    if re.search("^''' ", i):
        validcount += 1

    if re.search("^//", i):
        invalidcount += 1
    else:
        continue

print(
    f'The valid commets are {validcount} \nThe invalid comments are {invalidcount}')
