using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CameraManager
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        public Image img { get; set; }
        public CameraManager()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            CameraList();
        }
        public List<String> CameraList()
        {
            List<String> cameraList = new List<string>();
            for (int i = 0; i < filterInfoCollection.Count; i++)
            {
                cameraList.Add(filterInfoCollection[i].Name);
            }
            return cameraList;
        }
    }
}
