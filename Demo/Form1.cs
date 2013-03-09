using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;
using System.IO;
using System.Reflection;
using Emgu.CV.CvEnum;
using HaarDetector;

namespace Demo
{
    public partial class Form1 : Form
    {
        Image<Bgr, Byte> image;

        public Form1()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            PopulateCascades();
            PopulateScaleFactors();
            PopulateMinNeighbors();
            PopulateDetectionTypes();
            PopulateSizes(cbxMinimumSize);
            cbxMinimumSize.SelectedIndex = 1;
            PopulateSizes(cbxMaximumSize);
            cbxMaximumSize.SelectedIndex = 0;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK || result == System.Windows.Forms.DialogResult.Yes)
            {
                txtFileName.Text = openFileDialog1.FileName;
            }
            else
            {
                return;
            }

            try
            {
                image = new Image<Bgr, byte>(txtFileName.Text);
                imgResult.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void PopulateCascades()
        {
            Type haarCascadeManagerType = typeof(CascadeManager);
            foreach (PropertyInfo pi in haarCascadeManagerType.GetProperties())
            {
                cbxHaarCascade.Items.Add(pi.Name);
            }

            cbxHaarCascade.SelectedIndex = 5;
        }

        private void PopulateScaleFactors()
        {
            cbxScaleFactor.Items.Add("1.1");
            cbxScaleFactor.Items.Add("1.2");
            cbxScaleFactor.Items.Add("1.3");
            cbxScaleFactor.Items.Add("1.4");
            cbxScaleFactor.Items.Add("1.5");

            cbxScaleFactor.SelectedIndex = 2;
        }

        private void PopulateMinNeighbors()
        {
            cbxMinNeighbors.Items.Add("0");
            cbxMinNeighbors.Items.Add("5");
            cbxMinNeighbors.Items.Add("10");
            cbxMinNeighbors.Items.Add("15");
            cbxMinNeighbors.Items.Add("20");
            cbxMinNeighbors.Items.Add("25");
            cbxMinNeighbors.Items.Add("30");

            cbxMinNeighbors.SelectedIndex = 2;
        }

        private void PopulateDetectionTypes()
        {
            Type detectionType = typeof(HAAR_DETECTION_TYPE);
            foreach (string property in detectionType.GetEnumNames())
            {
                cbxDetectionType.Items.Add(property);
            }

            cbxDetectionType.SelectedIndex = 1;
        }

        private void PopulateSizes(ComboBox cbx)
        {
            cbx.Items.Add("0");
            cbx.Items.Add("10");
            cbx.Items.Add("20");
            cbx.Items.Add("30");
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            btnDetect.Enabled = false;

            List<string> errors = new List<string>();

            if (image == null)
            {
                errors.Add("Please select Image");
            }

            string cascade = cbxHaarCascade.SelectedItem.ToString();
            double scaleFactor = Convert.ToDouble(cbxScaleFactor.SelectedItem);
            int minNeighbors = Convert.ToInt32(cbxMinNeighbors.SelectedItem);
            HAAR_DETECTION_TYPE detectionType = (HAAR_DETECTION_TYPE)Enum.Parse(typeof(HAAR_DETECTION_TYPE), cbxDetectionType.SelectedItem.ToString());
            int min = Convert.ToInt32(cbxMinimumSize.SelectedItem);
            int max = Convert.ToInt32(cbxMaximumSize.SelectedItem);

            if (max != 0 && max < min)
            {
                errors.Add("Maximum Size cannot be less than Minium Size");
            }

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors.ToArray()), "ERROR!", MessageBoxButtons.OK);
                btnDetect.Enabled = true;
                return;
            }

            try
            {
                Rectangle[] detected = Detector.Detect(image, cascade,
                    scaleFactor, minNeighbors,
                    detectionType,
                    min, max);

                using (Image<Bgr, Byte> imageCopy = image.Copy())
                {
                    foreach (Rectangle region in detected)
                    {
                        imageCopy.Draw(region, new Bgr(Color.Blue), 2);
                    }

                    imgResult.Image = imageCopy;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                btnDetect.Enabled = true;
            }
        }
    }
}
