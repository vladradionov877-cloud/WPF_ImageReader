using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;

namespace WPF_ImageReader;

public class ImageItem
{
    public BitmapImage Image { get; set; } = null!;
    public string FileName { get; set; } = null!;
    public long FileSize { get; set; } // у КБ
    public DateTime DateCreated { get; set; }
}
