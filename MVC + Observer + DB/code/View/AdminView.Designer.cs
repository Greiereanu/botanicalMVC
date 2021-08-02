
namespace Garden.View
{
    partial class AdminView
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.accountTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.roleTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.formTestPresenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formTestPresenterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTestPresenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTestPresenterBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountCol,
            this.passwordCol,
            this.roleCol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(688, 229);
            this.dataGridView1.TabIndex = 3;
            // 
            // accountCol
            // 
            this.accountCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountCol.HeaderText = "Account";
            this.accountCol.Name = "accountCol";
            this.accountCol.ReadOnly = true;
            this.accountCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // passwordCol
            // 
            this.passwordCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passwordCol.HeaderText = "Password";
            this.passwordCol.Name = "passwordCol";
            this.passwordCol.ReadOnly = true;
            // 
            // roleCol
            // 
            this.roleCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roleCol.HeaderText = "Role";
            this.roleCol.Name = "roleCol";
            this.roleCol.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "admin",
            "employee"});
            this.comboBox1.Location = new System.Drawing.Point(427, 339);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Filter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // accountTxt
            // 
            this.accountTxt.Location = new System.Drawing.Point(12, 339);
            this.accountTxt.Name = "accountTxt";
            this.accountTxt.Size = new System.Drawing.Size(100, 20);
            this.accountTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Role";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(158, 339);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(100, 20);
            this.passwordTxt.TabIndex = 11;
            // 
            // roleTxt
            // 
            this.roleTxt.Location = new System.Drawing.Point(306, 340);
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(100, 20);
            this.roleTxt.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;

            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;

            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(306, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;

            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(579, 399);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;

            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 445);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roleTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountTxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminView";
            this.Text = "Admin GUI";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTestPresenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTestPresenterBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleCol;
        private System.Windows.Forms.BindingSource formTestPresenterBindingSource;
        private System.Windows.Forms.BindingSource formTestPresenterBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox accountTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox roleTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}