﻿using CefSharp;
using CefSharp.Wpf;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
namespace TarKov
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary> 
    /// 


    public partial class MainWindow : System.Windows.Window
    {
        public ChromiumWebBrowser ChromiumBrowser;
        public bool isDevMode = false;
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        public MainWindow()
        {
            InitializeComponent();
            AllocConsole();
            Setup();
            ChromeInit("https://github.com/AmazingDM/TarkovApp");
            InputHelper.Init();
            AppHandler.Init(this);
        }
        void Setup()
        {
            this.Topmost = true;    
            var _width = SystemParameters.PrimaryScreenWidth;
            var _height = SystemParameters.PrimaryScreenHeight;
            this.Width = _width;
            this.Height = _height;
            this.AppGrid.Width = _width;
            this.AppGrid.Height = _height;
        }
        public void ChromeInit(string url)
        {

            CefSettings chromium = new CefSettings();
            Cef.Initialize(chromium);
            ChromiumBrowser = new ChromiumWebBrowser();
            ChromiumBrowser.Address = url;
            ChromiumBrowser.Width = 500;
            ChromiumBrowser.HorizontalAlignment = HorizontalAlignment.Left;
            Grid.SetColumn(ChromiumBrowser, 1);
            AppGrid.Children.Add(ChromiumBrowser);
            ChromiumBrowser.Visibility = Visibility.Visible;
            BrowserHelper.MainWindow = this;
            BrowserHelper.Browser = ChromiumBrowser;
        }
        public void ChangeURL(string url, bool whiteBg, int browerSize)
        {
            MapHandler.HideAndBrowserShow();
            ChromiumBrowser.HorizontalAlignment = HorizontalAlignment.Left;
            ChromiumBrowser.Visibility = Visibility.Visible;
            whiteBackground.Width = browerSize;
            ChromiumBrowser.Width = browerSize;
            ChromiumBrowser.Load(url);
            whiteBackground.Visibility = (whiteBg == true) ? Visibility.Visible : Visibility.Hidden;
        }
        public void BrowserZoom(System.Windows.Forms.MouseEventArgs e)
        {
            if (InputHelper.EnableControlKey)
            {
                var p = 1;
                if (e.Delta > 0) p = 1;
                else p = -1;
                ChromiumBrowser.ZoomLevel += p;
            }
        }

        private void Button_Armor(object sender, RoutedEventArgs e)
        {
            BrowserHelper.VisitContent(EContent.ARMOR);
        }
        private void Button_Ammo(object sender, RoutedEventArgs e)
        {
            BrowserHelper.VisitContent(EContent.AMMO);
        }
        private void Button_Market(object sender, RoutedEventArgs e)
        {
            BrowserHelper.VisitContent(EContent.MARKET);
        }
        private void Button_Weapons(object sender, RoutedEventArgs e)
        {
            BrowserHelper.VisitContent(EContent.WEAPON);
        }

        public void Button_Quest(object sender, RoutedEventArgs e)
        {
            BrowserHelper.VisitContent(EContent.QUEST);
        }
        public void DisableBrowser()
        {
            ChromiumBrowser.Visibility = Visibility.Hidden;
        }
        public void EnableBrowser()
        {
            ChromiumBrowser.Visibility = Visibility.Visible;
        }
        public string GetLocale()
        {
            return "zh";
        }
        /// <summary>
        /// 工厂
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Map_Factory(object sender, RoutedEventArgs e)
        {
            MapHandler.ShowMap($"Factory_{GetLocale()}");
        }
        /// <summary>
        /// 海关
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Map_Custom(object sender, RoutedEventArgs e)
        {
            MapHandler.ShowMap($"Customs_{GetLocale()}");
        }
        /// <summary>
        /// 海关#彩蛋
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Map_Custom_Egg(object sender, RoutedEventArgs e)
        {
            MapHandler.ShowMap($"Customs_egg_{GetLocale()}");
        }
        /// <summary>
        /// 森林
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Map_Wood(object sender, RoutedEventArgs e)
        {
            MapHandler.ShowMap($"Woods_{GetLocale()}");
        }
        /// <summary>
        /// 森林#彩蛋
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Map_Wood_Egg(object sender, RoutedEventArgs e)
        {
            MapHandler.ShowMap($"Woods_egg_{GetLocale()}");
        }
        /// <summary>
        /// 海岸线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Map_Shoreline(object sender, RoutedEventArgs e)
        {
            MapHandler.ShowMap($"Shoreline_{GetLocale()}");
        }
        /// <summary>
        /// 海岸线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Map_Shoreline2(object sender, RoutedEventArgs e)
        {
            MapHandler.ShowMap($"Shoreline2_{GetLocale()}");
        }
        /// <summary>
        /// 立交桥
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Map_InterChange(object sender, RoutedEventArgs e)
        {
            MapHandler.ShowMap($"InterChange_{GetLocale()}");
        }
        /// <summary>
        /// 立交桥#彩蛋
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Map_InterChange_Egg(object sender, RoutedEventArgs e)
        {
            MapHandler.ShowMap($"InterChange_egg_{GetLocale()}");
        }
        /// <summary>
        /// 实验室
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Map_TheLab(object sender, RoutedEventArgs e)
        {
            MapHandler.ShowMap($"TheLab_{GetLocale()}");
        }
        /// <summary>
        /// 储备站
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Map_Reserve(object sender, RoutedEventArgs e)
        {
            MapHandler.ShowMap($"Reserve_{GetLocale()}");
        }
        /// <summary>
        /// 储备站#地下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Map_Reserve2(object sender, RoutedEventArgs e)
        {
            MapHandler.ShowMap($"Reserve2_{GetLocale()}");
        }
        public void Button_Help(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Insert 键: 关闭/开启 \n ESC : 关闭 \n 相同按钮双击 : 返回原始网址", "amazingdmdd@gmail.com", MessageBoxButton.OK);
        }

        private void HideMap(object sender, RoutedEventArgs e)
        {
            MapHandler.HideAndBrowserShow();
        }
    }


}
