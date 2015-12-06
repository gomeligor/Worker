namespace Worker
{
    partial class SaveInExcel
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxWorkerName = new System.Windows.Forms.TextBox();
            this.workersDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalaryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMounthSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.comboBoxSalaryType = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxWorkerName
            // 
            this.textBoxWorkerName.Location = new System.Drawing.Point(25, 186);
            this.textBoxWorkerName.Name = "textBoxWorkerName";
            this.textBoxWorkerName.Size = new System.Drawing.Size(125, 20);
            this.textBoxWorkerName.TabIndex = 0;
            this.textBoxWorkerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // workersDataGridView
            // 
            this.workersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnSalaryType,
            this.ColumnSalary,
            this.ColumnMounthSalary});
            this.workersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.workersDataGridView.Name = "workersDataGridView";
            this.workersDataGridView.Size = new System.Drawing.Size(483, 150);
            this.workersDataGridView.TabIndex = 1;
            this.workersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 40;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnSalaryType
            // 
            this.ColumnSalaryType.HeaderText = "Salary Type";
            this.ColumnSalaryType.Name = "ColumnSalaryType";
            // 
            // ColumnSalary
            // 
            this.ColumnSalary.HeaderText = "Salary";
            this.ColumnSalary.Name = "ColumnSalary";
            // 
            // ColumnMounthSalary
            // 
            this.ColumnMounthSalary.HeaderText = "Mounth Salary";
            this.ColumnMounthSalary.Name = "ColumnMounthSalary";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(253, 186);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(101, 20);
            this.textBoxSalary.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(188, 273);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(101, 23);
            this.Sort.TabIndex = 6;
            this.Sort.Text = "Сортувати";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // comboBoxSalaryType
            // 
            this.comboBoxSalaryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSalaryType.FormattingEnabled = true;
            this.comboBoxSalaryType.Items.AddRange(new object[] {
            "Hour",
            "Mounth"});
            this.comboBoxSalaryType.Location = new System.Drawing.Point(157, 186);
            this.comboBoxSalaryType.Name = "comboBoxSalaryType";
            this.comboBoxSalaryType.Size = new System.Drawing.Size(90, 21);
            this.comboBoxSalaryType.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Сохранить в Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SaveInExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 328);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxSalaryType);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.workersDataGridView);
            this.Controls.Add(this.textBoxWorkerName);
            this.Name = "SaveInExcel";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWorkerName;
        private System.Windows.Forms.DataGridView workersDataGridView;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalaryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMounthSalary;
        private System.Windows.Forms.ComboBox comboBoxSalaryType;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

