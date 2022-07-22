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
            string[] packages = new string[package_list.Items.Count];
            bool requirements = requirements_checkbox.Checked;

            for(int i = 0; i < package_list.Items.Count; i++)
            {
                packages.Append(package_list.Items[i].ToString());
            }

            try
            {
                System.Diagnostics.Process cmd = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                // startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C mkdir " + projectDir + "\\" + projectLabel;
                string projectPath = projectDir + "\\" + projectLabel;
                string python = pythonDir + "\\python.exe";
                cmd.StartInfo = startInfo;
                cmd.Start();
                Console.WriteLine(cmd.StandardOutput.ReadToEnd());
                if (virtualenvLabel != null || virtualenvLabel != "Enter your virtualenv name here")
                {
                    startInfo.Arguments = "/C cd " + projectPath + " && " + python + " -m venv " + virtualenvLabel;
                    cmd.StartInfo = startInfo;
                    cmd.Start();
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());

                    startInfo.Arguments = "/C cd " + projectPath + " && " + "venv\\Scripts\\activate.bat";
                    cmd.StartInfo = startInfo;
                    cmd.Start();
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());

                    for (int i = 0; i <= packages.Length; i++)
                    {
                        startInfo.Arguments = "/C cd " + projectPath + " && " + "venv\\Scripts\\activate.bat && " + pythonDir + "-m pip install " + packages[i];
                        cmd.StartInfo = startInfo;
                        cmd.Start();
                        Console.WriteLine(cmd.StandardOutput.ReadToEnd());
                    }
                }
                else
                {
                    for (int i = 0; i <= packages.Length; i++)
                    {
                        startInfo.Arguments = "/C " + pythonDir + "-m pip install " + packages[i];
                        cmd.StartInfo = startInfo;
                        cmd.Start();
                        Console.WriteLine(cmd.StandardOutput.ReadToEnd());
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