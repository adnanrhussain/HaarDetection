using System;
using System.Drawing;
using System.Linq;
using Emgu.CV;
using Emgu.CV.GPU;
using Emgu.CV.Structure;

namespace HaarDetector
{
    public class Detector
    {
        public static Rectangle[] Detect(Image<Bgr, Byte> image, string cascadeFile,
            double scaleFactor = 1.3, int minNeighbors = 10,
            Emgu.CV.CvEnum.HAAR_DETECTION_TYPE detectionType = Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
            int minSize = 20, int maxSize = 0)
        {
            string cascadeFilePath = CascadeManager.GetCascade(cascadeFile);

            Size minimumSize;
            if (minSize == 0)
            {
                minimumSize = Size.Empty;
            }
            else
            {
                minimumSize = new Size(minSize, minSize);
            }

            Size maximumSize;
            if (maxSize == 0)
            {
                maximumSize = Size.Empty;
            }
            else
            {
                maximumSize = new Size(maxSize, maxSize);
            }

            if (GpuInvoke.HasCuda)
            {
                using (GpuCascadeClassifier cascade = new GpuCascadeClassifier(cascadeFilePath))
                using (GpuImage<Bgr, Byte> gpuImage = new GpuImage<Bgr, byte>(image))
                using (GpuImage<Gray, Byte> gpuGray = gpuImage.Convert<Gray, Byte>())
                {
                    return cascade.DetectMultiScale(gpuGray, scaleFactor, minNeighbors, minimumSize);
                }
            }
            else
            {
                using (HaarCascade cascade = new HaarCascade(cascadeFilePath))
                using (Image<Gray, Byte> gray = image.Convert<Gray, Byte>())
                {
                    gray._EqualizeHist();

                    MCvAvgComp[] detected = cascade.Detect(gray,
                        scaleFactor, minNeighbors,
                        detectionType,
                        minimumSize, maximumSize);

                    return (from x in detected
                            select x.rect).ToArray();
                }
            }
        }
    }
}
