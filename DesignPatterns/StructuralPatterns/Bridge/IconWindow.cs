namespace DesignPatterns.StructuralPatterns.Bridge
{
    class IconWindow : Window
    {
        private readonly string _bitmapName;

        public IconWindow(WindowImpl implementor, string bitmapName)
            : base(implementor)
        {
            _bitmapName = bitmapName;
        }

        public override void DrawContents()
        {
            Implementor.DeviceBitmap(_bitmapName, 0.0, 0.0);
        }

        public override void Open()
        {
            throw new System.NotImplementedException();
        }

        public override void Close()
        {
            throw new System.NotImplementedException();
        }

        public override void Iconify()
        {
            throw new System.NotImplementedException();
        }

        public override void Deiconify()
        {
            throw new System.NotImplementedException();
        }

        public override void SetOrigin(Point at)
        {
            throw new System.NotImplementedException();
        }

        public override void SetExtent(Point extent)
        {
            throw new System.NotImplementedException();
        }

        public override void Raise()
        {
            throw new System.NotImplementedException();
        }

        public override void Lower()
        {
            throw new System.NotImplementedException();
        }

        public override void DrawLine(Point x, Point y)
        {
            throw new System.NotImplementedException();
        }

        public override void DrawRect(Point x, Point y)
        {
            throw new System.NotImplementedException();
        }

        public override void DrawPolygon(Point[] points, int n)
        {
            throw new System.NotImplementedException();
        }

        public override void DrawText(string text, Point point)
        {
            throw new System.NotImplementedException();
        }
    }
}