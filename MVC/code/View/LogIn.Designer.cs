
namespace Garden.View
{
    partial class LogIn
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.accountText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 427);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;

            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(104, 275);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(100, 23);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account";
            // 
            // accountText
            // 
            this.accountText.Location = new System.Drawing.Point(104, 108);
            this.accountText.Name = "accountText";
            this.accountText.Size = new System.Drawing.Size(100, 20);
            this.accountText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(104, 222);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(100, 20);
            this.PasswordText.TabIndex = 5;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 462);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accountText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordText;
    }
}