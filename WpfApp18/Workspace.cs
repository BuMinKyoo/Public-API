using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ViewModel.WpfApp18;

namespace WpfApp18
{
    public class Workspace : INotifyPropertyChanged
    {
        static Workspace m_Instance = new Workspace();

        public static Workspace Instance
        {
            get { return m_Instance; }
        } 

        private UserControl_Home_ViewModel m_Usercontrol_home_viewmodel = new UserControl_Home_ViewModel();
        public UserControl_Home_ViewModel Usercontrol_home_viewmodel
        {
            get { return m_Usercontrol_home_viewmodel; }
            set
            {
                if (m_Usercontrol_home_viewmodel != value)
                {
                    m_Usercontrol_home_viewmodel = value;
                    Notify("Usercontrol_home_viewmodel");
                }
            }
        }

        private MainWindow_ViewModel m_Mainwindow_viewmodel = new MainWindow_ViewModel();
        public MainWindow_ViewModel Mainwindow_viewmodel
        {
            get { return m_Mainwindow_viewmodel; }
            set
            {
                if (m_Mainwindow_viewmodel != value)
                {
                    m_Mainwindow_viewmodel = value;
                    Notify("Mainwindow_viewmodel");
                }
            }
        }

        private UserControl_MyInfo_ViewModel m_Usercontrol_myinfo_viewmodel = new UserControl_MyInfo_ViewModel();
        public UserControl_MyInfo_ViewModel Usercontrol_myinfo_viewmodel
        {
            get { return m_Usercontrol_myinfo_viewmodel; }
            set
            {
                if (m_Usercontrol_myinfo_viewmodel != value)
                {
                    m_Usercontrol_myinfo_viewmodel = value;
                    Notify("Usercontrol_myinfo_viewmodel");
                }
            }
        }

        private UserControl_Recruit_ViewModel m_Usercontrol_recruit_viewmodel = new UserControl_Recruit_ViewModel();
        public UserControl_Recruit_ViewModel Usercontrol_recruit_viewmodel
        {
            get { return m_Usercontrol_recruit_viewmodel; }
            set
            {
                if (m_Usercontrol_recruit_viewmodel != value)
                {
                    m_Usercontrol_recruit_viewmodel = value;
                    Notify("Usercontrol_recruit_viewmodel");
                }
            }
        }
        
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void Notify([CallerMemberName] string propertyName = null)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
