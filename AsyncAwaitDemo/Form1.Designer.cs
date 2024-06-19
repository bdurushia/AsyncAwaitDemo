namespace AsyncAwaitDemo
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
            ThreadLockButton = new Button();
            UnlockThreadButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // ThreadLockButton
            // 
            ThreadLockButton.Location = new Point(287, 215);
            ThreadLockButton.Name = "ThreadLockButton";
            ThreadLockButton.Size = new Size(202, 46);
            ThreadLockButton.TabIndex = 0;
            ThreadLockButton.Text = "Lock Thread";
            ThreadLockButton.UseVisualStyleBackColor = true;
            ThreadLockButton.Click += ThreadLockButton_Click;
            // 
            // UnlockThreadButton
            // 
            UnlockThreadButton.Location = new Point(795, 215);
            UnlockThreadButton.Name = "UnlockThreadButton";
            UnlockThreadButton.Size = new Size(250, 46);
            UnlockThreadButton.TabIndex = 2;
            UnlockThreadButton.Text = "Unlocked Thread";
            UnlockThreadButton.UseVisualStyleBackColor = true;
            UnlockThreadButton.Click += UnlockThreadButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(289, 470);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Plz don't lock me!";
            textBox1.Size = new Size(763, 392);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 1032);
            Controls.Add(textBox1);
            Controls.Add(UnlockThreadButton);
            Controls.Add(ThreadLockButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ThreadLockButton;
        private Button UnlockThreadButton;
        private TextBox textBox1;
    }
}
