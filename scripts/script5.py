template = '<a href="students/{number}.html">{name}</a>'
names = open("scripts/names_out.txt","r").readlines()
numbers = open("scripts/numbers_out.txt").readlines()
with open("scripts/index.txt","a") as f:
    for x in range(59):
        name = names[x]
        number = numbers[x]
        f.write(str(template.format(number=number, name=name)).replace("\n",""))
        f.write("\n")
f.close()
        