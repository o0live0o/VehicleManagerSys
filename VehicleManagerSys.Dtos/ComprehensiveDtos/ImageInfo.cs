using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleManagerSys.Dtos.ComprehensiveDtos
{
    public class ImageInfo
    {
        public string ImageKey { get; set; }

        public byte[] ImageByte { get; set; }

        public string ImageName { get; set; }

        public string ImageToBase64 { get { return Convert.ToBase64String(ImageByte); } }
    }
}
