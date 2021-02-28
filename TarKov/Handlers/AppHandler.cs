using System.Windows;
using TarKov;

public static class AppHandler
{
    public static MainWindow window;
    public static void Init(MainWindow target)
    {
        window = target;
    }



    public static void KeyUpEventHandler(object sender, System.Windows.Forms.KeyEventArgs e)
    {

        if (e.KeyCode == System.Windows.Forms.Keys.Insert)
        {
            if (window.Topmost == true)
            {
                window.Topmost = false;
                window.Visibility = Visibility.Hidden;
            }
            else
            {
                window.Topmost = true;
                window.Visibility = Visibility.Visible;
            }
        }
        if (e.KeyCode == System.Windows.Forms.Keys.Escape)
        {
            if (window.Topmost == true)
            {
                window.Topmost = false;
                window.Visibility = Visibility.Hidden;
            }
        }
    }
}