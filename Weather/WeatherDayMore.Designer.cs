namespace Weather
{
    partial class WeatherDayMore
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelDay = new System.Windows.Forms.Label();
            this.pictureBoxWeather = new System.Windows.Forms.PictureBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelWind1 = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelWind2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 7;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel.Controls.Add(this.labelDay, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.pictureBoxWeather, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelWind1, 5, 0);
            this.tableLayoutPanel.Controls.Add(this.labelInfo, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.labelTemp, 4, 0);
            this.tableLayoutPanel.Controls.Add(this.labelWind2, 6, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(728, 28);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelDay
            // 
            this.labelDay.BackColor = System.Drawing.Color.LightGray;
            this.labelDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDay.Location = new System.Drawing.Point(0, 0);
            this.labelDay.Margin = new System.Windows.Forms.Padding(0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(110, 28);
            this.labelDay.TabIndex = 1;
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxWeather
            // 
            this.pictureBoxWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxWeather.Location = new System.Drawing.Point(110, 0);
            this.pictureBoxWeather.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxWeather.Name = "pictureBoxWeather";
            this.pictureBoxWeather.Size = new System.Drawing.Size(30, 28);
            this.pictureBoxWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxWeather.TabIndex = 5;
            this.pictureBoxWeather.TabStop = false;
            // 
            // labelInfo
            // 
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInfo.Location = new System.Drawing.Point(160, 0);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(140, 28);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWind1
            // 
            this.labelWind1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWind1.Location = new System.Drawing.Point(440, 0);
            this.labelWind1.Margin = new System.Windows.Forms.Padding(0);
            this.labelWind1.Name = "labelWind1";
            this.labelWind1.Size = new System.Drawing.Size(140, 28);
            this.labelWind1.TabIndex = 9;
            this.labelWind1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTemp
            // 
            this.labelTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTemp.Location = new System.Drawing.Point(300, 0);
            this.labelTemp.Margin = new System.Windows.Forms.Padding(0);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(140, 28);
            this.labelTemp.TabIndex = 10;
            this.labelTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWind2
            // 
            this.labelWind2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWind2.Location = new System.Drawing.Point(580, 0);
            this.labelWind2.Margin = new System.Windows.Forms.Padding(0);
            this.labelWind2.Name = "labelWind2";
            this.labelWind2.Size = new System.Drawing.Size(148, 28);
            this.labelWind2.TabIndex = 9;
            this.labelWind2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeatherDayMore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(730, 30);
            this.MinimumSize = new System.Drawing.Size(730, 30);
            this.Name = "WeatherDayMore";
            this.Size = new System.Drawing.Size(728, 28);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.PictureBox pictureBoxWeather;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelWind1;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelWind2;
    }
}
