namespace TarKov.Handlers
{
    public static class BrowserHandler
    {
        public static void Wheeling(System.Windows.Forms.MouseEventArgs e)
        {
            AppHandler.window.BrowserZoom(e);
        }
    }
}
