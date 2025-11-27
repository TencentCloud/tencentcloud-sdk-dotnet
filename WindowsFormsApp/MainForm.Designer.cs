namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.getZonesSyncButton = new System.Windows.Forms.Button();
            this.getZonesSyncText = new System.Windows.Forms.TextBox();
            this.secretIdText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secretKeyText = new System.Windows.Forms.TextBox();
            this.getZonesAsyncText = new System.Windows.Forms.TextBox();
            this.getZonesAsyncButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.httpProxyText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getZonesSyncButton
            // 
            this.getZonesSyncButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getZonesSyncButton.Location = new System.Drawing.Point(75, 218);
            this.getZonesSyncButton.Margin = new System.Windows.Forms.Padding(4);
            this.getZonesSyncButton.Name = "getZonesSyncButton";
            this.getZonesSyncButton.Size = new System.Drawing.Size(317, 63);
            this.getZonesSyncButton.TabIndex = 0;
            this.getZonesSyncButton.Text = "GetZonesSync";
            this.getZonesSyncButton.UseVisualStyleBackColor = true;
            this.getZonesSyncButton.Click += new System.EventHandler(this.getZonesSyncButton_Click);
            // 
            // getZonesSyncText
            // 
            this.getZonesSyncText.Location = new System.Drawing.Point(75, 294);
            this.getZonesSyncText.Margin = new System.Windows.Forms.Padding(4);
            this.getZonesSyncText.Multiline = true;
            this.getZonesSyncText.Name = "getZonesSyncText";
            this.getZonesSyncText.Size = new System.Drawing.Size(317, 246);
            this.getZonesSyncText.TabIndex = 1;
            // 
            // secretIdText
            // 
            this.secretIdText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.secretIdText.Location = new System.Drawing.Point(257, 31);
            this.secretIdText.Multiline = true;
            this.secretIdText.Name = "secretIdText";
            this.secretIdText.Size = new System.Drawing.Size(487, 39);
            this.secretIdText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(79, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "SecretId: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(79, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "SecretKey: ";
            // 
            // secretKeyText
            // 
            this.secretKeyText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.secretKeyText.Location = new System.Drawing.Point(258, 91);
            this.secretKeyText.Multiline = true;
            this.secretKeyText.Name = "secretKeyText";
            this.secretKeyText.Size = new System.Drawing.Size(486, 39);
            this.secretKeyText.TabIndex = 7;
            // 
            // getZonesAsyncText
            // 
            this.getZonesAsyncText.Location = new System.Drawing.Point(427, 294);
            this.getZonesAsyncText.Margin = new System.Windows.Forms.Padding(4);
            this.getZonesAsyncText.Multiline = true;
            this.getZonesAsyncText.Name = "getZonesAsyncText";
            this.getZonesAsyncText.Size = new System.Drawing.Size(317, 246);
            this.getZonesAsyncText.TabIndex = 8;
            // 
            // getZonesAsyncButton
            // 
            this.getZonesAsyncButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getZonesAsyncButton.Location = new System.Drawing.Point(427, 218);
            this.getZonesAsyncButton.Margin = new System.Windows.Forms.Padding(4);
            this.getZonesAsyncButton.Name = "getZonesAsyncButton";
            this.getZonesAsyncButton.Size = new System.Drawing.Size(317, 63);
            this.getZonesAsyncButton.TabIndex = 9;
            this.getZonesAsyncButton.Text = "GetZonesAsync";
            this.getZonesAsyncButton.UseVisualStyleBackColor = true;
            this.getZonesAsyncButton.Click += new System.EventHandler(this.getZonesAsyncButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(79, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 39);
            this.label3.TabIndex = 10;
            this.label3.Text = "HttpProxy: ";
            // 
            // httpProxyText
            // 
            this.httpProxyText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.httpProxyText.Location = new System.Drawing.Point(258, 144);
            this.httpProxyText.Multiline = true;
            this.httpProxyText.Name = "httpProxyText";
            this.httpProxyText.Size = new System.Drawing.Size(486, 39);
            this.httpProxyText.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 621);
            this.Controls.Add(this.httpProxyText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getZonesAsyncButton);
            this.Controls.Add(this.getZonesAsyncText);
            this.Controls.Add(this.secretKeyText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secretIdText);
            this.Controls.Add(this.getZonesSyncText);
            this.Controls.Add(this.getZonesSyncButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Tencent Cloud Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getZonesSyncButton;
        private System.Windows.Forms.TextBox getZonesSyncText;
        private System.Windows.Forms.TextBox secretIdText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secretKeyText;
        private System.Windows.Forms.TextBox getZonesAsyncText;
        private System.Windows.Forms.Button getZonesAsyncButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox httpProxyText;
    }
}

