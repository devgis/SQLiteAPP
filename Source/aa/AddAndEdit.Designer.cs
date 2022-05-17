namespace aa
{
    partial class AddAndEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btCatch = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudStartno = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDayRequire = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudThreads = new System.Windows.Forms.NumericUpDown();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayRequire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "商店链接：";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(108, 24);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(416, 21);
            this.tbURL.TabIndex = 1;
            // 
            // btCatch
            // 
            this.btCatch.Location = new System.Drawing.Point(549, 24);
            this.btCatch.Name = "btCatch";
            this.btCatch.Size = new System.Drawing.Size(75, 23);
            this.btCatch.TabIndex = 2;
            this.btCatch.Text = "抓取";
            this.btCatch.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(108, 68);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(110, 21);
            this.tbName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "应用名：";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(302, 67);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(110, 21);
            this.tbID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "应用ID：";
            // 
            // nudStartno
            // 
            this.nudStartno.Location = new System.Drawing.Point(504, 66);
            this.nudStartno.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStartno.Name = "nudStartno";
            this.nudStartno.Size = new System.Drawing.Size(120, 21);
            this.nudStartno.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "初始下载：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "日需求量：";
            // 
            // nudDayRequire
            // 
            this.nudDayRequire.Location = new System.Drawing.Point(119, 112);
            this.nudDayRequire.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDayRequire.Name = "nudDayRequire";
            this.nudDayRequire.Size = new System.Drawing.Size(110, 21);
            this.nudDayRequire.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "天数：";
            // 
            // nudDays
            // 
            this.nudDays.Location = new System.Drawing.Point(311, 111);
            this.nudDays.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(110, 21);
            this.nudDays.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "线程数：";
            // 
            // nudThreads
            // 
            this.nudThreads.Location = new System.Drawing.Point(513, 111);
            this.nudThreads.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudThreads.Name = "nudThreads";
            this.nudThreads.Size = new System.Drawing.Size(110, 21);
            this.nudThreads.TabIndex = 13;
            // 
            // tbRemarks
            // 
            this.tbRemarks.Location = new System.Drawing.Point(108, 154);
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(516, 21);
            this.tbRemarks.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "备注：";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(379, 215);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 17;
            this.btOK.Text = "确定";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(481, 215);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 18;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // AddAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 261);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbRemarks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudThreads);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudDayRequire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudStartno);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCatch);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAndEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddAndEdit";
            ((System.ComponentModel.ISupportInitialize)(this.nudStartno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayRequire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btCatch;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudStartno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDayRequire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudThreads;
        private System.Windows.Forms.TextBox tbRemarks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
    }
}