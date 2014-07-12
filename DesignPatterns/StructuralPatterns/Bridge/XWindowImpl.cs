namespace DesignPatterns.StructuralPatterns.Bridge
{
    class XWindowImpl : WindowImpl
    {
        public override void DrawLine(Point x, Point y)
        {
            throw new System.NotImplementedException();
        }

        public override void DeviceRect(double a, double b, double c, double d)
        {
            throw new System.NotImplementedException();
        }

        public override void DeviceText(string text, double a, double b)
        {
            throw new System.NotImplementedException();
        }

        public override void DeviceBitmap(string bitmap, double a, double b)
        {
            throw new System.NotImplementedException();
        }
    }
}