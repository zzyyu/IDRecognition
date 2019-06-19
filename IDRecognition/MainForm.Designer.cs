namespace IDRecognition
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnFile = new System.Windows.Forms.Button();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblFace = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbBirth = new System.Windows.Forms.TextBox();
            this.tbNation = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblNation = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIssue = new System.Windows.Forms.TextBox();
            this.tbEnd_date = new System.Windows.Forms.TextBox();
            this.tbStart_date = new System.Windows.Forms.TextBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.lblEnd_date = new System.Windows.Forms.Label();
            this.lblStart_date = new System.Windows.Forms.Label();
            this.cmbConfigure = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(18, 12);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(111, 45);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "文件识别";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // lblWaiting
            // 
            this.lblWaiting.AutoSize = true;
            this.lblWaiting.Font = new System.Drawing.Font("宋体", 16F);
            this.lblWaiting.Location = new System.Drawing.Point(345, 20);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(162, 27);
            this.lblWaiting.TabIndex = 1;
            this.lblWaiting.Text = "等待数据...";
            // 
            // btnClipboard
            // 
            this.btnClipboard.Location = new System.Drawing.Point(156, 12);
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size(111, 45);
            this.btnClipboard.TabIndex = 4;
            this.btnClipboard.Text = "剪贴板识别";
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(16, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.Controls.Add(this.lblFace);
            this.splitContainer1.Panel1.Controls.Add(this.tbAddress);
            this.splitContainer1.Panel1.Controls.Add(this.tbNum);
            this.splitContainer1.Panel1.Controls.Add(this.tbBirth);
            this.splitContainer1.Panel1.Controls.Add(this.tbNation);
            this.splitContainer1.Panel1.Controls.Add(this.lblAddress);
            this.splitContainer1.Panel1.Controls.Add(this.lblNum);
            this.splitContainer1.Panel1.Controls.Add(this.lblBirth);
            this.splitContainer1.Panel1.Controls.Add(this.lblNation);
            this.splitContainer1.Panel1.Controls.Add(this.lblSex);
            this.splitContainer1.Panel1.Controls.Add(this.lblName);
            this.splitContainer1.Panel1.Controls.Add(this.tbName);
            this.splitContainer1.Panel1.Controls.Add(this.tbSex);
            this.splitContainer1.Panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.splitContainer1_Panel1_DragDrop);
            this.splitContainer1.Panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.tbIssue);
            this.splitContainer1.Panel2.Controls.Add(this.tbEnd_date);
            this.splitContainer1.Panel2.Controls.Add(this.tbStart_date);
            this.splitContainer1.Panel2.Controls.Add(this.lblIssue);
            this.splitContainer1.Panel2.Controls.Add(this.lblEnd_date);
            this.splitContainer1.Panel2.Controls.Add(this.lblStart_date);
            this.splitContainer1.Panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.splitContainer1_Panel2_DragDrop);
            this.splitContainer1.Panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.splitContainer1.Size = new System.Drawing.Size(760, 260);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 21;
            // 
            // lblFace
            // 
            this.lblFace.AutoSize = true;
            this.lblFace.Font = new System.Drawing.Font("黑体", 15.73109F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFace.Location = new System.Drawing.Point(145, 14);
            this.lblFace.Name = "lblFace";
            this.lblFace.Size = new System.Drawing.Size(96, 27);
            this.lblFace.TabIndex = 27;
            this.lblFace.Text = "详情面";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(107, 213);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(251, 25);
            this.tbAddress.TabIndex = 26;
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(107, 183);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(251, 25);
            this.tbNum.TabIndex = 25;
            // 
            // tbBirth
            // 
            this.tbBirth.Location = new System.Drawing.Point(107, 153);
            this.tbBirth.Name = "tbBirth";
            this.tbBirth.Size = new System.Drawing.Size(251, 25);
            this.tbBirth.TabIndex = 24;
            // 
            // tbNation
            // 
            this.tbNation.Location = new System.Drawing.Point(107, 123);
            this.tbNation.Name = "tbNation";
            this.tbNation.Size = new System.Drawing.Size(251, 25);
            this.tbNation.TabIndex = 23;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 217);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(84, 15);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "住    址：";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(17, 187);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(82, 15);
            this.lblNum.TabIndex = 21;
            this.lblNum.Text = "身份证号：";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(17, 157);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(82, 15);
            this.lblBirth.TabIndex = 20;
            this.lblBirth.Text = "出生日期：";
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.Location = new System.Drawing.Point(17, 127);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(84, 15);
            this.lblNation.TabIndex = 19;
            this.lblNation.Text = "民    族：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(17, 97);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(84, 15);
            this.lblSex.TabIndex = 18;
            this.lblSex.Text = "性    别：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 15);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "姓    名：";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(107, 63);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(251, 25);
            this.tbName.TabIndex = 16;
            // 
            // tbSex
            // 
            this.tbSex.Location = new System.Drawing.Point(107, 93);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(251, 25);
            this.tbSex.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 15.73109F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(142, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 28;
            this.label1.Text = "有效面";
            // 
            // tbIssue
            // 
            this.tbIssue.Location = new System.Drawing.Point(157, 123);
            this.tbIssue.Name = "tbIssue";
            this.tbIssue.Size = new System.Drawing.Size(170, 25);
            this.tbIssue.TabIndex = 26;
            // 
            // tbEnd_date
            // 
            this.tbEnd_date.Location = new System.Drawing.Point(157, 93);
            this.tbEnd_date.Name = "tbEnd_date";
            this.tbEnd_date.Size = new System.Drawing.Size(170, 25);
            this.tbEnd_date.TabIndex = 25;
            // 
            // tbStart_date
            // 
            this.tbStart_date.Location = new System.Drawing.Point(157, 63);
            this.tbStart_date.Name = "tbStart_date";
            this.tbStart_date.Size = new System.Drawing.Size(170, 25);
            this.tbStart_date.TabIndex = 24;
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Location = new System.Drawing.Point(24, 127);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(122, 15);
            this.lblIssue.TabIndex = 23;
            this.lblIssue.Text = "签  发 机  关：";
            // 
            // lblEnd_date
            // 
            this.lblEnd_date.AutoSize = true;
            this.lblEnd_date.Location = new System.Drawing.Point(24, 97);
            this.lblEnd_date.Name = "lblEnd_date";
            this.lblEnd_date.Size = new System.Drawing.Size(127, 15);
            this.lblEnd_date.TabIndex = 22;
            this.lblEnd_date.Text = "有效期结束时间：";
            // 
            // lblStart_date
            // 
            this.lblStart_date.AutoSize = true;
            this.lblStart_date.Location = new System.Drawing.Point(24, 67);
            this.lblStart_date.Name = "lblStart_date";
            this.lblStart_date.Size = new System.Drawing.Size(127, 15);
            this.lblStart_date.TabIndex = 21;
            this.lblStart_date.Text = "有效期起始时间：";
            // 
            // cmbConfigure
            // 
            this.cmbConfigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigure.FormattingEnabled = true;
            this.cmbConfigure.Items.AddRange(new object[] {
            "详情面",
            "有效面"});
            this.cmbConfigure.Location = new System.Drawing.Point(665, 24);
            this.cmbConfigure.Name = "cmbConfigure";
            this.cmbConfigure.Size = new System.Drawing.Size(111, 23);
            this.cmbConfigure.TabIndex = 22;
            this.cmbConfigure.SelectedIndexChanged += new System.EventHandler(this.cmbConfigure_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 340);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.cmbConfigure);
            this.Controls.Add(this.lblWaiting);
            this.Controls.Add(this.btnClipboard);
            this.Controls.Add(this.btnFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "身份证识别";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label lblWaiting;
        private System.Windows.Forms.Button btnClipboard;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblFace;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbBirth;
        private System.Windows.Forms.TextBox tbNation;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblNation;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIssue;
        private System.Windows.Forms.TextBox tbEnd_date;
        private System.Windows.Forms.TextBox tbStart_date;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.Label lblEnd_date;
        private System.Windows.Forms.Label lblStart_date;
        private System.Windows.Forms.ComboBox cmbConfigure;
    }
}

