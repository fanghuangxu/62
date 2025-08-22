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
            MessageBox.Show("已成功克隆仓库，请在"+userDirectory+"\\62目录下查看。");
            System.Console.Write("已成功克隆仓库，请在" + userDirectory + "\\62目录下查看。\n");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string privateKey = @"
-----BEGIN OPENSSH PRIVATE KEY-----
b3BlbnNzaC1rZXktdjEAAAAABG5vbmUAAAAEbm9uZQAAAAAAAAABAAAAMwAAAAtzc2gtZW
QyNTUxOQAAACDEnbXY3nFiJyUPRjHEOJ7CoE3Io8CCrJm6GrnsOTYFGQAAAJi4a8yguGvM
oAAAAAtzc2gtZWQyNTUxOQAAACDEnbXY3nFiJyUPRjHEOJ7CoE3Io8CCrJm6GrnsOTYFGQ
AAAEBM/ePOfFacXNJy5hOmjEmVV5NuXiKz8jhVITgsWaCd9MSdtdjecWInJQ9GMcQ4nsKg
TcijwIKsmboauew5NgUZAAAAE2ZhbmdodWFuZ3h1QDE2My5jb20BAg==
-----END OPENSSH PRIVATE KEY-----
";
            string userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string privateKeyPath = userDirectory + "\\private.key";
            System.IO.File.WriteAllText(privateKeyPath, privateKey);
            Process.Start("ssh-add", privateKeyPath);
            MessageBox.Show("已成功添加私钥到ssh-agent。");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}