using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class WeatherDayMore : UserControl
    {
        public WeatherDayMore()
        {
            InitializeComponent();
        }

        string day;
        [Category("设置")]
        [Description("设置或获得日期")]
        [DefaultValue("")]
        public string Day
        {
            set
            {
                this.day = value;
                this.labelDay.Text = this.day;
            }
            get
            {
                return this.day;
            }
        }
        string info;
        [Category("设置")]
        [Description("设置或获得天气信息")]
        [DefaultValue("")]
        public string Info
        {
            set
            {
                this.info = value;
                this.labelInfo.Text = this.info;
            }
            get
            {
                return this.info;
            }
        }

        string temperature;
        [Category("设置")]
        [Description("设置或获得温度")]
        public string Temperature
        {
            set
            {
                this.temperature = value;
                this.labelTemp.Text = this.temperature;
            }
            get
            {
                return this.temperature;
            }
        }


        string wind1;
        [Category("设置")]
        [Description("设置或获得风级1")]
        [DefaultValue("")]
        public string Wind1
        {
            set
            {
                this.wind1 = value;
                this.labelWind1.Text = this.wind1;
            }
            get
            {
                return this.wind1;
            }
        }

        string wind2;
        [Category("设置")]
        [Description("设置或获得风级2")]
        [DefaultValue("")]
        public string Wind2
        {
            set
            {
                this.wind2 = value;
                this.labelWind2.Text = this.wind2;
            }
            get
            {
                return this.wind2;
            }
        }

        WeatherStatus status = WeatherStatus.Weizhi;
        [Category("设置")]
        [Description("设置或获得天气图标")]
        [DefaultValue(WeatherStatus.Weizhi)]
        public WeatherStatus WeatherStatus
        {
            set
            {
                this.status = value;
                this.pictureBoxWeather.ImageLocation = this.GetSmallWeatherStatusString(this.status);
            }
            get
            {
                return this.status;
            }
        }

        string GetSmallWeatherStatusString(WeatherStatus weatherStatus)
        {
            string url = "http://www.webxml.com.cn/images/weather/";
            switch (weatherStatus)
            {
                case WeatherStatus.Weizhi: url += "nothing.gif"; break;
                case WeatherStatus.Qing: url += "0.gif"; break;
                case WeatherStatus.Duoyun: url += "1.gif"; break;
                case WeatherStatus.Yin: url += "2.gif"; break;
                case WeatherStatus.Zhenyu: url += "3.gif"; break;
                case WeatherStatus.Leizhenyu: url += "4.gif"; break;
                case WeatherStatus.LeizhenyuBingpao: url += "5.gif"; break;
                case WeatherStatus.Yujiaxue: url += "6.gif"; break;
                case WeatherStatus.Xiaoyu: url += "7.gif"; break;
                case WeatherStatus.Zhongyu: url += "8.gif"; break;
                case WeatherStatus.Dayu: url += "9.gif"; break;
                case WeatherStatus.Baoyu: url += "10.gif"; break;
                case WeatherStatus.Dabaoyu: url += "11.gif"; break;
                case WeatherStatus.Tedabaoyu: url += "12.gif"; break;
                case WeatherStatus.Zhenxue: url += "13.gif"; break;
                case WeatherStatus.Xiaoxue: url += "14.gif"; break;
                case WeatherStatus.Zhongxue: url += "15.gif"; break;
                case WeatherStatus.Daxue: url += "16.gif"; break;
                case WeatherStatus.Baoxue: url += "17.gif"; break;
                case WeatherStatus.Wu: url += "18.gif"; break;
                case WeatherStatus.Dongyu: url += "19.gif"; break;
                case WeatherStatus.Shachenbao: url += "20.gif"; break;
                case WeatherStatus.XiaoyuZhuangZhongyu: url += "21.gif"; break;
                case WeatherStatus.ZhongyuZhuangDayu: url += "22.gif"; break;
                case WeatherStatus.DayuZhuangBaoyu: url += "23.gif"; break;
                case WeatherStatus.BaoyuZhuangDabaoyu: url += "24.gif"; break;
                case WeatherStatus.DabaoyuZhuangTedabaoyu: url += "25.gif"; break;
                case WeatherStatus.XiaoxueZhuangZhongxue: url += "26.gif"; break;
                case WeatherStatus.ZhongxueZhuangDaxue: url += "27.gif"; break;
                case WeatherStatus.DaxueZhuangBaoxue: url += "28.gif"; break;
                case WeatherStatus.Fuchen: url += "29.gif"; break;
                case WeatherStatus.Yasha: url += "30.gif"; break;
                case WeatherStatus.Qiangshachenbao: url += "31.gif"; break;
                case WeatherStatus.Xiaodaozhongyu: url += "21.gif"; break;
                case WeatherStatus.Zhongdaodayu: url += "22.gif"; break;
                case WeatherStatus.Dadaobaoyu: url += "23.gif"; break;
                case WeatherStatus.Xiaodaozhongxue: url += "26.gif"; break;
                case WeatherStatus.Zhongdaodaxue: url += "27.gif"; break;
                case WeatherStatus.Dadaobaoxue: url += "28.gif"; break;
                case WeatherStatus.Xiaozhenyu: url += "3.gif"; break;
                case WeatherStatus.Yintian: url += "2.gif"; break;
                case WeatherStatus.Mai: url += "18.gif"; break;
                case WeatherStatus.Wumai: url += "18.gif"; break;
                default: url += "nothing.gif"; break;
            }
            return url;
        }
    }
}
