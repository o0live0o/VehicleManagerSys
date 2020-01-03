using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eloamComLib;
using System.Globalization;
using System.Timers;
using System.IO;
using VehicleManagerSys.Dtos.ComprehensiveDtos;

namespace VehicleManagerSys.Main.Controls
{
    public partial class CaptureEloam : UserControl
    {
        private EloamGlobal global;
        private EloamVideo m_pVideo;
        private int m_timerValue;
        private EloamVideoCap m_pVideoCap;

        private EloamImage m_globalTempImage;

        public EloamMemory m_pTemplate;
        public EloamMemory m_pFeature;

        bool hasClickOcrList = false;
        //定义系统计时器
        private System.Timers.Timer timer;

        public string CapturePath { get; set; }

        public string VehicleNo { get; set; }

        //设备列表
        private List<EloamDevice> m_deviceList;

        public CaptureEloam()
        {

            InitializeComponent();
            global = new EloamGlobal();
            m_deviceList = new List<EloamDevice>();

            m_pFeature = null;
            m_pTemplate = null;
            m_pVideoCap = null;
        
            FormInit();

            Init();
        }

        public void InitImgType(ImgTypeEntity[] list)
        {
            if (list != null)
            {
                combImgList.DataSource = list;
                combImgList.DisplayMember = "ImgName";
            }
;        }

        public void InitCapturePath(string strPath)
        {
            CapturePath = strPath;
            LoadImg();
        }

