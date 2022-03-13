using ComboBox_Enum.WpfApp18;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp18;

namespace ViewModel.WpfApp18
{
    public class UserControl_MyInfo_ViewModel : INotifyPropertyChanged
    {
        //콤보박스에 바인딩한 ObservableCollection에 add로 요소 추가하기
        #region ComboBox_ItemSource_list_add
        public void ComboBox_ItemSource_list_add_MyInfo()
        {
                E_ACDMCR_CMMN_CODE_SE_list.Add(E_ACDMCR_CMMN_CODE_SE.전체);
                E_ACDMCR_CMMN_CODE_SE_list.Add(E_ACDMCR_CMMN_CODE_SE.전문대학);
                E_ACDMCR_CMMN_CODE_SE_list.Add(E_ACDMCR_CMMN_CODE_SE.중학교);
                E_ACDMCR_CMMN_CODE_SE_list.Add(E_ACDMCR_CMMN_CODE_SE.고등학교);
                E_ACDMCR_CMMN_CODE_SE_list.Add(E_ACDMCR_CMMN_CODE_SE.초등학교);
                E_ACDMCR_CMMN_CODE_SE_list.Add(E_ACDMCR_CMMN_CODE_SE.대학교);
                E_ACDMCR_CMMN_CODE_SE_list.Add(E_ACDMCR_CMMN_CODE_SE.관계없음);
                E_ACDMCR_CMMN_CODE_SE_list.Add(E_ACDMCR_CMMN_CODE_SE.박사과정);

                E_EMPLYM_STLE_CMMN_CODE_SE_list.Add(E_EMPLYM_STLE_CMMN_CODE_SE.전체);
                E_EMPLYM_STLE_CMMN_CODE_SE_list.Add(E_EMPLYM_STLE_CMMN_CODE_SE.계약직);
                E_EMPLYM_STLE_CMMN_CODE_SE_list.Add(E_EMPLYM_STLE_CMMN_CODE_SE.상용직시간제);
                E_EMPLYM_STLE_CMMN_CODE_SE_list.Add(E_EMPLYM_STLE_CMMN_CODE_SE.상용직);
                E_EMPLYM_STLE_CMMN_CODE_SE_list.Add(E_EMPLYM_STLE_CMMN_CODE_SE.계약직시간제);

                E_CAREER_CND_CMMN_CODE_SE_list.Add(E_CAREER_CND_CMMN_CODE_SE.전체);
                E_CAREER_CND_CMMN_CODE_SE_list.Add(E_CAREER_CND_CMMN_CODE_SE.신입);
                E_CAREER_CND_CMMN_CODE_SE_list.Add(E_CAREER_CND_CMMN_CODE_SE.경력);
                E_CAREER_CND_CMMN_CODE_SE_list.Add(E_CAREER_CND_CMMN_CODE_SE.무관);
            
        }
        #endregion

        //콤보박스 enum객체를 ObservableCollection으로 만들기
        #region ComboBox ItemSource List
        private ObservableCollection<E_ACDMCR_CMMN_CODE_SE> m_E_ACDMCR_CMMN_CODE_SE_list = new ObservableCollection<E_ACDMCR_CMMN_CODE_SE>();
        public ObservableCollection<E_ACDMCR_CMMN_CODE_SE> E_ACDMCR_CMMN_CODE_SE_list
        {
            get { return m_E_ACDMCR_CMMN_CODE_SE_list; }
            set
            {
                if (m_E_ACDMCR_CMMN_CODE_SE_list != value)
                {
                    m_E_ACDMCR_CMMN_CODE_SE_list = value;
                    Notify("E_ACDMCR_CMMN_CODE_SE_list");
                }
            }
        }

        private ObservableCollection<E_EMPLYM_STLE_CMMN_CODE_SE> m_E_EMPLYM_STLE_CMMN_CODE_SE_list = new ObservableCollection<E_EMPLYM_STLE_CMMN_CODE_SE>();
        public ObservableCollection<E_EMPLYM_STLE_CMMN_CODE_SE> E_EMPLYM_STLE_CMMN_CODE_SE_list
        {
            get { return m_E_EMPLYM_STLE_CMMN_CODE_SE_list; }
            set
            {
                if (m_E_EMPLYM_STLE_CMMN_CODE_SE_list != value)
                {
                    m_E_EMPLYM_STLE_CMMN_CODE_SE_list = value;
                    Notify("E_EMPLYM_STLE_CMMN_CODE_SE_list");
                }
            }
        }

        private ObservableCollection<E_CAREER_CND_CMMN_CODE_SE> m_E_CAREER_CND_CMMN_CODE_SE_list = new ObservableCollection<E_CAREER_CND_CMMN_CODE_SE>();
        public ObservableCollection<E_CAREER_CND_CMMN_CODE_SE> E_CAREER_CND_CMMN_CODE_SE_list
        {
            get { return m_E_CAREER_CND_CMMN_CODE_SE_list; }
            set
            {
                if (m_E_CAREER_CND_CMMN_CODE_SE_list != value)
                {
                    m_E_CAREER_CND_CMMN_CODE_SE_list = value;
                    Notify("E_CAREER_CND_CMMN_CODE_SE_list");
                }
            }
        }
        #endregion

        // 콤보박스 SelectedItem에 바인딩 하기(Myinfo)
        #region ComboBox selectedItem Myinfo
        private E_ACDMCR_CMMN_CODE_SE m_E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo;
        public E_ACDMCR_CMMN_CODE_SE E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo
        {
            get { return m_E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo; }
            set
            {
                if (m_E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo != value)
                {
                    m_E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo = value;
                    Notify("E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo");

                    // 콤보박스 아이템 변경시 컬러 표시하기
                    Workspace.Instance.Usercontrol_recruit_viewmodel.ColorFlag();
                }
            }
        }

        private E_EMPLYM_STLE_CMMN_CODE_SE m_E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Myinfo;
        public E_EMPLYM_STLE_CMMN_CODE_SE E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Myinfo
        {
            get { return m_E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Myinfo; }
            set
            {
                if (m_E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Myinfo != value)
                {
                    m_E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Myinfo = value;
                    Notify("E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Myinfo");

                    // 콤보박스 아이템 변경시 컬러 표시하기
                    Workspace.Instance.Usercontrol_recruit_viewmodel.ColorFlag();
                }
            }
        }

        private E_CAREER_CND_CMMN_CODE_SE m_E_CAREER_CND_CMMN_CODE_SE_selectedItem_Myinfo;
        public E_CAREER_CND_CMMN_CODE_SE E_CAREER_CND_CMMN_CODE_SE_selectedItem_Myinfo
        {
            get { return m_E_CAREER_CND_CMMN_CODE_SE_selectedItem_Myinfo; }
            set
            {
                if (m_E_CAREER_CND_CMMN_CODE_SE_selectedItem_Myinfo != value)
                {
                    m_E_CAREER_CND_CMMN_CODE_SE_selectedItem_Myinfo = value;
                    Notify("E_CAREER_CND_CMMN_CODE_SE_selectedItem_Myinfo");

                    // 콤보박스 아이템 변경시 컬러 표시하기
                    Workspace.Instance.Usercontrol_recruit_viewmodel.ColorFlag();
                }
            }
        }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void Notify([CallerMemberName] string propName = null)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        #endregion
    }
}
