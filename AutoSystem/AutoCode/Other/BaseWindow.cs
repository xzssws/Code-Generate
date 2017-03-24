using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AvalonDock;

namespace HSIS
{
    /// <summary>
    /// BaseWindow.xaml 的交互逻辑
    /// </summary>
    public partial class BaseWindow : DockableContent
    {
        public BaseWindow()
        {
            ShowSubWindowAction = new Action<DockableContent, ShowModel>(ShowSubWindow);
        }
        public DockingManager DKM { get; set; }

        private void ShowSubWindow(DockableContent dc,ShowModel showmodel)
        {
            switch (showmodel)
            {
                case ShowModel.show: dc.Show(DKM); break;
                case ShowModel.ShowAsDocument: dc.ShowAsDocument(DKM); break;
                case ShowModel.ShowAsFloatingWindow: dc.ShowAsFloatingWindow(DKM, true); break;
            }
            
        }

        public Action<DockableContent, ShowModel>  ShowSubWindowAction;
        
    }
    public enum ShowModel
    {
        show = 1,
        ShowAsDocument = 2,
        ShowAsFloatingWindow
    }
}
