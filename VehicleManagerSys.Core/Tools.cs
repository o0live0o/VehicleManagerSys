using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagerSys.Core
{
    public abstract class Tools
    {
        public static void MergeEntity<Target, Src>(Target t, Src s)
        {
            PropertyInfo[] properInfos = s.GetType().GetProperties();
            foreach (var item in properInfos)
            {
                object obj = item.GetValue(s, null);
                if (obj != null && !string.IsNullOrEmpty(obj.ToString()))
                {
                    PropertyInfo targetInfo = t.GetType().GetProperty(item.Name);
                    targetInfo.SetValue(t, obj, null);
                }
            }
        }

        public static  byte[] ChageImage(byte[] byteImage, int x, int y)
        {

            if (byteImage != null)
            {
                try
                {
                    Stream stream = new MemoryStream(byteImage);
                    stream.Seek(0, SeekOrigin.Begin);
                    Bitmap bmpDest = new Bitmap(x, y);
                    Bitmap bmpSrc = new Bitmap(stream);
                    Graphics g = Graphics.FromImage(bmpDest);
                    g.DrawImage(bmpSrc, new Rectangle(0, 0, x, y), new Rectangle(0, 0, bmpSrc.Width, bmpSrc.Height), GraphicsUnit.Pixel);
                    bmpSrc.Dispose();

                    MemoryStream ms = new MemoryStream();
                    bmpDest.Save(ms, ImageFormat.Jpeg);
                    byte[] bytes = ms.GetBuffer();
                    ms.Close();
                    return bytes;
                }
                catch 
                {
                    throw;
                }

            }
            return null;

        }

        public static byte[] GetImageByPath(string strPath, int x, int y, bool bChange = false)
        {
            if (File.Exists(strPath))
            {
                FileStream fs = new FileStream(strPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] imgBytesIn = br.ReadBytes((int)fs.Length);
                br.Close();
                br.Dispose();
                fs.Close();
                fs.Dispose();
                if (bChange)
                {
                    return Tools.ChageImage(imgBytesIn, x, y);
                }
                else
                {
                    return imgBytesIn;
                }
            }
            return null;
        }
    }
}
