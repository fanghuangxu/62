using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System;

namespace _62CommandTools
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            Process.Start("cmd.exe", "mkdir " + userDirectory + "\\62");
            Process.Start("git", @"clone https://bgithub.xyz/fanghuangxu/62.git "+userDirectory+"\\62");
            Process.Start("cmd.exe", "rmdir /s /q " + userDirectory + "\\62\\.git");
            Process.Start("cmd.exe","cd "+userDirectory+ "\\62 && git init && git branch -M main && git remote add origin git@github.com:fanghuangxu/62cct.git");
            MessageBox.Show("已成功克隆仓库，请在" + userDirectory + "\\62 目录下查看。");
            System.Console.Write("已成功克隆仓库，请在" + userDirectory + "\\62目录下查看。\n");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            Process.Start("cmd.exe", "ssh-keygen -t rsa -C \"fanghuangxu@163.com\"");
            MessageBox.Show("已成功生成密钥，请在 "+userDirectory+"\\.ssh目录下查看。");
            Process.Start("notepad.exe", userDirectory + "\\.ssh\\id_rsa.pub");
            MessageBox.Show("已成功打开公钥文件，请将其内容想办法发送至作者");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            Process.Start("code", userDirectory + "\\62");
            MessageBox.Show("已成功打开仓库目录，请在编辑器中进行修改。");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            /*
             * echo "# 62cct" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin git@github.com:fanghuangxu/62cct.git
git push -u origin main
             */
            string userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            Process.Start("cmd.exe", "cd " + userDirectory + "\\62 && git add . && git commit -m \"cct updata\" && git push -u origin main");
            MessageBox.Show("已成功提交并推送至远程仓库。");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            Process.Start("cmd.exe", "cd " + userDirectory + "\\62 && git pull");
            MessageBox.Show("已成功拉取远程仓库最新代码。");
        }
    }
}