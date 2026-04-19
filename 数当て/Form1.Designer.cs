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
            textBox1 = new TextBox();
            Writelabel = new Label();
            Anslavel = new Label();
            SuspendLayout();
            // 
            // btAns
            // 
            btAns.Location = new Point(286, 76);
            btAns.Name = "btAns";
            btAns.Size = new Size(105, 39);
            btAns.TabIndex = 0;
            btAns.Text = "回答する";
            btAns.UseVisualStyleBackColor = true;
            btAns.Click += btAns_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Writelabel
            // 
            Writelabel.AutoSize = true;
            Writelabel.Location = new Point(87, 48);
            Writelabel.Name = "Writelabel";
            Writelabel.Size = new Size(115, 15);
            Writelabel.TabIndex = 2;
            Writelabel.Text = "数字を入力してください";
            // 
            // Anslavel
            // 
            Anslavel.AutoSize = true;
            Anslavel.Location = new Point(87, 148);
            Anslavel.Name = "Anslavel";
            Anslavel.Size = new Size(38, 15);
            Anslavel.TabIndex = 3;
            Anslavel.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Anslavel);
            Controls.Add(Writelabel);
            Controls.Add(textBox1);
            Controls.Add(btAns);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAns;
        private TextBox textBox1;
        private Label Writelabel;
        private Label Anslavel;
    }
}
