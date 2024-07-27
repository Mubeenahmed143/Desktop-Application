namespace WinForm_2212F3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            Name_lable = new Label();
            Email_lable = new Label();
            age_lable = new Label();
            Course_lable = new Label();
            name = new TextBox();
            email = new TextBox();
            age = new TextBox();
            course = new ComboBox();
            gen_lable = new Label();
            submit = new Button();
            gender = new ComboBox();
            show = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(161, 25);
            label1.Name = "label1";
            label1.Size = new Size(364, 30);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // Name_lable
            // 
            Name_lable.AutoSize = true;
            Name_lable.BackColor = Color.WhiteSmoke;
            Name_lable.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name_lable.Location = new Point(153, 97);
            Name_lable.Name = "Name_lable";
            Name_lable.Size = new Size(43, 17);
            Name_lable.TabIndex = 1;
            Name_lable.Text = "Name";
            // 
            // Email_lable
            // 
            Email_lable.AutoSize = true;
            Email_lable.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Email_lable.Location = new Point(157, 136);
            Email_lable.Name = "Email_lable";
            Email_lable.Size = new Size(39, 17);
            Email_lable.TabIndex = 2;
            Email_lable.Text = "Email";
            Email_lable.Click += Email_lable_Click;
            // 
            // age_lable
            // 
            age_lable.AutoSize = true;
            age_lable.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            age_lable.Location = new Point(157, 171);
            age_lable.Name = "age_lable";
            age_lable.Size = new Size(31, 17);
            age_lable.TabIndex = 3;
            age_lable.Text = "Age";
            // 
            // Course_lable
            // 
            Course_lable.AutoSize = true;
            Course_lable.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Course_lable.Location = new Point(157, 211);
            Course_lable.Name = "Course_lable";
            Course_lable.Size = new Size(49, 17);
            Course_lable.TabIndex = 4;
            Course_lable.Text = "Course";
            // 
            // name
            // 
            name.Location = new Point(280, 91);
            name.Name = "name";
            name.Size = new Size(224, 23);
            name.TabIndex = 5;
            // 
            // email
            // 
            email.Location = new Point(280, 130);
            email.Name = "email";
            email.Size = new Size(224, 23);
            email.TabIndex = 6;
            // 
            // age
            // 
            age.Location = new Point(280, 165);
            age.Name = "age";
            age.Size = new Size(224, 23);
            age.TabIndex = 7;
            // 
            // course
            // 
            course.FormattingEnabled = true;
            course.Items.AddRange(new object[] { "Web Designing", "Web Development", "Graphics", "Digital Marketing", "Artificial Intelligence" });
            course.Location = new Point(280, 205);
            course.Name = "course";
            course.Size = new Size(224, 23);
            course.TabIndex = 8;
            course.Text = "Select your course";
            // 
            // gen_lable
            // 
            gen_lable.AutoSize = true;
            gen_lable.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gen_lable.Location = new Point(157, 258);
            gen_lable.Name = "gen_lable";
            gen_lable.Size = new Size(51, 17);
            gen_lable.TabIndex = 9;
            gen_lable.Text = "Gender";
            // 
            // submit
            // 
            submit.BackColor = SystemColors.ActiveCaption;
            submit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            submit.ForeColor = Color.DarkRed;
            submit.Location = new Point(161, 317);
            submit.Name = "submit";
            submit.Size = new Size(364, 30);
            submit.TabIndex = 12;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // gender
            // 
            gender.DrawMode = DrawMode.OwnerDrawVariable;
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.Location = new Point(280, 255);
            gender.Name = "gender";
            gender.Size = new Size(224, 24);
            gender.TabIndex = 13;
            gender.Text = "Select gender";
            // 
            // show
            // 
            show.Location = new Point(280, 367);
            show.Name = "show";
            show.Size = new Size(142, 39);
            show.TabIndex = 14;
            show.Text = "Show Data";
            show.UseVisualStyleBackColor = true;
            show.Click += show_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(655, 444);
            Controls.Add(show);
            Controls.Add(gender);
            Controls.Add(submit);
            Controls.Add(gen_lable);
            Controls.Add(course);
            Controls.Add(age);
            Controls.Add(email);
            Controls.Add(name);
            Controls.Add(Course_lable);
            Controls.Add(age_lable);
            Controls.Add(Email_lable);
            Controls.Add(Name_lable);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Name_lable;
        private Label Email_lable;
        private Label age_lable;
        private Label Course_lable;
        private TextBox name;
        private TextBox email;
        private TextBox age;
        private ComboBox course;
        private Label gen_lable;
        private Button submit;
        private ComboBox gender;
        private Button show;
    }
}