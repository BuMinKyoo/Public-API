using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp18;

namespace ViewModel.WpfApp18
{
    public class UserControl_Home_ViewModel
    {
        #region MoveMyInfo
        private Command m_MoveMyInfo;
        public ICommand MoveMyInfo
        {
            get { return m_MoveMyInfo = new Command(OneClickEvent_m_MoveMyInfo_BUtton); }
        }

        private void OneClickEvent_m_MoveMyInfo_BUtton(object obj)
        {
            Workspace.Instance.Mainwindow_viewmodel.TabControl_SelectedIndex = 2;
        }
        #endregion

        #region OneClickEvent_MoveRecruit_BUtton
        private Command m_MoveRecruit;
        public ICommand MoveRecruit
        {
            get { return m_MoveRecruit = new Command(OneClickEvent_MoveRecruit_BUtton); }
        }

        private void OneClickEvent_MoveRecruit_BUtton(object obj)
        {
            Workspace.Instance.Mainwindow_viewmodel.TabControl_SelectedIndex = 1;

        }
        #endregion
    }
}
