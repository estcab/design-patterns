namespace DesignPatterns.StructuralPatterns.Bridge
{
    abstract class WindowImpl
    {
        public int Top { get; set; }
        public int Bottom { get; set; }

        public Point Extent { get; set; }
        public Point Origin { get; set; }

        public abstract void DrawLine(Point x, Point y);
        public abstract void DeviceRect(double a, double b, double c, double d);
        public abstract void DeviceText(string text, double a, double b);
        public abstract void DeviceBitmap(string bitmap, double a, double b);

    }
}