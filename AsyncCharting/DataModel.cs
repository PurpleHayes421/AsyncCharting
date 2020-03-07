using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncCharting
{
    /*Ultimately want this to be an ObservableCollection of the appropriate data type for
     * a given DUT.
     */
     /// <summary>
     /// 
     /// </summary>
    public class DataModel : ObservableCollection<KeyValuePair<string, int>>

    {
        public DataModel()
        {
            Initialize();
        }

        /*This is just a dummy method; realistically, the DataModel needs a set
         * of async methods for polling our external data sources
         */
        public void Initialize()
        {
            Add(new KeyValuePair<string, int>("Dog", 30));
            Add(new KeyValuePair<string, int>("Cat", 25));
        }
    }
}
