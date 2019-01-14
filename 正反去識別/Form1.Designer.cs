namespace 正反去識別
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDeFZ = new System.Windows.Forms.TextBox();
            this.txtFZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFZ = new System.Windows.Forms.Button();
            this.btnDeFZ = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtDeFZ
            // 
            this.txtDeFZ.Location = new System.Drawing.Point(80, 50);
            this.txtDeFZ.Name = "txtDeFZ";
            this.txtDeFZ.Size = new System.Drawing.Size(100, 22);
            this.txtDeFZ.TabIndex = 0;
            // 
            // txtFZ
            // 
            this.txtFZ.Location = new System.Drawing.Point(80, 94);
            this.txtFZ.Name = "txtFZ";
            this.txtFZ.Size = new System.Drawing.Size(100, 22);
            this.txtFZ.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "未去識別";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "去識別";
            // 
            // btnFZ
            // 
            this.btnFZ.Location = new System.Drawing.Point(12, 142);
            this.btnFZ.Name = "btnFZ";
            this.btnFZ.Size = new System.Drawing.Size(75, 23);
            this.btnFZ.TabIndex = 4;
            this.btnFZ.Text = "去識別";
            this.btnFZ.UseVisualStyleBackColor = true;
            this.btnFZ.Click += new System.EventHandler(this.btnFZ_Click);
            // 
            // btnDeFZ
            // 
            this.btnDeFZ.Location = new System.Drawing.Point(105, 142);
            this.btnDeFZ.Name = "btnDeFZ";
            this.btnDeFZ.Size = new System.Drawing.Size(75, 23);
            this.btnDeFZ.TabIndex = 5;
            this.btnDeFZ.Text = "反去識別";
            this.btnDeFZ.UseVisualStyleBackColor = true;
            this.btnDeFZ.Click += new System.EventHandler(this.btnDeFZ_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 16);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ID";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(105, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "帳號";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 204);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnDeFZ);
            this.Controls.Add(this.btnFZ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFZ);
            this.Controls.Add(this.txtDeFZ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "正反去識別化";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeFZ;
        private System.Windows.Forms.TextBox txtFZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFZ;
        private System.Windows.Forms.Button btnDeFZ;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

