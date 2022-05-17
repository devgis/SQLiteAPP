namespace aa
{
    partial class SetForm
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
            this.tbProxyURLS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbShowLog = new System.Windows.Forms.CheckBox();
            this.btSet = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbProxyURLS
            // 
            this.tbProxyURLS.Location = new System.Drawing.Point(10, 37);
            this.tbProxyURLS.Multiline = true;
            this.tbProxyURLS.Name = "tbProxyURLS";
            this.tbProxyURLS.Size = new System.Drawing.Size(495, 181);
            this.tbProxyURLS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "代理抓取地址（每行一条连接）";
            // 
            // cbShowLog
            // 
            this.cbShowLog.AutoSize = true;
            this.cbShowLog.Location = new System.Drawing.Point(12, 225);
            this.cbShowLog.Name = "cbShowLog";
            this.cbShowLog.Size = new System.Drawing.Size(108, 16);
            this.cbShowLog.TabIndex = 3;
            this.cbShowLog.Text = "列表栏实时日志";
            this.cbShowLog.UseVisualStyleBackColor = true;
            // 
            // btSet
            // 
            this.btSet.Location = new System.Drawing.Point(345, 226);
            this.btSet.Name = "btSet";
            this.btSet.Size = new System.Drawing.Size(75, 23);
            this.btSet.TabIndex = 4;
            this.btSet.Text = "设置(&S)";
            this.btSet.UseVisualStyleBackColor = true;
            this.btSet.Click += new System.EventHandler(this.btSet_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(429, 226);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "取消(&C)";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 261);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSet);
            this.Controls.Add(this.cbShowLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProxyURLS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.SetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProxyURLS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbShowLog;
        private System.Windows.Forms.Button btSet;
        private System.Windows.Forms.Button btCancel;
    }
}