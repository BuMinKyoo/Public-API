using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
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
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            Custlist = new ObservableCollection<Cust>();

            //콤보박스에 바인딩한 ObservableCollection에 add로 요소 추가하기
            #region ComboBox ItemSource list add
            E_ACDMCR_CMMN_CODE_SE_list = new ObservableCollection<E_ACDMCR_CMMN_CODE_SE>();
            E_ACDMCR_CMMN_CODE_SE_list.Add(E_ACDMCR_CMMN_CODE_SE.전체);
            E_ACDMCR_CMMN_CODE_SE_list.Add(E_ACDMCR_CMMN_CODE_SE.전문대학);
            E_ACDMCR_CMMN_CODE_SE_list.Add(E_ACDMCR_CMMN_CODE_SE.중학교);
            E_ACDMCR_CMMN_CODE_SE_list.Add(E_ACDMCR_CMMN_CODE_SE.고등학교);
            E_ACDMCR_CMMN_CODE_SE_list.Add(E_ACDMCR_CMMN_CODE_SE.초등학교);
            E_ACDMCR_CMMN_CODE_SE_list.Add(E_ACDMCR_CMMN_CODE_SE.대학교);
            E_ACDMCR_CMMN_CODE_SE_list.Add(E_ACDMCR_CMMN_CODE_SE.관계없음);
            E_ACDMCR_CMMN_CODE_SE_list.Add(E_ACDMCR_CMMN_CODE_SE.박사과정);

            E_EMPLYM_STLE_CMMN_CODE_SE_list = new ObservableCollection<E_EMPLYM_STLE_CMMN_CODE_SE>();
            E_EMPLYM_STLE_CMMN_CODE_SE_list.Add(E_EMPLYM_STLE_CMMN_CODE_SE.전체);
            E_EMPLYM_STLE_CMMN_CODE_SE_list.Add(E_EMPLYM_STLE_CMMN_CODE_SE.계약직);
            E_EMPLYM_STLE_CMMN_CODE_SE_list.Add(E_EMPLYM_STLE_CMMN_CODE_SE.상용직시간제);
            E_EMPLYM_STLE_CMMN_CODE_SE_list.Add(E_EMPLYM_STLE_CMMN_CODE_SE.상용직);
            E_EMPLYM_STLE_CMMN_CODE_SE_list.Add(E_EMPLYM_STLE_CMMN_CODE_SE.계약직시간제);

            E_CAREER_CND_CMMN_CODE_SE_list = new ObservableCollection<E_CAREER_CND_CMMN_CODE_SE>();
            E_CAREER_CND_CMMN_CODE_SE_list.Add(E_CAREER_CND_CMMN_CODE_SE.전체);
            E_CAREER_CND_CMMN_CODE_SE_list.Add(E_CAREER_CND_CMMN_CODE_SE.신입);
            E_CAREER_CND_CMMN_CODE_SE_list.Add(E_CAREER_CND_CMMN_CODE_SE.경력);
            E_CAREER_CND_CMMN_CODE_SE_list.Add(E_CAREER_CND_CMMN_CODE_SE.무관);
            #endregion

            this.DataContext = this;
        }

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

        // ListView의 목록들인 Cust를 ObservableCollection으로 만들기
        #region ListView_GridViewColumn_staus
        private ObservableCollection<Cust> m_Custlist;
        public ObservableCollection<Cust> Custlist
        {
            get { return m_Custlist; }
            set
            {
                if (m_Custlist != value)
                {
                    m_Custlist = value;
                    Notify("Custlist");
                }
            }
        }
        #endregion

        //콤보박스 enum객체를 ObservableCollection으로 만들기
        #region ComboBox ItemSource List
        private ObservableCollection<E_ACDMCR_CMMN_CODE_SE> m_E_ACDMCR_CMMN_CODE_SE_list;
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

        private ObservableCollection<E_EMPLYM_STLE_CMMN_CODE_SE> m_E_EMPLYM_STLE_CMMN_CODE_SE_list;
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

        private ObservableCollection<E_CAREER_CND_CMMN_CODE_SE> m_E_CAREER_CND_CMMN_CODE_SE_list;
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

        // 콤보박스 SelectedItem에 바인딩 하기(Recruit)
        #region ComboBox selectedItem Recruit
        private E_ACDMCR_CMMN_CODE_SE m_E_ACDMCR_CMMN_CODE_SE_selectedItem_Recruit;
        public E_ACDMCR_CMMN_CODE_SE E_ACDMCR_CMMN_CODE_SE_selectedItem_Recruit
        {
            get { return m_E_ACDMCR_CMMN_CODE_SE_selectedItem_Recruit; }
            set
            {
                if(m_E_ACDMCR_CMMN_CODE_SE_selectedItem_Recruit != value)
                {
                    m_E_ACDMCR_CMMN_CODE_SE_selectedItem_Recruit = value;
                    Notify("E_ACDMCR_CMMN_CODE_SE_selectedItem_Recruit");
                }
            }
        }

        private E_EMPLYM_STLE_CMMN_CODE_SE m_E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Recruit;
        public E_EMPLYM_STLE_CMMN_CODE_SE E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Recruit
        {
            get { return m_E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Recruit; }
            set
            {
                if (m_E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Recruit != value)
                {
                    m_E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Recruit = value;
                    Notify("E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Recruit");
                }
            }
        }

        private E_CAREER_CND_CMMN_CODE_SE m_E_CAREER_CND_CMMN_CODE_SE_selectedItem_Recruit;
        public E_CAREER_CND_CMMN_CODE_SE E_CAREER_CND_CMMN_CODE_SE_selectedItem_Recruit
        {
            get { return m_E_CAREER_CND_CMMN_CODE_SE_selectedItem_Recruit; }
            set
            {
                if (m_E_CAREER_CND_CMMN_CODE_SE_selectedItem_Recruit != value)
                {
                    m_E_CAREER_CND_CMMN_CODE_SE_selectedItem_Recruit = value;
                    Notify("E_CAREER_CND_CMMN_CODE_SE_selectedItem_Recruit");
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
                    m_E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo_colorchange();
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
                    m_E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Myinfo_colorchange();
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
                    m_E_CAREER_CND_CMMN_CODE_SE_selectedItem_Myinfo_colorchange();
                }
            }
        }
        #endregion

        public void m_E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo_colorchange()
        {
            foreach (var item in Custlist)
            {
                item.ColorChange_ACDMCR_CMMN_CODE_SE = "0";
            }

            if (E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo == E_ACDMCR_CMMN_CODE_SE.전체)
            {
                foreach (var item in Custlist)
                {
                    item.ColorChange_ACDMCR_CMMN_CODE_SE = "1";
                }
            }

            else if (E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo == E_ACDMCR_CMMN_CODE_SE.전문대학)
            {
                foreach (var item in Custlist)
                {
                    if (item.ACDMCR_NM == "전문대학")
                    {
                        item.ColorChange_ACDMCR_CMMN_CODE_SE = "1";
                    }
                }
            }
            else if (E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo == E_ACDMCR_CMMN_CODE_SE.중학교)
            {
                foreach (var item in Custlist)
                {
                    if (item.ACDMCR_NM == "중학교")
                    {
                        item.ColorChange_ACDMCR_CMMN_CODE_SE = "1";
                    }
                }
            }
            else if (E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo == E_ACDMCR_CMMN_CODE_SE.고등학교)
            {
                foreach (var item in Custlist)
                {
                    if (item.ACDMCR_NM == "고등학교")
                    {
                        item.ColorChange_ACDMCR_CMMN_CODE_SE = "1";
                    }
                }
            }
            else if (E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo == E_ACDMCR_CMMN_CODE_SE.초등학교)
            {
                foreach (var item in Custlist)
                {
                    if (item.ACDMCR_NM == "초등학교")
                    {
                        item.ColorChange_ACDMCR_CMMN_CODE_SE = "1";
                    }
                }
            }
            else if (E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo == E_ACDMCR_CMMN_CODE_SE.대학교)
            {
                foreach (var item in Custlist)
                {
                    if (item.ACDMCR_NM == "대학교")
                    {
                        item.ColorChange_ACDMCR_CMMN_CODE_SE = "1";
                    }
                }
            }
            else if (E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo == E_ACDMCR_CMMN_CODE_SE.관계없음)
            {
                foreach (var item in Custlist)
                {
                    if (item.ACDMCR_NM == "관계없음")
                    {
                        item.ColorChange_ACDMCR_CMMN_CODE_SE = "1";
                    }
                }
            }
            else if (E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo == E_ACDMCR_CMMN_CODE_SE.박사과정)
            {
                foreach (var item in Custlist)
                {
                    if (item.ACDMCR_NM == "박사과정")
                    {
                        item.ColorChange_ACDMCR_CMMN_CODE_SE = "1";
                    }
                }
            }
        }

        public void m_E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Myinfo_colorchange()
        {

            foreach (var item in Custlist)
            {
                item.ColorChange_EMPLYM_STLE_CMMN_CODE_SE = "0";
            }

            if (E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Myinfo == E_EMPLYM_STLE_CMMN_CODE_SE.전체)
            {
                foreach (var item in Custlist)
                {
                    item.ColorChange_EMPLYM_STLE_CMMN_CODE_SE = "1";
                }
            }
            else if (E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Myinfo == E_EMPLYM_STLE_CMMN_CODE_SE.계약직)
            {
                foreach (var item in Custlist)
                {
                    if (item.EMPLYM_STLE_CMMN_MM == "계약직")
                    {
                        item.ColorChange_EMPLYM_STLE_CMMN_CODE_SE = "1";
                    }
                }
            }
            else if (E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Myinfo == E_EMPLYM_STLE_CMMN_CODE_SE.상용직시간제)
            {
                foreach (var item in Custlist)
                {
                    if (item.EMPLYM_STLE_CMMN_MM == "상용직(시간제)")
                    {
                        item.ColorChange_EMPLYM_STLE_CMMN_CODE_SE = "1";
                    }
                }
            }
            else if (E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Myinfo == E_EMPLYM_STLE_CMMN_CODE_SE.상용직)
            {
                foreach (var item in Custlist)
                {
                    if (item.EMPLYM_STLE_CMMN_MM == "상용직")
                    {
                        item.ColorChange_EMPLYM_STLE_CMMN_CODE_SE = "1";
                    }
                }
            }
            else if (E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Myinfo == E_EMPLYM_STLE_CMMN_CODE_SE.계약직시간제)
            {
                foreach (var item in Custlist)
                {
                    if (item.EMPLYM_STLE_CMMN_MM == "계약직(시간제)")
                    {
                        item.ColorChange_EMPLYM_STLE_CMMN_CODE_SE = "1";
                    }
                }
            }
        }

        public void m_E_CAREER_CND_CMMN_CODE_SE_selectedItem_Myinfo_colorchange()
        {
            foreach (var item in Custlist)
            {
                item.ColorChange_CAREER_CND_CMMN_CODE_SE = "0";
            }

            if (E_CAREER_CND_CMMN_CODE_SE_selectedItem_Myinfo == E_CAREER_CND_CMMN_CODE_SE.전체)
            {
                foreach (var item in Custlist)
                {
                    item.ColorChange_CAREER_CND_CMMN_CODE_SE = "1";
                }
            }
            else if (E_CAREER_CND_CMMN_CODE_SE_selectedItem_Myinfo == E_CAREER_CND_CMMN_CODE_SE.신입)
            {
                foreach (var item in Custlist)
                {
                    if (item.CAREER_CND_NM == "신입")
                    {
                        item.ColorChange_CAREER_CND_CMMN_CODE_SE = "1";
                    }
                }
            }
            else if (E_CAREER_CND_CMMN_CODE_SE_selectedItem_Myinfo == E_CAREER_CND_CMMN_CODE_SE.경력)
            {
                foreach (var item in Custlist)
                {
                    if (item.CAREER_CND_NM == "경력")
                    {
                        item.ColorChange_CAREER_CND_CMMN_CODE_SE = "1";
                    }
                }
            }
            else if (E_CAREER_CND_CMMN_CODE_SE_selectedItem_Myinfo == E_CAREER_CND_CMMN_CODE_SE.무관)
            {
                foreach (var item in Custlist)
                {
                    if (item.CAREER_CND_NM == "무관")
                    {
                        item.ColorChange_CAREER_CND_CMMN_CODE_SE = "1";
                    }
                }
            }
        }

        // 클릭이벤트로 넘어온 stirng을 받아주는 프로퍼티
        #region API string
        private string m_ACDMCR_CMMN_CODE_SE_APIsting;
        public string ACDMCR_CMMN_CODE_SE_APIsting
        {
            get { return m_ACDMCR_CMMN_CODE_SE_APIsting; }
            set
            {
                if (m_ACDMCR_CMMN_CODE_SE_APIsting != value)
                {
                    m_ACDMCR_CMMN_CODE_SE_APIsting = value;
                    Notify("ACDMCR_CMMN_CODE_SE_APIsting");
                }
            }
        }

        private string m_EMPLYM_STLE_CMMN_CODE_SE_APIsting;
        public string EMPLYM_STLE_CMMN_CODE_SE_APIsting
        {
            get { return m_EMPLYM_STLE_CMMN_CODE_SE_APIsting; }
            set
            {
                if (m_EMPLYM_STLE_CMMN_CODE_SE_APIsting != value)
                {
                    m_EMPLYM_STLE_CMMN_CODE_SE_APIsting = value;
                    Notify("EMPLYM_STLE_CMMN_CODE_SE_APIsting");
                }
            }
        }

        private string m_CAREER_CND_CMMN_CODE_SE_APIsting;
        public string CAREER_CND_CMMN_CODE_SE_APIsting
        {
            get { return m_CAREER_CND_CMMN_CODE_SE_APIsting; }
            set
            {
                if (m_CAREER_CND_CMMN_CODE_SE_APIsting != value)
                {
                    m_CAREER_CND_CMMN_CODE_SE_APIsting = value;
                    Notify("CAREER_CND_CMMN_CODE_SE_APIsting");
                }
            }
        }

        //서울시 일자리 포털 : https://data.seoul.go.kr/dataList/OA-13341/A/1/datasetView.do
        private string m_path;
        public string path
        {
            get { return m_path; }
            set
            {
                if (m_path != value)
                {
                    m_path = value;
                    Notify("Path");
                }
            }
        }
        #endregion


        private int m_TabControl_SelectedIndex;
        public int TabControl_SelectedIndex
        {
            get { return m_TabControl_SelectedIndex; }
            set
            {
                if (m_TabControl_SelectedIndex != value)
                {
                    m_TabControl_SelectedIndex = value;
                    Notify("TabControl_SelectedIndex");
                }
            }
        }

        #region
        private Command m_MoveMyInfo;
        public ICommand MoveMyInfo
        {
            get { return m_MoveMyInfo = new Command(OneClickEvent_m_MoveMyInfo_BUtton); }
        }

        private void OneClickEvent_m_MoveMyInfo_BUtton(object obj)
        {
            TabControl_SelectedIndex = 2;
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
            TabControl_SelectedIndex = 1;
        }
        #endregion

        // 클릭이벤트로 string변경 및 XmlDocument받아오기
        #region Button Event
        private Command m_Getdata;
        public ICommand Getdata
        {
            get { return m_Getdata = new Command(OneClickEvent); }
        }
        private void OneClickEvent(object obj)
        {
            #region E_ACDMCR_CMMN_CODE_SE_selectedItem_Recruit_event
            if (E_ACDMCR_CMMN_CODE_SE_selectedItem_Recruit == E_ACDMCR_CMMN_CODE_SE.전체)
            {
                ACDMCR_CMMN_CODE_SE_APIsting = " /";
            }
            else if (E_ACDMCR_CMMN_CODE_SE_selectedItem_Recruit == E_ACDMCR_CMMN_CODE_SE.전문대학)
            {
                ACDMCR_CMMN_CODE_SE_APIsting = "J00108/";
            }
            else if (E_ACDMCR_CMMN_CODE_SE_selectedItem_Recruit == E_ACDMCR_CMMN_CODE_SE.중학교)
            {
                ACDMCR_CMMN_CODE_SE_APIsting = "J00104/";
            }
            else if (E_ACDMCR_CMMN_CODE_SE_selectedItem_Recruit == E_ACDMCR_CMMN_CODE_SE.고등학교)
            {
                ACDMCR_CMMN_CODE_SE_APIsting = "J00106/";
            }
            else if (E_ACDMCR_CMMN_CODE_SE_selectedItem_Recruit == E_ACDMCR_CMMN_CODE_SE.초등학교)
            {
                ACDMCR_CMMN_CODE_SE_APIsting = "J00102/";
            }
            else if (E_ACDMCR_CMMN_CODE_SE_selectedItem_Recruit == E_ACDMCR_CMMN_CODE_SE.대학교)
            {
                ACDMCR_CMMN_CODE_SE_APIsting = "J00110/";
            }
            else if (E_ACDMCR_CMMN_CODE_SE_selectedItem_Recruit == E_ACDMCR_CMMN_CODE_SE.관계없음)
            {
                ACDMCR_CMMN_CODE_SE_APIsting = "J00100/";
            }
            else if (E_ACDMCR_CMMN_CODE_SE_selectedItem_Recruit == E_ACDMCR_CMMN_CODE_SE.박사과정)
            {
                ACDMCR_CMMN_CODE_SE_APIsting = "J00114/";
            }
            #endregion

            #region E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Recruit
            if (E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Recruit == E_EMPLYM_STLE_CMMN_CODE_SE.전체)
            {
                EMPLYM_STLE_CMMN_CODE_SE_APIsting = " /";
            }
            else if (E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Recruit == E_EMPLYM_STLE_CMMN_CODE_SE.계약직)
            {
                EMPLYM_STLE_CMMN_CODE_SE_APIsting = "J01102/";
            }
            else if (E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Recruit == E_EMPLYM_STLE_CMMN_CODE_SE.상용직시간제)
            {
                EMPLYM_STLE_CMMN_CODE_SE_APIsting = "J01105/";
            }
            else if (E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Recruit == E_EMPLYM_STLE_CMMN_CODE_SE.상용직)
            {
                EMPLYM_STLE_CMMN_CODE_SE_APIsting = "J01101/";
            }
            else if (E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Recruit == E_EMPLYM_STLE_CMMN_CODE_SE.계약직시간제)
            {
                EMPLYM_STLE_CMMN_CODE_SE_APIsting = "J01103/";
            }
            #endregion

            #region E_CAREER_CND_CMMN_CODE_SE_selectedItem_Recruit
            if (E_CAREER_CND_CMMN_CODE_SE_selectedItem_Recruit == E_CAREER_CND_CMMN_CODE_SE.전체)
            {
                CAREER_CND_CMMN_CODE_SE_APIsting = " /";
            }
            else if (E_CAREER_CND_CMMN_CODE_SE_selectedItem_Recruit == E_CAREER_CND_CMMN_CODE_SE.신입)
            {
                CAREER_CND_CMMN_CODE_SE_APIsting = "J01301/";
            }
            else if (E_CAREER_CND_CMMN_CODE_SE_selectedItem_Recruit == E_CAREER_CND_CMMN_CODE_SE.경력)
            {
                CAREER_CND_CMMN_CODE_SE_APIsting = "J01302/";
            }
            else if (E_CAREER_CND_CMMN_CODE_SE_selectedItem_Recruit == E_CAREER_CND_CMMN_CODE_SE.무관)
            {
                CAREER_CND_CMMN_CODE_SE_APIsting = "J01300/";
            }
            #endregion


            path = "http://openapi.seoul.go.kr:8088/68734f416a716e613535594b6d4f48/xml/GetJobInfo/1/100/" + ACDMCR_CMMN_CODE_SE_APIsting + EMPLYM_STLE_CMMN_CODE_SE_APIsting + CAREER_CND_CMMN_CODE_SE_APIsting;

            Custlist.Clear();
            OxReadXML();

            //클릭 했을시 컬러 변경하기

            #region Clikc colorchange
            m_E_ACDMCR_CMMN_CODE_SE_selectedItem_Myinfo_colorchange();
            m_E_EMPLYM_STLE_CMMN_CODE_SE_selectedItem_Myinfo_colorchange();
            m_E_CAREER_CND_CMMN_CODE_SE_selectedItem_Myinfo_colorchange();
            #endregion
        }
        #endregion

        private void OxReadXML()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(path);

            XmlNodeList nodesRow = xdoc.SelectNodes("/GetJobInfo/row");

            foreach (XmlNode node in nodesRow)
            {
                string CMPNY_NM_IT = node.SelectSingleNode("CMPNY_NM").InnerText; //기업명칭
                string RCRIT_NMPR_CO_IT = node.SelectSingleNode("RCRIT_NMPR_CO").InnerText; //모집인원수
                string WORK_TIME_NM_IT = node.SelectSingleNode("WORK_TIME_NM").InnerText; //근무시간
                string RCEPT_MTH_IEM_NM_IT = node.SelectSingleNode("RCEPT_MTH_IEM_NM").InnerText; //전형장소
                string MODEL_MTH_NM_IT = node.SelectSingleNode("MODEL_MTH_NM").InnerText; //전형방법

                string ACDMCR_NM_IT = node.SelectSingleNode("ACDMCR_NM").InnerText; //학력
                string EMPLYM_STLE_CMMN_MM_IT = node.SelectSingleNode("EMPLYM_STLE_CMMN_MM").InnerText; //고용형태
                string CAREER_CND_NM_IT = node.SelectSingleNode("CAREER_CND_NM").InnerText; //경력조건

                Custlist.Add(new Cust() { CMPNY_NM = CMPNY_NM_IT, RCRIT_NMPR_CO = RCRIT_NMPR_CO_IT, WORK_TIME_NM = WORK_TIME_NM_IT, RCEPT_MTH_IEM_NM = RCEPT_MTH_IEM_NM_IT, MODEL_MTH_NM = MODEL_MTH_NM_IT, ACDMCR_NM = ACDMCR_NM_IT, EMPLYM_STLE_CMMN_MM = EMPLYM_STLE_CMMN_MM_IT, CAREER_CND_NM = CAREER_CND_NM_IT });
            }

            if(Custlist.Count == 0)
            {
                MessageBox.Show("현재 페이지 내에서는 존재하는 데이터가 없습니다");
            }
        }
    }
}
