namespace RandomPic.Client
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFav = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFileName = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.lbWidthAndHeight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbForder = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbTotalCount = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(31, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(31, 244);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(27, 27);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(64, 244);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(27, 27);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnFav
            // 
            this.btnFav.Location = new System.Drawing.Point(97, 244);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(27, 27);
            this.btnFav.TabIndex = 2;
            this.btnFav.Text = "收";
            this.btnFav.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(249, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文 件 名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(249, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "大    小：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(249, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "路    径：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(249, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "尺    寸：";
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.BackColor = System.Drawing.Color.Transparent;
            this.lbFileName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFileName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbFileName.Location = new System.Drawing.Point(320, 27);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(65, 12);
            this.lbFileName.TabIndex = 3;
            this.lbFileName.Text = "lbFileName";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.BackColor = System.Drawing.Color.Transparent;
            this.lbSize.Location = new System.Drawing.Point(320, 53);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(65, 12);
            this.lbSize.TabIndex = 3;
            this.lbSize.Text = "lbFileName";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.BackColor = System.Drawing.Color.Transparent;
            this.lbPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPath.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbPath.Location = new System.Drawing.Point(3, 0);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(65, 12);
            this.lbPath.TabIndex = 3;
            this.lbPath.Text = "lbFileName";
            // 
            // lbWidthAndHeight
            // 
            this.lbWidthAndHeight.AutoSize = true;
            this.lbWidthAndHeight.BackColor = System.Drawing.Color.Transparent;
            this.lbWidthAndHeight.Location = new System.Drawing.Point(320, 79);
            this.lbWidthAndHeight.Name = "lbWidthAndHeight";
            this.lbWidthAndHeight.Size = new System.Drawing.Size(65, 12);
            this.lbWidthAndHeight.TabIndex = 3;
            this.lbWidthAndHeight.Text = "lbFileName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(249, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "目    錄：";
            // 
            // lbForder
            // 
            this.lbForder.AutoSize = true;
            this.lbForder.BackColor = System.Drawing.Color.Transparent;
            this.lbForder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbForder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbForder.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbForder.Location = new System.Drawing.Point(3, 0);
            this.lbForder.Name = "lbForder";
            this.lbForder.Size = new System.Drawing.Size(65, 12);
            this.lbForder.TabIndex = 3;
            this.lbForder.Text = "lbFileName";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Location = new System.Drawing.Point(213, 252);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(11, 12);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "T";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(130, 244);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(27, 27);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // lbTotalCount
            // 
            this.lbTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalCount.AutoSize = true;
            this.lbTotalCount.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalCount.Location = new System.Drawing.Point(623, 277);
            this.lbTotalCount.Name = "lbTotalCount";
            this.lbTotalCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotalCount.Size = new System.Drawing.Size(77, 12);
            this.lbTotalCount.TabIndex = 6;
            this.lbTotalCount.Text = "lbTotalCount";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.lbPath);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(320, 105);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(370, 44);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.lbForder);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(320, 155);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(370, 47);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(702, 298);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbTotalCount);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbWidthAndHeight);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnFav);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbWidthAndHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbForder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbTotalCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

