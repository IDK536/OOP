namespace OOP
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
            work_time = new Button();
            textBox1 = new TextBox();
            exit = new Button();
            open_form2 = new Button();
            create_button = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // work_time
            // 
            work_time.Location = new Point(322, 423);
            work_time.Margin = new Padding(3, 4, 3, 4);
            work_time.Name = "work_time";
            work_time.Size = new Size(253, 104);
            work_time.TabIndex = 0;
            work_time.Text = "Work time";
            work_time.UseVisualStyleBackColor = true;
            work_time.Click += Work_Time_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(390, 273);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 1;
            // 
            // exit
            // 
            exit.Location = new Point(829, -4);
            exit.Margin = new Padding(3, 4, 3, 4);
            exit.Name = "exit";
            exit.Size = new Size(86, 31);
            exit.TabIndex = 2;
            exit.Text = "exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += Exit_Click;
            // 
            // open_form2
            // 
            open_form2.Location = new Point(70, 423);
            open_form2.Name = "open_form2";
            open_form2.Size = new Size(175, 104);
            open_form2.TabIndex = 3;
            open_form2.Text = "Open second window";
            open_form2.UseVisualStyleBackColor = true;
            open_form2.Click += Open_Form2;
            // 
            // create_button
            // 
            create_button.Location = new Point(653, 423);
            create_button.Name = "create_button";
            create_button.Size = new Size(214, 104);
            create_button.TabIndex = 5;
            create_button.Text = "Create new button";
            create_button.UseVisualStyleBackColor = true;
            create_button.Click += Create_Button_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(598, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Controls.Add(create_button);
            Controls.Add(open_form2);
            Controls.Add(exit);
            Controls.Add(textBox1);
            Controls.Add(work_time);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button work_time;
        private TextBox textBox1;
        private Button exit;
        private Button open_form2;
        private Button create_button;
        private Panel panel1;
    }
}
