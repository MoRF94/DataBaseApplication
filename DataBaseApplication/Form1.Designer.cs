namespace DataBaseApplication
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage_CreateQuery = new System.Windows.Forms.TabPage();
            this.textBox_TextQuery = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage_SelectTable = new System.Windows.Forms.TabPage();
            this.checkBox_Headers = new System.Windows.Forms.CheckBox();
            this.checkBox_Field = new System.Windows.Forms.CheckBox();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_SelectTable = new System.Windows.Forms.Label();
            this.button_Connection = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel_StatusQuery = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox_StatusQuery = new System.Windows.Forms.ToolStripTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_CreateQuery.SuspendLayout();
            this.tabPage_SelectTable.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 329);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // tabPage_CreateQuery
            // 
            this.tabPage_CreateQuery.Controls.Add(this.textBox_TextQuery);
            this.tabPage_CreateQuery.Controls.Add(this.button1);
            this.tabPage_CreateQuery.Location = new System.Drawing.Point(4, 25);
            this.tabPage_CreateQuery.Name = "tabPage_CreateQuery";
            this.tabPage_CreateQuery.Size = new System.Drawing.Size(660, 90);
            this.tabPage_CreateQuery.TabIndex = 2;
            this.tabPage_CreateQuery.Text = "Создать запрос";
            this.tabPage_CreateQuery.UseVisualStyleBackColor = true;
            // 
            // textBox_TextQuery
            // 
            this.textBox_TextQuery.Location = new System.Drawing.Point(4, 4);
            this.textBox_TextQuery.Multiline = true;
            this.textBox_TextQuery.Name = "textBox_TextQuery";
            this.textBox_TextQuery.Size = new System.Drawing.Size(583, 70);
            this.textBox_TextQuery.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "GO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage_SelectTable
            // 
            this.tabPage_SelectTable.Controls.Add(this.checkBox_Headers);
            this.tabPage_SelectTable.Controls.Add(this.checkBox_Field);
            this.tabPage_SelectTable.Controls.Add(this.textBox_Search);
            this.tabPage_SelectTable.Controls.Add(this.button_Search);
            this.tabPage_SelectTable.Controls.Add(this.label_SelectTable);
            this.tabPage_SelectTable.Controls.Add(this.button_Connection);
            this.tabPage_SelectTable.Controls.Add(this.comboBox1);
            this.tabPage_SelectTable.Location = new System.Drawing.Point(4, 25);
            this.tabPage_SelectTable.Name = "tabPage_SelectTable";
            this.tabPage_SelectTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SelectTable.Size = new System.Drawing.Size(660, 90);
            this.tabPage_SelectTable.TabIndex = 0;
            this.tabPage_SelectTable.Text = "Таблицы";
            this.tabPage_SelectTable.UseVisualStyleBackColor = true;
            // 
            // checkBox_Headers
            // 
            this.checkBox_Headers.AutoSize = true;
            this.checkBox_Headers.Location = new System.Drawing.Point(31, 61);
            this.checkBox_Headers.Name = "checkBox_Headers";
            this.checkBox_Headers.Size = new System.Drawing.Size(127, 21);
            this.checkBox_Headers.TabIndex = 9;
            this.checkBox_Headers.Text = "По заголовкам";
            this.checkBox_Headers.UseVisualStyleBackColor = true;
            this.checkBox_Headers.CheckedChanged += new System.EventHandler(this.checkBox_Headers_CheckedChanged);
            // 
            // checkBox_Field
            // 
            this.checkBox_Field.AutoSize = true;
            this.checkBox_Field.Location = new System.Drawing.Point(31, 39);
            this.checkBox_Field.Name = "checkBox_Field";
            this.checkBox_Field.Size = new System.Drawing.Size(93, 21);
            this.checkBox_Field.TabIndex = 8;
            this.checkBox_Field.Text = "По полям";
            this.checkBox_Field.UseVisualStyleBackColor = true;
            this.checkBox_Field.CheckedChanged += new System.EventHandler(this.checkBox_Field_CheckedChanged);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(191, 56);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(317, 22);
            this.textBox_Search.TabIndex = 7;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(514, 47);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(123, 37);
            this.button_Search.TabIndex = 6;
            this.button_Search.Text = "Поиск";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label_SelectTable
            // 
            this.label_SelectTable.AutoSize = true;
            this.label_SelectTable.Location = new System.Drawing.Point(28, 12);
            this.label_SelectTable.Name = "label_SelectTable";
            this.label_SelectTable.Size = new System.Drawing.Size(157, 17);
            this.label_SelectTable.TabIndex = 4;
            this.label_SelectTable.Text = "Просмотреть таблицу:";
            // 
            // button_Connection
            // 
            this.button_Connection.Location = new System.Drawing.Point(514, 8);
            this.button_Connection.Name = "button_Connection";
            this.button_Connection.Size = new System.Drawing.Size(123, 33);
            this.button_Connection.TabIndex = 3;
            this.button_Connection.Text = "Подключиться";
            this.button_Connection.UseVisualStyleBackColor = true;
            this.button_Connection.Click += new System.EventHandler(this.button_Connection_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Водители",
            "Маршруты",
            "Перевозки",
            "Экипаж"});
            this.comboBox1.Location = new System.Drawing.Point(191, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_SelectTable);
            this.tabControl1.Controls.Add(this.tabPage_CreateQuery);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 119);
            this.tabControl1.TabIndex = 4;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_StatusQuery,
            this.toolStripTextBox_StatusQuery});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 504);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(692, 25);
            this.bindingNavigator1.TabIndex = 7;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel_StatusQuery
            // 
            this.toolStripLabel_StatusQuery.Name = "toolStripLabel_StatusQuery";
            this.toolStripLabel_StatusQuery.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel_StatusQuery.Text = "Статус:";
            // 
            // toolStripTextBox_StatusQuery
            // 
            this.toolStripTextBox_StatusQuery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox_StatusQuery.Enabled = false;
            this.toolStripTextBox_StatusQuery.Name = "toolStripTextBox_StatusQuery";
            this.toolStripTextBox_StatusQuery.Size = new System.Drawing.Size(455, 25);
            // 
            // button_Add
            // 
            this.button_Add.Image = ((System.Drawing.Image)(resources.GetObject("button_Add.Image")));
            this.button_Add.Location = new System.Drawing.Point(16, 132);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(31, 31);
            this.button_Add.TabIndex = 8;
            this.button_Add.Text = "+";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Image = ((System.Drawing.Image)(resources.GetObject("button_Delete.Image")));
            this.button_Delete.Location = new System.Drawing.Point(50, 132);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(31, 31);
            this.button_Delete.TabIndex = 10;
            this.button_Delete.Text = "D";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Save
            // 
            this.button_Save.Image = ((System.Drawing.Image)(resources.GetObject("button_Save.Image")));
            this.button_Save.Location = new System.Drawing.Point(84, 132);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(31, 31);
            this.button_Save.TabIndex = 11;
            this.button_Save.Text = "S";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 529);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Base Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_CreateQuery.ResumeLayout(false);
            this.tabPage_CreateQuery.PerformLayout();
            this.tabPage_SelectTable.ResumeLayout(false);
            this.tabPage_SelectTable.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage_CreateQuery;
        private System.Windows.Forms.TextBox textBox_TextQuery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage_SelectTable;
        private System.Windows.Forms.Label label_SelectTable;
        private System.Windows.Forms.Button button_Connection;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_StatusQuery;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_StatusQuery;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.CheckBox checkBox_Headers;
        private System.Windows.Forms.CheckBox checkBox_Field;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

