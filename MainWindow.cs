using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mastodot;
using Mastodot.Enums;
using Mastodot.Utils;
using Mastodot.Entities;

namespace WindowsFormsApplication1
{
    public partial class MainWindow : Form
    {
        static Oauth form2 =   new Oauth();
        static AutoToot AutoTootFrom = new AutoToot();
        public static Mastodot.Entities.RegisteredApp registeredApp;
        private static string host;
        private static string AccessToken;
        public static  string [] TodoList;
        public static MainWindow main = new MainWindow();
        private string UserName;

        public MainWindow()
        {

            //var p = new Form1();
            InitializeComponent();

            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(
                @"TodoList.txt",
                System.Text.Encoding.GetEncoding("utf-8"));
                //内容を一行ずつ読み込む
                while (sr.Peek() > -1)
                {
                    TodoList_GUILIST.Items.Add(sr.ReadLine());
                    //Console.WriteLine(sr.ReadLine());
                }

                //閉じる
                sr.Close();
            }
            catch(Exception e) {
                e.ToString();
            }

            try
            {
                System.IO.StreamReader sr2 = new System.IO.StreamReader(
                @"HashTagOption.txt",
                System.Text.Encoding.GetEncoding("utf-8"));
                UserName=sr2.ReadLine();
                HashTagOption.Text = UserName;

                //閉じる
                sr2.Close();
            }
            catch (Exception e)
            {
                e.ToString();
            }

            TodoList = this.TodoList_GUILIST.Items.Cast<string>().ToArray();


        }

        private void ADD_button_Click(object sender, EventArgs e)
        {
            string text_value = Add_Text.Text;
            //TodoList.Add(text_value);
            TodoList_GUILIST.Items.Add (text_value);
            Add_Text.Clear();
            TodoList = this.TodoList_GUILIST.Items.Cast<string>().ToArray();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            TodoList_GUILIST.Items.RemoveAt(TodoList_GUILIST.SelectedIndex);
            TodoList = this.TodoList_GUILIST.Items.Cast<string>().ToArray();

        }

        public void OAuth()
        {
            try
            {
                //"C:\test\1.txt"をShift-JISコードとして開く
                Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\TodoListDon\sub", false);
                //内容を一行ずつ読み込む
                AccessToken = (string)regkey.GetValue("AccessToken");
                host = (string)regkey.GetValue("hostname");
                Toot();
            }
            catch (NullReferenceException e)
            {
                    form2.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
                    try
                    {
                        form2.ShowDialog();
                    }
                    catch (Exception)
                    {
                        form2.Visible = false;
                    }
            }
        }

        public void OAuth(string a)
        {

            //"C:\test\1.txt"をShift-JISコードとして開く
            Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\TodoListDon\sub", false);
            //内容を一行ずつ読み込む
            AccessToken = (string)regkey.GetValue("AccessToken");
            host = (string)regkey.GetValue("hostname");


            if (AccessToken == null)
            {
                form2.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
                try
                {
                    form2.ShowDialog();
                }
                catch (Exception)
                {
                    form2.Visible = false;
                }
            }
        }


        public void Form2_FormClosed(object sender, FormClosedEventArgs e) {


            Oauth f2 = (Oauth)sender;

            //main.OAuth();
        }

        public void Toot() {
            registeredApp = ApplicaionManager.RegistApp(host, "TodoListDon", Scope.Read | Scope.Write | Scope.Follow).Result;
            var client = new MastodonClient(host, AccessToken);

            UserName = HashTagOption.Text;

            int i = 0;
            var TodoString = ""; 
            foreach (var s in TodoList) {
                i++;
                TodoString += i + ":[ ]" + s + Environment.NewLine;
            }
            client.PostNewStatus(status: TodoString +"#"+ UserName +"_On_TodoListDon",visibility:Visibility.Unlisted);
        }


        private void Toot_button_Click(object sender, EventArgs e)
        {
            //form2.Show();
            OAuth();

        }

        private void Auto_Toot_button_Click(object sender, EventArgs e)
        {
            OAuth("switch");
            AutoTootFrom.Show();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            TodoList = this.TodoList_GUILIST.Items.Cast<string>().ToArray(); 
            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(
            @"TodoList.txt",
            false,
            System.Text.Encoding.GetEncoding("utf-8"));
                //TextBox1.Textの内容を1行ずつ書き込む
                foreach (string line in TodoList)
                {
                    sw.WriteLine(line);
                }
                //閉じる
                sw.Close();

            }
            catch (Exception ex) {
                ex.ToString();
            }

            try
            {
                System.IO.StreamWriter sw2 = new System.IO.StreamWriter(
            @"HashTagOption.txt",
            false,
            System.Text.Encoding.GetEncoding("utf-8"));
                //TextBox1.Textの内容を1行ずつ書き込む
                sw2.WriteLine(HashTagOption.Text);
                //閉じる
                sw2.Close();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }


        }

    }
}
