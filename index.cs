using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace FPS_Python
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void project_dir_button_Click(object sender, EventArgs e)
        {
            DialogResult result = directoryDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                project_dir.Text = directoryDialog.SelectedPath.ToString();
            }
        }

        private void python_int_button_Click(object sender, EventArgs e)
        {
            DialogResult result = directoryDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                python_int.Text = directoryDialog.SelectedPath.ToString();
            }
        }

        private void index_Load(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            string userName2 = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            var result = new bool[6];

            var directories = new string[6] {"C:\\Program Files\\Python", "C:\\Python", "C:\\Users\\Python", "C:\\Users\\Default\\Python", "C:\\Users\\" + userName + "\\Python", "C:\\Users\\" + userName2 + "\\Python"};

            result[0] = Directory.Exists("C:\\Program Files\\Python");
            result[1] = Directory.Exists("C:\\Python");
            result[2] = Directory.Exists("C:\\Users\\Python");
            result[3] = Directory.Exists("C:\\Users\\Default\\Python");
            result[4] = Directory.Exists("C:\\Users\\" + userName + "\\Python");
            result[5] = Directory.Exists("C:\\Users\\" + userName2 + "\\Python");

            foreach (var item in result.Select((item, index) => (item, index)))
            {
                if (item.item == true)
                {
                    python_int.Text = directories[item.index];
                }
            }
        }

        private void virtualenv_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            int width1 = 445;
            int height1 = 282;
            int width2 = 237;
            int height2 = 251;

            if (virtualenv_checkbox.Checked == true)
            {
                this.MaximumSize = new Size(width1, height1);
                this.MinimumSize = new Size(width1, height1);
                this.Size = new Size(width1, height1);

            }
            else if(virtualenv_checkbox.Checked == false)
            {
                this.MaximumSize = new Size(width2, height2);
                this.MinimumSize = new Size(width2, height2);
                this.Size = new Size(width2, height2);

            }
        }

        private void add_package_button_Click(object sender, EventArgs e)
        {
            string PackageName = package_name.Text;
            package_list.Items.Add(PackageName);
        }

        private void delete_package_button_Click(object sender, EventArgs e)
        {
            string element = package_list.Text;
            package_list.Items.Remove(element);
        }

        private void create_project_Click(object sender, EventArgs e)
        {
            string projectLabel = projectName.Text;
            string projectDir = project_dir.Text;
            string repo = github_repo.Text;
            string pythonDir = python_int.Text;

            string virtualenvLabel = virtualenv_name.Text;
            string[] packages = package_list.Items.OfType<string>().ToArray();
            bool requirements = requirements_checkbox.Checked;

            try
            {
                System.Diagnostics.Process cmd = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C mkdir " + projectDir + "\\" + projectLabel;
                string projectPath = projectDir + "\\" + projectLabel;
                string python = pythonDir + "\\python.exe";
                cmd.StartInfo = startInfo;
                cmd.Start();
                cmd.WaitForExit();
                cmd.Close();
                if (virtualenvLabel != null || virtualenvLabel != "Enter your virtualenv name here")
                {
                    System.Diagnostics.Process cmd1 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo1 = new System.Diagnostics.ProcessStartInfo();
                    startInfo1.FileName = "cmd.exe";
                    startInfo1.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo1.Arguments = "/C " + python +  " -m venv " + "\"" + projectPath + "\\" + virtualenvLabel + "\"";
                    cmd1.StartInfo = startInfo1;
                    cmd1.Start();
                    cmd1.WaitForExit();
                    cmd1.Close();

                    System.Diagnostics.Process cmd2 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo2 = new System.Diagnostics.ProcessStartInfo();
                    startInfo2.FileName = "cmd.exe";
                    startInfo2.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo2.Arguments = "/C " + projectPath + "\\" + virtualenvLabel + "\\Scripts\\activate.bat";
                    cmd2.StartInfo = startInfo;
                    cmd2.Start();
                    cmd2.WaitForExit();
                    cmd2.Close();

                    for (int i = 0; i <= packages.Length; i++)
                    {
                        System.Diagnostics.Process cmd3 = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo3 = new System.Diagnostics.ProcessStartInfo();
                        startInfo3.FileName = "cmd.exe";
                        startInfo3.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo3.Arguments = "/C " + projectPath + "\\" + virtualenvLabel + "\\Scripts\\activate.bat " + "&&" + " pip install " + packages[i];
                        cmd3.StartInfo = startInfo3;
                        cmd3.Start();
                        cmd3.WaitForExit();
                        cmd3.Close();
                    }
                }
                else
                {
                    for (int i = 0; i <= packages.Length; i++)
                    {
                        System.Diagnostics.Process cmd4 = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo4 = new System.Diagnostics.ProcessStartInfo();
                        startInfo4.FileName = "cmd.exe";
                        startInfo4.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo4.Arguments = "/C " + python + " -m pip install " + packages[i];
                        cmd4.StartInfo = startInfo4;
                        cmd4.Start();
                        cmd4.WaitForExit();
                        cmd4.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
        }
    }
}