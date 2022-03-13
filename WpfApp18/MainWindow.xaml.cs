using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml;

namespace WpfApp18
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = Workspace.Instance.Mainwindow_viewmodel;

            //콤보박스에 바인딩한 ObservableCollection에 add로 요소 추가하기
            Workspace.Instance.Usercontrol_recruit_viewmodel.ComboBox_ItemSource_list_add_Recruit();
            Workspace.Instance.Usercontrol_myinfo_viewmodel.ComboBox_ItemSource_list_add_MyInfo();

        }
    }
}
