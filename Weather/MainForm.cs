using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Weather
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        public void InvokeToForm(Action action) => this.Invoke(action);
        public void BeginInvokeToForm(Action action) => this.BeginInvoke(action);
        private void BindProvince()
        {
            this.InvokeToForm(() => 
            {
                comboBoxProvince.ComboBox.ValueMember = "ID";
                comboBoxProvince.ComboBox.DisplayMember = "Name";
            });
            PlaceModel[] provinces = Place.GetProvinces();
            if(provinces != null)
            {
                this.InvokeToForm(() => comboBoxProvince.ComboBox.DataSource = provinces);
            }
        }
        
        private void BindCity()
        {
            PlaceModel city = null;
            this.InvokeToForm(() => 
            {
                comboBoxCity.ComboBox.ValueMember = "ID";
                comboBoxCity.ComboBox.DisplayMember = "Name";
                city = comboBoxProvince.ComboBox.SelectedItem as PlaceModel;
            });
            if(city != null)
            {
                PlaceModel[] citys = Place.GetCitys(city);
                this.InvokeToForm(() => comboBoxCity.ComboBox.DataSource = citys);
            }
        }

        private void BindDistrict()
        {
            PlaceModel province = null;
            PlaceModel city = null;
            this.InvokeToForm(() =>
            {
                comboBoxDistrict.ComboBox.ValueMember = "ID";
                comboBoxDistrict.ComboBox.DisplayMember = "Name";
                province = comboBoxProvince.ComboBox.SelectedItem as PlaceModel;
                city = comboBoxCity.ComboBox.SelectedItem as PlaceModel;
            });
            if(province != null && city != null)
            {
                PlaceModel[] districts = Place.GetDistricts(province, city);
                this.InvokeToForm(() => comboBoxDistrict.ComboBox.DataSource = districts);
            }
            else
            {
                this.InvokeToForm(() => lblStatus.Text = "地区加载错误，请确保联网正确");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblVerson.Text = $"版本：{Assembly.GetExecutingAssembly().GetName().Version.ToString()}";
            lblStatus.Text = "数据加载中";
            BindMenu();
            Task.Factory.StartNew(() => 
            {
                BindProvince();
                BindCity();
                BindDistrict();
                this.BeginInvokeToForm(() => {
                    if(areas!= null && areas.Areas!= null && areas.Areas.Length >0)
                    {
                        comboBoxProvince.SelectedItem = areas.Areas[0].Province;
                        comboBoxCity.SelectedItem = areas.Areas[0].City;
                        comboBoxDistrict.SelectedItem = areas.Areas[0].District;
                    }
                    buttonSearch.PerformClick();
                });
            }).ContinueWith(t=> 
            {
                if(t.IsFaulted)
                {
                    this.InvokeToForm(() => lblStatus.Text = "地区加载错误，请确保联网正确");
                }
            });
            
        }

        private void ComboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
             BindCity();
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDistrict();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            PlaceModel province = null, city= null, district = null;
            this.InvokeToForm(() =>
            {
                province = this.comboBoxProvince.ComboBox.SelectedItem as PlaceModel;
                city = this.comboBoxCity.ComboBox.SelectedItem as PlaceModel;
                district = this.comboBoxDistrict.ComboBox.SelectedItem as PlaceModel;
            });
            if(province != null && city != null && district != null)
            {
                this.InvokeToForm(() =>lblStatus.Text = "查询中");
                Task.Factory.StartNew(() =>
                {
                    WeatherDetail detail = this.Search(province, city, district);
                    this.Invoke(new Action(() =>
                    {
                        this.SetWeather(detail);
                        lblStatus.Text = "已完成";
                    }));
                }).ContinueWith(t=> 
                {
                    if(t.IsFaulted)
                    {
                        this.InvokeToForm(() =>lblStatus.Text = "查询错误，请确保联网正确");
                    }
                });
            }
        }

        private void SetWeather(WeatherDetail detail)
        {
            WeatherDay[] weatherDays = new WeatherDay[] { weatherDay1, weatherDay2, weatherDay3, weatherDay4, weatherDay5, weatherDay6, weatherDay7 };
            for(int i=0;i<weatherDays.Length;i++)
            {
                weatherDays[i].Day = detail.Day_1To7[i]??"";
                weatherDays[i].Info = detail.Info_1To7[i] ?? "";
                weatherDays[i].Temperature = detail.Temperature_1To7[i] ?? "";
                weatherDays[i].Wind = detail.Wind_1To7[i] ?? "";
                weatherDays[i].WeatherStatus =detail.WeatherStatus_1To7[i];
            }
            WeatherDayMore[] weatherDaysMore = new WeatherDayMore[] { weatherDayMore1, weatherDayMore2, weatherDayMore3, weatherDayMore4, weatherDayMore5, weatherDayMore6, weatherDayMore7, weatherDayMore8 };
            for (int i = 0; i < weatherDaysMore.Length; i++)
            {
                weatherDaysMore[i].Day = detail.Day_7To15[i] ?? "";
                weatherDaysMore[i].Info = detail.Info_7To15[i] ?? "";
                weatherDaysMore[i].Temperature = detail.Temperature_7To15[i] ?? "";
                weatherDaysMore[i].Wind1 = detail.Wind1_7To15[i] ?? "";
                weatherDaysMore[i].Wind2 = detail.Wind2_7To15[i] ?? "";
                weatherDaysMore[i].WeatherStatus = detail.WeatherStatus_7To15[i];
            }
        }

        private WeatherDetail Search(PlaceModel province, PlaceModel city, PlaceModel district)
        {
            WeatherDetail detail = new WeatherDetail(province, city, district);
            detail.HandleWeather();
            return detail;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"天气预报\r\n版本：{Assembly.GetExecutingAssembly().GetName().Version.ToString()}\r\n作者QQ：494345105\r\nEmail:cnc46@qq.com","信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "weather.xml");
        AreaCollection areas;
        private void BindMenu()
        {
            buttonCustom.DropDownItems.Clear();
            //ToolStripMenuItem
            areas = XmlOperator.Deserialize<AreaCollection>(path);
            if(areas != null)
            {
                for(int i=0;i<areas.Areas.Length;i++)
                {
                    ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem
                    {
                        Name = $"toolStripMenuItem_{areas.Areas[i].Province.Name}_{areas.Areas[i].City.Name}_{areas.Areas[i].District.Name}",
                        Text = areas.Areas[i].Name,
                        Tag = areas.Areas[i]
                    };
                    toolStripMenuItem.Click += (s, o) => 
                    {
                        ToolStripMenuItem _toolStripMenuItem = (ToolStripMenuItem)s;
                        Area area = (Area)_toolStripMenuItem.Tag;
                        comboBoxProvince.SelectedItem = area.Province;
                        comboBoxCity.SelectedItem = area.City;
                        comboBoxDistrict.SelectedItem = area.District;
                        buttonSearch.PerformClick();
                    };
                    buttonCustom.DropDownItems.Add(toolStripMenuItem);
                }
            }
            else
            {
                areas = new AreaCollection();
            }
            buttonCustom.DropDownItems.Add(new ToolStripSeparator());
            ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem()
            {
                Name = "toolStripMenuItem_AddCity",
                Text = "添加城市",
            };
            toolStripMenuItem1.Click += (s, o) =>
            {
                PlaceModel province = comboBoxProvince.ComboBox.SelectedItem as PlaceModel;
                PlaceModel city = comboBoxCity.ComboBox.SelectedItem as PlaceModel;
                PlaceModel district = comboBoxDistrict.ComboBox.SelectedItem as PlaceModel;
                if(province != null && city != null && district != null)
                { 
                    areas.Add(new Area() { Name = district.Name, Province = province, City = city, District = district });
                    XmlOperator.Serialize(path,areas);
                    BindMenu();
                }
            };
            buttonCustom.DropDownItems.Add(toolStripMenuItem1);


            ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem()
            {
                Name = "toolStripMenuItem_DeleteCity",
                Text = "删除城市",
            };
            toolStripMenuItem2.Click += (s, o) =>
            {
                PlaceModel province = comboBoxProvince.ComboBox.SelectedItem as PlaceModel;
                PlaceModel city = comboBoxCity.ComboBox.SelectedItem as PlaceModel;
                PlaceModel district = comboBoxDistrict.ComboBox.SelectedItem as PlaceModel;
                if (province != null && city != null && district != null)
                {
                    areas.Remove(new Area() { Name = district.Name, Province = province, City = city, District = district });
                    XmlOperator.Serialize(path, areas);
                    BindMenu();
                }
            };
            buttonCustom.DropDownItems.Add(toolStripMenuItem2);
        }
    }
}
