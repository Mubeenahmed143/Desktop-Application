namespace WinForm_2212F3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            Id = new ColumnHeader();
            name = new ColumnHeader();
            age = new ColumnHeader();
            course = new ColumnHeader();
            gender = new ColumnHeader();
            email = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Id, name, email, age, course, gender });
            listView1.Location = new Point(88, 56);
            listView1.Name = "listView1";
            listView1.Size = new Size(551, 294);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // name
            // 
            name.Text = "Name";
            name.Width = 100;
            // 
            // age
            // 
            age.DisplayIndex = 2;
            age.Text = "Age";
            age.Width = 80;
            // 
            // course
            // 
            course.DisplayIndex = 3;
            course.Text = "Course";
            course.Width = 120;
            // 
            // gender
            // 
            gender.DisplayIndex = 4;
            gender.Text = "Gender";
            gender.Width = 80;
            // 
            // email
            // 
            email.DisplayIndex = 5;
            email.Text = "Email";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader Id;
        private ColumnHeader name;
        private ColumnHeader age;
        private ColumnHeader course;
        private ColumnHeader gender;
        private ColumnHeader email;
    }
}