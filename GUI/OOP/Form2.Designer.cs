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
            checkbox = new CheckBox();
            label1 = new Label();
            move_control_label = new Label();
            panel1 = new Panel();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(497, 50);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 10, 0);
            panel1.Size = new Size(272, 339);
            panel1.TabIndex = 4;
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
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(34, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            comboBox1.
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
            MouseMove += mose_move_control;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}