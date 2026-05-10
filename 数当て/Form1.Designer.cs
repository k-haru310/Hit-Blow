namespace 数当て
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
            btAns = new Button();
            Writelabel = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            txtInput1 = new TextBox();
            txtInput2 = new TextBox();
            txtInput3 = new TextBox();
            txtInput4 = new TextBox();
            AnsButton = new Button();
            SuspendLayout();
            // 
            // btAns
            // 
            btAns.Location = new Point(0, 0);
            btAns.Name = "btAns";
            btAns.Size = new Size(75, 23);
            btAns.TabIndex = 20;
            // 
            // Writelabel
            // 
            Writelabel.Location = new Point(0, 0);
            Writelabel.Name = "Writelabel";
            Writelabel.Size = new Size(100, 23);
            Writelabel.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(116, 80);
            button1.Name = "button1";
            button1.Size = new Size(37, 31);
            button1.TabIndex = 4;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NumberButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(72, 80);
            button2.Name = "button2";
            button2.Size = new Size(37, 31);
            button2.TabIndex = 5;
            button2.Text = "0";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NumberButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(163, 80);
            button3.Name = "button3";
            button3.Size = new Size(37, 31);
            button3.TabIndex = 6;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NumberButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(206, 80);
            button4.Name = "button4";
            button4.Size = new Size(37, 31);
            button4.TabIndex = 7;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += NumberButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(249, 80);
            button5.Name = "button5";
            button5.Size = new Size(37, 31);
            button5.TabIndex = 8;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += NumberButton_Click;
            // 
            // button6
            // 
            button6.Location = new Point(73, 117);
            button6.Name = "button6";
            button6.Size = new Size(37, 31);
            button6.TabIndex = 9;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += NumberButton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(116, 117);
            button7.Name = "button7";
            button7.Size = new Size(37, 31);
            button7.TabIndex = 10;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += NumberButton_Click;
            // 
            // button8
            // 
            button8.Location = new Point(163, 117);
            button8.Name = "button8";
            button8.Size = new Size(37, 31);
            button8.TabIndex = 11;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += NumberButton_Click;
            // 
            // button9
            // 
            button9.Location = new Point(206, 117);
            button9.Name = "button9";
            button9.Size = new Size(37, 31);
            button9.TabIndex = 12;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NumberButton_Click;
            // 
            // button10
            // 
            button10.Location = new Point(249, 117);
            button10.Name = "button10";
            button10.Size = new Size(37, 31);
            button10.TabIndex = 13;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            button10.Click += NumberButton_Click;
            // 
            // txtInput1
            // 
            txtInput1.Location = new Point(73, 169);
            txtInput1.Name = "txtInput1";
            txtInput1.ReadOnly = true;
            txtInput1.Size = new Size(37, 23);
            txtInput1.TabIndex = 14;
            txtInput1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtInput2
            // 
            txtInput2.Location = new Point(116, 169);
            txtInput2.Name = "txtInput2";
            txtInput2.ReadOnly = true;
            txtInput2.Size = new Size(37, 23);
            txtInput2.TabIndex = 15;
            txtInput2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtInput3
            // 
            txtInput3.Location = new Point(163, 169);
            txtInput3.Name = "txtInput3";
            txtInput3.ReadOnly = true;
            txtInput3.Size = new Size(37, 23);
            txtInput3.TabIndex = 16;
            txtInput3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtInput4
            // 
            txtInput4.Location = new Point(206, 169);
            txtInput4.Name = "txtInput4";
            txtInput4.ReadOnly = true;
            txtInput4.Size = new Size(37, 23);
            txtInput4.TabIndex = 17;
            txtInput4.TextAlign = HorizontalAlignment.Center;
            // 
            // AnsButton
            // 
            AnsButton.Location = new Point(269, 169);
            AnsButton.Name = "AnsButton";
            AnsButton.Size = new Size(125, 23);
            AnsButton.TabIndex = 21;
            AnsButton.Text = "回答する";
            AnsButton.UseVisualStyleBackColor = true;
            AnsButton.Click += AnsButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 331);
            Controls.Add(AnsButton);
            Controls.Add(txtInput4);
            Controls.Add(txtInput3);
            Controls.Add(txtInput2);
            Controls.Add(txtInput1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Writelabel);
            Controls.Add(btAns);
            Name = "Form1";
            Text = "Hit-Blow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAns;
        private Label Writelabel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox txtInput1;
        private TextBox txtInput2;
        private TextBox txtInput3;
        private TextBox txtInput4;
        private Button AnsButton;
    }
}
