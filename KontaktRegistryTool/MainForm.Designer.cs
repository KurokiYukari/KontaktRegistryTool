namespace KontaktRegistryTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LibrariesListTitle_Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddLibrary_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LibraryName_Label = new System.Windows.Forms.Label();
            this.LibraryPwd_Label = new System.Windows.Forms.Label();
            this.SelectLibrary_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Libraries_ListBox = new System.Windows.Forms.ListBox();
            this.DeleteLibrary_Button = new System.Windows.Forms.Button();
            this.Main_Label = new System.Windows.Forms.Label();
            this.Bottom_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LibrariesListTitle_Label
            // 
            this.LibrariesListTitle_Label.AutoSize = true;
            this.LibrariesListTitle_Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LibrariesListTitle_Label.Location = new System.Drawing.Point(16, 22);
            this.LibrariesListTitle_Label.Name = "LibrariesListTitle_Label";
            this.LibrariesListTitle_Label.Size = new System.Drawing.Size(61, 17);
            this.LibrariesListTitle_Label.TabIndex = 0;
            this.LibrariesListTitle_Label.Text = "Libraries";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 23);
            this.textBox1.TabIndex = 1;
            // 
            // AddLibrary_Button
            // 
            this.AddLibrary_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLibrary_Button.Location = new System.Drawing.Point(17, 142);
            this.AddLibrary_Button.Name = "AddLibrary_Button";
            this.AddLibrary_Button.Size = new System.Drawing.Size(237, 27);
            this.AddLibrary_Button.TabIndex = 2;
            this.AddLibrary_Button.Text = "Add Self-created Library";
            this.AddLibrary_Button.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.LibraryName_Label);
            this.groupBox1.Controls.Add(this.LibraryPwd_Label);
            this.groupBox1.Controls.Add(this.SelectLibrary_Button);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.AddLibrary_Button);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(29, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD LIBRARY";
            // 
            // LibraryName_Label
            // 
            this.LibraryName_Label.Font = new System.Drawing.Font("Bradley Hand ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LibraryName_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LibraryName_Label.Location = new System.Drawing.Point(17, 69);
            this.LibraryName_Label.Name = "LibraryName_Label";
            this.LibraryName_Label.Size = new System.Drawing.Size(109, 27);
            this.LibraryName_Label.TabIndex = 5;
            this.LibraryName_Label.Text = "Library Name";
            this.LibraryName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LibraryPwd_Label
            // 
            this.LibraryPwd_Label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LibraryPwd_Label.Location = new System.Drawing.Point(17, 34);
            this.LibraryPwd_Label.Name = "LibraryPwd_Label";
            this.LibraryPwd_Label.Size = new System.Drawing.Size(237, 23);
            this.LibraryPwd_Label.TabIndex = 4;
            this.LibraryPwd_Label.Text = "Library Pwd";
            // 
            // SelectLibrary_Button
            // 
            this.SelectLibrary_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectLibrary_Button.Location = new System.Drawing.Point(132, 69);
            this.SelectLibrary_Button.Name = "SelectLibrary_Button";
            this.SelectLibrary_Button.Size = new System.Drawing.Size(122, 27);
            this.SelectLibrary_Button.TabIndex = 3;
            this.SelectLibrary_Button.Text = "Select Library";
            this.SelectLibrary_Button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Libraries_ListBox);
            this.panel1.Controls.Add(this.DeleteLibrary_Button);
            this.panel1.Controls.Add(this.LibrariesListTitle_Label);
            this.panel1.Location = new System.Drawing.Point(344, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 406);
            this.panel1.TabIndex = 4;
            // 
            // Libraries_ListBox
            // 
            this.Libraries_ListBox.FormattingEnabled = true;
            this.Libraries_ListBox.ItemHeight = 17;
            this.Libraries_ListBox.Location = new System.Drawing.Point(16, 49);
            this.Libraries_ListBox.Name = "Libraries_ListBox";
            this.Libraries_ListBox.Size = new System.Drawing.Size(272, 310);
            this.Libraries_ListBox.TabIndex = 3;
            // 
            // DeleteLibrary_Button
            // 
            this.DeleteLibrary_Button.Location = new System.Drawing.Point(16, 372);
            this.DeleteLibrary_Button.Name = "DeleteLibrary_Button";
            this.DeleteLibrary_Button.Size = new System.Drawing.Size(272, 27);
            this.DeleteLibrary_Button.TabIndex = 2;
            this.DeleteLibrary_Button.Text = "Delete Library";
            this.DeleteLibrary_Button.UseVisualStyleBackColor = true;
            this.DeleteLibrary_Button.Click += new System.EventHandler(this.DeleteLibrary_Button_Click);
            // 
            // Main_Label
            // 
            this.Main_Label.AutoSize = true;
            this.Main_Label.BackColor = System.Drawing.Color.Transparent;
            this.Main_Label.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Main_Label.Location = new System.Drawing.Point(57, 46);
            this.Main_Label.Name = "Main_Label";
            this.Main_Label.Size = new System.Drawing.Size(210, 26);
            this.Main_Label.TabIndex = 5;
            this.Main_Label.Text = "CARINYA Kontakt Tool";
            // 
            // Bottom_Label
            // 
            this.Bottom_Label.BackColor = System.Drawing.Color.Transparent;
            this.Bottom_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bottom_Label.Location = new System.Drawing.Point(29, 435);
            this.Bottom_Label.Name = "Bottom_Label";
            this.Bottom_Label.Size = new System.Drawing.Size(620, 17);
            this.Bottom_Label.TabIndex = 7;
            this.Bottom_Label.Text = "Powered By Kuroki  (￣▽￣)\" ";
            this.Bottom_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(29, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 2);
            this.label1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(665, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bottom_Label);
            this.Controls.Add(this.Main_Label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Kontakt Registry Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LibrariesListTitle_Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddLibrary_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LibraryName_Label;
        private System.Windows.Forms.Label LibraryPwd_Label;
        private System.Windows.Forms.Button SelectLibrary_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteLibrary_Button;
        private System.Windows.Forms.Label Main_Label;
        private System.Windows.Forms.Label Bottom_Label;
        private System.Windows.Forms.ListBox Libraries_ListBox;
        private System.Windows.Forms.Label label1;
    }
}

