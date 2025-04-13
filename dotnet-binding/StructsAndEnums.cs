using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace MBProgressHUD {
    
    [Native]
    public enum MBProgressHUDMode : long
    {
        Indeterminate,
        Determinate,
        DeterminateHorizontalBar,
        AnnularDeterminate,
        CustomView,
        Text
    }

    [Native]
    public enum MBProgressHUDAnimation : long
    {
        Fade,
        Zoom,
        ZoomOut,
        ZoomIn
    }

    [Native]
    public enum MBProgressHUDBackgroundStyle : long
    {
        SolidColor,
        Blur
    }
    
}