        private void LoadImg()
        {
            try
            {
                eloamThumbnail.Clear(false);
                if (Directory.Exists(CapturePath))
                {
                    string[] files = Directory.GetFiles(CapturePath, "*.jpg");
                    for (int i = 0; i < files.Length; i++)
                    {
                        eloamThumbnail.Add(files[i]);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void FormInit()
        {
            //传入设备状态改变事件
            global.DevChange += DevChangeEventHandler;
            //传入移动监测事件
            global.MoveDetec += MoveDetecEventHandler;
            //视频播放事件
            global.Arrival += ArrivalEventHandler;
            //二代证
            global.IdCard += IdCardEventHandler;
            //初始化设备
            global.InitDevs();

        }


        public void DisposeContorl()
        {
            closeVideo_Click(new object(), new EventArgs());

            int count = m_deviceList.Count;
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    m_deviceList[i].Destroy();
                }
            }
            m_deviceList.Clear();

            global.DeinitBarcode();

            if (null != m_pTemplate)
            {
                m_pTemplate.Destroy();
                m_pTemplate = null;
            }
            if (null != m_pFeature)
            {
                m_pFeature.Destroy();
                m_pFeature = null;
            }

            if (m_pVideoCap != null)
            {
                m_pVideoCap.VideoCapStop();
                m_pVideoCap.Destroy();
                m_pVideoCap = null;
            }

            global.DeinitBiokey();
            global.DeinitIdCard();
            global.DeinitDevs();
            global.DeinitOcr();

            //传出设备状态改变事件
            global.DevChange -= DevChangeEventHandler;
            //传出移动监测事件
            global.MoveDetec -= MoveDetecEventHandler;
            //传出视频播放事件
            global.Arrival -= ArrivalEventHandler;
            //传出二代证
            global.IdCard -= IdCardEventHandler;
        }

        //设备状态改变事件响应
        public void DevChangeEventHandler(int type, int idx, int dbt)
        {
            if (1 == type)
            {
                if (1 == dbt)//设备到达
                {
                    EloamDevice tempDevice = (EloamDevice)global.CreateDevice(1, idx);
                    m_deviceList.Add(tempDevice);

                    selectDevice.Items.Add(tempDevice.GetFriendlyName());
                    if (-1 == selectDevice.SelectedIndex)
                    {
                        selectDevice.SelectedIndex = 0;//改变所选设备
                    }

                }
                else if (2 == dbt)//设备丢失
                {
                    EloamDevice tempDevice = m_deviceList[idx];
                    if (null != m_pVideo)
                    {
                        EloamDevice tempDevice2 = (EloamDevice)m_pVideo.GetDevice();
                        if (tempDevice == tempDevice2)
                        {
                            closeVideo_Click(new object(), new EventArgs());
                        }
                    }

                    m_deviceList[idx].Destroy();
                    m_deviceList.RemoveAt(idx);
                    selectDevice.Items.RemoveAt(idx);
                    if (-1 == selectDevice.SelectedIndex)
                    {
                        if (0 != m_deviceList.Count)
                        {
                            selectDevice.SelectedIndex = 0;
                        }
                        else
                        {
                            selectDevice.Items.Clear();
                            selectMode.Items.Clear();
                            selectResolution.Items.Clear();
                        }
                    }
                }
            }
        }

        //二代证事件响应
        public void IdCardEventHandler(int ret)
        {
            // Fire_MoveDetec
            StringBuilder MyStringBuilder = new StringBuilder();

            for (int i = 0; i < 16; i++)
            {
                string read;
                read = global.GetIdCardData(i + 1);
                MyStringBuilder.Append(read);
                MyStringBuilder.Append("\r\n");
            }
            string show = MyStringBuilder.ToString();
            EloamImage img = (EloamImage)global.GetIdCardImage(1);
            img.Save("idcard.jpg", 0);
            img.Destroy();
            MessageBox.Show(show);
        }

        //移动监测事件响应
        public void MoveDetecEventHandler(object pVideo, int id)
        {
            // Fire_MoveDetec
            shoot_Click(new object(), new EventArgs());
        }

        //视频播放事件
        private void ArrivalEventHandler(object pVideo, int id)
        {
            if (0 == id)//视频第一帧
            {
                openVideo.Enabled = false;
                closeVideo.Enabled = true;
                turnLeft.Enabled = true;
                turnRight.Enabled = true;
                //exchangeLeftRight.Enabled = true;
                //exchangeUpDown.Enabled = true;
                openProperty.Enabled = true;
              
                shoot.Enabled = true;
            }
        }

        private void openVideo_Click(object sender, EventArgs e)
        {
            try
            {
                int devIdx = selectDevice.SelectedIndex;
                string curModeString = selectMode.SelectedItem.ToString();
                int modeIdx = (curModeString == "YUY2" ? 1 :
                                (curModeString == "MJPG" ? 2 :
                                    (curModeString == "UYVY" ? 4 :
                                        -1)));
                int resIdx = selectResolution.SelectedIndex;

                if (-1 != devIdx)
                {
                    if (null != m_pVideo)
                    {
                        m_pVideo.Destroy();
                        m_pVideo = null;
                    }

                    EloamDevice tempDevice = m_deviceList[devIdx];
                    m_pVideo = (EloamVideo)tempDevice.CreateVideo(resIdx, modeIdx);

                    if (null != m_pVideo)
                    {
                        eloamView.SelectVideo(m_pVideo);
                        eloamView.SetText("打开视频中，请等待...", RGB(255, 255, 255));

                        selectDevice.Enabled = false;
                        selectResolution.Enabled = false;
                        selectMode.Enabled = false;

                        openVideo.Enabled = false;
                        closeVideo.Enabled = true;
                        btnTime.Enabled = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public uint RGB(uint r, uint g, uint b)
        {
            return (((b << 16) | (g << 8)) | r);
        }

        private void closeVideo_Click(object sender, EventArgs e)
        {
            if (null != m_pVideo)
            {
                eloamView.SetText(null, 0);
                m_pVideo.Destroy();
                m_pVideo = null;
            }

            eloamView.SetText(null, 0);

            Reset();
        }
        public void Reset()
        {
            Init();
        }
        public void Init()
        {
            selectDevice.Enabled = true;
            selectResolution.Enabled = true;
            selectMode.Enabled = true;

            openVideo.Enabled = true;
            closeVideo.Enabled = false;
            turnLeft.Enabled = false;
            turnRight.Enabled = false;
            exchangeLeftRight.Enabled = false;
            exchangeUpDown.Enabled = false;
            openProperty.Enabled = false;
            shoot.Enabled = false;
            btnTime.Enabled = false;
            m_timerValue = 5;
        }


        private void openProperty_Click(object sender, EventArgs e)
        {
            if (null != m_pVideo)
            {
                EloamDevice tempDevice = (EloamDevice)m_pVideo.GetDevice();
                tempDevice.ShowProperty(eloamView.GetView());
            }
        }








        private void shoot_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(combImgList.Text))
            {
                MessageBox.Show("请选择拍照类型！");
                return;
            }

            if (null == m_pVideo)
            {
                return;
            }

            EloamView tempView = (EloamView)eloamView.GetView();
            EloamImage tempImage = (EloamImage)m_pVideo.CreateImage(0, tempView);

            if (null != tempImage)
            {
                if(!Directory.Exists(CapturePath))
                {
                    Directory.CreateDirectory(CapturePath);
                }

                string filename = Path.Combine(CapturePath, combImgList.Text + ".jpg");

                if (tempImage.Save(filename, 0))
                {
                    eloamView.PlayCaptureEffect();
                    LoadImg();
                  //  eloamThumbnail.Add(filename);
                  
                }
                else
                {
                    MessageBox.Show("保存失败，请检查保存路径设置是否正确!");
                }

            }
        }


        private void turnLeft_Click(object sender, EventArgs e)
        {
            m_pVideo.RotateLeft();
        }

        private void turnRight_Click(object sender, EventArgs e)
        {
            m_pVideo.RotateRight();
        }

        private void exchangeLeftRight_Click(object sender, EventArgs e)
        {
            m_pVideo.Mirror();
        }

        private void exchangeUpDown_Click(object sender, EventArgs e)
        {
            m_pVideo.Flip();
        }


        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            shoot_Click(sender, e);
        }

        private void selectDevice_SelectedIndexChanged(object sender, EventArgs e)
        {

            int idx = selectDevice.SelectedIndex;//记录当前所选设备

            selectMode.Items.Clear();

            if (-1 != idx)
            {
                EloamDevice tempDevice = m_deviceList[idx];

                //加载模式列表
                int subtype = tempDevice.GetSubtype();
                if (0 != (subtype & 1))
                {
                    selectMode.Items.Add("YUY2");
                }
                if (0 != (subtype & 2))
                {
                    selectMode.Items.Add("MJPG");
                }
                if (0 != (subtype & 4))
                {
                    selectMode.Items.Add("UYVY");
                }

                //若为辅摄像头，优先选择MJPG方式
                if (1 != tempDevice.GetEloamType() && (0 != (subtype & 2)) && (0 != (subtype & 1)))
                {
                    selectMode.SelectedIndex = 1;
                }
                else
                {
                    selectMode.SelectedIndex = 0;
                }

                openVideo.Enabled = true;
            }
            else
            {
                openVideo.Enabled = false;
            }
        }


        private void selectMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = selectDevice.SelectedIndex;//记录当前所选设备

            selectResolution.Items.Clear();

            if (-1 != idx)
            {
                EloamDevice tempDevice = m_deviceList[idx];
                //加载分辨率列表
                int subtype = -1;
                string curModeString = selectMode.SelectedItem.ToString();
                subtype = (curModeString == "YUY2" ? 1 :
                            (curModeString == "MJPG" ? 2 :
                                (curModeString == "UYVY" ? 4 :
                                    -1)));
                if (-1 != subtype)
                {
                    int count = tempDevice.GetResolutionCountEx(subtype);
                    for (int i = 0; i < count; ++i)
                    {
                        int width = tempDevice.GetResolutionWidthEx(subtype, i);
                        int height = tempDevice.GetResolutionHeightEx(subtype, i);

                        string str = width.ToString() + "*" + height.ToString();
                        selectResolution.Items.Add(str);
                    }
                    selectResolution.SelectedIndex = 0;
                }
            }
        }

        private void CaptureEloam_Load(object sender, EventArgs e)
        {

        }

        private void btnTime_Click(object sender, EventArgs e)
        {
                   var font1 = global.CreateTypeface(200, 200, 0, 0, 2, 0, 0, 0, "宋体");
                   bool succ = m_pVideo.EnableDate(font1, 10, 10, 0xffffff, 150);
        }
    }
}
