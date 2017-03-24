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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            DynamiClient.JG_PaymentClient.Instance.Add(new ClientTemplate.RealService.JG_PaymentEntity()
            {
                PA_ID = Guid.NewGuid().ToString(),
                PA_xybh="0000000000",
                PA_zfrq = new DateTime(2222,11,11)
                
            });
            flush(null, null);
        }
        int i = 0;
        private void flush(object sender, RoutedEventArgs e)
        {
            DR.ItemsSource = DynamiClient.JG_PaymentClient.Instance.SelectsForPage(i,10);
            i++;
            //目录设计思路：  一次去除10页 前台分页 然后等到查看到第 9页的时候再获取一下 获取到15页 界面还应该有一个 集合 用来保存列表 然后新茶到的 9~15页的数据可以 加到集合中去。
        }
    }
}
