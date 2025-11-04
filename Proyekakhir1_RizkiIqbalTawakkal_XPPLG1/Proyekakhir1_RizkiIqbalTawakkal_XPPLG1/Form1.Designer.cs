namespace Proyekakhir1_RizkiIqbalTawakkal_XPPLG1
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
            btnlogin = new Button();
            txtusername = new TextBox();
            lblusername = new Label();
            lblpassword = new Label();
            txtpassword = new TextBox();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(234, 236);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(68, 37);
            btnlogin.TabIndex = 0;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(252, 123);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(125, 27);
            txtusername.TabIndex = 1;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(170, 126);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(76, 20);
            lblusername.TabIndex = 2;
            lblusername.Text = "username:";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(170, 169);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(75, 20);
            lblpassword.TabIndex = 3;
            lblpassword.Text = "password:";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(252, 166);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(125, 27);
            txtpassword.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtpassword);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Controls.Add(txtusername);
            Controls.Add(btnlogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogin;
        private TextBox txtusername;
        private Label lblusername;
        private Label lblpassword;
        private TextBox txtpassword;
    }
}
