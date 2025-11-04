namespace Proyekakhir_Rizkiiqbaltawakkal_XPPLG1
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            groupBox1 = new GroupBox();
            btnlogin = new Button();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            lblpassword = new Label();
            lblusername = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(btnlogin);
            groupBox1.Controls.Add(txtpassword);
            groupBox1.Controls.Add(txtusername);
            groupBox1.Controls.Add(lblpassword);
            groupBox1.Controls.Add(lblusername);
            groupBox1.Location = new Point(248, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nama siswa";
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(137, 164);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 29);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(128, 110);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(125, 27);
            txtpassword.TabIndex = 3;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(128, 63);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(125, 27);
            txtusername.TabIndex = 2;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(29, 113);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(75, 20);
            lblpassword.TabIndex = 1;
            lblpassword.Text = "password:";
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(29, 66);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(76, 20);
            lblusername.TabIndex = 0;
            lblusername.Text = "username:";
            lblusername.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(385, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 32);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.ErrorImage = null;
            pictureBox2.Location = new Point(6, 110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 32);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "FormLogin";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblusername;
        private TextBox txtusername;
        private Label lblpassword;
        private TextBox txtpassword;
        private Button btnlogin;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
