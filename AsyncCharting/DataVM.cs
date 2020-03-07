using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AsyncCharting
{
    public class DataVM : INotifyPropertyChanged
    {
        private DataModel _DataModel;
        public DataVM()
        {
            _DataModel = new DataModel();
            _Data = _DataModel;
        }
        private ObservableCollection<KeyValuePair<string, int>> _Data;
        public ObservableCollection<KeyValuePair<string, int>> Data { get { return _Data; } }

        /* I want an ICommand or IAsyncCommand here that polls an external I/O-gated
         * data source here, and it should update the Data ObservableCollection
         * as well as report progress/completion and support cancellation. I think
         * the command is supposed to live in the VM since it's available to the XAML
         * View but needs knowledge of the underlying model's methods for acquiring data.
         */
        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            //For future reference; look into using this with Begin/End Invoke and
            //an async Task implementation for a fully-asynchronous INotifyPropertyChanged.
            //Also look at Nito.NotifyTask
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
