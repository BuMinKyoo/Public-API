using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfApp18;

namespace Model.WpfApp18
{
    public class Cust : INotifyPropertyChanged
    {

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

        private string m_CMPNY_NM;
        public string CMPNY_NM  //기업명칭
        {
            get { return m_CMPNY_NM; }
            set
            {
                if (m_CMPNY_NM != value)
                {
                    m_CMPNY_NM = value;
                    Notify("CMPNY_NM");
                }
            }
        }

        private string m_RCRIT_NMPR_CO;
        public string RCRIT_NMPR_CO  //모집인원수
        {
            get { return m_RCRIT_NMPR_CO; }
            set
            {
                if (m_RCRIT_NMPR_CO != value)
                {
                    m_RCRIT_NMPR_CO = value;
                    Notify("RCRIT_NMPR_CO");
                }
            }
        }

        private string m_WORK_TIME_NM;
        public string WORK_TIME_NM //근무시간
        {
            get { return m_WORK_TIME_NM; }
            set
            {
                if (m_WORK_TIME_NM != value)
                {
                    m_WORK_TIME_NM = value;
                    Notify("WORK_TIME_NM");
                }
            }
        }

        private string m_RCEPT_MTH_IEM_NM;
        public string RCEPT_MTH_IEM_NM  //전형장소
        {
            get { return m_RCEPT_MTH_IEM_NM; }
            set
            {
                if (m_RCEPT_MTH_IEM_NM != value)
                {
                    m_RCEPT_MTH_IEM_NM = value;
                    Notify("RCEPT_MTH_IEM_NM");
                }
            }
        }

        private string m_MODEL_MTH_NM;
        public string MODEL_MTH_NM  //전형방법
        {
            get { return m_MODEL_MTH_NM; }
            set
            {
                if (m_MODEL_MTH_NM != value)
                {
                    m_MODEL_MTH_NM = value;
                    Notify("MODEL_MTH_NM");
                }
            }
            
        }

        

        private bool m_ColorFlag;
        public bool ColorFlag
        {
            get { return m_ColorFlag; }
            set
            {
                if (m_ColorFlag != value)
                {
                    m_ColorFlag = value;
                    Notify("ColorFlag");
                }
            }

        }



        private string m_ACDMCR_NM; //학력
        public string ACDMCR_NM
        {
            get { return m_ACDMCR_NM; }
            set
            {
                if (m_ACDMCR_NM != value)
                {
                    m_ACDMCR_NM = value;
                    Notify("ACDMCR_NM");
                }
            }
        }

        private string m_EMPLYM_STLE_CMMN_MM; //고용형태
        public string EMPLYM_STLE_CMMN_MM
        {
            get { return m_EMPLYM_STLE_CMMN_MM; }
            set
            {
                if (m_EMPLYM_STLE_CMMN_MM != value)
                {
                    m_EMPLYM_STLE_CMMN_MM = value;
                    Notify("EMPLYM_STLE_CMMN_MM");
                }
            }
        }

        private string m_CAREER_CND_NM; //경력조건
        public string CAREER_CND_NM
        {
            get { return m_CAREER_CND_NM; }
            set
            {
                if (m_CAREER_CND_NM != value)
                {
                    m_CAREER_CND_NM = value;
                    Notify("CAREER_CND_NM");
                }
            }
        }
    }
}
