namespace Tic_Tac_Toe_MP
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.iTalk_ThemeContainer1 = new iTalk.iTalk_ThemeContainer();
            this.iTalk_Button_11 = new iTalk.iTalk_Button_1();
            this.txt_Username = new iTalk.iTalk_TextBox_Big();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.iTalk_ControlBox1 = new iTalk.iTalk_ControlBox();
            this.iTalk_ThemeContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iTalk_ThemeContainer1
            // 
            this.iTalk_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.iTalk_ThemeContainer1.Controls.Add(this.iTalk_ControlBox1);
            this.iTalk_ThemeContainer1.Controls.Add(this.iTalk_Button_11);
            this.iTalk_ThemeContainer1.Controls.Add(this.txt_Username);
            this.iTalk_ThemeContainer1.Controls.Add(this.iTalk_Label1);
            this.iTalk_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iTalk_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_ThemeContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_ThemeContainer1.Name = "iTalk_ThemeContainer1";
            this.iTalk_ThemeContainer1.Padding = new System.Windows.Forms.Padding(3, 28, 3, 28);
            this.iTalk_ThemeContainer1.Sizable = true;
            this.iTalk_ThemeContainer1.Size = new System.Drawing.Size(230, 220);
            this.iTalk_ThemeContainer1.SmartBounds = false;
            this.iTalk_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.iTalk_ThemeContainer1.TabIndex = 0;
            this.iTalk_ThemeContainer1.Text = "Login";
            // 
            // iTalk_Button_11
            // 
            this.iTalk_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iTalk_Button_11.Image = null;
            this.iTalk_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_11.Location = new System.Drawing.Point(19, 149);
            this.iTalk_Button_11.Name = "iTalk_Button_11";
            this.iTalk_Button_11.Size = new System.Drawing.Size(199, 40);
            this.iTalk_Button_11.TabIndex = 2;
            this.iTalk_Button_11.Text = "Login";
            this.iTalk_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_11.Click += new System.EventHandler(this.btn_SetName_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.Transparent;
            this.txt_Username.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_Username.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Username.Image = null;
            this.txt_Username.Location = new System.Drawing.Point(19, 100);
            this.txt_Username.MaxLength = 25;
            this.txt_Username.Multiline = false;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.ReadOnly = false;
            this.txt_Username.Size = new System.Drawing.Size(199, 41);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Username.UseSystemPasswordChar = false;
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 32F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(9, 38);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(215, 59);
            this.iTalk_Label1.TabIndex = 0;
            this.iTalk_Label1.Text = "Username";
            // 
            // iTalk_ControlBox1
            // 
            this.iTalk_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iTalk_ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_ControlBox1.Location = new System.Drawing.Point(141, 31);
            this.iTalk_ControlBox1.Name = "iTalk_ControlBox1";
            this.iTalk_ControlBox1.Size = new System.Drawing.Size(77, 19);
            this.iTalk_ControlBox1.TabIndex = 3;
            this.iTalk_ControlBox1.Text = "iTalk_ControlBox1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 220);
            this.Controls.Add(this.iTalk_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(126, 39);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Login_Load);
            this.iTalk_ThemeContainer1.ResumeLayout(false);
            this.iTalk_ThemeContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_ThemeContainer iTalk_ThemeContainer1;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Button_1 iTalk_Button_11;
        private iTalk.iTalk_TextBox_Big txt_Username;
        private iTalk.iTalk_ControlBox iTalk_ControlBox1;
    }
}