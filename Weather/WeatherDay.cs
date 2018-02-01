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
    [DefaultProperty("Day")]
    public partial class WeatherDay : UserControl
    {
        public WeatherDay()
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


        string wind;
        [Category("设置")]
        [Description("设置或获得风级")]
        [DefaultValue("")]
        public string Wind
        {
            set
            {
                this.wind = value;
                this.labelWind.Text = this.wind;
            }
            get
            {
                return this.wind;
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
                this.pictureBoxWeather.ImageLocation = this.GetBigWeatherStatusString(this.status);
            }
            get
            {
                return this.status;
            }
        }

        string GetBigWeatherStatusString(WeatherStatus weatherStatus)
        {
            string url = "http://www.webxml.com.cn/images/weather/";
            switch (weatherStatus)
            {
                case WeatherStatus.Weizhi: url +=  "a_nothing.gif";break;
                case WeatherStatus.Qing: url += "a_0.gif"; break;
                case WeatherStatus.Duoyun: url += "a_1.gif"; break;
                case WeatherStatus.Yin: url += "a_2.gif"; break;
                case WeatherStatus.Zhenyu: url += "a_3.gif"; break;
                case WeatherStatus.Leizhenyu: url += "a_4.gif"; break;
                case WeatherStatus.LeizhenyuBingpao: url += "a_5.gif"; break;
                case WeatherStatus.Yujiaxue: url += "a_6.gif"; break;
                case WeatherStatus.Xiaoyu: url += "a_7.gif"; break;
                case WeatherStatus.Zhongyu: url += "a_8.gif"; break;
                case WeatherStatus.Dayu: url += "a_9.gif"; break;
                case WeatherStatus.Baoyu: url += "a_10.gif"; break;
                case WeatherStatus.Dabaoyu: url += "a_11.gif"; break;
                case WeatherStatus.Tedabaoyu: url += "a_12.gif"; break;
                case WeatherStatus.Zhenxue: url += "a_13.gif"; break;
                case WeatherStatus.Xiaoxue: url += "a_14.gif"; break;
                case WeatherStatus.Zhongxue: url += "a_15.gif"; break;
                case WeatherStatus.Daxue: url += "a_16.gif"; break;
                case WeatherStatus.Baoxue: url += "a_17.gif"; break;
                case WeatherStatus.Wu: url += "a_18.gif"; break;
                case WeatherStatus.Dongyu: url += "a_19.gif"; break;
                case WeatherStatus.Shachenbao: url += "a_20.gif"; break;
                case WeatherStatus.XiaoyuZhuangZhongyu: url += "a_21.gif"; break;
                case WeatherStatus.ZhongyuZhuangDayu: url += "a_22.gif"; break;
                case WeatherStatus.DayuZhuangBaoyu: url += "a_23.gif"; break;
                case WeatherStatus.BaoyuZhuangDabaoyu: url += "a_24.gif"; break;
                case WeatherStatus.DabaoyuZhuangTedabaoyu: url += "a_25.gif"; break;
                case WeatherStatus.XiaoxueZhuangZhongxue: url += "a_26.gif"; break;
                case WeatherStatus.ZhongxueZhuangDaxue: url += "a_27.gif"; break;
                case WeatherStatus.DaxueZhuangBaoxue: url += "a_28.gif"; break;
                case WeatherStatus.Fuchen: url += "a_29.gif"; break;
                case WeatherStatus.Yasha: url += "a_30.gif"; break;
                case WeatherStatus.Qiangshachenbao: url += "a_31.gif"; break;
                case WeatherStatus.Xiaodaozhongyu: url += "a_21.gif"; break;
                case WeatherStatus.Zhongdaodayu: url += "a_22.gif"; break;
                case WeatherStatus.Dadaobaoyu: url += "a_23.gif"; break;
                case WeatherStatus.Xiaodaozhongxue: url += "a_26.gif"; break;
                case WeatherStatus.Zhongdaodaxue: url += "a_27.gif"; break;
                case WeatherStatus.Dadaobaoxue: url += "a_28.gif"; break;
                case WeatherStatus.Xiaozhenyu: url += "a_3.gif"; break;
                case WeatherStatus.Yintian: url += "a_2.gif"; break;
                case WeatherStatus.Mai: url += "a_18.gif"; break;
                case WeatherStatus.Wumai: url += "a_18.gif"; break;
                default: url += "a_nothing.gif"; break;
            }
            return url;
        }


    }



    /// <summary>
    /// 天气状态
    /// </summary>
    public enum WeatherStatus
    {
        /// <summary>
        /// 未知
        /// </summary>
        Weizhi,
        /// <summary>
        /// 晴
        /// </summary>
        Qing,
        /// <summary>
        /// 多云
        /// </summary>
        Duoyun,
        /// <summary>
        /// 阴
        /// </summary>
        Yin,
        /// <summary>
        /// 阵雨
        /// </summary>
        Zhenyu,
        /// <summary>
        /// 雷阵雨
        /// </summary>
        Leizhenyu,
        /// <summary>
        /// 雷阵雨并伴有冰雹
        /// </summary>
        LeizhenyuBingpao,
        /// <summary>
        /// 雨夹雪
        /// </summary>
        Yujiaxue,
        /// <summary>
        /// 小雨
        /// </summary>
        Xiaoyu,
        /// <summary>
        /// 中雨
        /// </summary>
        Zhongyu,
        /// <summary>
        /// 大雨
        /// </summary>
        Dayu,
        /// <summary>
        /// 暴雨
        /// </summary>
        Baoyu,
        /// <summary>
        /// 大暴雨
        /// </summary>
        Dabaoyu,
        /// <summary>
        /// 特大暴雨
        /// </summary>
        Tedabaoyu,
        /// <summary>
        /// 阵雪
        /// </summary>
        Zhenxue,
        /// <summary>
        /// 小雪
        /// </summary>
        Xiaoxue,
        /// <summary>
        /// 中雪
        /// </summary>
        Zhongxue,
        /// <summary>
        /// 大雪
        /// </summary>
        Daxue,
        /// <summary>
        /// 暴雪
        /// </summary>
        Baoxue,
        /// <summary>
        /// 雾
        /// </summary>
        Wu,
        /// <summary>
        /// 冻雨
        /// </summary>
        Dongyu,
        /// <summary>
        /// 沙尘暴
        /// </summary>
        Shachenbao,
        /// <summary>
        /// 小雨-中雨
        /// </summary>
        XiaoyuZhuangZhongyu,
        /// <summary>
        /// 中雨-大雨
        /// </summary>
        ZhongyuZhuangDayu,
        /// <summary>
        /// 大雨-暴雨
        /// </summary>
        DayuZhuangBaoyu,
        /// <summary>
        /// 大雨-大暴雨
        /// </summary>
        BaoyuZhuangDabaoyu,
        /// <summary>
        /// 大暴雨-特大暴雨
        /// </summary>
        DabaoyuZhuangTedabaoyu,
        /// <summary>
        /// 小雪-中雪
        /// </summary>
        XiaoxueZhuangZhongxue,
        /// <summary>
        /// 中雪-大雪
        /// </summary>
        ZhongxueZhuangDaxue,
        /// <summary>
        /// 大雪-暴雪
        /// </summary>
        DaxueZhuangBaoxue,
        /// <summary>
        /// 浮尘
        /// </summary>
        Fuchen,
        /// <summary>
        /// 扬沙
        /// </summary>
        Yasha,
        /// <summary>
        /// 强沙尘暴
        /// </summary>
        Qiangshachenbao,
        /// <summary>
        /// 小到中雨
        /// </summary>
        Xiaodaozhongyu,
        /// <summary>
        /// 中到大雨
        /// </summary>
        Zhongdaodayu,
        /// <summary>
        /// 大到暴雨
        /// </summary>
        Dadaobaoyu,
        /// <summary>
        /// 小到中雪
        /// </summary>
        Xiaodaozhongxue,
        /// <summary>
        /// 中到大雪
        /// </summary>
        Zhongdaodaxue,
        /// <summary>
        /// 大到暴雪
        /// </summary>
        Dadaobaoxue,
        /// <summary>
        /// 小阵雨
        /// </summary>
        Xiaozhenyu,
        /// <summary>
        /// 阴天
        /// </summary>
        Yintian,
        /// <summary>
        /// 霾
        /// </summary>
        Mai,
        /// <summary>
        /// 雾霾
        /// </summary>
        Wumai
    }

}
