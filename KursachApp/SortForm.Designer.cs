namespace KursachApp
{
    partial class SortForm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.selSortTextBox = new System.Windows.Forms.TextBox();
            this.qSortTextBox = new System.Windows.Forms.TextBox();
            this.transpSS = new System.Windows.Forms.TextBox();
            this.compSS = new System.Windows.Forms.TextBox();
            this.transpQS = new System.Windows.Forms.TextBox();
            this.compQS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selSortButton = new System.Windows.Forms.Button();
            this.qSortButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(10, 52);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(158, 261);
            this.textBox.TabIndex = 0;
            // 
            // selSortTextBox
            // 
            this.selSortTextBox.Location = new System.Drawing.Point(190, 98);
            this.selSortTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.selSortTextBox.Multiline = true;
            this.selSortTextBox.Name = "selSortTextBox";
            this.selSortTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.selSortTextBox.Size = new System.Drawing.Size(182, 215);
            this.selSortTextBox.TabIndex = 1;
            // 
            // qSortTextBox
            // 
            this.qSortTextBox.Location = new System.Drawing.Point(394, 97);
            this.qSortTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.qSortTextBox.Multiline = true;
            this.qSortTextBox.Name = "qSortTextBox";
            this.qSortTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.qSortTextBox.Size = new System.Drawing.Size(182, 216);
            this.qSortTextBox.TabIndex = 2;
            // 
            // transpSS
            // 
            this.transpSS.Location = new System.Drawing.Point(190, 75);
            this.transpSS.Margin = new System.Windows.Forms.Padding(2);
            this.transpSS.Name = "transpSS";
            this.transpSS.ReadOnly = true;
            this.transpSS.Size = new System.Drawing.Size(76, 20);
            this.transpSS.TabIndex = 3;
            // 
            // compSS
            // 
            this.compSS.Location = new System.Drawing.Point(190, 52);
            this.compSS.Margin = new System.Windows.Forms.Padding(2);
            this.compSS.Name = "compSS";
            this.compSS.ReadOnly = true;
            this.compSS.Size = new System.Drawing.Size(76, 20);
            this.compSS.TabIndex = 4;
            // 
            // transpQS
            // 
            this.transpQS.Location = new System.Drawing.Point(500, 74);
            this.transpQS.Margin = new System.Windows.Forms.Padding(2);
            this.transpQS.Name = "transpQS";
            this.transpQS.ReadOnly = true;
            this.transpQS.Size = new System.Drawing.Size(76, 20);
            this.transpQS.TabIndex = 5;
            this.transpQS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // compQS
            // 
            this.compQS.Location = new System.Drawing.Point(500, 52);
            this.compQS.Margin = new System.Windows.Forms.Padding(2);
            this.compQS.Name = "compQS";
            this.compQS.ReadOnly = true;
            this.compQS.Size = new System.Drawing.Size(76, 20);
            this.compQS.TabIndex = 6;
            this.compQS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(337, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Число сравнений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(328, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Число перестановок";
            // 
            // selSortButton
            // 
            this.selSortButton.Location = new System.Drawing.Point(190, 11);
            this.selSortButton.Margin = new System.Windows.Forms.Padding(2);
            this.selSortButton.Name = "selSortButton";
            this.selSortButton.Size = new System.Drawing.Size(182, 37);
            this.selSortButton.TabIndex = 9;
            this.selSortButton.Text = "Сортировка выбором (М1)";
            this.selSortButton.UseVisualStyleBackColor = true;
            this.selSortButton.Click += new System.EventHandler(this.selSortButton_Click);
            // 
            // qSortButton
            // 
            this.qSortButton.Location = new System.Drawing.Point(394, 10);
            this.qSortButton.Margin = new System.Windows.Forms.Padding(2);
            this.qSortButton.Name = "qSortButton";
            this.qSortButton.Size = new System.Drawing.Size(180, 37);
            this.qSortButton.TabIndex = 10;
            this.qSortButton.Text = "Быстрая сортировка с рекурсиями (М6)";
            this.qSortButton.UseVisualStyleBackColor = true;
            this.qSortButton.Click += new System.EventHandler(this.qSortButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(501, 330);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(74, 26);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(10, 330);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(74, 26);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ваши данные:";
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.qSortButton);
            this.Controls.Add(this.selSortButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compQS);
            this.Controls.Add(this.transpQS);
            this.Controls.Add(this.compSS);
            this.Controls.Add(this.transpSS);
            this.Controls.Add(this.qSortTextBox);
            this.Controls.Add(this.selSortTextBox);
            this.Controls.Add(this.textBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SortForm";
            this.Text = "SortForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox selSortTextBox;
        private System.Windows.Forms.TextBox qSortTextBox;
        private System.Windows.Forms.TextBox transpSS;
        private System.Windows.Forms.TextBox compSS;
        private System.Windows.Forms.TextBox transpQS;
        private System.Windows.Forms.TextBox compQS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selSortButton;
        private System.Windows.Forms.Button qSortButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label3;
    }
}