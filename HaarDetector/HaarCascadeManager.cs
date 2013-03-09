using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HaarDetector
{
    public static class CascadeManager
    {
        public static string EYE { get; set; }
        public static string EYE_TREE_EYEGLASSES { get; set; }
        public static string FRONTALFACE_ALT { get; set; }
        public static string FRONTALFACE_ALT2 { get; set; }
        public static string FRONTALFACE_ALT_TREE { get; set; }
        public static string FRONTALFACE_DEFAULT { get; set; }
        public static string FULLBODY { get; set; }
        public static string LEFTEYE_2SPLITS { get; set; }
        public static string LOWERBODY { get; set; }
        public static string MCS_EYEPAIR_BIG { get; set; }
        public static string MCS_EYEPAIR_SMALL { get; set; }
        public static string MCS_LEFTEAR { get; set; }
        public static string MCS_LEFTEYE { get; set; }
        public static string MCS_MOUTH { get; set; }
        public static string MCS_NOSE { get; set; }
        public static string MCS_RIGHTEAR { get; set; }
        public static string MCS_RIGHTEYE { get; set; }
        public static string MCS_UPPERBODY { get; set; }
        public static string PROFILEFACE { get; set; }
        public static string RIGHTEYE_2SPLITS { get; set; }
        public static string UPPERBODY { get; set; }

        static CascadeManager()
        {
            EYE = "haarcascade_eye.xml";
            EYE_TREE_EYEGLASSES = "haarcascade_eye_tree_eyeglasses.xml";
            FRONTALFACE_ALT = "haarcascade_frontalface_alt.xml";
            FRONTALFACE_ALT2 = "haarcascade_frontalface_alt2.xml";
            FRONTALFACE_ALT_TREE = "haarcascade_frontalface_alt_tree.xml";
            FRONTALFACE_DEFAULT = "haarcascade_frontalface_default.xml";
            FULLBODY = "haarcascade_fullbody.xml";
            LEFTEYE_2SPLITS = "haarcascade_lefteye_2splits.xml";
            LOWERBODY = "haarcascade_lowerbody.xml";
            MCS_EYEPAIR_BIG = "haarcascade_mcs_eyepair_big.xml";
            MCS_EYEPAIR_SMALL = "haarcascade_mcs_eyepair_small.xml";
            MCS_LEFTEAR = "haarcascade_mcs_leftear.xml";
            MCS_LEFTEYE = "haarcascade_mcs_lefteye.xml";
            MCS_MOUTH = "haarcascade_mcs_mouth.xml";
            MCS_NOSE = "haarcascade_mcs_nose.xml";
            MCS_RIGHTEAR = "haarcascade_mcs_rightear.xml";
            MCS_RIGHTEYE = "haarcascade_mcs_righteye.xml";
            MCS_UPPERBODY = "haarcascade_mcs_upperbody.xml";
            PROFILEFACE = "haarcascade_profileface.xml";
            RIGHTEYE_2SPLITS = "haarcascade_righteye_2splits.xml";
            UPPERBODY = "haarcascade_upperbody.xml";
        }

        public static string GetCascade(string cascade)
        {
            Type type = typeof(CascadeManager);
            string cascadeFileName = type.GetProperty(cascade).GetValue(null, null).ToString();

            return Path.Combine(Directory.GetCurrentDirectory(), "Haar", cascadeFileName);
        }
    }
}
