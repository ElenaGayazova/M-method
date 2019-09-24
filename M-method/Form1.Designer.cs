namespace SimplexMethod
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridZ = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_nu = new System.Windows.Forms.NumericUpDown();
            this.numeric_nx = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridT = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridX = new System.Windows.Forms.DataGridView();
            this.textF = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridT1 = new System.Windows.Forms.DataGridView();
            this.textStep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericStep = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.задачаИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.решениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьЗадачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_nu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_nx)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridT)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridX)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStep)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataGridZ);
            this.tabPage1.Controls.Add(this.dataGridA);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numeric_nu);
            this.tabPage1.Controls.Add(this.numeric_nx);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задача";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(321, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(133, 36);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Целевая функция Z =";
            // 
            // dataGridZ
            // 
            this.dataGridZ.AllowUserToAddRows = false;
            this.dataGridZ.AllowUserToDeleteRows = false;
            this.dataGridZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridZ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.dataGridZ.Location = new System.Drawing.Point(493, 11);
            this.dataGridZ.Name = "dataGridZ";
            this.dataGridZ.Size = new System.Drawing.Size(133, 308);
            this.dataGridZ.TabIndex = 6;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // dataGridA
            // 
            this.dataGridA.AllowUserToAddRows = false;
            this.dataGridA.AllowUserToDeleteRows = false;
            this.dataGridA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridA.Location = new System.Drawing.Point(7, 78);
            this.dataGridA.Name = "dataGridA";
            this.dataGridA.Size = new System.Drawing.Size(480, 240);
            this.dataGridA.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество ограничений";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество переменных";
            // 
            // numeric_nu
            // 
            this.numeric_nu.Location = new System.Drawing.Point(230, 48);
            this.numeric_nu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_nu.Name = "numeric_nu";
            this.numeric_nu.Size = new System.Drawing.Size(58, 22);
            this.numeric_nu.TabIndex = 2;
            this.numeric_nu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_nu.ValueChanged += new System.EventHandler(this.numeric_nu_ValueChanged);
            // 
            // numeric_nx
            // 
            this.numeric_nx.Location = new System.Drawing.Point(231, 9);
            this.numeric_nx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_nx.Name = "numeric_nx";
            this.numeric_nx.Size = new System.Drawing.Size(57, 22);
            this.numeric_nx.TabIndex = 1;
            this.numeric_nx.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_nx.ValueChanged += new System.EventHandler(this.numeric_nx_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dataGridT);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Симплекс-таблица";
            // 
            // dataGridT
            // 
            this.dataGridT.AllowUserToAddRows = false;
            this.dataGridT.AllowUserToDeleteRows = false;
            this.dataGridT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridT.Location = new System.Drawing.Point(7, 28);
            this.dataGridT.Name = "dataGridT";
            this.dataGridT.Size = new System.Drawing.Size(617, 291);
            this.dataGridT.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.dataGridX);
            this.tabPage3.Controls.Add(this.textF);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(632, 325);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Решение задачи";
            // 
            // dataGridX
            // 
            this.dataGridX.AllowUserToAddRows = false;
            this.dataGridX.AllowUserToDeleteRows = false;
            this.dataGridX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridX.Location = new System.Drawing.Point(9, 80);
            this.dataGridX.Name = "dataGridX";
            this.dataGridX.Size = new System.Drawing.Size(617, 92);
            this.dataGridX.TabIndex = 5;
            // 
            // textF
            // 
            this.textF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textF.Location = new System.Drawing.Point(9, 21);
            this.textF.Multiline = true;
            this.textF.Name = "textF";
            this.textF.Size = new System.Drawing.Size(615, 41);
            this.textF.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.dataGridT1);
            this.tabPage4.Controls.Add(this.textStep);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.numericStep);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(632, 325);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ход решения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "из ";
            // 
            // dataGridT1
            // 
            this.dataGridT1.AllowUserToAddRows = false;
            this.dataGridT1.AllowUserToDeleteRows = false;
            this.dataGridT1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridT1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridT1.Location = new System.Drawing.Point(7, 109);
            this.dataGridT1.Name = "dataGridT1";
            this.dataGridT1.Size = new System.Drawing.Size(617, 210);
            this.dataGridT1.TabIndex = 3;
            // 
            // textStep
            // 
            this.textStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textStep.Location = new System.Drawing.Point(249, 6);
            this.textStep.Multiline = true;
            this.textStep.Name = "textStep";
            this.textStep.Size = new System.Drawing.Size(375, 97);
            this.textStep.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Номер шага";
            // 
            // numericStep
            // 
            this.numericStep.Location = new System.Drawing.Point(120, 18);
            this.numericStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericStep.Name = "numericStep";
            this.numericStep.Size = new System.Drawing.Size(55, 22);
            this.numericStep.TabIndex = 0;
            this.numericStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericStep.ValueChanged += new System.EventHandler(this.numericStep_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задачаИзФайлаToolStripMenuItem,
            this.toolStripMenuItem1,
            this.решениеToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.сохранитьЗадачуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // задачаИзФайлаToolStripMenuItem
            // 
            this.задачаИзФайлаToolStripMenuItem.Name = "задачаИзФайлаToolStripMenuItem";
            this.задачаИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(138, 23);
            this.задачаИзФайлаToolStripMenuItem.Text = "Задача из файла";
            this.задачаИзФайлаToolStripMenuItem.Click += new System.EventHandler(this.задачаИзФайлаToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(95, 23);
            this.toolStripMenuItem1.Text = "Заполнить";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // решениеToolStripMenuItem
            // 
            this.решениеToolStripMenuItem.Name = "решениеToolStripMenuItem";
            this.решениеToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.решениеToolStripMenuItem.Text = "Решение";
            this.решениеToolStripMenuItem.Click += new System.EventHandler(this.решениеToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // сохранитьЗадачуToolStripMenuItem
            // 
            this.сохранитьЗадачуToolStripMenuItem.Name = "сохранитьЗадачуToolStripMenuItem";
            this.сохранитьЗадачуToolStripMenuItem.Size = new System.Drawing.Size(148, 23);
            this.сохранитьЗадачуToolStripMenuItem.Text = "Сохранить задачу";
            this.сохранитьЗадачуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьЗадачуToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            this.openFileDialog1.InitialDirectory = "M-method\\M-method\\bin\\Debug";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            this.saveFileDialog1.InitialDirectory = "M-method\\M-method\\bin\\Debug";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 387);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "М-метод";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_nu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_nx)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridT)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridX)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStep)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_nu;
        private System.Windows.Forms.NumericUpDown numeric_nx;
        private System.Windows.Forms.DataGridView dataGridA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem задачаИзФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem решениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьЗадачуToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dataGridZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridT;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridT1;
        private System.Windows.Forms.TextBox textStep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericStep;
        private System.Windows.Forms.DataGridView dataGridX;
        private System.Windows.Forms.TextBox textF;
        private System.Windows.Forms.Label label4;
    }
}

