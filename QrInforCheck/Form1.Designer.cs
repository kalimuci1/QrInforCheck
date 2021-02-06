namespace QrInforCheck
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvMater = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsBathDif = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsReNumber = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbIsRepass = new System.Windows.Forms.Label();
            this.lbReBath = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurBath = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMater)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMater
            // 
            this.DgvMater.AllowUserToAddRows = false;
            this.DgvMater.AllowUserToDeleteRows = false;
            this.DgvMater.AllowUserToResizeRows = false;
            this.DgvMater.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvMater.BackgroundColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMater.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMater.ColumnHeadersHeight = 30;
            this.DgvMater.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Batch,
            this.Number,
            this.IsBathDif,
            this.IsReNumber});
            this.DgvMater.EnableHeadersVisualStyles = false;
            this.DgvMater.Location = new System.Drawing.Point(3, 33);
            this.DgvMater.Name = "DgvMater";
            this.DgvMater.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMater.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvMater.RowHeadersWidth = 65;
            this.DgvMater.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DgvMater.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvMater.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DgvMater.RowTemplate.Height = 23;
            this.DgvMater.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvMater.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMater.Size = new System.Drawing.Size(549, 607);
            this.DgvMater.TabIndex = 76;
            this.DgvMater.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvMater_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Batch
            // 
            this.Batch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Batch.DataPropertyName = "Batch";
            this.Batch.HeaderText = "批号";
            this.Batch.Name = "Batch";
            this.Batch.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "编号";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 150;
            // 
            // IsBathDif
            // 
            this.IsBathDif.DataPropertyName = "IsBathDif";
            this.IsBathDif.FalseValue = "否";
            this.IsBathDif.HeaderText = "批号不同";
            this.IsBathDif.Name = "IsBathDif";
            this.IsBathDif.ReadOnly = true;
            this.IsBathDif.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsBathDif.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsBathDif.TrueValue = "是";
            // 
            // IsReNumber
            // 
            this.IsReNumber.DataPropertyName = "IsReNumber";
            this.IsReNumber.FalseValue = "否";
            this.IsReNumber.HeaderText = "编号重复";
            this.IsReNumber.Name = "IsReNumber";
            this.IsReNumber.ReadOnly = true;
            this.IsReNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsReNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsReNumber.TrueValue = "是";
            this.IsReNumber.Width = 110;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("宋体", 20F);
            this.btnClear.Location = new System.Drawing.Point(579, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(259, 79);
            this.btnClear.TabIndex = 77;
            this.btnClear.Text = "清空所有";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(1030, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 78;
            this.label1.Text = "状态↓";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(579, 379);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(558, 261);
            this.txtLog.TabIndex = 79;
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Font = new System.Drawing.Font("宋体", 16F);
            this.txtUrl.Location = new System.Drawing.Point(595, 33);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ReadOnly = true;
            this.txtUrl.Size = new System.Drawing.Size(513, 32);
            this.txtUrl.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(710, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 78;
            this.label2.Text = "信息数量：";
            // 
            // lbIsRepass
            // 
            this.lbIsRepass.BackColor = System.Drawing.Color.Green;
            this.lbIsRepass.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbIsRepass.ForeColor = System.Drawing.Color.White;
            this.lbIsRepass.Location = new System.Drawing.Point(587, 121);
            this.lbIsRepass.Name = "lbIsRepass";
            this.lbIsRepass.Size = new System.Drawing.Size(235, 108);
            this.lbIsRepass.TabIndex = 78;
            this.lbIsRepass.Text = "无重复";
            this.lbIsRepass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbReBath
            // 
            this.lbReBath.BackColor = System.Drawing.Color.Green;
            this.lbReBath.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbReBath.ForeColor = System.Drawing.Color.White;
            this.lbReBath.Location = new System.Drawing.Point(888, 121);
            this.lbReBath.Name = "lbReBath";
            this.lbReBath.Size = new System.Drawing.Size(235, 108);
            this.lbReBath.TabIndex = 78;
            this.lbReBath.Text = "同批号";
            this.lbReBath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCount
            // 
            this.lbCount.BackColor = System.Drawing.Color.OldLace;
            this.lbCount.Font = new System.Drawing.Font("黑体", 80F, System.Drawing.FontStyle.Bold);
            this.lbCount.Location = new System.Drawing.Point(886, 263);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(237, 109);
            this.lbCount.TabIndex = 78;
            this.lbCount.Text = "0";
            this.lbCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 20F);
            this.label3.Location = new System.Drawing.Point(590, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 27);
            this.label3.TabIndex = 78;
            this.label3.Text = "当前扫描域名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 20F);
            this.label4.Location = new System.Drawing.Point(591, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 27);
            this.label4.TabIndex = 78;
            this.label4.Text = "当前批号：";
            // 
            // txtCurBath
            // 
            this.txtCurBath.Font = new System.Drawing.Font("宋体", 16F);
            this.txtCurBath.Location = new System.Drawing.Point(725, 71);
            this.txtCurBath.Name = "txtCurBath";
            this.txtCurBath.ReadOnly = true;
            this.txtCurBath.Size = new System.Drawing.Size(212, 32);
            this.txtCurBath.TabIndex = 79;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("宋体", 12F);
            this.txtNumber.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtNumber.Location = new System.Drawing.Point(48, 3);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(504, 26);
            this.txtNumber.TabIndex = 79;
            this.txtNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumber_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 78;
            this.label5.Text = "扫码：";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 642);
            this.Controls.Add(this.txtCurBath);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbReBath);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbIsRepass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.DgvMater);
            this.Name = "frmMain";
            this.Text = "二维码信息比较工具";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMater)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMater;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbIsRepass;
        private System.Windows.Forms.Label lbReBath;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurBath;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsBathDif;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsReNumber;
    }
}

