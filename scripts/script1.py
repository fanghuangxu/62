import os

code = """
<!DOCTYPE html>
<html>

<head>
    <title>翁馨尧</title>
    <link rel="stylesheet" type="text/css" href="..\styles\students.css">
</head>

<body>
    <div class="student-profile">
        <h1>翁馨尧</h1>
        <img src="https://bgithub.xyz/fanghuangxu/62/raw/refs/heads/main/icons/students/1.jpg" alt="head image">
        <p>名字: 翁馨尧</p>
        <p>座号: 1</p>
        <div class="contact">
            <p>微信: None</p>
            <p>QQ: None</p>
            <p>E-Mail: None</p>
        </div>
    </div>
</body>

</html>

"""

for x in range(59):
    with open(f"students/{x+1}.html", "w") as f:
        f.write(code)
        f.close()
        