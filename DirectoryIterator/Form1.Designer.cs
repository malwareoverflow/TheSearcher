namespace DirectoryIterator
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
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.TextBox();
            this.Searchvalue = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Deletechoice = new System.Windows.Forms.CheckBox();
            this.Extensionvalue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExtensionList = new System.Windows.Forms.DataGridView();
            this.Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ExtensionList)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(89, 86);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(100, 20);
            this.Path.TabIndex = 0;
            // 
            // Searchvalue
            // 
            this.Searchvalue.Location = new System.Drawing.Point(89, 112);
            this.Searchvalue.Name = "Searchvalue";
            this.Searchvalue.Size = new System.Drawing.Size(100, 20);
            this.Searchvalue.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Deletechoice
            // 
            this.Deletechoice.AutoSize = true;
            this.Deletechoice.Location = new System.Drawing.Point(89, 209);
            this.Deletechoice.Name = "Deletechoice";
            this.Deletechoice.Size = new System.Drawing.Size(57, 17);
            this.Deletechoice.TabIndex = 5;
            this.Deletechoice.Text = "Delete";
            this.Deletechoice.UseVisualStyleBackColor = true;
            // 
            // Extensionvalue
            // 
            this.Extensionvalue.Location = new System.Drawing.Point(89, 138);
            this.Extensionvalue.Name = "Extensionvalue";
            this.Extensionvalue.Size = new System.Drawing.Size(100, 20);
            this.Extensionvalue.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Extension";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Directory";
            // 
            // ExtensionList
            // 
            this.ExtensionList.BackgroundColor = System.Drawing.Color.White;
            this.ExtensionList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ExtensionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExtensionList.GridColor = System.Drawing.SystemColors.ControlLight;
            this.ExtensionList.Location = new System.Drawing.Point(303, 67);
            this.ExtensionList.Name = "ExtensionList";
            this.ExtensionList.RowHeadersWidth = 10;
            this.ExtensionList.Size = new System.Drawing.Size(385, 170);
            this.ExtensionList.TabIndex = 6;
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(456, 22);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(35, 13);
            this.Timer.TabIndex = 11;
            this.Timer.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timertick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 261);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.ExtensionList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Extensionvalue);
            this.Controls.Add(this.Deletechoice);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Searchvalue);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ExtensionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.TextBox Searchvalue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox Deletechoice;
        private System.Windows.Forms.TextBox Extensionvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ExtensionList;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Timer timer1;
    }
}

