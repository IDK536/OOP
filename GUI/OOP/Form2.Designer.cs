namespace OOP
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
            components = new System.ComponentModel.Container();
            checkbox = new CheckBox();
            label1 = new Label();
            move_control_label = new Label();
            panel1 = new Panel();
            trackBar1 = new TrackBar();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // checkbox
            // 
            checkbox.AutoSize = true;
            checkbox.Location = new Point(36, 219);
            checkbox.Name = "checkbox";
            checkbox.Size = new Size(93, 24);
            checkbox.TabIndex = 1;
            checkbox.Text = "checkBox";
            checkbox.UseVisualStyleBackColor = true;
            checkbox.CheckedChanged += box_ChackedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 156);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // move_control_label
            // 
            move_control_label.AutoSize = true;
            move_control_label.Location = new Point(384, 173);
            move_control_label.Name = "move_control_label";
            move_control_label.Size = new Size(32, 20);
            move_control_label.TabIndex = 3;
            move_control_label.Text = "0, 0";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(497, 50);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 10, 0);
            panel1.Size = new Size(272, 339);
            panel1.TabIndex = 4;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(34, 123);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(130, 56);
            trackBar1.TabIndex = 6;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(34, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += combobox1_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(34, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radio_CheckedChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(move_control_label);
            Controls.Add(label1);
            Controls.Add(checkbox);
            Name = "Form2";
            Text = "Form2";
            MouseMove += mouse_move_control;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkbox;
        private Label label1;
        private Label move_control_label;
        private Panel panel1;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
    }
}