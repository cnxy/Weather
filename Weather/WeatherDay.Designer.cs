namespace Weather
{
    partial class WeatherDay
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
            this.labelDay = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelWind = new System.Windows.Forms.Label();
            this.pictureBoxWeather = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDay
            // 
            this.labelDay.BackColor = System.Drawing.Color.LightGray;
            this.labelDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDay.Location = new System.Drawing.Point(0, 0);
            this.labelDay.Margin = new System.Windows.Forms.Padding(0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(97, 30);
            this.labelDay.TabIndex = 0;
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInfo
            // 
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInfo.Location = new System.Drawing.Point(0, 30);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(97, 35);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.labelDay, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelInfo, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelTemp, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelWind, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.pictureBoxWeather, 0, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(97, 207);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // labelTemp
            // 
            this.labelTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTemp.Location = new System.Drawing.Point(0, 65);
            this.labelTemp.Margin = new System.Windows.Forms.Padding(0);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(97, 35);
            this.labelTemp.TabIndex = 2;
            this.labelTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWind
            // 
            this.labelWind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWind.Location = new System.Drawing.Point(0, 100);
            this.labelWind.Margin = new System.Windows.Forms.Padding(0);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(97, 35);
            this.labelWind.TabIndex = 3;
            this.labelWind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxWeather
            // 
            this.pictureBoxWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxWeather.Location = new System.Drawing.Point(0, 135);
            this.pictureBoxWeather.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxWeather.Name = "pictureBoxWeather";
            this.pictureBoxWeather.Size = new System.Drawing.Size(97, 72);
            this.pictureBoxWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxWeather.TabIndex = 4;
            this.pictureBoxWeather.TabStop = false;
            // 
            // WeatherDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(99, 209);
            this.MinimumSize = new System.Drawing.Size(99, 209);
            this.Name = "WeatherDay";
            this.Size = new System.Drawing.Size(97, 207);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelWind;
        private System.Windows.Forms.PictureBox pictureBoxWeather;
    }
}
