using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Drawing.Imaging;

namespace IDRecognition
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.cmbConfigure.SelectedIndex = 0;
        }

        byte[] contentBytes;       //图片编码
        //如果没有configure字段，config设为''  参数：face  back
        public static String config = "{\\\"side\\\":\\\"face\\\"}";

        /// <summary>
        /// 打开或者传入图片
        /// </summary>
        public void Recognition()
        {
            try
            {
                JObject jo = StartCheck();
                if (jo["success"].ToString() == "True")
                {
                    this.lblWaiting.Text = "查到了";
                    this.lblWaiting.ForeColor = Color.Green;

                    if (config.Contains("face"))
                    {
                        #region  <<数据赋值>>
                        this.tbName.Text = jo["name"].ToString();
                        this.tbSex.Text = jo["sex"].ToString();
                        this.tbNation.Text = jo["nationality"].ToString();
                        this.tbBirth.Text = jo["birth"].ToString();
                        this.tbNum.Text = jo["num"].ToString();
                        this.tbAddress.Text = jo["address"].ToString();
                        #endregion
                    }
                    else
                    {
                        this.tbStart_date.Text = jo["start_date"].ToString();
                        this.tbEnd_date.Text = jo["end_date"].ToString();
                        this.tbIssue.Text = jo["issue"].ToString();
                    }

                }
                else
                {
                    this.lblWaiting.Text = "查询失败";
                    this.lblWaiting.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                this.lblWaiting.Text = "查询失败";
                this.lblWaiting.ForeColor = Color.Red;
            }

            contentBytes = null;        //清空
        }

        /// <summary>
        /// 将图片发送到API
        /// </summary>
        /// <returns>返回一个JObject对象方便解析</returns>
        public JObject StartCheck()
        {
            //API地址  http或https协议都可以
            String url = "https://dm-51.data.aliyun.com/rest/160601/ocr/ocr_idcard.json";
            //如果输入带有inputs, 设置为True，否则设为False
            bool is_old_format = false;
            //输入自己的AppCode
            String appcode = "";
            //传递方式为post
            String method = "POST";

            String querys = "";

            String base64 = System.Convert.ToBase64String(contentBytes);
            String bodys;

            if (is_old_format)
            {
                bodys = "{\"inputs\" :" +
                                    "[{\"image\" :" +
                                        "{\"dataType\" : 50," +
                                         "\"dataValue\" :\"" + base64 + "\"" +
                                         "}";
                if (config.Length > 0)
                {
                    bodys += ",\"configure\" :" +
                                    "{\"dataType\" : 50," +
                                     "\"dataValue\" : \"" + config + "\"}" +
                                     "}";
                }
                bodys += "]}";
            }
            else
            {
                bodys = "{\"image\":\"" + base64 + "\"";
                if (config.Length > 0)
                {
                    bodys += ",\"configure\" :\"" + config + "\"";
                }
                bodys += "}";
            }
            HttpWebRequest httpRequest = null;
            HttpWebResponse httpResponse = null;

            if (0 < querys.Length)
            {
                url = url + "?" + querys;
            }

            if (url.Contains("https://"))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                httpRequest = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
            }
            else
            {
                httpRequest = (HttpWebRequest)WebRequest.Create(url);
            }
            httpRequest.Method = method;
            httpRequest.Headers.Add("Authorization", "APPCODE " + appcode);
            //根据API的要求，定义相对应的Content-Type
            httpRequest.ContentType = "application/json; charset=UTF-8";
            if (0 < bodys.Length)
            {
                byte[] data = Encoding.UTF8.GetBytes(bodys);
                using (Stream stream = httpRequest.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            try
            {
                httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            }
            catch (WebException ex)
            {
                httpResponse = (HttpWebResponse)ex.Response;
            }

            if (httpResponse.StatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine("http error code: " + httpResponse.StatusCode);
                Console.WriteLine("error in header: " + httpResponse.GetResponseHeader("X-Ca-Error-Message"));
                Console.WriteLine("error in body: ");
            }
            Stream st = httpResponse.GetResponseStream();      //获取信息流返还
            StreamReader reader = new StreamReader(st, Encoding.GetEncoding("utf-8"));
            JObject jo = JObject.Parse(reader.ReadToEnd());     //JSON对象
            return jo;
        }

        public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }

        /// <summary>
        /// 对图片文件编码
        /// </summary>
        /// <param name="img_file">文件绝对路径</param>
        public void Coding(String img_file)
        {
            FileStream fs = new FileStream(img_file, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            contentBytes = br.ReadBytes(Convert.ToInt32(fs.Length));
            fs.Flush();
            fs.Close();
            br.Close();
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            //只允许文件拖放
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            CleanData();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "图片文件(*.png;*.jpg;*.bmp;*.jpeg)|*.png;*.jpg;*.bmp;*.jpeg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Coding(dialog.FileName);
            }
            else
            {
                return;
            }
            Recognition();
        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            CleanData();
            Image img = Clipboard.GetImage();
            if (img == null)
                return;
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);
            contentBytes = ms.GetBuffer();      //转字节数组

            Recognition();
        }

        private void cmbConfigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbConfigure.SelectedIndex == 0)
            {
                config = "{\\\"side\\\":\\\"face\\\"}";
            }
            else
            {
                config = "{\\\"side\\\":\\\"back\\\"}";
            }
        }

        private void splitContainer1_Panel1_DragDrop(object sender, DragEventArgs e)
        {
            CleanData();
            config = "{\\\"side\\\":\\\"face\\\"}";
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] rs = (string[])e.Data.GetData(DataFormats.FileDrop);
                Coding(rs[0]);
                Recognition();
            }
        }

        private void splitContainer1_Panel2_DragDrop(object sender, DragEventArgs e)
        {
            CleanData();
            config = "{\\\"side\\\":\\\"back\\\"}";
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] rs = (string[])e.Data.GetData(DataFormats.FileDrop);
                Coding(rs[0]);
                Recognition();
            }
        }

        public void CleanData()
        {
            #region  <<清空数据>>
            this.lblWaiting.Text = "等待数据...";
            this.lblWaiting.ForeColor = Color.Black;
            this.tbName.Text = "";
            this.tbSex.Text = "";
            this.tbNation.Text = "";
            this.tbBirth.Text = "";
            this.tbNum.Text = "";
            this.tbAddress.Text = "";
            this.tbStart_date.Text = "";
            this.tbEnd_date.Text = "";
            this.tbIssue.Text = "";
            #endregion
        }
    }
}
