
namespace Garden.View
{
    partial class VisitorView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantSpecies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantCarnivorous = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.filterBtn = new System.Windows.Forms.Button();
            this.filterCombo = new System.Windows.Forms.ComboBox();
            this.statsBtn = new System.Windows.Forms.Button();
            this.filterTxt = new System.Windows.Forms.TextBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.statistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statsCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistics)).BeginInit();
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
            this.dataGridView1.TabIndex = 0;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(792, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;

            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1097, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;

            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(34, 393);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(121, 23);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;

            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(320, 393);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(121, 23);
            this.filterBtn.TabIndex = 4;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;

            // 
            // filterCombo
            // 
            this.filterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterCombo.FormattingEnabled = true;
            this.filterCombo.Items.AddRange(new object[] {
            "name",
            "type",
            "species",
            "isCarnivorous",
            "Zone"});
            this.filterCombo.Location = new System.Drawing.Point(462, 395);
            this.filterCombo.Name = "filterCombo";
            this.filterCombo.Size = new System.Drawing.Size(121, 21);
            this.filterCombo.TabIndex = 5;
            // 
            // statsBtn
            // 
            this.statsBtn.Location = new System.Drawing.Point(177, 393);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(121, 23);
            this.statsBtn.TabIndex = 6;
            this.statsBtn.Text = "Statistics";
            this.statsBtn.UseVisualStyleBackColor = true;

            // 
            // filterTxt
            // 
            this.filterTxt.Location = new System.Drawing.Point(598, 395);
            this.filterTxt.Name = "filterTxt";
            this.filterTxt.Size = new System.Drawing.Size(121, 20);
            this.filterTxt.TabIndex = 7;
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(34, 433);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(121, 20);
            this.searchTxt.TabIndex = 8;
            // 
            // statistics
            // 
            chartArea1.Name = "ChartArea1";
            this.statistics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.statistics.Legends.Add(legend1);
            this.statistics.Location = new System.Drawing.Point(872, 42);
            this.statistics.Name = "statistics";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.statistics.Series.Add(series1);
            this.statistics.Size = new System.Drawing.Size(300, 300);
            this.statistics.TabIndex = 9;
            this.statistics.Text = "chart1";
            this.statistics.Visible = false;
            // 
            // statsCombo
            // 
            this.statsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statsCombo.FormattingEnabled = true;
            this.statsCombo.Items.AddRange(new object[] {
            "Carnivorous",
            "Zone"});
            this.statsCombo.Location = new System.Drawing.Point(177, 432);
            this.statsCombo.Name = "statsCombo";
            this.statsCombo.Size = new System.Drawing.Size(121, 21);
            this.statsCombo.TabIndex = 10;
            // 
            // VisitorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 482);
            this.Controls.Add(this.statsCombo);
            this.Controls.Add(this.statistics);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.filterTxt);
            this.Controls.Add(this.statsBtn);
            this.Controls.Add(this.filterCombo);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VisitorView";
            this.Text = "VisitorView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantType;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantSpecies;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantCarnivorous;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantZone;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.ComboBox filterCombo;
        private System.Windows.Forms.Button statsBtn;
        private System.Windows.Forms.TextBox filterTxt;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.DataVisualization.Charting.Chart statistics;
        private System.Windows.Forms.ComboBox statsCombo;
    }
}