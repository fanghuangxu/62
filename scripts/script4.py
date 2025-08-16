template = """

<!DOCTYPE html>
<html>

<head>
    <title>{name}</title>
    <meta charset="UTF-8">
    <link rel="stylesheet" type="text/css" href="..\styles\students.css">
    <link rel="icon" href="https://bgithub.xyz/fanghuangxu/62/raw/refs/heads/main/icons/icon/fe43525e778ed14a76bd691e3cd8c807.png" type="image/png">
</head>

<body>
    <div class="student-profile" style="width: 500px; height: 600px;">
    <h1>{name}</h1>
    <img src="https://bgithub.xyz/fanghuangxu/62/raw/refs/heads/main/icons/students/{number}.jpg" alt="head image" style="width: 200px; height: 200px; object-fit: cover;">
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
        name = str(names[x]).replace("\n","")
        number = str(x+1).replace("\n","")
        wechat = "None"
        qq = "None"
        email = "None"
        f.write(str(template.format(name=name, number=number, wechat=wechat, qq=qq, email=email)).replace("",""))
        f.close()

import os

for x in range(59):
    os.remove(f"students/._{x+1}.html")