namespace VersionChanger
{
    partial class VersionChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionChanger));
            this.projectDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oldVersionInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newVersionInput = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.whatHappenedList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // projectDropdown
            // 
            this.projectDropdown.FormattingEnabled = true;
            this.projectDropdown.Location = new System.Drawing.Point(12, 34);
            this.projectDropdown.Name = "projectDropdown";
            this.projectDropdown.Size = new System.Drawing.Size(380, 21);
            this.projectDropdown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя проекта, в котором нужно поменять версию";
            // 
            // oldVersionInput
            // 
            this.oldVersionInput.Enabled = false;
            this.oldVersionInput.Location = new System.Drawing.Point(12, 74);
            this.oldVersionInput.Name = "oldVersionInput";
            this.oldVersionInput.Size = new System.Drawing.Size(380, 20);
            this.oldVersionInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текущая версия выбранного проекта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите новую версию выбранного проекта";
            // 
            // newVersionInput
            // 
            this.newVersionInput.Location = new System.Drawing.Point(12, 114);
            this.newVersionInput.Name = "newVersionInput";
            this.newVersionInput.Size = new System.Drawing.Size(380, 20);
            this.newVersionInput.TabIndex = 5;
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(398, 33);
            this.startButton.MinimumSize = new System.Drawing.Size(390, 100);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(390, 100);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Ну, поехали!";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // whatHappenedList
            // 
            this.whatHappenedList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.whatHappenedList.FormattingEnabled = true;
            this.whatHappenedList.Location = new System.Drawing.Point(12, 162);
            this.whatHappenedList.MinimumSize = new System.Drawing.Size(776, 121);
            this.whatHappenedList.Name = "whatHappenedList";
            this.whatHappenedList.Size = new System.Drawing.Size(776, 121);
            this.whatHappenedList.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Шо случилось в наших лесах?";
            // 
            // VersionChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 321);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.whatHappenedList);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.newVersionInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldVersionInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectDropdown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 360);
            this.Name = "VersionChanger";
            this.Text = "VersionChanger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox projectDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldVersionInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newVersionInput;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox whatHappenedList;
        private System.Windows.Forms.Label label4;
    }
}