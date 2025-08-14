template = """

<!DOCTYPE html>
<html>

<head>
    <title>{name}</title>
    <meta charset="UTF-8">
    <link rel="stylesheet" type="text/css" href="..\styles\students.css">
</head>

<body>
    <div class="student-profile" style="width: 500px; height: 600px;">
    <h1>{name}</h1>
    <img src="../icons/students/{number}.jpg" alt="head image" style="width: 200px; height: 200px; object-fit: cover;">
    <p>名字: {name}</p>
    <p>座号: {number}</p>
    <div class="contact">
        <p>微信: {wechat}</p>
        <p>QQ: {qq}</p>
    </div>
</div>
</body>

</html>
"""
names = open("scripts/names_out.txt","r").readlines()

for x in range(59):
    with open(f"students/{x+1}.html", "w", encoding="utf-8") as f:
        name = names[x]
        number = x+1
        wechat = "None"
        qq = "None"
        email = "None"
        f.write(str(template.format(name=name, number=number, wechat=wechat, qq=qq, email=email)).replace("\n",""))
        f.close()

import os

for x in range(59):
    os.remove(f"students/._{x+1}.html")