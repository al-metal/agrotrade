using Bike18;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agrotrade
{
    public partial class Form1 : Form
    {
        Thread forms;

        nethouse nethouse = new nethouse();
        httpRequest httprequest = new httpRequest();

        string fileUrls;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbLogin.Text = Properties.Settings.Default.login;
            tbPasswords.Text = Properties.Settings.Default.password;
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.login = tbLogin.Text;
            Properties.Settings.Default.password = tbPasswords.Text;
            Properties.Settings.Default.Save();

            fileUrls = "";
            ofdLoadPrice.ShowDialog();

            fileUrls = ofdLoadPrice.FileName.ToString();

            if (ofdLoadPrice.FileName == "openFileDialog1" || ofdLoadPrice.FileName == "")
            {
                MessageBox.Show("Ошибка при выборе файла", "Ошибка файла");
                return;
            }

            Thread tabl = new Thread(() => UpdateTovarXLSX());
            forms = tabl;
            forms.IsBackground = true;
            forms.Start();
        }

        private void UpdateTovarXLSX()
        {
            ControlsFormEnabledFalse();

            CookieContainer cookie = nethouse.CookieNethouse(tbLogin.Text, tbPasswords.Text);
            if (cookie.Count == 1)
            {
                MessageBox.Show("Логин или пароль для сайта введены не верно", "Ошибка логина/пароля");
                ControlsFormEnabledTrue();
                return;
            }

            FileInfo file = new FileInfo(fileUrls);
            ExcelPackage p = new ExcelPackage(file);
            ExcelWorksheet w = p.Workbook.Worksheets[1];
            int q = w.Dimension.Rows;

            for (int i = 4; q > i; i++)
            {
                string name = (string)w.Cells[i, 1].Value;
                double coast = (double)w.Cells[i, 3].Value;
                coast = ReturnPrice(coast);

                if (name == "" || coast == 0)
                    continue;

                name = ReturnName(name);

                string urlProduct = "";
                urlProduct = nethouse.searchTovar(name, name);
                if (urlProduct == null)
                {

                }
                else
                {
                    List<string> productB18 = nethouse.GetProductList(cookie, urlProduct);

                    string coastB18 = productB18[9];

                    if (coast.ToString() != coastB18)
                    {
                        productB18[9] = coast.ToString();
                        nethouse.SaveTovar(cookie, productB18);
                    }
                }
            }


            ControlsFormEnabledTrue();
        }

        private double ReturnPrice(double coast)
        {
            int newCoast = 0;
            if (coast < 30000)
            {
                double percent = coast * 0.2;
                coast = coast + percent;
                newCoast = Convert.ToInt32(coast);
                newCoast = newCoast / 100 * 100;
            }
            else if (coast < 100000)
            {
                double percent = coast * 0.15;
                coast = coast + percent;
                newCoast = Convert.ToInt32(coast);
                newCoast = newCoast / 100 * 100;
            }
            else if (coast < 1000000)
            {
                double percent = coast * 0.1;
                coast = coast + percent;
                newCoast = Convert.ToInt32(coast);
                newCoast = newCoast / 100 * 100;
            }
            else if (coast > 100000)
            {
                double percent = coast * 0.05;
                coast = coast + percent;
                newCoast = Convert.ToInt32(coast);
                newCoast = newCoast / 100 * 100;
            }

            coast = Convert.ToDouble(newCoast);
            return coast;
        }

        private string ReturnName(string name)
        {
            if (name.Contains("Борона бдф"))
            {
                string options = new Regex("\\(.*\\)").Match(name).ToString();
                name = name.Replace("бдф", "БДФ").Replace(options, "").Trim();
                int countM = name.LastIndexOf('м');
                if (countM == name.Length - 1)
                    name = name.Remove(name.Length - 1) + " м";
            }

            return name;
        }

        private void ControlsFormEnabledTrue()
        {
            btnPrice.Invoke(new Action(() => btnPrice.Enabled = true));
            tbLogin.Invoke(new Action(() => tbLogin.Enabled = true));
            tbPasswords.Invoke(new Action(() => tbPasswords.Enabled = true));
        }

        private void ControlsFormEnabledFalse()
        {
            btnPrice.Invoke(new Action(() => btnPrice.Enabled = false));
            tbLogin.Invoke(new Action(() => tbLogin.Enabled = false));
            tbPasswords.Invoke(new Action(() => tbPasswords.Enabled = false));

        }
    }
}
