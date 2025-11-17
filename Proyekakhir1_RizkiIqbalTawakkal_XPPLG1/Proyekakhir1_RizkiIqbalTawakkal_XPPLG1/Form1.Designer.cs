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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnlogin = new Button();
            txtusername = new TextBox();
            lblusername = new Label();
            lblpassword = new Label();
            txtpassword = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(450, 303);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(68, 37);
            btnlogin.TabIndex = 0;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(468, 190);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(125, 27);
            txtusername.TabIndex = 1;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(386, 193);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(76, 20);
            lblusername.TabIndex = 2;
            lblusername.Text = "username:";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(386, 236);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(75, 20);
            lblpassword.TabIndex = 3;
            lblpassword.Text = "password:";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(468, 233);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(125, 27);
            txtpassword.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(468, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 59);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 504);
            Controls.Add(pictureBox1);
            Controls.Add(txtpassword);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Controls.Add(txtusername);
            Controls.Add(btnlogin);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogin;
        private TextBox txtusername;
        private Label lblusername;
        private Label lblpassword;
        private TextBox txtpassword;
        private PictureBox pictureBox1;
    }
}
