
namespace Garden.View
{
    partial class EmployeeView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantSpecies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantCarnivorous = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plantName,
            this.plantType,
            this.plantSpecies,
            this.plantCarnivorous,
            this.plantZone});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 330);
            this.dataGridView1.TabIndex = 1;
            // 
            // plantName
            // 
            this.plantName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plantName.HeaderText = "Name";
            this.plantName.Name = "plantName";
            this.plantName.ReadOnly = true;
            this.plantName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // plantType
            // 
            this.plantType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plantType.HeaderText = "Type";
            this.plantType.Name = "plantType";
            this.plantType.ReadOnly = true;
            this.plantType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // plantSpecies
            // 
            this.plantSpecies.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plantSpecies.HeaderText = "Species";
            this.plantSpecies.Name = "plantSpecies";
            this.plantSpecies.ReadOnly = true;
            this.plantSpecies.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // plantCarnivorous
            // 
            this.plantCarnivorous.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plantCarnivorous.HeaderText = "Carnivorous";
            this.plantCarnivorous.Name = "plantCarnivorous";
            this.plantCarnivorous.ReadOnly = true;
            this.plantCarnivorous.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // plantZone
            // 
            this.plantZone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plantZone.HeaderText = "Zone";
            this.plantZone.Name = "plantZone";
            this.plantZone.ReadOnly = true;
            this.plantZone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(747, 432);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(23, 432);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(138, 432);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(255, 432);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(100, 23);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 387);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 387);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(255, 387);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(372, 387);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(490, 387);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Type";
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(372, 432);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(100, 23);
            this.reportBtn.TabIndex = 13;
            this.reportBtn.Text = "Reports";
            this.reportBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Species";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Carnivorous";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Zone";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CSV",
            "JSON"});
            this.comboBox1.Location = new System.Drawing.Point(490, 434);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 467);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeView";
            this.Text = "EmployeeView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantType;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantSpecies;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantCarnivorous;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantZone;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}