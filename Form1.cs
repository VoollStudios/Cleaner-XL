using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Bunifu.Framework.UI;
using System.Diagnostics;
using Bunifu;


namespace Computer_Cleaner
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {

        public Form1()
        {
            InitializeComponent();
        }

        public bool shownOne = false;
        public bool showOneRam = false;

        Process[] pro;

        MessageBoxIcon iconcool = MessageBoxIcon.Information;
        MessageBoxButtons voolbuttons = MessageBoxButtons.OK;

        // ==================================================

        MessageBoxIcon icon5 = MessageBoxIcon.Question;
        MessageBoxOptions cool = MessageBoxOptions.ServiceNotification;
        MessageBoxButtons buttons56 = MessageBoxButtons.YesNo;
        public string tiitlrer = "Helper";
        public string message62 = "Your Computer Does Not Have a tmp folder do you want to Create one.";

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent(); // Do Not Touch This!!!

            bunifuCircleProgressbar1.LabelVisible = true;
            bunifuCircleProgressbar2.LabelVisible = true;

            string tmpPath = textBox1.Text;
            timer1.Start();

            if (Directory.Exists(tmpPath) == false)
            {
                if (MessageBox.Show(message62, tiitlrer, buttons56, icon5) == DialogResult.Yes)
                {
                    Directory.CreateDirectory(tmpPath);
                }
            }

            Form1 form = new Form1();
            MessageBoxButtons opt = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Hand;

            string title = "Terms Agreement";
            string mess = "By Agreeing to these terms cleaner XL and its Authors Are Not Responsible At all if any damage is caused to your computer, If you do not agree to these terms you are not allowed to use Cleaner Xl At all.";

            if (MessageBox.Show(mess, title, opt, icon) == DialogResult.No)
            {
                this.Close();
            }
        }

        #region
        private void timer1_Tick(object sender, EventArgs e)
        {
            #region

            timer1.Interval = 200;
            float cpu = performanceCounter1.NextValue();
            float ram = performanceCounter2.NextValue();
            bunifuCircleProgressbar1.Value = (int)cpu;
            bunifuCircleProgressbar2.Value = (int)ram;
            label1.Text = string.Format("{0:0.00}% CPU Utilization", cpu);
            label2.Text = string.Format("{0:0.00} Memory In Use", ram);

            if (cpu < 70)
            {
                bunifuCircleProgressbar1.ForeColor = Color.DodgerBlue;
                bunifuCircleProgressbar1.ProgressColor = Color.DodgerBlue;
            }

            if (cpu >= 80)
            {
                bunifuCircleProgressbar1.ForeColor = Color.Red;
                bunifuCircleProgressbar1.ProgressColor = Color.Red;
                if (shownOne == false)
                {
                 notifyIcon1.BalloonTipText = "Your CPU Is At 80 or more %";
                 notifyIcon1.ShowBalloonTip(900000);
                 shownOne = true;
                }
            }

            if (ram >= 80)
            {
                bunifuCircleProgressbar2.ForeColor = Color.Red;
                bunifuCircleProgressbar2.ProgressColor = Color.Red;
                if (showOneRam == false)
                {
                 notifyIcon1.BalloonTipText = "Your Ram Is At 80 or more %";
                 notifyIcon1.ShowBalloonTip(900000);
                }
            }

            if (ram >= 70)
            {
                bunifuCircleProgressbar2.ForeColor = Color.Orange;
                bunifuCircleProgressbar2.ProgressColor = Color.Orange;
            }

            if (ram == 72)
            {
                string message = "Your Ram Is Over 70% Full";
                string title = "Cleaner XL";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result = MessageBox.Show(message, title, buttons, icon);

            }

            if (ram == 81)
            {
                string message = "Your Ram Is Over 80% Full";
                string title = "Cleaner XL";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                DialogResult result = MessageBox.Show(message, title, buttons, icon);
            }
            #endregion

            #region 
            // put stats here
            if (ram <= 30)
            {
                // Super
            }

            if (ram <= 60)
            {
                // Good
            }

            if (ram <= 75)
            {
                // Medum
            }

            if (ram <= 80)
            {
                // Bad
            }

            if (ram <= 90)
            {
                // Restart PC Now
            }
            #endregion
        }
        #endregion

        public void tab()
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        string title3 = "Helper";

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string tmpPath = textBox1.Text;
            string capturesPath = textBox2.Text;
            string custom1 = textBox6.Text;
            string custom2 = textBox5.Text;
            string custom3 = textBox4.Text;
            string custom4 = textBox3.Text;
            string tmp = "Tmp Folder Cleaned";
            string tmptitle = "Cleaner Message";

            MessageBoxIcon icon = MessageBoxIcon.Stop;
            MessageBoxIcon icon1 = MessageBoxIcon.Warning;
            MessageBoxIcon tmpicon = MessageBoxIcon.Information;
            MessageBoxButtons tmpbutton = MessageBoxButtons.OK;

            if (radioButton2.Checked == true)
            {
                if (Directory.Exists(tmpPath))
                {
                    Directory.Delete(tmpPath, true);
                    Directory.CreateDirectory(tmpPath);
                    MessageBox.Show(tmp,tmptitle,tmpbutton,tmpicon);
                }
                else
                    MessageBox.Show("Operation Faled Does Not Exist",title3,tmpbutton,icon1);
            }

            if (radioButton1.Checked == true)
            {
                string message1 = "Operation Failed Folder Does Not Exist Try Changing Samuel To Your User Name.";

                if (Directory.Exists(capturesPath))
                {
                    string message = "Are You Sure This Will Delete Every Thing In Your Clean Preset 2.";
                    string title = "Clean Preset 2";
                    MessageBoxIcon infoIcon = MessageBoxIcon.Information;

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, icon);

                    if (result == DialogResult.Yes)
                    {
                        Directory.Delete(capturesPath, true);
                        Directory.CreateDirectory(capturesPath);
                        MessageBox.Show("Clean Preset 2 Cleaned", title, ok, infoIcon);
                    }
                }
                else
                    MessageBox.Show(message1,title3,tmpbutton,icon1);
            }

            if (checkBox1.Checked)
            {
                if (Directory.Exists(custom1))
                {
                    string message = "Are You Sure This Will Delete Every Thing In Your "+custom1+" Folder";
                    string title = custom1+" Folder";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, icon1);

                    Directory.Delete(capturesPath, true);
                    Directory.CreateDirectory(capturesPath);
                    MessageBox.Show(custom1+" Cleaned");
                }
                else
                    MessageBox.Show(custom1+" Does Not Exist.");
            }



            if (checkBox2.Checked) //cool
            {
                if (Directory.Exists(custom2))
                {
                    string message = "Are You Sure This Will Delete Every Thing In Your " + custom2 + " Folder";
                    string title = custom2 + " Folder";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, icon1);

                    Directory.Delete(custom2, true);
                    Directory.CreateDirectory(custom2);
                    MessageBox.Show(custom2 + " Cleaned");
                }
                else
                    MessageBox.Show(custom2+" Does Not Exist");
            }

            if (checkBox3.Checked)
            {
                if (Directory.Exists(custom3))
                {
                    string message = "Are You Sure This Will Delete Every Thing In Your " + custom3 + " Folder";
                    string title = custom3 + " Folder";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, icon1);

                    Directory.Delete(custom3, true);
                    Directory.CreateDirectory(custom3);
                    MessageBox.Show(custom3 + " Cleaned");
                }
                else
                    MessageBox.Show(custom3 + " Does Not Exist");
            }

            if (checkBox4.Checked)
            {
                if (Directory.Exists(custom4))
                {
                    string message = "Are You Sure This Will Delete Every Thing In Your " + custom4 + " Folder";
                    string title = custom4+ " Folder";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, icon1);

                    Directory.Delete(custom4, true);
                    Directory.CreateDirectory(custom4);
                    MessageBox.Show(custom4 + " Cleaned");
                }
                else
                    MessageBox.Show(custom4 + " Does Not Exist");
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message1 = "Your Ram Is Over 70% Full";
            string title2 = "Cleaner XL";
            MessageBoxButtons buttons5 = MessageBoxButtons.OK;
            MessageBoxIcon icon8 = MessageBoxIcon.Information;
            DialogResult result7 = MessageBox.Show(message1, title2, buttons5, icon8);

            string message = "Your Ram Is Over 80% Full";
            string title = "Cleaner XL";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show(message, title, buttons, icon);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string cool = folderBrowserDialog1.SelectedPath;
                textBox6.Text = cool;
            }
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string cool = folderBrowserDialog1.SelectedPath;
                textBox5.Text = cool;
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string cool = folderBrowserDialog1.SelectedPath;
                textBox4.Text = cool;
            }
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string cool = folderBrowserDialog1.SelectedPath;
                textBox3.Text = cool;
            }
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            tabPage4.Hide();
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            tabPage4.Hide();
        }

        private void materialRaisedButton9_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string cool = folderBrowserDialog1.SelectedPath;
                textBox2.Text = cool;
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            string title = "Cleaner AI";
            MessageBox.Show("Cleaner XL Opened",title);
            Form1 form1 = new Form1();
            form1.Visible = true;
        }

        private void materialRaisedButton10_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Visible = false;
            notifyIcon1.ShowBalloonTip(9000);
            notifyIcon1.BalloonTipText = "Backround Mode Activated";
        }
    }
}
