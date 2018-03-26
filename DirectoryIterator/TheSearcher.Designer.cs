namespace DirectoryIterator
{
    partial class TheSearcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheSearcher));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExtensionList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(77, 133);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(100, 20);
            this.Path.TabIndex = 0;
            // 
            // Searchvalue
            // 
            this.Searchvalue.Location = new System.Drawing.Point(77, 159);
            this.Searchvalue.Name = "Searchvalue";
            this.Searchvalue.Size = new System.Drawing.Size(100, 20);
            this.Searchvalue.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Start);
            // 
            // Deletechoice
            // 
            this.Deletechoice.AutoSize = true;
            this.Deletechoice.Location = new System.Drawing.Point(77, 264);
            this.Deletechoice.Name = "Deletechoice";
            this.Deletechoice.Size = new System.Drawing.Size(57, 17);
            this.Deletechoice.TabIndex = 5;
            this.Deletechoice.Text = "Delete";
            this.Deletechoice.UseVisualStyleBackColor = true;
            this.Deletechoice.Visible = false;
            // 
            // Extensionvalue
            // 
            this.Extensionvalue.Location = new System.Drawing.Point(77, 185);
            this.Extensionvalue.Name = "Extensionvalue";
            this.Extensionvalue.Size = new System.Drawing.Size(100, 20);
            this.Extensionvalue.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Extension";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 133);
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
            this.ExtensionList.Location = new System.Drawing.Point(313, 111);
            this.ExtensionList.Name = "ExtensionList";
            this.ExtensionList.RowHeadersWidth = 10;
            this.ExtensionList.Size = new System.Drawing.Size(385, 170);
            this.ExtensionList.TabIndex = 6;
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(375, 9);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(0, 25);
            this.Timer.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timertick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ExtensionList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Deletechoice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Path);
            this.panel1.Controls.Add(this.Searchvalue);
            this.panel1.Controls.Add(this.Extensionvalue);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 292);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "All Matching Extension";
            // 
            // TheSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 373);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TheSearcher";
            this.Text = "The Searcher";
            ((System.ComponentModel.ISupportInitialize)(this.ExtensionList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}

