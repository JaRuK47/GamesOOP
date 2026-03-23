namespace classGame
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
            txtOut = new RichTextBox();
            btnRefill = new Button();
            btnGet = new Button();
            txtInfo = new RichTextBox();
            SuspendLayout();
            // 
            // txtOut
            // 
            txtOut.Location = new Point(12, 113);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(164, 120);
            txtOut.TabIndex = 0;
            txtOut.Text = "";
            // 
            // btnRefill
            // 
            btnRefill.Location = new Point(12, 12);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(264, 29);
            btnRefill.TabIndex = 1;
            btnRefill.Text = "Рерол";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(182, 113);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(94, 120);
            btnGet.TabIndex = 2;
            btnGet.Text = "Пробуем";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(12, 47);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(264, 60);
            txtInfo.TabIndex = 3;
            txtInfo.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 247);
            Controls.Add(txtInfo);
            Controls.Add(btnGet);
            Controls.Add(btnRefill);
            Controls.Add(txtOut);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtOut;
        private Button btnRefill;
        private Button btnGet;
        private RichTextBox txtInfo;
    }
}
