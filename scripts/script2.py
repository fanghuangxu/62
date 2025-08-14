# 处理`names.txt`文件，把数字去掉生成`output.txt`文件

with open("names.txt", "r") as f:
    file_con=f.read()

replaces = ["1","2","3","4","5","6","7","8","9","0"," "]
for r in replaces:
    file_con = file_con.replace(r,"")

with open("output.txt", "w") as f:
    f.write(file_con)