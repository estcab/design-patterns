namespace DesignPatterns.StructuralPatterns.Bridge
{
    abstract class Window
    {
        protected WindowImpl Implementor;

        protected Window(WindowImpl implementor)
        {
            Implementor = implementor;
        }

        // requests handled by window
        public abstract void DrawContents();
        public abstract void Open();
        public abstract void Close();
        public abstract void Iconify();
        public abstract void Deiconify();

        // requests forwarded to implementation
        public abstract void SetOrigin(Point at);
        public abstract void SetExtent(Point extent);
        public abstract void Raise();
        public abstract void Lower();

        public abstract void DrawLine(Point x, Point y);
        public abstract void DrawRect(Point x, Point y);
        public abstract void DrawPolygon(Point[] points, int n);
        public abstract void DrawText(string text, Point point);

    }
}