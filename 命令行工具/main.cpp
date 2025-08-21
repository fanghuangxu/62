#include <iostream>
#include <string>
#include <cstdlib>
using namespace std;

int main(int argc, char* argv[]) {
    // 检查参数数量
    if (argc < 2) {
        cout << "使用方法: " << argv[0] << " <参数1> <参数2> ..." << std::endl;
        return 1;
    }

    // 输出程序名称
    string command = argv[1];
    // 输出每个命令行参数
    if(command == "init"){
        int result = std::system("git clone https://gitee.com/colid/62cct.git && cd 62 && del /f /s /q .git && rm -rf .git && git init && git remote add origin https://gitee.com/colid/62cct.git && git add . && git commit -m 'init' && git config --global user.name \\\"COLID\\\" && git config --global user.email \\\"16058094+colid@user.noreply.gitee.com\\\" && git push -u origin \\\"master\\\" --force && git config --global user.name "" && git config --global user.email \\\"\\\"");
        if (result == 0) {
            cout << "初始化成功！" << "\n";
        } else {
            cout << "初始化失败！" << "\n";
        }
    }else if(command == "pull"){
        cout << "正在拉取仓库..." << "\n";
        int result = std::system("git pull");
        if (result == 0) {
            cout << "拉取成功！" << "\n";
        } else {
            cout << "拉取失败！" << "\n";
        }
    }else if(command == "push"){
        cout << "正在推送仓库..." << "\n";
        int result = std::system("git push --force");
        if (result == 0) {
            cout << "推送成功！" << "\n";
        } else {
            cout << "推送失败！" << "\n";
        }
    }else if(command == "edit"){
        cout << "正在打开编辑器..." << "\n";
        int result = std::system("code .");
        if (result == 0) {
            cout << "打开成功！" << "\n";
        } else {
            cout << "打开失败！" << "\n";
        }
    }
    else{
        cout << "未知命令！" << "\n";
    }

    return 0;
}
