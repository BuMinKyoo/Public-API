using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp18
{
    public class MainWindow_ViewModel : INotifyPropertyChanged
    {

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
