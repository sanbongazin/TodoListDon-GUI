using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AutoToot : Form
    {
        private TaskFactory taskFactory = new TaskFactory();
        private CancellationTokenSource cancellationToken = new CancellationTokenSource();
        private Task task;
        private MainWindow main = new MainWindow();

        public AutoToot()
        {
            InitializeComponent();
            IntervalTime.Items.Add("15");
            IntervalTime.Items.Add("30");
            IntervalTime.Items.Add("45");
            IntervalTime.Items.Add("60");
        }

        private void AutoTootButton_Click(object sender, EventArgs e)
        {
            var t = DateTime.Now;
            int interval = int.Parse(IntervalTime.SelectedItem.ToString());
            int BootTime = t.Minute;

            task = taskFactory.StartNew(() => {
                while (true)
                {
                    cancellationToken.Token.ThrowIfCancellationRequested();

                    DateTime t2 = DateTime.Now;
                    int now_m = t2.Minute;
                    now_m = t2.Minute;
                    if (now_m == BootTime + interval)
                    {
                        main.OAuth();
                        interval *= 2;
                        if (interval > 60)
                        {
                            interval %= 60;
                        }
                        AutoTootButton_Click(sender,e);

                    }
                    Thread.Sleep(500);
                }

            }, cancellationToken.Token);
            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (task != null)
            {
                try
                {
                    // キャンセル要求出す
                    cancellationToken.Cancel();

                    // タスクがキャンセルされるまで待機
                    task.Wait();
                }


                catch (AggregateException)
                {
                    // タスクがキャンセルされるとここが実行される
                    Console.WriteLine("Task is cancelled.");

                }

                Close();
            }
            else {
                Close();
            }

        }

    }
}
