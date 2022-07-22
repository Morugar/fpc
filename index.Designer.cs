namespace FPS_Python
{
    partial class index
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.projectName = new System.Windows.Forms.TextBox();
            this.github_repo = new System.Windows.Forms.TextBox();
            this.project_dir = new System.Windows.Forms.TextBox();
            this.directoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.project_dir_button = new System.Windows.Forms.Button();
            this.python_int = new System.Windows.Forms.TextBox();
            this.python_int_button = new System.Windows.Forms.Button();
            this.virtualenv_name = new System.Windows.Forms.TextBox();
            this.virtualenv_checkbox = new System.Windows.Forms.CheckBox();
            this.package_list = new System.Windows.Forms.ListBox();
            this.packages_label = new System.Windows.Forms.Label();
            this.add_package_button = new System.Windows.Forms.Button();
            this.package_name = new System.Windows.Forms.TextBox();
            this.delete_package_button = new System.Windows.Forms.Button();
            this.requirements_checkbox = new System.Windows.Forms.CheckBox();
            this.create_project = new System.Windows.Forms.Button();
            this.debug = new System.Windows.Forms.Label();
            this.debug2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(35, 12);
            this.projectName.MaxLength = 32;
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(156, 20);
            this.projectName.TabIndex = 0;
            this.projectName.Text = "Enter your project name here";
            // 
            // github_repo
            // 
            this.github_repo.Location = new System.Drawing.Point(35, 51);
            this.github_repo.MaxLength = 32;
            this.github_repo.Name = "github_repo";
            this.github_repo.Size = new System.Drawing.Size(156, 20);
            this.github_repo.TabIndex = 1;
            this.github_repo.Text = "Enter your github repo here";
            // 
            // project_dir
            // 
            this.project_dir.Location = new System.Drawing.Point(35, 88);
            this.project_dir.Name = "project_dir";
            this.project_dir.Size = new System.Drawing.Size(113, 20);
            this.project_dir.TabIndex = 2;
            this.project_dir.Text = "Etner project directory";
            // 
            // directoryDialog
            // 
            this.directoryDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.directoryDialog.SelectedPath = "C:\\Users";
            // 
            // project_dir_button
            // 
            this.project_dir_button.Location = new System.Drawing.Point(154, 88);
            this.project_dir_button.Name = "project_dir_button";
            this.project_dir_button.Size = new System.Drawing.Size(37, 20);
            this.project_dir_button.TabIndex = 3;
            this.project_dir_button.Text = "...";
            this.project_dir_button.UseVisualStyleBackColor = true;
            this.project_dir_button.Click += new System.EventHandler(this.project_dir_button_Click);
            // 
            // python_int
            // 
            this.python_int.Location = new System.Drawing.Point(35, 123);
            this.python_int.Name = "python_int";
            this.python_int.Size = new System.Drawing.Size(113, 20);
            this.python_int.TabIndex = 4;
            this.python_int.Text = "Etner python directory";
            // 
            // python_int_button
            // 
            this.python_int_button.Location = new System.Drawing.Point(154, 123);
            this.python_int_button.Name = "python_int_button";
            this.python_int_button.Size = new System.Drawing.Size(37, 20);
            this.python_int_button.TabIndex = 5;
            this.python_int_button.Text = "...";
            this.python_int_button.UseVisualStyleBackColor = true;
            this.python_int_button.Click += new System.EventHandler(this.python_int_button_Click);
            // 
            // virtualenv_name
            // 
            this.virtualenv_name.Location = new System.Drawing.Point(238, 12);
            this.virtualenv_name.MaxLength = 32;
            this.virtualenv_name.Name = "virtualenv_name";
            this.virtualenv_name.Size = new System.Drawing.Size(156, 20);
            this.virtualenv_name.TabIndex = 6;
            this.virtualenv_name.Text = "Enter your virtualenv name here";
            // 
            // virtualenv_checkbox
            // 
            this.virtualenv_checkbox.AutoSize = true;
            this.virtualenv_checkbox.Checked = true;
            this.virtualenv_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.virtualenv_checkbox.Location = new System.Drawing.Point(35, 158);
            this.virtualenv_checkbox.Name = "virtualenv_checkbox";
            this.virtualenv_checkbox.Size = new System.Drawing.Size(106, 17);
            this.virtualenv_checkbox.TabIndex = 7;
            this.virtualenv_checkbox.Text = "Create virtualenv";
            this.virtualenv_checkbox.UseVisualStyleBackColor = true;
            this.virtualenv_checkbox.CheckedChanged += new System.EventHandler(this.virtualenv_checkbox_CheckedChanged);
            // 
            // package_list
            // 
            this.package_list.FormattingEnabled = true;
            this.package_list.Location = new System.Drawing.Point(238, 67);
            this.package_list.Name = "package_list";
            this.package_list.Size = new System.Drawing.Size(156, 95);
            this.package_list.TabIndex = 8;
            // 
            // packages_label
            // 
            this.packages_label.AutoSize = true;
            this.packages_label.Location = new System.Drawing.Point(235, 51);
            this.packages_label.Name = "packages_label";
            this.packages_label.Size = new System.Drawing.Size(58, 13);
            this.packages_label.TabIndex = 9;
            this.packages_label.Text = "Packages:";
            // 
            // add_package_button
            // 
            this.add_package_button.Location = new System.Drawing.Point(238, 193);
            this.add_package_button.Name = "add_package_button";
            this.add_package_button.Size = new System.Drawing.Size(75, 23);
            this.add_package_button.TabIndex = 10;
            this.add_package_button.Text = "Add";
            this.add_package_button.UseVisualStyleBackColor = true;
            this.add_package_button.Click += new System.EventHandler(this.add_package_button_Click);
            // 
            // package_name
            // 
            this.package_name.Location = new System.Drawing.Point(238, 165);
            this.package_name.Name = "package_name";
            this.package_name.Size = new System.Drawing.Size(156, 20);
            this.package_name.TabIndex = 11;
            this.package_name.Text = "Package name here";
            // 
            // delete_package_button
            // 
            this.delete_package_button.Location = new System.Drawing.Point(319, 193);
            this.delete_package_button.Name = "delete_package_button";
            this.delete_package_button.Size = new System.Drawing.Size(75, 23);
            this.delete_package_button.TabIndex = 12;
            this.delete_package_button.Text = "Delete";
            this.delete_package_button.UseVisualStyleBackColor = true;
            this.delete_package_button.Click += new System.EventHandler(this.delete_package_button_Click);
            // 
            // requirements_checkbox
            // 
            this.requirements_checkbox.AutoSize = true;
            this.requirements_checkbox.Location = new System.Drawing.Point(238, 222);
            this.requirements_checkbox.Name = "requirements_checkbox";
            this.requirements_checkbox.Size = new System.Drawing.Size(134, 17);
            this.requirements_checkbox.TabIndex = 13;
            this.requirements_checkbox.Text = "Create requirements.txt";
            this.requirements_checkbox.UseVisualStyleBackColor = true;
            // 
            // create_project
            // 
            this.create_project.Location = new System.Drawing.Point(52, 195);
            this.create_project.Name = "create_project";
            this.create_project.Size = new System.Drawing.Size(96, 21);
            this.create_project.TabIndex = 14;
            this.create_project.Text = "Create";
            this.create_project.UseVisualStyleBackColor = true;
            this.create_project.Click += new System.EventHandler(this.create_project_Click);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(178, 225);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(35, 13);
            this.debug.TabIndex = 15;
            this.debug.Text = "label1";
            // 
            // debug2
            // 
            this.debug2.AutoSize = true;
            this.debug2.Location = new System.Drawing.Point(156, 172);
            this.debug2.Name = "debug2";
            this.debug2.Size = new System.Drawing.Size(35, 13);
            this.debug2.TabIndex = 16;
            this.debug2.Text = "label1";
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 243);
            this.Controls.Add(this.debug2);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.create_project);
            this.Controls.Add(this.requirements_checkbox);
            this.Controls.Add(this.delete_package_button);
            this.Controls.Add(this.package_name);
            this.Controls.Add(this.add_package_button);
            this.Controls.Add(this.packages_label);
            this.Controls.Add(this.package_list);
            this.Controls.Add(this.virtualenv_checkbox);
            this.Controls.Add(this.virtualenv_name);
            this.Controls.Add(this.python_int_button);
            this.Controls.Add(this.python_int);
            this.Controls.Add(this.project_dir_button);
            this.Controls.Add(this.project_dir);
            this.Controls.Add(this.github_repo);
            this.Controls.Add(this.projectName);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "index";
            this.Text = "FPC Python";
            this.Load += new System.EventHandler(this.index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox projectName;
        private System.Windows.Forms.TextBox github_repo;
        private System.Windows.Forms.TextBox project_dir;
        private System.Windows.Forms.FolderBrowserDialog directoryDialog;
        private System.Windows.Forms.Button project_dir_button;
        private System.Windows.Forms.TextBox python_int;
        private System.Windows.Forms.Button python_int_button;
        private System.Windows.Forms.TextBox virtualenv_name;
        private System.Windows.Forms.CheckBox virtualenv_checkbox;
        private System.Windows.Forms.ListBox package_list;
        private System.Windows.Forms.Label packages_label;
        private System.Windows.Forms.Button add_package_button;
        private System.Windows.Forms.TextBox package_name;
        private System.Windows.Forms.Button delete_package_button;
        private System.Windows.Forms.CheckBox requirements_checkbox;
        private System.Windows.Forms.Button create_project;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.Label debug2;
    }
}

