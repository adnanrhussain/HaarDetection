#HaarDetection

This is a demo application highlighting the Haar Cascade detection implementation in Emgu CV using OpenCV. The application provides an interface to change various parameters of the Haar feature detector.

![HaarDetection Demo](http://oi48.tinypic.com/11lhpmx.jpg)

## About Haar-like features
[Haar-like features](http://en.wikipedia.org/wiki/Haar-like_features) are digital image features used in object recognition. They owe their name to their intuitive similarity with Haar wavelets and were used in the first real-time face detector.

## About __Emgu CV__
[Emgu CV](http://www.emgu.com/wiki/index.php/Main_Page) is a cross platform .Net wrapper to the OpenCV image processing library. Allowing OpenCV functions to be called from .NET compatible languages such as C#, VB, VC++, IronPython etc. The wrapper can be compiled in Mono and run on Windows, Linux, Mac OS X, iPhone, iPad and Android devices.

## About __OpenCV__
[OpenCV](http://opencv.org/) (Open Source Computer Vision Library) is a library of programming functions mainly aimed at real-time computer vision, developed by Intel, and now supported by Willow Garage and Itseez. It is free for use under the open source BSD license. The library is cross-platform. It focuses mainly on real-time image processing.

### Haar Detection Parameters

- **Scale Factor**: Parameter specifying how much the image size is reduced at each image scale
- **Minimum Neighbors**: Parameter specifying how many neighbors each candidate rectangle should have to retain it
- **Detection Type**: If the Canny Pruning option is selected, the detector skips image regions that are unlikely to contain an object, reducing computational overhead and possibly eliminating some false detections
- **Minimum Size**: Minimum possible object size. Objects smaller than that are ignored
- **Maximum Size**: Maximum possible object size. Objects larger than that are ignored
