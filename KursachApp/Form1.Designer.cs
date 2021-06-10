namespace KursachApp
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
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.radioButtonSTRING = new System.Windows.Forms.RadioButton();
            this.radioButtonDOUBLE = new System.Windows.Forms.RadioButton();
            this.radioButtonINT = new System.Windows.Forms.RadioButton();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sortBbutton = new System.Windows.Forms.Button();
            this.groupBoxRandom = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.randomInitButton = new System.Windows.Forms.Button();
            this.groupBoxType.SuspendLayout();
            this.groupBoxRandom.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.radioButtonSTRING);
            this.groupBoxType.Controls.Add(this.radioButtonDOUBLE);
            this.groupBoxType.Controls.Add(this.radioButtonINT);
            this.groupBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxType.Location = new System.Drawing.Point(19, 10);
            this.groupBoxType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxType.Size = new System.Drawing.Size(113, 99);
            this.groupBoxType.TabIndex = 0;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип данных";
            // 
            // radioButtonSTRING
            // 
            this.radioButtonSTRING.AutoSize = true;
            this.radioButtonSTRING.Location = new System.Drawing.Point(13, 67);
            this.radioButtonSTRING.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonSTRING.Name = "radioButtonSTRING";
            this.radioButtonSTRING.Size = new System.Drawing.Size(76, 28);
            this.radioButtonSTRING.TabIndex = 3;
            this.radioButtonSTRING.TabStop = true;
            this.radioButtonSTRING.Text = "string";
            this.radioButtonSTRING.UseVisualStyleBackColor = true;
            this.radioButtonSTRING.CheckedChanged += new System.EventHandler(this.radioButtonSTRING_CheckedChanged);
            // 
            // radioButtonDOUBLE
            // 
            this.radioButtonDOUBLE.AutoSize = true;
            this.radioButtonDOUBLE.Location = new System.Drawing.Point(13, 45);
            this.radioButtonDOUBLE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonDOUBLE.Name = "radioButtonDOUBLE";
            this.radioButtonDOUBLE.Size = new System.Drawing.Size(90, 28);
            this.radioButtonDOUBLE.TabIndex = 2;
            this.radioButtonDOUBLE.TabStop = true;
            this.radioButtonDOUBLE.Text = "double";
            this.radioButtonDOUBLE.UseVisualStyleBackColor = true;
            this.radioButtonDOUBLE.CheckedChanged += new System.EventHandler(this.radioButtonDOUBLE_CheckedChanged);
            // 
            // radioButtonINT
            // 
            this.radioButtonINT.AutoSize = true;
            this.radioButtonINT.Location = new System.Drawing.Point(13, 22);
            this.radioButtonINT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonINT.Name = "radioButtonINT";
            this.radioButtonINT.Size = new System.Drawing.Size(50, 28);
            this.radioButtonINT.TabIndex = 1;
            this.radioButtonINT.TabStop = true;
            this.radioButtonINT.Text = "int";
            this.radioButtonINT.UseVisualStyleBackColor = true;
            this.radioButtonINT.CheckedChanged += new System.EventHandler(this.radioButtonINT_CheckedChanged);
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(19, 132);
            this.textBoxData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData.Size = new System.Drawing.Size(534, 224);
            this.textBoxData.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Данные:";
            // 
            // sortBbutton
            // 
            this.sortBbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortBbutton.Location = new System.Drawing.Point(364, 19);
            this.sortBbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sortBbutton.Name = "sortBbutton";
            this.sortBbutton.Size = new System.Drawing.Size(188, 91);
            this.sortBbutton.TabIndex = 3;
            this.sortBbutton.Text = "К СОРТИРОВКАМ!";
            this.sortBbutton.UseVisualStyleBackColor = true;
            this.sortBbutton.Click += new System.EventHandler(this.sortBbutton_Click);
            // 
            // groupBoxRandom
            // 
            this.groupBoxRandom.Controls.Add(this.label2);
            this.groupBoxRandom.Controls.Add(this.countTextBox);
            this.groupBoxRandom.Controls.Add(this.randomInitButton);
            this.groupBoxRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRandom.Location = new System.Drawing.Point(137, 10);
            this.groupBoxRandom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRandom.Name = "groupBoxRandom";
            this.groupBoxRandom.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRandom.Size = new System.Drawing.Size(222, 99);
            this.groupBoxRandom.TabIndex = 4;
            this.groupBoxRandom.TabStop = false;
            this.groupBoxRandom.Text = "Случайные данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество элементов:";
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(5, 37);
            this.countTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(213, 28);
            this.countTextBox.TabIndex = 1;
            // 
            // randomInitButton
            // 
            this.randomInitButton.Location = new System.Drawing.Point(4, 64);
            this.randomInitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randomInitButton.Name = "randomInitButton";
            this.randomInitButton.Size = new System.Drawing.Size(213, 28);
            this.randomInitButton.TabIndex = 0;
            this.randomInitButton.Text = "Сгенерировать";
            this.randomInitButton.UseVisualStyleBackColor = true;
            this.randomInitButton.Click += new System.EventHandler(this.randomInitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 366);
            this.Controls.Add(this.groupBoxRandom);
            this.Controls.Add(this.sortBbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.groupBoxType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Начальное окно (Курсач5)";
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.groupBoxRandom.ResumeLayout(false);
            this.groupBoxRandom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.RadioButton radioButtonSTRING;
        private System.Windows.Forms.RadioButton radioButtonDOUBLE;
        private System.Windows.Forms.RadioButton radioButtonINT;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sortBbutton;
        private System.Windows.Forms.GroupBox groupBoxRandom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Button randomInitButton;
    }
}